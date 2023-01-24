using System.Data.SQLite;

namespace Inventory
{
    internal static class Database
    {
        public static bool wantsToRemember;
        private static string connectionString = "Data Source=./Database/inventory.db";
        public static async Task<bool> HasRegisteredAdmin()
        {
            using (SQLiteConnection myconnection = new SQLiteConnection(connectionString))
            {
                if (!(myconnection.State == System.Data.ConnectionState.Open)) { myconnection.Open(); }
                string query = "SELECT * FROM admin";
                SQLiteCommand cmd = new SQLiteCommand(query, myconnection);
                using (var resultReader = await cmd.ExecuteReaderAsync())
                {
                    bool containsRows = resultReader.Read();
                    return containsRows;
                }
            }
        }
        public static async Task<string> AddAdmin(string username, string password)
        {
            if (!await HasRegisteredAdmin())
            {
                using (SQLiteConnection myconnection = new SQLiteConnection(connectionString))
                {
                    if (!(myconnection.State == System.Data.ConnectionState.Open)) { myconnection.Open(); }
                    string query = "INSERT INTO admin ('username','password','registered') VALUES (@username, @password,'True')";
                    SQLiteCommand cmd = new SQLiteCommand(query, myconnection);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    string updated = (await cmd.ExecuteNonQueryAsync()).ToString();
                    return "Updated\t" + updated;
                }
            }
            return "didnt update";
        }
        public static async Task<bool> LoginAdmin(string username, string password)
        {
            if (username == (await GetCredentials())[0] && password ==(await GetCredentials())[1]) { return true; }
            return false;
        }
        public static async Task<string[]> GetCredentials()
        {
            using (SQLiteConnection myconnection = new SQLiteConnection(connectionString))
            {
                string[] credentials = new string[3];
                if (!(myconnection.State == System.Data.ConnectionState.Open)) { myconnection.Open(); }
                string query = "SELECT * FROM admin";
                SQLiteCommand cmd = new SQLiteCommand(query, myconnection);
                using (var resultReader = await cmd.ExecuteReaderAsync())
                {
                    resultReader.Read();
                    credentials[0] = resultReader.GetString(0);
                    credentials[1] = resultReader.GetString(1);
                    credentials[2] = resultReader.GetString(2);
                    return credentials;
                }
            };
        }
        public static async Task UpdateRemember()
        {
            using (SQLiteConnection myconnection = new SQLiteConnection(connectionString))
            {
                if (!(myconnection.State == System.Data.ConnectionState.Open)) { myconnection.Open(); }
                string query = "UPDATE admin SET remember = @remember";
                SQLiteCommand cmd = new SQLiteCommand(query, myconnection);
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@remember", wantsToRemember.ToString());
                string updated = (await cmd.ExecuteNonQueryAsync()).ToString();
                myconnection.Close();
            }
        }
        public static async Task<List<Customer>> GetCustomers()
        {
            using (SQLiteConnection myconnection = new SQLiteConnection(connectionString))
            {
                List<Customer> customers = new List<Customer>();
                if (!(myconnection.State == System.Data.ConnectionState.Open)) { myconnection.Open(); }
                string query = "SELECT * FROM customers";
                SQLiteCommand cmd = new SQLiteCommand(query, myconnection);
                try
                {
                using (var resultReader = await cmd.ExecuteReaderAsync())
                {
                    while(resultReader.Read())
                    {
                        customers.Add(new Customer(resultReader.GetString(0), resultReader.GetString(1), resultReader.GetString(2), resultReader.GetString(3), resultReader.GetString(4)));
                    }
                    return customers;
                }
                }
                catch
                {
                    return customers;
                }
            };
        }
        public static async Task<List<Item>> GetInventory()
        {
            using (SQLiteConnection myconnection = new SQLiteConnection(connectionString))
            {
                List<Item> items = new List<Item>();
                if (!(myconnection.State == System.Data.ConnectionState.Open)) { myconnection.Open(); }
                string query = "SELECT * FROM items";
                SQLiteCommand cmd = new SQLiteCommand(query, myconnection);
                try
                {
                using (var resultReader = await cmd.ExecuteReaderAsync())
                {
                    while (resultReader.Read())
                    {
                        items.Add(new Item(resultReader.GetInt32(0), resultReader.GetString(1), resultReader.GetDecimal(2), resultReader.GetInt32(3), resultReader.GetInt32(4), resultReader.GetInt32(5)));
                    }
                    return items;
                }
                }
                catch
                {
                    return items;
                }
            };
        }
    }
}