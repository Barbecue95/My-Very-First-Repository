using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fitness_Software
{
    internal class tblUser
    {

        public static int uid;
        public static string uName;

        Database_Connection connect = new Database_Connection();

        //check user
        public bool CheckCredentials(string username, string password)
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbluser where username = @username AND password = @password;");
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Connection = connect.GetConnection();
            connect.OpenConnection();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                uid = dr.GetInt32(0);
                uName = dr.GetString(1);

                connect.CloseConnection();
                return true;
            }
            else
            {
                connect.CloseConnection();
                return false;
            }
        }

        //checking duplicated username in the database
        public bool userValid(string username)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbluser WHERE username= @username ");
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Connection = connect.GetConnection();
            connect.OpenConnection();
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                connect.CloseConnection();
                return true;
            }
            else
            {
                connect.CloseConnection();
                return false;
            }
        }

        //add user in database
        public void UserRegister(string username, string password, decimal goal)
        {
            MySqlCommand cmd = new MySqlCommand("Insert into tbluser(username, password,setgoal ) values (@username , @password, @goal )");
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@goal", goal);
            cmd.Connection = connect.GetConnection();
            connect.OpenConnection();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            dr.Close();
            connect.CloseConnection();
        }

        //get user's setgoal
        public static decimal getSetgoal()
        {
            Database_Connection connect = new Database_Connection();
            decimal setGoal = 0;
            MySqlCommand cmd = new MySqlCommand("select setgoal from tblUser where uId = @uid");
            cmd.Parameters.AddWithValue("uid", uid);
            cmd.Connection = connect.GetConnection();
            connect.OpenConnection();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                setGoal = dr.GetDecimal(0);
                connect.CloseConnection();
            }
            return setGoal;
        }

        //update user's setgoal
        public void updateSetgoal(decimal setGoal)
        {
            MySqlCommand cmd = new MySqlCommand("update tblUser set setgoal = @setgoal where uId = @uId ");
            cmd.Parameters.AddWithValue("setgoal", setGoal);
            cmd.Parameters.AddWithValue("uId", uid);
            cmd.Connection = connect.GetConnection();
            connect.OpenConnection();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            dr.Close();
            connect.CloseConnection();
        }
    }
}
