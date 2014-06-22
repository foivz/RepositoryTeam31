using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bastion
{
    class baza
    {
        private baza()
        {
           ConnectionString = @"Data Source=PI.db";
           //ConnectionString = @"C:\Users\jtrupina\Desktop\TRUPINA ZADNJE\Bastion\baza\PI.db";
            Connection = new SQLiteConnection(ConnectionString);
            Connection.Open();

        }

        ~baza()
        {
            Connection.Close();
            Connection = null;
        }

        private static baza instance;
        private string connecionString;
        private SQLiteConnection connection;

        public static baza Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new baza();
                }
                return instance;
            }
        }

        public string ConnectionString
        {
            get
            {
                return connecionString;
            }
            private set
            {
                if (connecionString != value)
                {
                    connecionString = value;
                }
            }
        } //public string ConnectionString

        public SQLiteConnection Connection
        {
            get
            {
                return connection;
            }
            private set
            {
                if (connection != value)
                {
                    connection = value;
                }
            }
        }

        public DbDataReader DohvatiDataReader(string sqlUpit)
        {
            SQLiteCommand commad = new SQLiteCommand(sqlUpit, Connection);
            return commad.ExecuteReader();
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        //izvrsavanje upita

        public int IzvrsiUpit(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }

        public int DohvatiV(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return Convert.ToInt32(command.ExecuteScalar());
        }

    }
}
