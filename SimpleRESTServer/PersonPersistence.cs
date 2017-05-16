using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleRESTServer.Models;
using MySql.Data;

namespace SimpleRESTServer
{
    public class PersonPersistence
    {
        private MySql.Data.MySqlClient.MySqlConnection conn;
       

        public PersonPersistence()
        {

           string  myConnectionString = "Server=127.0.0.1;Port=3306;Database=employeedb;Uid=root;Pwd=''";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // MessageBox.Show(ex.Message);
            }
                
        }

        public long SavePerson(Person PersonToSave)
        {
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("INSERT INTO TABLE Personnel (FirstName,LastName,PayRate,StartDate,EndDate) VALUES('" + PersonToSave.FirstName + "','" + PersonToSave.LastName + "','" + PersonToSave.PayRate + "','" + PersonToSave.StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + PersonToSave.EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "')", conn);
            cmd.ExecuteNonQuery();
            long id = cmd.LastInsertedId;
            return id;
        }
    }
}