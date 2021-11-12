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
                case "upproduct":
                    query = "UPDATE PRODUCTS SET NAME=@name,TYPEID=@price,PRICE=@price WHERE ID=@id";
                    break;
                case "uptype":
                    query = "UPDATE PTYPE SET NAME=@name,AMOUNT=@amount WHERE ID=@id";
                    break;
                case "upmanager":
                    query = "UPDATE MANAGERS SET NAME=@name WHERE ID=@id";
                    break;
                case "upcomp":
                    query = "UPDATE COMPANY SET NAME=@name WHERE ID=@id";
                    break;
                case "delproduct":
                    query = "DELETE PRODUCTS WHERE ID=@id";
                    break;
                case "deltype":
                    query = "DELETE PTYPE WHERE ID=@id";
                    break;
                case "delmanager":
                    query = "DELETE MANAGERS WHERE ID=@id";
                    break;
                case "delcomp":
                    query = "DELETE COMPANY WHERE ID=@id";
                    break;
                default:
                    break;
            }
            _formconnection.Open();
  
            SqlCommand command = new SqlCommand(query, _formconnection);
            SqlParameter param = new SqlParameter("@name", textBox1.Text.ToString());
            SqlParameter param2 = new SqlParameter("@typeid", Convert.ToInt32(textBox3.Text.ToString()));
            SqlParameter param3 = new SqlParameter("@price", Convert.ToInt32(textBox2.Text.ToString()));
            SqlParameter param4 = new SqlParameter("@name", textBox4.Text.ToString());
            SqlParameter param5 = new SqlParameter("@amount", Convert.ToInt32(textBox5.Text.ToString()));
            SqlParameter param6 = new SqlParameter("@name", textBox6.Text.ToString());
            SqlParameter param7 = new SqlParameter("@name", textBox7.Text.ToString());
            SqlParameter param8 = new SqlParameter("@id", Convert.ToInt32(textBox8.Text.ToString()));
            SqlParameter param9 = new SqlParameter("@id", Convert.ToInt32(textBox9.Text.ToString()));
            SqlParameter param10 = new SqlParameter("@id", Convert.ToInt32(textBox10.Text.ToString()));
            SqlParameter param11 = new SqlParameter("@id", Convert.ToInt32(textBox11.Text.ToString()));
            switch ((sender as Button).Name)
            {
                case "pbutton":
                    command.Parameters.Add(param);
                    command.Parameters.Add(param2);
                    command.Parameters.Add(param3);                  
                    break;
                case "tbutton":
                    command.Parameters.Add(param4);
                    command.Parameters.Add(param5);
                    break;
                case "mbutton":
                    command.Parameters.Add(param6);
                    break;
                case "cbutton":      
                    command.Parameters.Add(param7);
                    break;
                case "upproduct":
                    command.Parameters.Add(param);
                    command.Parameters.Add(param2);
                    command.Parameters.Add(param3);
                    command.Parameters.Add(param8);
                    break;
                case "uptype":
                    command.Parameters.Add(param4);
                    command.Parameters.Add(param5);
                    command.Parameters.Add(param9);
                    break;
                case "upmanager":
                    command.Parameters.Add(param6);
                    command.Parameters.Add(param10);
                    break;
                case "upcomp":
                    command.Parameters.Add(param7);
                    command.Parameters.Add(param11);
                    break;
                case "delproduct":
                    command.Parameters.Add(param8);
                    break;
                case "deltype":
                    command.Parameters.Add(param9);
                    break;
                case "delmanager":
                    command.Parameters.Add(param10);
                    break;
                case "delcomp":
                    command.Parameters.Add(param11);
                    break;
                default:
                    break;
            }
            command.ExecuteNonQuery();
            MessageBox.Show("Succesful insert");
            _formconnection.Close();
        }

        private void m1_Click(object sender, EventArgs e)
        {
            string query = "";
            string parameter = "";


          
                _formconnection.Open();
                DataTable data = new DataTable();
                switch ((sender as Button).Name)
                {
                    case "b1":
                        query = @"SELECT TOP 1 M.NAME,SUM(S.AMOUNT) FROM SALES S
                                INNER JOIN MANAGERS M ON S.MANAGERID=M.ID
                                GROUP BY M.NAME
                                ORDER BY SUM(S.AMOUNT) DESC";                    
                        break;
                    case "b2":
                        query = @"SELECT TOP 1 M.NAME,SUM(S.AMOUNT*S.PRICE)-SUM(S.AMOUNT*P.PRICE) FROM SALES S
                                INNER JOIN MANAGERS M ON S.MANAGERID=M.ID
                                INNER JOIN PRODUCTS P ON P.ID=S.PRODUCTID
                                GROUP BY M.NAME
                                ORDER BY SUM(S.AMOUNT*S.PRICE)-SUM(S.AMOUNT*P.PRICE) DESC";
                        break;
                    case "b8":
                        query = @"SELECT TOP 1 M.NAME,SUM(S.AMOUNT*S.PRICE)-SUM(S.AMOUNT*P.PRICE)[PROFIT] FROM SALES S
                                INNER JOIN MANAGERS M ON S.MANAGERID=M.ID
                                INNER JOIN PRODUCTS P ON P.ID=S.PRODUCTID
                                WHERE MONTH(S.SALEDATE)=@date
                                GROUP BY M.NAME
                                ORDER BY SUM(S.AMOUNT*S.PRICE)-SUM(S.AMOUNT*P.PRICE) DESC";
                        parameter = textBox12.Text.ToString();
                        break;
                    case "b3":
                        query = @"SELECT TOP 1 C.NAME FROM SALES S
                                INNER JOIN COMPANY C  ON S.COMPANYID=C.ID
                                GROUP BY C.NAME
                                ORDER BY SUM(S.AMOUNT*S.PRICE) DESC";
                        break;
                    case "b4":
                        query = @"SELECT TOP 1 T.NAME,SUM(S.AMOUNT)[AMOUNT] FROM SALES S
                                INNER JOIN PRODUCTS P ON P.ID=S.PRODUCTID
                                INNER JOIN PTYPE T ON P.TYPEID=T.ID
                                GROUP BY T.NAME
                                ORDER BY SUM(S.AMOUNT) DESC";
                        break;
                    case "b5":
                        query = @"SELECT TOP 3 P.NAME,SUM(S.AMOUNT*S.PRICE)-SUM(S.AMOUNT*P.PRICE)[PROFIT] FROM SALES S
                                INNER JOIN PRODUCTS P ON P.ID=S.PRODUCTID
                                GROUP BY P.NAME
                                ORDER BY SUM(S.AMOUNT*S.PRICE)-SUM(S.AMOUNT*P.PRICE) DESC";
                        break;
                    case "b6":
                        query = @"SELECT TOP 3 P.NAME,SUM(S.AMOUNT)[AMOUNT] FROM SALES S
                                INNER JOIN PRODUCTS P ON P.ID=S.PRODUCTID
                                GROUP BY P.NAME
                                ORDER BY SUM(S.AMOUNT) DESC";
                        break;
                    case "b7":
                        query = @"SELECT NAME FROM PRODUCTS P
                                WHERE ID NOT IN (SELECT PRODUCTID FROM SALES WHERE  MONTH(SALEDATE)=@date) ";
                        parameter = textBox13.Text.ToString();
                        break;
                    default:
                        break;
                }

                SqlCommand command = new SqlCommand(query, _formconnection);


                SqlParameter param = new SqlParameter("@date", parameter);
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
                dataV.DataSource = data;

            _formconnection.Close();

        }
    }
}
