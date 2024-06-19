using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Software
{
    internal class tblExercise
    {
        private string _description;
        private decimal _met;

        public string Description { get { return _description; } set { _description = value; } }
        public decimal Met { get { return _met; } set { _met = value; } }
        public static int eid;
        public static List<tblExercise> getExerciseFromDatabase(string type)
        {
            Database_Connection con = new Database_Connection();
            List<tblExercise> list = new List<tblExercise>();
            MySqlCommand cmd = new MySqlCommand("select * from tblexercise where Type = @type;");
            cmd.Connection = con.GetConnection();
            cmd.Parameters.AddWithValue("@type", type);
            con.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tblExercise exercises = new tblExercise();
                exercises.Description = reader.GetString("description");
                list.Add(exercises);
            }
            reader.Close();
            con.CloseConnection();
            return list;
        }

        public static decimal getMETFromDatabase (string desc) //get MET score 
        {
            decimal MET = 0;
            Database_Connection con = new Database_Connection();

            MySqlCommand cmd = new MySqlCommand("select * from tblExercise where description = @desc;");
            cmd.Connection = con.GetConnection();
            cmd.Parameters.AddWithValue("@desc", desc);
            con.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                eid = reader.GetInt32(0);
                MET = reader.GetDecimal(3);
                reader.Close();
                con.CloseConnection();
            }
            return MET;
        }

    }
}
