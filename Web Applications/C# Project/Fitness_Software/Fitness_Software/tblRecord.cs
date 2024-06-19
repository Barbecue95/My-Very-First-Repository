using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Software
{
    internal class tblRecord
    {
        private int _date;
        private decimal _calBurn;

        public int Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public decimal CalBurn
        {
            get { return _calBurn; }
            set { _calBurn = value; }
        }

        //encupsulation list to get record table
        public static List<tblRecord> getRecordFromDatabase()
        {
            Database_Connection con = new Database_Connection();
            List<tblRecord> list = new List<tblRecord>();
            MySqlCommand command = new MySqlCommand("select * from tblRecord where uid = @uId;");
            command.Connection = con.GetConnection();
            command.Parameters.AddWithValue("uid", tblUser.uid);
            con.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tblRecord record = new tblRecord();
                record.Date = reader.GetInt32("date");
                record.CalBurn = (decimal)reader["calBurn"];
                list.Add(record);
            }
            reader.Close();
            con.CloseConnection();
            return list;
        }

        //insert record data
        public void createRecord(int date, decimal calBurn)
        {
            Database_Connection con = new Database_Connection();
            MySqlCommand cmd = new MySqlCommand("insert into tblRecord (uid,eid,date,calburn) values (@uid,@eid,@date,@calburn);");
            cmd.Parameters.AddWithValue("uid", tblUser.uid);
            cmd.Parameters.AddWithValue("eid", tblExercise.eid);
            cmd.Parameters.AddWithValue("date", date);
            cmd.Parameters.AddWithValue("calburn", calBurn);
            cmd.Connection = con.GetConnection();
            con.OpenConnection();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            dr.Close();
            con.CloseConnection();

        }

        //get date 
        public static int getDate()
        {
            Database_Connection con = new Database_Connection();
            MySqlCommand cmd = new MySqlCommand("select * from tblRecord where uid = @uid;");
            cmd.Parameters.AddWithValue("uid", tblUser.uid);
            cmd.Connection = con.GetConnection();
            con.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            return count;
        }

        //get total calories burned by user
        public static decimal getTotalCal()
        {
            Database_Connection con = new Database_Connection();
            MySqlCommand cmd = new MySqlCommand("select Sum(calBurn) as calBurn from tblRecord where uid = @uid;");
            cmd.Parameters.AddWithValue("uid", tblUser.uid);
            cmd.Connection = con.GetConnection();
            con.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            decimal cal = 0;
            if (reader.Read() == true)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("calBurn")))
                {
                    cal = reader.GetDecimal(0);

                }
                else
                {
                    cal = 0;
                }

            }
            return cal;
        }

        //reset record
        public static void deleteGoal()
        {
            Database_Connection con = new Database_Connection();
            MySqlCommand cmd = new MySqlCommand("delete from tblRecord where uid = @uid ;");
            cmd.Parameters.AddWithValue("uid", tblUser.uid);
            cmd.Connection = con.GetConnection();
            con.OpenConnection();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            dr.Close();
            con.CloseConnection();
        }
    }
}
