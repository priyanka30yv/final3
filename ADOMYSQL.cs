using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ADOfinal
{
    class ADOMYSQL
    {
        public static void Main(string[] args)
        {
           MySqlConnection con = new MySqlConnection("server=localhost;database=concert;user id=root;password=root;port=3306");
            con.Open();
    
MySqlCommand cmd=new MySqlCommand("update music set playername='mayur' where playerName='roshani'",con);
int ans=cmd.ExecuteNonQuery();
Console.WriteLine("{0} record updated",ans);


        }
    }
}