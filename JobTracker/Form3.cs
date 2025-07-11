using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobTracker
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            string f3_name = Form1.name;
            string f3_surname = Form1.surname;
            string f3_department = Form1.department;
            string f3_nationalID = Form1.nationalID;
            string f3_authority = Form1.authority;
            string f3_password = Form1.password;
            string f3_userID = Form1.userID;

            label14.Text = f3_name.ToUpper() + " " + f3_surname.ToUpper();
            label4.Text = f3_nationalID;
            label13.Text = f3_name.ToUpper();
            label10.Text = f3_surname.ToUpper();
            label11.Text = f3_userID;
            label12.Text = f3_department.ToUpper();

            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT name AS[İsim], surname AS[Soyisim], department AS[Departman] FROM Employee WHERE authority = 'personel'", conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt; // DataGridView'e bağlama
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu!\n" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT name AS[İsim], surname AS[Soyisim], department AS[Departman] FROM Employee WHERE authority = 'yönetim'", conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView2.DataSource = dt; // DataGridView'e bağlama
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu!\n" + ex.Message);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                {
                    conn.Open();
                    string query = "SELECT e.name AS [İsim], e.surname AS [Soyisim], s.date AS [Tarih], s.description AS [Açıklama] " +
                                   "FROM Employee e INNER JOIN ShiftLogs s ON e.nationalID = s.nationalID " +
                                   "WHERE s.date = @date";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView3.DataSource = dt;
                            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler Getirilirken Bir Hata Meydana Geldi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                {
                    conn.Open();
                    string query = "SELECT e.name AS [İsim], e.surname AS [Soyisim], s.date AS [Tarih], s.description AS [Açıklama] " +
                                   "FROM Employee e INNER JOIN ShiftLogs s ON e.nationalID = s.nationalID " +
                                   "WHERE e.name = @name AND e.surname = @surname";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", textBox1.Text.ToLower());
                        cmd.Parameters.AddWithValue("@surname", textBox2.Text.ToLower());

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView4.DataSource = dt;
                            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler Getirilirken Bir Hata Meydana Geldi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                {
                    conn.Open();
                    string query = "SELECT e.name AS [İsim], e.surname AS [Soyisim], s.date AS [Tarih], s.description AS [Açıklama] " +
                                   "FROM Employee e INNER JOIN ShiftLogs s ON e.nationalID = s.nationalID " +
                                   "WHERE s.date = @date";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView3.DataSource = dt;
                            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler Getirilirken Bir Hata Meydana Geldi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                {
                    conn.Open();
                    string query = @"SELECT userID, name, surname, nationalID FROM Employee WHERE name = @name AND surname = @surname";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", textBox3.Text.Trim().ToLower());
                        cmd.Parameters.AddWithValue("@surname", textBox4.Text.Trim().ToLower());

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView6.DataSource = dt;
                            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView6.AutoGenerateColumns = true;

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler Getirilirken Bir Hata Meydana Geldi!" + ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                {
                    conn.Open();
                    
                    using (SqlCommand cmd = new SqlCommand("SELECT e.name AS [İsim], e.surname AS [Soyisim], s.date AS [Tarih], s.description AS [Açıklama] FROM Employee e INNER JOIN ShiftLogs s ON e.nationalID = s.nationalID WHERE e.name = @name AND e.surname = @surname AND s.date = @date", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", textBox5.Text.Trim().ToLower());
                        cmd.Parameters.AddWithValue("@surname", textBox6.Text.Trim().ToLower());
                        cmd.Parameters.AddWithValue("@date", dateTimePicker2.Value.ToString("yyyy-MM-dd"));

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView5.DataSource = dt;
                            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView5.AutoGenerateColumns = true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler Getirilirken Bir Hata Meydana Geldi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE s FROM ShiftLogs s INNER JOIN Employee e ON e.nationalID = s.nationalID WHERE e.name = @name AND e.surname = @surname AND s.date = @date", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", textBox5.Text.ToLower());
                        cmd.Parameters.AddWithValue("@surname", textBox6.Text.ToLower());
                        cmd.Parameters.AddWithValue("@date", dateTimePicker2.Value.ToString("yyyy-MM-dd"));

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Kayıt bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Silinirken Bir Hata Meydana Geldi!" + ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                {
                    conn.Open();
                    string query = "DELETE FROM Employee WHERE name = @name AND surname = @surname";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", textBox3.Text.ToLower());
                        cmd.Parameters.AddWithValue("@surname", textBox4.Text.ToLower());

                        int result = cmd.ExecuteNonQuery(); 

                        if (result > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Kayıt bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Silinirken Bir Hata Meydana Geldi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
