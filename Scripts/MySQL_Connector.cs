 using System;
 using System.Data;
 using MySql.Data.MySqlClient;
 
 public class MySQL_Connection
 {
    public static void Main(string[] args)
    {
       string connectionString =
          "Server=localhost;" +
          "Database=test;" +
          "User ID=myuserid;" +
          "Password=mypassword;" +
          "Pooling=false";
       IDbConnection con;
       con = new MySqlConnection(connectionString);
       con.Open();
       IDbCommand cmd = con.CreateCommand();
     
       cmd.Dispose();
       cmd = null;
       con.Close();
       con = null;
    }
 }