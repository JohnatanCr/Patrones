using System;
using System.Drawing;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;
using MaterialSkin.Controls;
using System.Data;

namespace OMB
{
    public partial class Interfaz : Form
    {
        DBManager DB = new DBManager();
        bool SingIn = false;

        public Interfaz()
        {
            InitializeComponent();
            InitialConfig(); 
        }

        #region FUNCTIONS
        /// <summary>
        /// Parametros y Ajustes Predeterminados cuando el
        /// Programa es ejecutado
        /// </summary>
        void InitialConfig()
        {
            MenuHide();
            ActiveControl = tb_userN;
            posX = (tabPage1.Width / 2 )-pnl_user.Width;
        }
        
        void MenuHide()
        {
            if (!SingIn)
            {
                foreach (object item in ms1.Items)
                {
                    if (item is ToolStripMenuItem)
                    {
                        (item as ToolStripMenuItem).Visible = false;
                    }
                    else if (item is ToolStripTextBox)
                    {
                        (item as ToolStripTextBox).Visible = false;
                    }

                }
                ms1.SuspendLayout();
                btn_Search.Hide();
                tc_main.SelectedIndex = 0;
                tms_obm.Visible = true;
                tabPage1.SuspendLayout();
                pnl_user.Location = new Point((tabPage1.Width/2)-pnl_user.Width, pnl_user.Location.Y);
                tabPage1.ResumeLayout();
                ms1.ResumeLayout();
                tms_home.Visible = false;

            }
            else
            {
                ms1.SuspendLayout();
                Animations.Enabled = true;
                Animations.Start();
                ms1.ResumeLayout();
                pnl_user.SuspendLayout();
                Tt_panel.Enabled = true;
                Tt_panel.Start();
                pnl_user.ResumeLayout();
                tms_home.Visible = true;
            }
        }

        /// <summary>
        /// Cambia el color de acuerdo al definido previamente
        /// </summary>
        /// <param name="tool">Control tipo ToolStripMenu a modificar</param>
        void toolChange(ToolStripMenuItem tool)
        {
            if (tool.ForeColor==Color.Black)    
            {
                if (tool.Equals(tms_user))
                {
                    tool.ForeColor = Color.FromArgb(254, 222, 126);
                }
                else
                {
                    tool.ForeColor = Color.White;
                }
            }
            else
            {
                tool.ForeColor = Color.Black;
            }
        }

        void CloseSesion()
        {
            MenuHide();
            SingIn = false;
        }
        #endregion

