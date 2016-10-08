using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data;
//using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Drawing;
namespace ProductTracking
{
    public class Model
    {
        private formContainer fc;
        private User currentUser;
        private SqlConnection con;
        private ArrayList userList;   //Declare the SqlConnection data connection object as an SqlClient (SQLEXPRESS)
        //DataSet ds;                 //Declare the DataSet object
        //SqlDataAdapter da;   //Declare the DataAdapter object

        public Model()
        {
            userList = new ArrayList();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=3C15-BW-LAPTOP ;Initial Catalog=ProductTracker;Integrated Security=True";
            //con.ConnectionString = "Data Source=BDEV2 ;Initial Catalog=ProductTracker;Integrated Security=True";
            /*       con.ConnectionString = "Data Source=SQL02.student.litdom.lit.ie\\SD3A ;Initial Catalog=ProductTracker;Integrated Security=True";
                     This last conection string is for SQL02.student.litdom.lit.ie\SD3A  Note the extra (slash)\ in the code. This is needed in the lab 
                     for the extra instances Annette Bowman sets up on the CS SQL Server*/
            try
            {
                con.Open();
                //MessageBox.Show("Database Open");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                Environment.Exit(0); //Force the application to close
            }
        }

        ~Model()
        {
            con.Close(); ;
        } 

        public formContainer Fc
        {
            get
            {
                return fc;
            }
            set
            {
                fc = value;
            }
        }

        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }

        public SqlConnection Con
        {
            get
            {
                return con;
            }
            //set
            //{
            //    con = value;
            //}
        }

        public ArrayList UserList
        {
            get
            {
                return userList;
            }
            //set
            //{
            //}
        }
    }
}
