using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ds3
{
    public partial class Form1 : Form
    {
        private SqlConnection cn;
        private int currentContact;
        private bool adding;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
            loadCustomersToolStripMenuItem_Click(sender, e);

        }


        private SqlConnection getSGBDConnection() 
        {
            return new SqlConnection("data source= tcp:mednat.ieeta.pt\\SQLSERVER,8101;initial catalog=p3g1;uid=p3g1;password=-102487102578@BD");
        }

        private bool verifySGBDConnection() 
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                currentContact = listBox1.SelectedIndex;
                ShowContact();
            }
        }

        private void loadCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM ds3.Bosses " +
                "JOIN ds3.Adversario on Bosses.Adversario = Adversario.Personagem" +
                "JOIN Personagem on Persongem" +
                "JOIN Localizacao_Adversario on Adversario.Personagem = Localizacao_Adversario.Persongem" +
                "JOIN Localizacao.coordenadas =  Localizacao_Adversario.coordenada" +
                "JOIN Zona on Zona.Nome = Localizacao.Zona ", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {

                Saves S = new Saves();
                S.ID = reader["ID"].ToString();
                S.Ultima_localizacao = reader["Ultima_localizacao"].ToString();
                S.Horas = reader["Horas"].ToString();
                S.Jogador = reader["Jogador"].ToString();
                listBox1.Items.Add(S);
            }

            cn.Close();


            currentContact = 0;
            ShowContact();
        }

        private void SubmitContact(Saves S)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT Saves (ID, Ultima_localizacao, Horas, Jogador) VALUES (@ID, @Ultima_localizacao, @Horas, @Jogador)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", S.ID);
            cmd.Parameters.AddWithValue("@Ultima_localizacao", S.Ultima_localizacao);
            cmd.Parameters.AddWithValue("@Horas", S.Horas);
            cmd.Parameters.AddWithValue("@Jogador", S.Jogador);
            cmd.Connection = cn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }


        private void UpdateContact(Saves C)
        {
            
        }


        private void RemoveContact(string ContactID)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE Customers WHERE CustomerID=@contactID ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@contactID", ContactID);
            cmd.Connection = cn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }


        // Helper routines
        public void LockControls()
        {
            txtID.ReadOnly = true;
            txtJogador.ReadOnly = true;
            txtHoras.ReadOnly = true;
            txtUltima_localizacao.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtState.ReadOnly = true;
            txtZIP.ReadOnly = true;
            txtCountry.ReadOnly = true;
            txtTel.ReadOnly = true;
            txtFax.ReadOnly = true;
        }

        public void UnlockControls()
        {
            txtID.ReadOnly = false;
            txtJogador.ReadOnly = false;
            txtHoras.ReadOnly = false;
            txtUltima_localizacao.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtState.ReadOnly = false;
            txtZIP.ReadOnly = false;
            txtCountry.ReadOnly = false;
            txtTel.ReadOnly = false;
            txtFax.ReadOnly = false;
        }

        public void ShowButtons()
        {
            LockControls();
            bttnAdd.Visible = true;
            bttnDelete.Visible = true;
            bttnEdit.Visible = true;
            bttnOK.Visible = false;
            bttnCancel.Visible = false;
        }

        public void ClearFields()
        {
            txtID.Text = "";
            txtJogador.Text = "";
            txtHoras.Text = "";
            txtUltima_localizacao.Text = "";
            txtCity.Text = "";
            txtZIP.Text = "";
            txtState.Text = "";
            txtTel.Text = "";
            txtFax.Text = "";
            txtCountry.Text = "";
        }

        public void ShowContact()
        {
            if (listBox1.Items.Count == 0 | currentContact < 0)
                return;
            Saves contact = new Saves();
            contact = (Saves)listBox1.Items[currentContact];
            txtID.Text = contact.ID;
            txtJogador.Text = contact.Ultima_localizacao;
            txtHoras.Text = contact.Horas;
            txtUltima_localizacao.Text = contact.Jogador;

        }

        public void HideButtons()
        {
            UnlockControls();
            bttnAdd.Visible = false;
            bttnDelete.Visible = false;
            bttnEdit.Visible = false;
            bttnOK.Visible = true;
            bttnCancel.Visible = true;
        }

        private bool SaveContact()
        {
            Saves contact = new Saves();
            try
            {
                contact.ID = txtID.Text;
                contact.Ultima_localizacao = txtJogador.Text;
                contact.Horas = txtHoras.Text;
                contact.Jogador = txtUltima_localizacao.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            if (adding)
            {
                SubmitContact(contact);
                listBox1.Items.Add(contact);
            }
            else
            {
                UpdateContact(contact);
                listBox1.Items[currentContact] = contact;
            }
            return true;
        }


        private void bttnAdd_Click(object sender, EventArgs e)
        {
            adding = true;
            ClearFields();
            HideButtons();
            listBox1.Enabled = false;
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            listBox1.Enabled = true;
            if (listBox1.Items.Count > 0)
            {
                currentContact = listBox1.SelectedIndex;
                if (currentContact < 0)
                    currentContact = 0;
                ShowContact();
            }
            else
            {
                ClearFields();
                LockControls();
            }
            ShowButtons();
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            currentContact = listBox1.SelectedIndex;
            if (currentContact <= 0)
            {
                MessageBox.Show("Please select a contact to edit");
                return;
            }
            adding = false;
            HideButtons();
            listBox1.Enabled = false;
        }

        private void bttnOK_Click(object sender, EventArgs e)
        {
            try
            {
                SaveContact();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listBox1.Enabled = true;
            int idx = listBox1.FindString(txtID.Text);
            listBox1.SelectedIndex = idx;
            ShowButtons();
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                try
                {
                    RemoveContact(((Saves)listBox1.SelectedItem).ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (currentContact == listBox1.Items.Count)
                    currentContact = listBox1.Items.Count - 1;
                if (currentContact == -1)
                {
                    ClearFields();
                    MessageBox.Show("There are no more contacts");
                }
                else
                {
                    ShowContact();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  


    }
}
