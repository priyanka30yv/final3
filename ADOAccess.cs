using System;
using System.Data;

using System.Data.OleDb;
namespace ADOfinal
{
    class ADOAccess
    {
        public static void Main(string[] args)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\TRGDemos\NewsPaper.accdb;");
            con.Open();
            Console.WriteLine("state {0}",con.State);
OleDbCommand cmd=new OleDbCommand("select * from NewsArticle",con);
OleDbDataReader dr=cmd.ExecuteReader();
while(dr.Read())
{
System.Console.WriteLine("news id {0}",dr[0]);
System.Console.WriteLine("Article Name {0}",dr[1]);
System.Console.WriteLine("Reporter Name {0}",dr[2]);
}
 
        }
    }
}