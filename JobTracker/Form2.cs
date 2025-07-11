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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JobTracker
{
    public partial class Form2 : Form
    {
        private SqlConnection conn;
        string connectionString = "Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;";

        public string nid { get; set; }
        public Form2()
        {
            InitializeComponent();
            string f2_name = Form1.name;
            string f2_surname = Form1.surname;
            string f2_department = Form1.department;
            string f2_nationalID = Form1.nationalID;
            string f2_authority = Form1.authority;
            string f2_password = Form1.password;
            string f2_userID = Form1.userID;

            label14.Text = f2_name.ToUpper() + " " + f2_surname.ToUpper();
            label4.Text = f2_nationalID;
            label13.Text = f2_name.ToUpper();
            label10.Text = f2_surname.ToUpper();
            label11.Text = f2_userID;
            label12.Text = f2_department.ToUpper();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bool hasReg = false;
            using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
            {
                conn.Open();
                SqlCommand selectQuery = new SqlCommand("SELECT * FROM ShiftLogs WHERE date = @date AND nationalID = @nationalID", conn);
                selectQuery.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                selectQuery.Parameters.AddWithValue("@nationalID", Form1.nationalID);
                SqlDataReader registerReader = selectQuery.ExecuteReader();
                while (registerReader.Read())
                {
                    hasReg = true;
                    break;
                }
                conn.Close();
            }


            if (hasReg == false && textBox3.Text.Length != 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                    {
                        conn.Open();
                        SqlCommand insertQuery = new SqlCommand("INSERT INTO ShiftLogs (nationalID, date, description) VALUES (@nationalID, @date, @description)", conn);
                        insertQuery.Parameters.AddWithValue("@nationalID", Form1.nationalID);
                        insertQuery.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                        insertQuery.Parameters.AddWithValue("@description", textBox3.Text);


                        insertQuery.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox3.Clear();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (hasReg == true)
            {
                MessageBox.Show("Bu tarihe ait kayıt zaten var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                {
                    conn.Open();
                    string query = "SELECT e.name + ' ' + e.surname AS [Personel], " +
                       "e.department AS [Departman], s.date AS [Tarih], s.description AS [Açıklama] " +
                       "FROM Employee e " +
                       "INNER JOIN ShiftLogs s ON e.nationalID = s.nationalID " +
                       "WHERE e.nationalID = @nationalID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nationalID", Form1.nationalID); // buraya istediğin kişiyi yazabilirsin

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
                MessageBox.Show("Veriler yüklenirken hata oluştu!\n" + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hasReg = false;
            using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
            {
                conn.Open();
                SqlCommand selectQuery = new SqlCommand("SELECT * FROM ShiftLogs WHERE date = @date", conn);
                selectQuery.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                SqlDataReader registerReader = selectQuery.ExecuteReader();
                while (registerReader.Read())
                {
                    hasReg = true;
                    break;
                }
                conn.Close();
            }


            if (hasReg == false && textBox3.Text.Length != 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                    {
                        conn.Open();
                        SqlCommand insertQuery = new SqlCommand("INSERT INTO ShiftLogs (nationalID, date, description) VALUES (@nationalID, @date, @description)", conn);
                        insertQuery.Parameters.AddWithValue("@nationalID", Form1.nationalID);
                        insertQuery.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                        insertQuery.Parameters.AddWithValue("@description", textBox3.Text);


                        insertQuery.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox3.Clear();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (hasReg == true)
            {
                MessageBox.Show("Bu tarihe ait kayıt zaten var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool hasReg = false;
            using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
            {
                conn.Open();
                SqlCommand selectQuery = new SqlCommand("SELECT * FROM ShiftLogs WHERE date = @date AND nationalID = @nationalID", conn);
                selectQuery.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                selectQuery.Parameters.AddWithValue("@nationalID", Form1.nationalID);
                SqlDataReader registerReader = selectQuery.ExecuteReader();
                while (registerReader.Read())
                {
                    hasReg = true;
                    break;
                }
                conn.Close();
            }


            if (hasReg == false && textBox3.Text.Length != 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                    {
                        conn.Open();
                        SqlCommand insertQuery = new SqlCommand("INSERT INTO ShiftLogs (nationalID, date, description) VALUES (@nationalID, @date, @description)", conn);
                        insertQuery.Parameters.AddWithValue("@nationalID", Form1.nationalID);
                        insertQuery.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                        insertQuery.Parameters.AddWithValue("@description", textBox3.Text);


                        insertQuery.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox3.Clear();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (hasReg == true)
            {
                MessageBox.Show("Bu tarihe ait kayıt zaten var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DELL-G15-5520\\SQLEXPRESS; Initial Catalog = JobTracker; Integrated Security = True; TrustServerCertificate = True;"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT date AS Tarih, description AS Açıklama FROM ShiftLogs WHERE date = @date AND nationalID = @nationalID", conn))
                    {
                        cmd.Parameters.AddWithValue("@date", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@nationalID", Form1.nationalID);

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
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM ShiftLogs WHERE date = @date AND nationalID = @nationalID", conn))
                    {
                        cmd.Parameters.AddWithValue("@nationalID", Form1.nationalID);
                        cmd.Parameters.AddWithValue("@date", dateTimePicker2.Value.Date);

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

    }
}
