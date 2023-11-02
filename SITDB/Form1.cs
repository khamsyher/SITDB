using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cnbt_Click(object sender, EventArgs e)
        {
            /* 
             
            string cnstring;
            SqlConnection cnn;
            cnstring = "Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=SITDB;Integrated Security=True;";
            cnn = new SqlConnection(cnstring);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            sql = " SELECT * FROM SubjectTb";
            command= new SqlCommand(sql, cnn);
            dataReader= command.ExecuteReader();
            while(dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "_" + dataReader.GetValue(1) + "\n";
            }
            MessageBox.Show(Output);
            dataReader.Close();
            command.Dispose();
            cnn.Close();
            */

            /*
            string cnstring;
            SqlConnection cnn;
            cnstring = "Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=SITDB;Integrated Security=True;";
            cnn = new SqlConnection(cnstring);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter dataAdapter= new SqlDataAdapter();
            String sql;
            sql = "INSERT INTO SubjectTb(Subject) values('" + " visual.net " + "')";
            command = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            MessageBox.Show("Data Inserted");
            cnn.Close();
            */

            string cnstring;
            SqlConnection cnn;
            cnstring = "Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=SITDB;Integrated Security=True;";
            cnn = new SqlConnection(cnstring);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            String sql;
            sql = "UPDATE SubjectTb SET Subject='" + " Microsoft Studio Visual.net " + "' WHERE SubjectID=4";
            command = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            MessageBox.Show("Data success Updated");
            cnn.Close();

        }
    }
}
