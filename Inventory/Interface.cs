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
            PopulateTables();
            UpdateLabels();
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
            var items = await Database.GetInventory();
            var customers = await Database.GetCustomers();
            InventoryTable.DataSource = items;
            itemscount = items.Count;
            customerscount = customers.Count;
            money = items.Sum(x => x.price * x.inStock);
            customersTable.DataSource = customers;
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
            if (Decimal.TryParse(itempricetextbox.Text, out decimal price) && int.TryParse(itemamounttext.Text, out int amount) && price >0 && amount >0)
            {
                await Database.AddItem(itemnametextbox.Text, price, amount);
                RefreshAll();
                itempricetextbox.Text = ""; itemamounttext.Text = "";itemnametextbox.Text = "";
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Invalid parameters","Error adding item",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            customersTable.Refresh();
        }

        private async void InventoryTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var rowcells = InventoryTable.CurrentRow.Cells;
            if (rowcells != null)
            {
                var myitem = new Item((int)rowcells[0].Value, (string)rowcells[1].Value, (decimal)rowcells[2].Value, (int)rowcells[3].Value, (int)rowcells[4].Value, (int)rowcells[5].Value);
                await Database.UpdateItem(myitem);
                RefreshAll();
            }
        }

        private void InventoryTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void InventoryTable_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if(e.ColumnIndex != 1)
            {
                int.TryParse((string)e.FormattedValue,out int result);
                if (!(result > 0)) { e.Cancel = true; MessageBox.Show("Value cannot be negative!","Negative value error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
        }

        private void InventoryTable_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void InventoryTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("the value you entered is not of correct format","invalid cell",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
