using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace ADOfinal
{
    class ADOExcel
    {
        public static void Main(string[] args)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\TRGDemos\data
.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;'");
            con.Open();
    
OleDbCommand cmd=new OleDbCommand("Select * from Marksheet",con);
OleDbDataReader dr=cmd.ExecuteReader();
while(dr.Read())
{
System.Console.WriteLine("student id {0}",dr[0]);
System.Console.WriteLine("student Name {0}",dr[1]);
System.Console.WriteLine("marks{0}",dr[2]);
}

        }
    }
}