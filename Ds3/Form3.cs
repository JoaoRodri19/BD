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
    public partial class Form3 : Form
    {
        private SqlConnection cn;
        private int currentContact;
        private bool adding;
        private List<Boss> bosses;
        private List<Localizacao> zonas;

        public Form3()
        {
            InitializeComponent();
            UnlockControls();
            DropBoss.Items.Add("Nome");
            DropBoss.Items.Add("Imunidade");
            DropBoss.Items.Add("Fraqueza");
            DropBoss.Items.Add("Resistência");
            DropBoss.Items.Add("Drops");
            DropBoss.Items.Add("Zona");

            DropBoss.SelectedIndexChanged += DropBoss_SelectedIndexChanged;
        }

        private void DropBoss_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = DropBoss.SelectedItem.ToString();
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
        private String nullToEmpty(String a) { if(a == null)return ""; return a; }
        private void loadCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("exec GetAllBossInformation", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();
            
            while (reader.Read())
            {

                BossInfo S = new BossInfo();             
                Boss boss = new Boss();
                Localizacao zona = new Localizacao();
                boss.Trilha_Sonora = reader.GetString(0);
                boss.Dialogo = reader.IsDBNull(1) ? null : (reader.GetString(1));
                boss.Adversario = reader.GetInt32(2).ToString();
                boss.Drops = reader.IsDBNull(3) ? null : (reader.GetString(3));
                boss.Fraqueza = reader.IsDBNull(4) ? null : (reader.GetString(4));
                boss.Resistencia = reader.IsDBNull(5) ? null : (reader.GetString(5));
                boss.Imunidade = reader.IsDBNull(6) ? null : (reader.GetString(6));
                boss.Personagem = reader.GetInt32(7).ToString();
                boss.Nome = reader.IsDBNull(8) ? null : (reader.GetString(8));
                boss.Pontos_De_Vida = reader.IsDBNull(9) ? null : (reader.GetInt32(9).ToString());
                boss.ID = reader.GetInt32(10).ToString();
                zona.Coordenadas = reader.IsDBNull(12) ? null : (reader.GetString(12));
                zona.Item = reader.IsDBNull(13) ? null : (reader.GetInt32(13).ToString());
                zona.Zona = reader.IsDBNull(14) ? null : (reader.GetString(14));

                ListBoss list_boss = new ListBoss(boss,zona);
  
               
                listBox1.Items.Add(list_boss);
            }

            cn.Close();


            currentContact = 0;
            ShowContact();
        }

        private void SubmitContact(ListBoss Boss)
        {
            
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "exec InsertBoss @Nome,@Pontos_De_Vida,@Drops,@Fraqueza,@Resistencia,@Imunidade,@Trilha_Sonora,@Dialogo,@Nome_Zona,@Coordenadas)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nome", Boss.boss.ID);
            cmd.Parameters.AddWithValue("@Pontos_De_Vida", Boss.boss.Pontos_De_Vida);
            cmd.Parameters.AddWithValue("@Drops", Boss.boss.Drops);
            cmd.Parameters.AddWithValue("@Fraqueza", Boss.boss.Fraqueza);
            cmd.Parameters.AddWithValue("@Resistencia", Boss.boss.Resistencia);
            cmd.Parameters.AddWithValue("@Imunidade",Boss.boss.Imunidade );
            cmd.Parameters.AddWithValue("@Trilha_Sonora", Boss.boss.Trilha_Sonora);
            cmd.Parameters.AddWithValue("@Dialogo",Boss.boss.Dialogo);
            cmd.Parameters.AddWithValue("@Nome_Zona", Boss.loc.Zona);
            cmd.Parameters.AddWithValue("@Coordenadas", Boss.loc.Coordenadas);
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


        private void UpdateContact(BossInfo C)
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
            txtNome.ReadOnly = true;
            txtHP.ReadOnly = true;
            txtImunidade.ReadOnly = true;
            txtResistencia.ReadOnly = true;
            txtDrops.ReadOnly = true;
            txtFraqueza.ReadOnly = true;
            txtTrilha.ReadOnly = true;
            txtDialogo.ReadOnly = true;
            txtCoordenadas.ReadOnly = true;
            txtZona.ReadOnly = true;
            txtFiltrar.ReadOnly = true;
            txtHP1.ReadOnly = true;
            txtHP2.ReadOnly = true;
        }

        public void UnlockControls()
        {
            txtNome.ReadOnly = false;
            txtHP.ReadOnly = false;
            txtImunidade.ReadOnly = false;
            txtResistencia.ReadOnly = false;
            txtDrops.ReadOnly = false;
            txtFraqueza.ReadOnly = false;
            txtTrilha.ReadOnly = false;
            txtDialogo.ReadOnly = false;
            txtCoordenadas.ReadOnly = false;
            txtZona.ReadOnly = false;
            txtFiltrar.ReadOnly = false;
            txtHP1.ReadOnly = false;
            txtHP2.ReadOnly = false;
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
            txtNome.Text = "";
            txtHP.Text = "";
            txtImunidade.Text = "";
            txtResistencia.Text = "";
            txtDrops.Text = "";
            txtFraqueza.Text = "";
            txtTrilha.Text = "";
            txtDialogo.Text = "";
            txtCoordenadas.Text = "";
            txtZona.Text = "";
            txtFiltrar.Text = "";
            txtHP1.Text = "";
            txtHP2.Text = "";
        }

        public void ShowContact()
        {
            if (listBox1.Items.Count == 0 | currentContact < 0)
                return;
            ListBoss boss = new ListBoss();
            boss = (ListBoss)listBox1.Items[currentContact];
            txtNome.Text = boss.boss.Nome;
            txtHP.Text = boss.boss.Pontos_De_Vida;
            txtZona.Text = boss.loc.Zona;
            txtResistencia.Text = boss.boss.Resistencia;
            txtImunidade.Text = boss.boss.Imunidade;
            txtCoordenadas.Text = boss.loc.Coordenadas;
            txtFraqueza.Text = boss.boss.Fraqueza;
            txtDialogo.Text = boss.boss.Dialogo;
            txtDrops.Text = boss.boss.Drops;
            txtTrilha.Text = boss.boss.Trilha_Sonora;

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
            ListBoss boss = new ListBoss();
            boss.boss = new Boss();
            boss.loc = new Localizacao();
            try
            {
                boss.boss.Nome = txtNome.Text;
                boss.boss.Pontos_De_Vida = txtHP.Text;
                boss.loc.Zona = txtZona.Text;
                boss.boss.Resistencia = txtResistencia.Text;
                boss.boss.Imunidade = txtImunidade.Text;
                boss.loc.Coordenadas = txtCoordenadas.Text;
                boss.boss.Fraqueza = txtFraqueza.Text;
                boss.boss.Dialogo = txtDialogo.Text;
                boss.boss.Drops = txtDrops.Text;
                boss.boss.Trilha_Sonora = txtTrilha.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            if (adding)
            {
                SubmitContact(boss);
                listBox1.Items.Add(boss);
            }
            else
            {
                //UpdateContact(boss);
                listBox1.Items[currentContact] = boss;
            }
            return true;
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFiltrar_Click_1(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            String entity = "";
            String attribute = "";
            String textFilter = txtFiltrar.Text;
            SqlCommand cmd = null;

            if ( DropBoss.SelectedItem != null)
            {
                switch (DropBoss.SelectedItem)
                {
                    case "Nome":
                        entity = "Personagem";
                        attribute = "Nome";
                        break;

                    case "HP":
                        entity = "Personagem";
                        attribute = "HP";
                        break;

                    case "Imunidade":
                        entity = "Adversario";
                        attribute = "Imunidade";
                        break;

                    case "Fraqueza":
                        entity = "Adversario";
                        attribute = "Fraqueza";
                        break;

                    case "Resistência":
                        entity = "Adversario";
                        attribute = "Resistencia";
                        break;

                    case "Drops":
                        entity = "Adversario";
                        attribute = "Drops";
                        break;

                    case "Zona":
                        entity = "Zona";
                        attribute = "Nome";
                        break;
                }

                cmd = new SqlCommand("exec GetBossByAttributeName @entity = " + entity + ", @attribute = " + attribute + ", @filter = " + textFilter + ";", cn);
            }
            else
            {
                if(Regex.IsMatch(txtHP1.Text, @"^\d+$") && (Regex.IsMatch(txtHP2.Text, @"^\d+$")))
                {

                    String hp_inicio = txtHP1.Text;
                    String hp_fim = txtHP2.Text;
                    cmd = new SqlCommand("exec GetBossByHp @hp_ini, @hp_fim;", cn);
                    cmd.Parameters.AddWithValue("@hp_ini", hp_inicio);
                    cmd.Parameters.AddWithValue("@hp_fim", hp_fim);
                }
            }
            if (cmd == null){
                cn.Close();
                return;
            }
            Console.Write(cmd.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                
                Boss boss = new Boss();
                Localizacao zona = new Localizacao();
                boss.Nome = reader.IsDBNull(0) ? null : (reader.GetString(0));
                boss.Pontos_De_Vida = reader.IsDBNull(1) ? null : (reader.GetInt32(1).ToString());
                zona.Zona = reader.IsDBNull(2) ? null : (reader.GetString(2));

                ListBoss listBoss = new ListBoss(boss,zona);

                listBox1.Items.Add(listBoss);
            }

            cn.Close();


            currentContact = 0;
            ShowContact();
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void load_Click(object sender, EventArgs e)
        {
            loadCustomersToolStripMenuItem_Click(sender, e);
        }

        private void bttnAdd_Click_1(object sender, EventArgs e)
        {
            adding = true;
            //ClearFields();
            HideButtons();
            listBox1.Enabled = false;
        }

        private void bttnOK_Click_1(object sender, EventArgs e)
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
            int idx = listBox1.FindString(txtNome.Text);
            listBox1.SelectedIndex = idx;
            ShowButtons();
        }

        private void bttnCancel_Click_1(object sender, EventArgs e)
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
    }
}
