using Guna.UI2.WinForms;
using System.Media;
using System.Runtime.InteropServices;

namespace Inventory
{
    public partial class MainInterface : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
        );
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public static int itemscount;
        public static decimal money;
        public static int customerscount;
        public MainInterface()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private async void Interface_Load(object sender, EventArgs e)
        {
            loggedinuserLBL.Text = (await Database.GetCredentials())[0];
            RefreshAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductsTab_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Interface_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainInterfaceTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Sold_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void resizeinterfaceBTN_Click(object sender, EventArgs e)
        {
            this.Size = (this.MaximumSize == this.Size) ? this.MinimumSize : this.MaximumSize;
        }

        private void guna2TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            PopulateTables();
        }
        private async void PopulateTables()
        {
            try
            {

                var items = await Database.GetInventory();
                var customers = await Database.GetCustomers();
                InventoryTable.DataSource = items;
                itemscount = items.Count;
                customerscount = customers.Count;
                money = items.Sum(x => x.price * x.inStock);
                CustomersTable.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateLabels()
        {
            itemsCountLBL.Text = $"{itemscount} items";
            totalmoneyLBL.Text = $"${money}";
            customerscountLBL.Text = $"{customerscount} customers";

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void customersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitBTN_MouseHover(object sender, EventArgs e)
        {

        }

        private async void AddItemBTN_Click(object sender, EventArgs e)
        {
            try
            {


                if (Decimal.TryParse(itempricetextbox.Text, out decimal price) && int.TryParse(itemamounttext.Text, out int amount) && price > 0 && amount > 0)
                {
                    Item item = new Item(itemnametextbox.Text, price);
                    await Database.AddItem(item, amount);
                    RefreshAll();
                    itempricetextbox.Text = ""; itemamounttext.Text = ""; itemnametextbox.Text = "";
                }
                else
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Invalid parameters", "Error adding item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private async Task RefreshAll()
        {
            PopulateTables();
            UpdateLabels();
            InventoryTable.Refresh();
            CustomersTable.Refresh();
            SortByBox.Refresh();
            UpdateSortBox();
        }

        private async void InventoryTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var rowcells = InventoryTable.CurrentRow.Cells;
            try
            {
                if (rowcells != null)
                {
                    var myitem = new Item((int)rowcells[0].Value, (string)rowcells[1].Value, (decimal)rowcells[2].Value, (int)rowcells[3].Value, (int)rowcells[4].Value, (int)rowcells[5].Value);
                    await Database.UpdateItem(myitem);
                    RefreshAll();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InventoryTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void InventoryTable_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }

        private void InventoryTable_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void InventoryTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("the value you entered is not of correct format", "invalid cell", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UIAddLBL_Click(object sender, EventArgs e)
        {

        }

        private async void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var customers = await Database.GetCustomers();
                CustomersTable.DataSource = guna2ToggleSwitch1.Checked ? customers.OrderByDescending(x => x.GetProperty(guna2ComboBox1.SelectedIndex)).ToList() : customers.OrderBy(x => x.GetProperty(guna2ComboBox1.SelectedIndex)).ToList();
                CustomersTable.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortByBox_DataSourceChanged(object sender, EventArgs e)
        {

        }
        private async Task UpdateSortBox()
        {
            if (SortByBox.Items.Count == 0)
            {
                int nColumns = InventoryTable.Columns.Count;
                for (int i = 0; i < nColumns; i++)
                {
                    SortByBox.Items.Add(InventoryTable.Columns[i].Name);
                }
                SortByBox.Refresh();
            }
        }

        private void InventoryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void DescToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private async void RemoveItemBTN_Click(object sender, EventArgs e)
        {
            await Database.RemoveItem(Convert.ToInt32(InventoryTable.CurrentRow.Cells[0].Value));
            RefreshAll();
        }

        private void itemamounttext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddItemBTN.PerformClick();
            }
        }

        private void InventoryTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            //hi
        }

        private void InventoryTab_Click(object sender, EventArgs e)
        {

        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Guna2TextBox[] textBoxes = { EditID, EditName, EditPrice, EditinStock };
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    textBoxes[i].Text = InventoryTable.CurrentRow.Cells[i].Value.ToString();
                }

            }
            catch
            {
                //no row selected
            }
        }

        private async void ConfirmEdit_Click(object sender, EventArgs e)
        {
            Guna2TextBox[] textBoxes = { EditID, EditName, EditPrice, EditinStock };
            bool IDValid = int.TryParse(EditID.Text, out int id);
            bool NameValid = EditName.Text.Length > 0;
            bool PriceValid = decimal.TryParse(EditPrice.Text, out decimal price);
            bool inStockValid = int.TryParse(EditinStock.Text, out int inStock);
            bool[] checks = { IDValid, NameValid, PriceValid, inStockValid };
            if (checks.All(x => x == true))
            {
                var item = new Item(id, EditName.Text, price, inStock, 0, 0);
                try
                {
                    await Database.UpdateItem(item);
                    textBoxes.ToList().ForEach(x => x.Text = "");
                    RefreshAll();
                    MessageBox.Show("Successfully Updated Records!", "Records Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        //customer edit button
        {
            try
            {
                Guna2TextBox[] textBoxes = { CustomerID, CustomerName, CustomerPhone, CustomerEmail };
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    textBoxes[i].Text = CustomersTable.CurrentRow.Cells[i].Value.ToString();
                }

            }
            catch
            {
                //no row selected
            }
        }

        private async void guna2Button4_Click(object sender, EventArgs e)
        {
            //remove customer BTN
            try
            {

                await Database.RemoveCustomer(Convert.ToInt32(CustomersTable.CurrentRow.Cells[0].Value));
                RefreshAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void CustomerAddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Guna2TextBox[] textBoxes = {CustomerAddName, CustomerAddPhone, CustomerAddEmail };
                bool isNameValid = CustomerAddName.Text.Length > 0;
                bool isPhoneValid = CustomerAddPhone.Text.Length > 0;
                bool isEmailValid = CustomerAddEmail.Text.Length > 0;
                bool[] checks = {isNameValid,isPhoneValid, isEmailValid};

                if (checks.All(x => x == true))
                {
                    await Database.AddCustomer(new Customer(CustomerAddName.Text,CustomerAddPhone.Text,CustomerAddEmail.Text));
                    textBoxes.ToList().ForEach(x => x.Text = "");
                    RefreshAll();
                }
                else
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Invalid parameters", "Error adding Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
