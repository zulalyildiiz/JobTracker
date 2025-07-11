using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobTracker
{
    public partial class Form4 : Form
    {
        private SqlConnection conn;
        string connectionString = "Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;";

        string userID, name, surname, nationalID, department, password, authority;

        public Form4()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hasAcc = false;
            conn.Open();
            SqlCommand selectQuery = new SqlCommand("SELECT * FROM Employee WHERE nationalID = '" + textBox1.Text + "'", conn);
            SqlDataReader registerReader = selectQuery.ExecuteReader();

            while (registerReader.Read())
            {
                hasAcc = true;
                break;
            }
            conn.Close();

            if (hasAcc == false)
            {
                if (textBox1.Text.Length != 11 || textBox1.Text == "")
                {
                    label1.ForeColor = Color.Red;
                }
                else
                {
                    label1.ForeColor = Color.Indigo;
                }

                if (textBox2.Text.Length < 2 || textBox2.Text == "")
                {
                    label5.ForeColor = Color.Red;
                }
                else
                {
                    label5.ForeColor = Color.Indigo;
                }

                if (textBox3.Text.Length < 2 || textBox3.Text == "")
                {
                    label6.ForeColor = Color.Red;
                }
                else
                {
                    label6.ForeColor = Color.Indigo;
                }

                if (textBox4.Text == "")
                {
                    label9.ForeColor = Color.Red;
                }
                else
                {
                    label9.ForeColor = Color.Indigo;
                }
                if (textBox5.Text == "")
                {
                    label3.ForeColor = Color.Red;
                }
                else
                {
                    label3.ForeColor = Color.Indigo;
                }
                if (textBox6.Text != textBox5.Text)
                {
                    label4.ForeColor = Color.Red;
                    MessageBox.Show("Parolalar Eşleşmiyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    label4.ForeColor = Color.Indigo;
                }

                if (textBox1.Text.Length == 11 && textBox2.Text.Length >= 2 && textBox3.Text.Length >= 2 && textBox4.Text.Length >= 2 && textBox5.Text != "" && textBox6.Text == textBox5.Text)
                {
                    string insertName = textBox2.Text.ToLower();
                    string insertSurname = textBox3.Text.ToLower();
                    string insertNationalID = textBox1.Text;
                    string insertDepartment = textBox4.Text.ToLower();
                    string insertPassword = textBox5.Text;
                    
                    if (radioButton1.Checked == true)
                    {
                        authority = "personel";
                    }
                    else if (radioButton2.Checked == true)
                    {
                        authority = "yönetim";
                    }
                    int newUserID = 0;

                    // 1. Mevcut en büyük userID'yi al
                    string getMaxIdQuery = "SELECT ISNULL(MAX(userID), 0) FROM Employee";
                    using (SqlCommand getIDCmd = new SqlCommand(getMaxIdQuery, conn))
                    {
                        conn.Open();
                        newUserID = Convert.ToInt32(getIDCmd.ExecuteScalar());
                        conn.Close();
                    }
                    newUserID += 1;


                    try
                    {
                        conn.Open();
                        SqlCommand insertQuery = new SqlCommand("INSERT INTO Employee (name, surname, nationalID, department, password, authority, userID) VALUES (@name, @surname, @nationalID, @department, @password, @authority, @userID)", conn);
                        insertQuery.Parameters.AddWithValue("@name", insertName);
                        insertQuery.Parameters.AddWithValue("@surname", insertSurname);
                        insertQuery.Parameters.AddWithValue("@nationalID", insertNationalID);
                        insertQuery.Parameters.AddWithValue("@department", insertDepartment);
                        insertQuery.Parameters.AddWithValue("@password", insertPassword);
                        insertQuery.Parameters.AddWithValue("@authority", authority);
                        insertQuery.Parameters.AddWithValue("@userID", newUserID);


                        insertQuery.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik Numarası zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.AcceptButton = button1;
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox6.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
