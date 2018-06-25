using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ClassLibrary1 {
    public class Class1 {
        string myConnectionString = "SERVER=localhost;" +
                            "DATABASE=nobelpreise;" +
                            "UID=root;" +
                            "PASSWORD=;" + "SslMode=none";

        public DataTable Bla() {

            MySqlConnection connection = new MySqlConnection(myConnectionString);

            try {

                String query = "SELECT * FROM winners";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows) {
                    Console.WriteLine(string.Format("name = {0}", row["name"].ToString()));
                }
                connection.Close();
                return dt;
            } catch (Exception ex) {
                Console.WriteLine("Kackfehler: {0}", ex.Message);
                return null;
            }
        }
    }
}