        #region MAIN_EVENTS
        //Resize
        private void rule_cons_SizeChanged(object sender, EventArgs e)
        {
            if (SingIn)
            {
                if (tms_consult.Enabled == true) tms_consult.AutoSize = false;
                ms1.SuspendLayout();
                btn_Search.Location = new Point(rule_cons.Location.X + rule_cons.Width + 9, btn_Search.Location.Y);
                tms_consult.Width = rule_cons.Width;
                if (rule_cons.Width < 5)
                {
                    tms_consult.Visible = false;
                    btn_Search.Visible = false;
                    tms_Tconsult.Visible = false;
                    tms_user.Alignment = ToolStripItemAlignment.Left;
                    tms_user.Margin = new Padding(10, 0, 0, 0);
                }
                else
                {
                    tms_consult.Visible = true;
                    btn_Search.Visible = true;
                    tms_Tconsult.Visible = true;
                    tms_user.Alignment = ToolStripItemAlignment.Right;
                    tms_user.Margin = new Padding(0, 0, 10, 0);
                }
                ms1.ResumeLayout();
            }

        }
        private void Interfaz_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Maximized)
            {
                rule_cons_SizeChanged(sender, e);
            }
            rule_cons_SizeChanged(sender, e);
        }
        private void Interfaz_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                rule_cons_SizeChanged(sender, e);
            }
            rule_cons_SizeChanged(sender, e);
        }
        //TabPage
        private void tabPage1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Left))
            {
                e.IsInputKey = true;
            }
        }
        private void tc_main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Tab) == Keys.Tab)
            {
                e.Handled = true;
            }

        }
        private void tc_main_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Left))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region BUTTONS
        private void Stm_addClient_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                new Users().Show();
            }
            else
            {
                Application.OpenForms[1].Select();
            }


        }
        private void nuevoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Pago().Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SingIn == true)
            {
                SingIn = false;
                MenuHide();
                InitialConfig();
            }
            else
            {
                if (MessageBox.Show("¿Seguro que desea salir?", "Salir",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    foreach (Form win in Application.OpenForms)
                    {
                        win.Close();
                    }
                    Close();
                }
            }
        }

        private void bt_Sesion_Click(object sender, EventArgs e)
        {
            rule_cons_SizeChanged(sender, e);
            tc_main.SelectedIndex = 1;
            
            SingIn = true;
            MenuHide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            tc_main.SelectedIndex = 2;
            if (tms_consult.Text=="")
            {
                dgv_consult.DataSource =
                  DB.Table("SELECT * FROM gym.cliente").Tables["Data"];
            }
            else
            {
                string data = $"SELECT * FROM gym.cliente WHERE Nombre LIKE '%{tms_consult.Text}%' OR apPat LIKE '%{tms_consult.Text}%'" +
                    $"OR apMat LIKE '%{tms_consult.Text}%'" +
                    $"OR FechaNac LIKE '%{tms_consult.Text}%'" +
                    $"OR Peso LIKE '%{tms_consult.Text}%'" +
                    $"OR TipoSangre LIKE '%{tms_consult.Text}%'" +
                    $"OR Alergias LIKE '%{tms_consult.Text}%'" +
                    $"OR Correo LIKE '%{tms_consult.Text}%'" +
                    $"OR NombreEmer LIKE '%{tms_consult.Text}%'" +
                    $"OR celularEmer LIKE '%{tms_consult.Text}%'" +
                    $"OR Tipo LIKE '%{tms_consult.Text}%'" +
                    $"OR Status LIKE '%{tms_consult.Text}%'" +
                    $"OR idCliente LIKE '%{tms_consult.Text}%'" +
                    $"OR Sexo LIKE '%{tms_consult.Text}%'" +
                    $"OR IdentificadoCon LIKE '%{tms_consult.Text}%'" +
                    $"OR Calle_Num LIKE '%{tms_consult.Text}%'" +
                    $"OR Colonia LIKE '%{tms_consult.Text}%'" +
                    $"OR CodigoPostal LIKE '%{tms_consult.Text}%'" +
                    $"OR Ciudad LIKE '%{tms_consult.Text}%'" +
                    $"OR Estado LIKE '%{tms_consult.Text}%'" +
                    $"OR Telefono LIKE '%{tms_consult.Text}%'" +
                    $"OR Celular LIKE '%{tms_consult.Text}%'" +
                    $"OR TelefonoEmer LIKE '%{tms_consult.Text}%'; ";
                dgv_consult.DataSource =
                    DB.Table(data).Tables["Data"];
            }
 
        }
        #endregion

        #region SUBMENU_ITEMS
        //OBM
        private void tms_obm_DropDownOpening(object sender, EventArgs e)
        {
            toolChange(sender as ToolStripMenuItem);
        }
        private void tms_obm_DropDownClosed(object sender, EventArgs e)
        {
            toolChange(sender as ToolStripMenuItem);
        }
        private void tms_home_Click(object sender, EventArgs e)
        {
            if (tc_main.SelectedIndex != 0)
            {
                if (tc_main.SelectedIndex == 2)
                {
                    dgv_consult.Columns.Clear();
                }
                tc_main.SelectedIndex = 1;
            }

        }

        private void tms_closeSesn_Click(object sender, EventArgs e)
        {
            SingIn = false;
            InitialConfig();
        }

        #endregion

        #region ANIMATIONS

        int indice = 0;
        private void Animations_Tick(object sender, EventArgs e)
        {

            if (indice < ms1.Items.Count - 1)
            {
                indice++;
            }
            else { indice = 0; Animations.Enabled = false; Animations.Stop(); }
            if (ms1.Items[indice].Visible == false)
            {
                ms1.SuspendLayout();
                ms1.Items[indice].Visible = true;
                ms1.ResumeLayout();
            }

            if (indice == 6)
            {
                btn_Search.Show();
            }
        }

        int posX=0;
        private void Tt_panel_Tick(object sender, EventArgs e)
        {
            posX -= 15;
            if (posX <= 30)
            {
                pnl_user.Location = new Point(30, pnl_user.Location.Y);
                Tt_panel.Stop();
                Tt_panel.Enabled = false;
            }
            else
            {
                pnl_user.Location = new Point(posX, pnl_user.Location.Y);
            }

        }


        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Stm_addClient_Click(sender, e);
        }
        private void DeleteAll(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Back)
                {
                    e.SuppressKeyPress = true;
                    (sender as TextBox).Text = "";
                }
            }
        }
    }
}




