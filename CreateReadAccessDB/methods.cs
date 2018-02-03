using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateReadAccessDB
{
    class methods
    {
        //GLOBAL VARIABLES
        static OleDbConnection connectionObject;
        static OleDbCommand commandObject;
        static OleDbDataReader readerObject;

        public static void GetEntries()
        {
            string Entries = "";
            connectionObject = new OleDbConnection();
            connectionObject.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source= database/example.accdb";
            commandObject = new OleDbCommand();
            commandObject.Connection = connectionObject;
            commandObject.CommandText = "SELECT * FROM Table1";
            connectionObject.Open();
            readerObject = commandObject.ExecuteReader();
            while (readerObject.Read())
            {
                Entries += readerObject[0] + "-" + readerObject[1] + "\n";
            }
            Console.WriteLine(Entries + "\n");
            connectionObject.Close();
        }

        public static void InsertEntry()
        {
            Console.Write("Entry:");
            string Entry = Console.ReadLine();
            connectionObject = new OleDbConnection();
            connectionObject.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=database/example.accdb";
            commandObject = new OleDbCommand();
            commandObject.Connection = connectionObject;
            commandObject.CommandText = "INSERT INTO Table1 (scratch) VALUES ('" + Entry + "')";
            connectionObject.Open();
            commandObject.ExecuteNonQuery();
            connectionObject.Close();
            Console.WriteLine("Success!\n");
        }
    }
}
