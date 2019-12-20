#define a
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab35___Bazy_danych
{
    class Program
    {
        static void Main(string[] args)
        {
            string connnectionString = @"Data Source=192.168.3.136,50500; Initial Catalog=Wardzyn; User ID=Piotr; Password=admin2";
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(connnectionString);
            sqlConnection.Open();
            Console.WriteLine("SQL Otwarte");
#if (select)
            SqlCommand sqlCommandSelect;
            SqlDataReader sqlDataReader;
            string sqlSelect = "";
            sqlSelect = "Select * from portfel";
            sqlCommandSelect = new SqlCommand(sqlSelect, sqlConnection);
            sqlDataReader = sqlCommandSelect.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine($"{sqlDataReader.GetValue(0)} | {sqlDataReader.GetValue(1)} | {sqlDataReader.GetValue(2)} | {sqlDataReader.GetValue(3)} | {sqlDataReader.GetValue(4)}");
                
            }
            sqlDataReader.Close();
            sqlCommandSelect.Dispose();

            //Console.ReadKey();
#elif (insert)
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            //SqlCommand sqlCommandInsert;
            string sqlInsert = "";
            sqlInsert = "Insert into portfel values (5, 'abc', 'wydatek', 22.43, getdate())";
            sqlDataAdapter1.InsertCommand = new SqlCommand(sqlInsert,sqlConnection);
            //sqlDataAdapter1.InsertCommand.ExecuteNonQuery();
            int ilosc = sqlDataAdapter1.InsertCommand.ExecuteNonQuery();
            Console.WriteLine($"wrzucono nowe wiersze w ilości:  {ilosc}");
#elif (update)
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();            
            Console.WriteLine("Podaj pozycje zmiany kwoty");
            int id=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nowa kwota");
            decimal kwota = decimal.Parse(Console.ReadLine());
            string sqlUpdate = $"update portfel set porKwota={kwota} where porPK = {id}";
            sqlDataAdapter1.UpdateCommand = new SqlCommand(sqlUpdate, sqlConnection);
            //sqlDataAdapter1.InsertCommand.ExecuteNonQuery();
            int ilosc = sqlDataAdapter1.UpdateCommand.ExecuteNonQuery();
            Console.WriteLine($"Zaktualizowano rekordów: {ilosc}");
#elif(delete)
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            string sqlDelete;
            Console.WriteLine("Podaj pozycje do usunięcia");
            int id=Int32.Parse(Console.ReadLine());
            sqlDelete = $"delete from portfel where porPK = {id}";
            sqlDataAdapter1.DeleteCommand = new SqlCommand(sqlDelete, sqlConnection);
            int ilosc = sqlDataAdapter1.DeleteCommand.ExecuteNonQuery();
            Console.WriteLine($"Usunięto rekordów: {ilosc}");

#endif
            sqlConnection.Close();
            Console.WriteLine("SQL Zamkniete");
            Console.ReadKey();
        }
    }
}
