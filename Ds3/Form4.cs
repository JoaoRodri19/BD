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
    public partial class Form4 : Form
    {
        private SqlConnection cn;
        private int current1;
        private int current2;
        private int current3;
        private bool adding;
        private List<Boss> bosses;
        private List<Localizacao> zonas;
        private String _jogador;

        public Form4(String jogador)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //this.Resize += Form1_Resize;
            LockControls();
            todos.Hide();
            this._jogador = jogador;
            
        }

        private void DropBoss_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = DropBoss.SelectedItem.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
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
                current1 = listBox1.SelectedIndex;
                ShowContact();
            }
        }

        private void loadCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("exec GetArmaduraByName @Nome", cn);
            cmd.Parameters.AddWithValue("@Nome", this._jogador);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox2.Items.Clear();

            while (reader.Read())
            {

                Armadura armadura = new Armadura();
                armadura.Defesa = reader.GetInt32(0).ToString();
                armadura.Item_Equipavel = reader.GetInt32(1).ToString();
                armadura.Peso = reader.GetDouble(2).ToString();
                armadura.Durabilidade = reader.GetInt32(3).ToString();
                armadura.Nome = reader.GetString(5);
                armadura.Tipo = reader.GetString(6);
                armadura.ID = reader.GetInt32(7).ToString();

                listBox2.Items.Add(armadura);
            }
            reader.Close();

            cmd = new SqlCommand("exec GetArmaByName @Nome", cn);
            cmd.Parameters.AddWithValue("@Nome", this._jogador);
            SqlDataReader reader1 = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader1.Read())
            {
                
                Arma arma = new Arma();
                arma.Dano = reader1.GetInt32(0).ToString();
                arma.Item_Equipavel = reader1.GetInt32(1).ToString();
                arma.Peso = reader1.GetDouble(2).ToString();
                arma.Durabilidade = reader1.GetInt32(3).ToString();
                arma.Nome = reader1.GetString(5);
                arma.Tipo = reader1.GetString(6);
                arma.ID = reader1.GetInt32(7).ToString();

                listBox1.Items.Add(arma);
            }
            reader1.Close();

            cmd = new SqlCommand("exec GetItemNaoEquipavelByName @Nome", cn);
            cmd.Parameters.AddWithValue("@Nome", this._jogador);
            SqlDataReader reader2 = cmd.ExecuteReader();
            listBox3.Items.Clear();

            while (reader2.Read())
            {

                Item_Nao_Equipavel ine = new Item_Nao_Equipavel();
                ine.Quantidade = reader2.GetByte(0).ToString();
                ine.Item = reader2.GetInt32(1).ToString();
                ine.Nome = reader2.GetString(2);
                ine.Tipo = reader2.GetString(3);
                

                listBox3.Items.Add(ine);
            }



            cn.Close();


            current1 = -1;
            current2 = -1;
            current3 = -1;
            ShowContact();
        }

        private void loadCustomersToolStripMenuItem_ClickV2(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("exec GetArmadura", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox2.Items.Clear();

            while (reader.Read())
            {

                Armadura armadura = new Armadura();
                armadura.Defesa = reader.GetInt32(0).ToString();
                armadura.Item_Equipavel = reader.GetInt32(1).ToString();
                armadura.Peso = reader.GetDouble(2).ToString();
                armadura.Durabilidade = reader.GetInt32(3).ToString();
                armadura.Nome = reader.GetString(5);
                armadura.Tipo = reader.GetString(6);
                armadura.ID = reader.GetInt32(7).ToString();

                listBox2.Items.Add(armadura);
            }
            reader.Close();

            cmd = new SqlCommand("exec GetArma", cn);
            SqlDataReader reader1 = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader1.Read())
            {

                Arma arma = new Arma();
                arma.Dano = reader1.GetInt32(0).ToString();
                arma.Item_Equipavel = reader1.GetInt32(1).ToString();
                arma.Peso = reader1.GetDouble(2).ToString();
                arma.Durabilidade = reader1.GetInt32(3).ToString();
                arma.Nome = reader1.GetString(5);
                arma.Tipo = reader1.GetString(6);
                arma.ID = reader1.GetInt32(7).ToString();

                listBox1.Items.Add(arma);
            }
            reader1.Close();

            cmd = new SqlCommand("exec GetItemNaoEquipavel", cn);
            SqlDataReader reader2 = cmd.ExecuteReader();
            listBox3.Items.Clear();

            while (reader2.Read())
            {

                Item_Nao_Equipavel ine = new Item_Nao_Equipavel();
                ine.Quantidade = reader2.GetByte(0).ToString();
                ine.Item = reader2.GetInt32(1).ToString();
                ine.Nome = reader2.GetString(2);
                ine.Tipo = reader2.GetString(3);


                listBox3.Items.Add(ine);
            }



            cn.Close();


            current1 = -1;
            current2 = -1;
            current3 = -1;
            ShowContact();
        }

        private void SubmitContact(Item item)
        {

            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "exec InsertItem @Nome_Personagem = \'"+ this._jogador + "\', @ID_Item = "+ item.ID;
            cmd.Parameters.Clear();
            //cmd.Parameters.Add("@Nome_Personagem", SqlDbType.NVarChar).Value = this._jogador;
            //cmd.Parameters.Add("@ID_Item", SqlDbType.Int).Value = int.Parse(item.ID);


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


        private void RemoveContact(String Item_ID)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.Clear();
            cmd.CommandText = "exec DeleteItem_Personagem @Item_ID, @Nome_Personagem";
            cmd.Parameters.AddWithValue("@Item_ID", Item_ID);
            cmd.Parameters.AddWithValue("@Nome_Personagem", this._jogador);
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
            txtDurabilidade.ReadOnly = true;
            txtID.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtTipo.ReadOnly = true;
            txtPeso.ReadOnly = true;
            txtDano.ReadOnly = true;
            txtDefesa.ReadOnly = true;
            txtQuantidade.ReadOnly = true;
        }

        public void UnlockControls()
        {
            txtDurabilidade.ReadOnly = false;
            txtID.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtTipo.ReadOnly = false;
            txtPeso.ReadOnly = false;
            txtDano.ReadOnly = false;
            txtDefesa.ReadOnly = false;
            txtQuantidade.ReadOnly = false;
        }

        public void ShowButtons()
        {
            LockControls();
            bttnAdd.Visible = true;
            bttnDelete.Visible = true;
            bttnOK.Visible = false;
            bttnCancel.Visible = false;
        }

        public void ClearFields()
        {
            txtNome.Text = "";
            txtTipo.Text = "";
            txtPeso.Text = "";
            txtDano.Text = "";
            txtDefesa.Text = "";
            txtQuantidade.Text = "";
            txtDurabilidade.Text = "";
            txtID.Text = "";
        }

        public void ShowContact()
        {
                if (current1 >= 0)
            {
                Arma arma = new Arma();
                arma = (Arma)listBox1.Items[current1];
                txtNome.Text = arma.Nome;
                txtTipo.Text = arma.Tipo;
                txtDano.Text = arma.Dano;
                txtPeso.Text = arma.Peso;
                txtDurabilidade.Text = arma.Durabilidade;
                txtID.Text = arma.ID;
                txtDefesa.Text = "";
            }
            else if (current2 >= 0)
            {
                Armadura armadura = new Armadura();
                armadura = (Armadura)listBox2.Items[current2];
                txtNome.Text = armadura.Nome;
                txtTipo.Text = armadura.Tipo;
                txtID.Text = armadura.ID;
                txtDurabilidade.Text = armadura.Durabilidade;
                txtDefesa.Text = armadura.Defesa;
                txtPeso.Text = armadura.Peso;
                txtDano.Text = "";
            }
            else if (current3 >= 0)
            {
                Item_Nao_Equipavel ine = new Item_Nao_Equipavel();
                ine = (Item_Nao_Equipavel)listBox3.Items[current3];
                txtNome.Text = ine.Nome;
                txtTipo.Text = ine.Tipo;
                txtID.Text = ine.Item;
                txtQuantidade.Text = ine.Quantidade;
                txtDefesa.Text = "";
                txtDano.Text = "";
                txtPeso.Text = "";
            }
                
          

        }

        public void HideButtons()
        {
            bttnAdd.Visible = false;
            bttnDelete.Visible = false;
            bttnOK.Visible = true;
            bttnCancel.Visible = true;
        }

        private bool SaveContact(Object sender, EventArgs e)
        {
            Item item = new Item();
            
            try
            {
                item.ID = txtID.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            if (adding)
            {
                SubmitContact(item);
                loadCustomersToolStripMenuItem_Click(sender,e);
            }
            
            return true;
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

            if (DropBoss.SelectedItem != null)
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
                if (Regex.IsMatch(txtHP1.Text, @"^\d+$") && (Regex.IsMatch(txtHP2.Text, @"^\d+$")))
                {

                    String hp_inicio = txtHP1.Text;
                    String hp_fim = txtHP2.Text;
                    cmd = new SqlCommand("exec GetBossByHp @hp_ini, @hp_fim;", cn);
                    cmd.Parameters.AddWithValue("@hp_ini", hp_inicio);
                    cmd.Parameters.AddWithValue("@hp_fim", hp_fim);
                }
            }
            if (cmd == null)
            {
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

                ListBoss listBoss = new ListBoss(boss, zona);

                listBox1.Items.Add(listBoss);
            }

            cn.Close();


            current1 = -1;
            current2 = -1;
            current3 = -1;
            ShowContact();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void load_Click(object sender, EventArgs e)
        {
            loadCustomersToolStripMenuItem_Click(sender, e);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                current1 = listBox1.SelectedIndex;
                ShowContact();
                listBox2.ClearSelected();
                listBox3.ClearSelected();
                current2 = -1;
                current3 = -1;
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                current2 = listBox2.SelectedIndex;
                ShowContact();
                listBox1.ClearSelected();
                listBox3.ClearSelected();
                current1 = -1;
                current3 = -1;
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex >= 0)
            {
                current3 = listBox3.SelectedIndex;
                ShowContact();
                listBox1.ClearSelected();
                listBox2.ClearSelected();
                current1 = -1;
                current2 = -1;
            }
        }

        private void menuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
            this.Hide();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            loadCustomersToolStripMenuItem_ClickV2(sender, e);
            inv.Hide();
            todos.Show();
            LockControls();
            ClearFields();
            adding = true;
            HideButtons();
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                try
                {
                    RemoveContact(((Arma)listBox1.SelectedItem).ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (current1 == listBox1.Items.Count)
                    current1 = listBox1.Items.Count - 1;
                if (current1 == -1)
                {
                    ClearFields();
                    MessageBox.Show("There are no more contacts");
                }

            }
            else if(listBox2.SelectedIndex > -1)
            {
                try
                {
                    RemoveContact(((Armadura)listBox2.SelectedItem).ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                if (current2 == listBox2.Items.Count)
                    current2 = listBox2.Items.Count - 1;
                if (current2 == -1)
                {
                    ClearFields();
                    MessageBox.Show("There are no more contacts");
                }

            }
            else if (listBox3.SelectedIndex > -1)
            {
                try
                {
                    RemoveContact(((Item_Nao_Equipavel)listBox3.SelectedItem).Item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                listBox3.Items.RemoveAt(listBox3.SelectedIndex);
                if (current3 == listBox3.Items.Count)
                    current3 = listBox3.Items.Count - 1;
                if (current3 == -1)
                {
                    ClearFields();
                    MessageBox.Show("There are no more contacts");
                }

            }
            ClearFields();
        }

        private void bttnOK_Click(object sender, EventArgs e)
        {
            todos.Hide();
            inv.Show();
            try
            {
                SaveContact(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ShowButtons();
            LockControls();
            loadCustomersToolStripMenuItem_Click(sender, e);
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            todos.Hide();
            inv.Show();
            ClearFields();
            LockControls();
            ShowButtons();
            loadCustomersToolStripMenuItem_Click(sender, e);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
