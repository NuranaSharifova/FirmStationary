using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;


namespace FirmStationary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection GetConnection()
        {

            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Stationary; Integrated Security = true; ";

            return new SqlConnection(connectionString);
        }

        private void allbutton_Click(object sender, EventArgs e)
        {
            string query = "";
            using (SqlConnection connection = GetConnection())
            {
                DataTable data = new DataTable();
                switch ((sender as Button).Name)
                {
                    case "allbutton":
                        query = @"SELECT T.NAME,P.NAME,P.PRICE,T.AMOUNT FROM PRODUCTS P INNER JOIN PTYPE T ON P.TYPEID=T.ID";
                        break;
                    case "typebutton":
                        query = @"SELECT NAME FROM PTYPE";
                        break;
                    case "mbutton":
                        query = @"SELECT NAME FROM MANAGERS";
                        break;
                    case "maxqbtn":
                        query = @" SELECT P.NAME FROM PRODUCTS P INNER JOIN PTYPE T ON P.TYPEID=T.ID
                                WHERE T.AMOUNT=(SELECT MAX(AMOUNT) FROM PTYPE)";
                        break;
                    case "minqbtn":
                        query = @"SELECT P.NAME FROM PRODUCTS P INNER JOIN PTYPE T ON P.TYPEID=T.ID
                        WHERE T.AMOUNT=(SELECT MIN(AMOUNT) FROM PTYPE)";
                        break;
                    case "maxpbtn":
                        query = @"SELECT P.NAME FROM PRODUCTS P WHERE P.PRICE=(SELECT MAX(PRICE) FROM PRODUCTS)";
                        break;
                    case "minpbutton":
                        query = @"SELECT P.NAME FROM PRODUCTS P WHERE P.PRICE=(SELECT MIN(PRICE) FROM PRODUCTS)";
                        break;
                    case "datebtn":
                        query = @"SELECT P.NAME,M.NAME,S.AMOUNT,S.SALEDATE FROM SALES S
                                INNER JOIN PRODUCTS P ON P.ID=S.PRODUCTID
                                INNER JOIN MANAGERS M ON S.MANAGERID=M.ID
                                INNER JOIN COMPANY C ON C.ID=S.COMPANYID
                                WHERE S.SALEDATE=(SELECT MAX (SALEDATE) FROM SALES)";
                        break;
                    case "avgbutton":
                        query = @"SELECT NAME, AVG(AMOUNT) FROM  PTYPE GROUP BY NAME";
                        break;
                    default:
                        break;
                }
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    adapter.Fill(data);
                }
                dataG.DataSource = data;

            }

        }

        private void conbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                conbox.Text = connection.State.ToString();
            }
        }

        private void ubutton1_Click(object sender, EventArgs e)
        {
            string query = "";
            string parameter = "";


            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                DataTable data = new DataTable();
                switch ((sender as Button).Name)
                {
                    case "ubutton1":
                        query = @"SELECT P.NAME FROM PRODUCTS P INNER JOIN PTYPE T ON P.TYPEID=T.ID WHERE T.NAME=@userbox";
                        parameter = textBox1.Text.ToString();
                        break;
                    case "ubutton2":
                        query = @"SELECT P.NAME FROM SALES S INNER JOIN PRODUCTS P ON S.PRODUCTID=P.ID
                        INNER JOIN MANAGERS M ON M.ID=S.MANAGERID WHERE M.NAME=@userbox";
                        parameter = textBox2.Text.ToString();
                        break;
                    case "ubutton3":
                        query = @"SELECT P.NAME FROM SALES S INNER JOIN PRODUCTS P ON S.PRODUCTID=P.ID
                         INNER JOIN COMPANY C ON C.ID=S.COMPANYID WHERE C.NAME=@userbox";
                        parameter = textBox3.Text.ToString();
                        break;
                    default:
                        break;
                }
                
                SqlCommand command = new SqlCommand(query, connection);
                

                SqlParameter param = new SqlParameter("@userbox", parameter);
                command.Parameters.Add(param);
                SqlDataReader reader = command.ExecuteReader();
                for (int i = 0; i < reader.FieldCount; i++)
                {

                    data.Columns.Add(reader.GetName(i));

                }
               

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        DataRow row = data.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {

                            row[i] = reader[i];

                        }
                        data.Rows.Add(row);
                    }
                }
                dataG.DataSource = data;
            }

           
           
        }
    }
}
