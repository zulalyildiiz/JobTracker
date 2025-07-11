using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JobTracker
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        string connectionString = "Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;";

        public static string userID, name, surname, nationalID, department, password, authority;
        string inputNID, inputPassword;
        public int right = 5;


        public Form1()
        {
            InitializeComponent();

            conn = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Kullanýcý Giriþi";
            this.AcceptButton = button1;
            this.CancelButton = button2;
            label6.Text = Convert.ToString(right);
            radioButton2.Checked = true;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (right != 0)
            {
                try
                {
                    conn.Open();

                    SqlCommand selectQuery = new SqlCommand("SELECT * FROM Employee", conn);
                    SqlDataReader registerReader = selectQuery.ExecuteReader();
                    bool loginSuccess = false;

                    while (registerReader.Read())
                    {
                        userID = registerReader["userID"].ToString();
                        name = registerReader["name"].ToString();
                        surname = registerReader["surname"].ToString();
                        nationalID = registerReader["nationalID"].ToString();
                        department = registerReader["department"].ToString();
                        password = registerReader["password"].ToString();
                        authority = registerReader["authority"].ToString();

                        inputNID = textBox1.Text.Trim();
                        inputPassword = textBox2.Text.Trim();



                        if (radioButton2.Checked == true
                            && nationalID == inputNID
                            && password == inputPassword
                            && authority == "personel")
                        {
                            loginSuccess = true;
                            MessageBox.Show("Personel Giriþi Baþarýlý!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



                            right = 5;
                            label6.Text = Convert.ToString(right);

                            getValues(registerReader);

                            this.Hide();

                            Form2 form2 = new Form2();
                            form2.Show();
                            break;
                        }

                        if (radioButton1.Checked == true
                             && nationalID == inputNID
                             && password == inputPassword
                             && authority == "yönetim")
                        {
                            loginSuccess = true;
                            MessageBox.Show("Yönetici Giriþi Baþarýlý!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            right = 5; // Giriþ baþarýlý olduðunda hakký sýfýrla
                            label6.Text = Convert.ToString(right);

                            this.Hide();

                            getValues(registerReader);


                            Form3 form3 = new Form3();
                            form3.Show();
                            break;
                        }

                    }

                    registerReader.Close();

                    if (!loginSuccess)
                    {
                        right--;
                        label6.Text = Convert.ToString(right);
                        MessageBox.Show("Kullanýcý adý veya þifre yanlýþ. Kalan giriþ hakkýnýz: " + right, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (right == 0)
                        {
                            MessageBox.Show("Giriþ hakkýnýz kalmadý.");
                            this.Close();
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Giriþ hakkýnýz kalmadý.");
            }

        }
        private void getValues(SqlDataReader reader)
        {
            userID = reader["userID"].ToString();
            name = reader["name"].ToString();
            surname = reader["surname"].ToString();
            nationalID = reader["nationalID"].ToString();
            department = reader["department"].ToString();
            password = reader["password"].ToString();
            authority = reader["authority"].ToString();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
