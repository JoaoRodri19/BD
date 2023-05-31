using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Ds3
{
    public partial class Form2 : Form
    {
        private SqlConnection cn;

        public Form2()
        {
            InitializeComponent();
            getJogador();
            DropJogador.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= tcp:mednat.ieeta.pt\\SQLSERVER,8101;initial catalog=p3g1;uid=p3g1;password=-102487102578@BD");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
        }

        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void getJogador()
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("exec GetAllBossInformation", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                String jogador = reader.GetString(0);

                DropJogador.Items.Add(jogador);
            }

            cn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show();
            this.Hide();
        }

        private void btBosses_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            x.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = DropJogador.SelectedItem.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 x = new Form4(DropJogador.SelectedItem.ToString());
            x.Show();
            this.Hide();
        }
    }
}
