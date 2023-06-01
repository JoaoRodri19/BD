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
            this.WindowState = FormWindowState.Maximized;

            DropClass.Items.Add("Knight");
            DropClass.Items.Add("Warrior");
            DropClass.Items.Add("Thief");
            DropClass.Items.Add("Sorcerer");

            DropClass.SelectedIndexChanged += DropClass_SelectedIndexChanged;
        }

        private void DropClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = DropClass.SelectedItem.ToString();
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
            if (listBox1.SelectedIndex >= 0)
            {
                currentContact = listBox1.SelectedIndex;
                ShowContact();
            }
        }

        private void loadCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("GetAllSavesInformation", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {

                ListSaves Save = new ListSaves
                {
                    save = new Saves(),
                    jog = new Jogador()
                };

                Save.save.ID = reader.IsDBNull(0) ? null : reader.GetInt32(0).ToString();
                Save.save.Ultima_localizacao = reader.GetString(1);
                Save.save.Horas = reader.GetTimeSpan(2).ToString();
                Save.save.Jogador = reader.IsDBNull(3) ? null : reader.GetInt32(3).ToString();
                Save.jog.ID = reader.IsDBNull(4) ? null : reader.GetInt32(4).ToString();
                Save.jog.Item_Discovery = reader.GetInt32(5).ToString();
                Save.jog.Stamina = reader.GetInt32(6).ToString();
                Save.jog.Classe = reader.GetString(7);
                Save.jog.Equip_Load = reader.GetFloat(8).ToString();
                Save.jog.Focus_Points = reader.GetInt32(9).ToString();
                Save.jog.Nivel = reader.GetInt16(10).ToString();
                Save.jog.Nome = reader.GetString(11);
                Save.jog.Pontos_De_Vida = reader.GetInt32(12).ToString();
                
                listBox1.Items.Add(Save);
            }

            cn.Close();


            currentContact = -1;
            ShowContact();
        }

        private void SubmitContact(ListSaves Save)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "exec InsertSave @Ultima_localizacao,@Horas,@Item_Discovery,@Stamina,@Classe,@Equip_Load,@Focus_Points,@Nivel,@Nome,@Zona,@Pontos_De_Vida";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Ultima_localizacao", Save.save.Ultima_localizacao);
            cmd.Parameters.AddWithValue("@Horas", Save.save.Horas);
            cmd.Parameters.AddWithValue("@Item_Discovery", Save.jog.Item_Discovery);
            cmd.Parameters.AddWithValue("@Stamina", Save.jog.Stamina);
            cmd.Parameters.AddWithValue("@Classe", Save.jog.Classe);
            cmd.Parameters.AddWithValue("@Equip_Load", Save.jog.Equip_Load);
            cmd.Parameters.AddWithValue("@Focus_Points", Save.jog.Focus_Points);
            cmd.Parameters.AddWithValue("@Nivel", Save.jog.Nivel);
            cmd.Parameters.AddWithValue("@Nome", Save.jog.Nome);
            cmd.Parameters.AddWithValue("@Zona", "Cemetery of Ash");
            cmd.Parameters.AddWithValue("@Pontos_De_Vida", Save.jog.Pontos_De_Vida);
            cmd.Connection = cn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update Save in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }


        private void UpdateContact(Saves C)
        {

        }


        private void RemoveContact(ListSaves Save)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "exec DeleteSave @ID";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", Save.save.ID);
            cmd.Connection = cn;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete Save in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }


        // Helper routines
        public void LockControls()
        {
            txtHP.ReadOnly = true;
            txtEquip_Load.ReadOnly = true;
            txtItem_Discovery.ReadOnly = true;
            txtStamina.ReadOnly = true;
            txtStamina.ReadOnly = true;
            txtNivel.ReadOnly = true;
            txtHoras.ReadOnly = true;
            txtUltima_Localizacao.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtFocusPoints.ReadOnly = true;
        }

        public void UnlockControls()
        {
            txtHP.ReadOnly = false;
            txtEquip_Load.ReadOnly = false;
            txtItem_Discovery.ReadOnly = false;
            txtStamina.ReadOnly = false;
            txtStamina.ReadOnly = false;
            txtNivel.ReadOnly = false;
            txtHoras.ReadOnly = false;
            txtUltima_Localizacao.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtFocusPoints.ReadOnly = false;

        }

        public void ShowButtons()
        {
            LockControls();
            bttnAdd.Visible = true;
            bttnDelete.Visible = true;
            bttnEdit.Visible = true;
            bttnOK.Visible = false;
            bttnCancel.Visible = false;
            DropClass.Visible = false;
            txtClass.Visible = true;
        }

        public void ClearFields()
        {
            txtHP.Text = "";
            txtEquip_Load.Text = "";
            txtItem_Discovery.Text = "";
            txtStamina.Text = "";
            txtStamina.Text = "";
            txtNivel.Text = "";
            txtHoras.Text = "";
            txtUltima_Localizacao.Text = "";
            txtNome.Text = "";
            txtFocusPoints.Text = "";
        }

        public void ShowContact()
        {
            if (listBox1.Items.Count == 0 | currentContact < 0)
                return;
            ListSaves Save = new ListSaves();
            Save = (ListSaves)listBox1.Items[currentContact];
            txtHP.Text = Save.jog.Pontos_De_Vida;
            txtEquip_Load.Text = Save.jog.Equip_Load;
            txtItem_Discovery.Text = Save.jog.Item_Discovery;
            txtStamina.Text = Save.jog.Stamina;
            txtNivel.Text = Save.jog.Nivel;
            txtHoras.Text = Save.save.Horas;
            txtUltima_Localizacao.Text = Save.save.Ultima_localizacao;
            txtNome.Text = Save.jog.Nome;
            txtFocusPoints.Text = Save.jog.Focus_Points;
            txtClass.Text = Save.jog.Classe;

        }

        public void HideButtons()
        {
            UnlockControls();
            bttnAdd.Visible = false;
            bttnDelete.Visible = false;
            bttnEdit.Visible = false;
            bttnOK.Visible = true;
            bttnCancel.Visible = true;
            DropClass.Visible = true;
            txtClass.Visible = false;
        }

        private bool SaveContact()
        {

            ListSaves Save = new ListSaves
            {
                save = new Saves(),
                jog = new Jogador()
            };

            String classe = DropClass.Text;
            String equipLoad = "";
            String stamina = "";
            String fp = "";
            String nivel = "";
            String PV = "";
            String item_Disc = "";

            switch (classe)
            {
                case "Knight":
                    equipLoad = "55";
                    stamina = "90";
                    fp = "70";
                    nivel = "10";
                    PV = "950";
                    item_Disc = "100";
                    break;

                case "Warrior":
                    equipLoad = "55";
                    stamina = "95";
                    fp = "60";
                    nivel = "11";
                    PV = "940";
                    item_Disc = "100";
                    break;
                
                case "Thief":
                    equipLoad = "48";
                    stamina = "94";
                    fp = "75";
                    nivel = "9";
                    PV = "900";
                    item_Disc = "120";
                    break;

                case "Sorcerer":
                    equipLoad = "50";
                    stamina = "85";
                    fp = "80";
                    nivel = "10";
                    PV = "920";
                    item_Disc = "110";
                    break;
            }
            
            try
            {
                Save.save.Ultima_localizacao = "432,542,123";
                Save.save.Horas = "0";
                Save.jog.Nome = txtNome.Text;
                Save.jog.Stamina = stamina;
                Save.jog.Equip_Load = equipLoad;
                Save.jog.Classe = classe;
                Save.jog.Focus_Points = fp;
                Save.jog.Item_Discovery = item_Disc;
                Save.jog.Nivel = nivel;
                Save.jog.Pontos_De_Vida = PV;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            if (adding)
            {
                SubmitContact(Save);
                listBox1.Items.Add(Save);
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
                    currentContact = -1;
                ShowContact();
            }
            else
            {
                ClearFields();
                LockControls();
            }
            ShowButtons();
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                try
                {
                    RemoveContact(((ListSaves)listBox1.SelectedItem));
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
                    MessageBox.Show("There are no more Saves");
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

        private void bttnAdd_Click_1(object sender, EventArgs e)
        {
            adding = true;
            ClearFields();
            HideButtons();
            listBox1.Enabled = false;
            LockControls();
            txtNome.ReadOnly = false;
            txtClass.ReadOnly = false;

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
                    currentContact = -1;
                ShowContact();
            }
            else
            {
                ClearFields();
                LockControls();
            }
            ShowButtons();
        }

        private void bttnDelete_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                try
                {
                    RemoveContact(((ListSaves)listBox1.SelectedItem));
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
                    MessageBox.Show("There are no more Saves");
                }
                else
                {
                    ShowContact();
                }
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
            this.Hide();
        }
    }
}