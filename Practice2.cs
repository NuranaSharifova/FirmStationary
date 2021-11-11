using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FirmStationary
{
    public partial class Practice2 : Form
    {
        SqlConnection _formconnection;
        public Practice2(SqlConnection connection)
        {
            InitializeComponent();
            _formconnection = connection;
        }

        private void pbutton_Click(object sender, EventArgs e)
        {
            string query = "";
        
            switch ((sender as Button).Name)
            {
                case "pbutton":
                    query = "INSERT INTO PRODUCTS(NAME,TYPEID,PRICE) VALUES(@name,@typeid,@price)";
                    break;
                case "tbutton":
                    query = "INSERT INTO PTYPE(NAME,AMOUNT) VALUES(@name,@amount)";
                    break;
                case "mbutton":
                    query = "INSERT INTO MANAGERS(NAME) VALUES(@name)";
                    break;
                case "cbutton":
                    query = "INSERT INTO COMPANY(NAME) VALUES(@name)";
                    break;
                default:
                    break;
            }
            _formconnection.Open();

            SqlCommand command = new SqlCommand(query, _formconnection);
            switch ((sender as Button).Name)
            {
                case "pbutton":
                    SqlParameter param = new SqlParameter("@name", textBox1.Text.ToString());
                    SqlParameter param2 = new SqlParameter("@typeid", Convert.ToInt32(textBox3.Text.ToString()));
                    SqlParameter param3 = new SqlParameter("@price", Convert.ToInt32(textBox2.Text.ToString()));
                    command.Parameters.Add(param);
                    command.Parameters.Add(param2);
                    command.Parameters.Add(param3);                  
                    break;
                case "tbutton":
                    SqlParameter param4 = new SqlParameter("@name", textBox4.Text.ToString());
                    SqlParameter param5 = new SqlParameter("@amount", Convert.ToInt32(textBox5.Text.ToString()));
                    command.Parameters.Add(param4);
                    command.Parameters.Add(param5);
                    break;
                case "mbutton":
                    SqlParameter param6 = new SqlParameter("@name", textBox6.Text.ToString());
                    command.Parameters.Add(param6);
                    break;
                case "cbutton":
                    SqlParameter param7 = new SqlParameter("@name", textBox7.Text.ToString());
                    command.Parameters.Add(param7);
                    break;
                default:
                    break;
            }
            command.ExecuteNonQuery();
            MessageBox.Show("Succesful insert");
            _formconnection.Close();
        }
    }
}
