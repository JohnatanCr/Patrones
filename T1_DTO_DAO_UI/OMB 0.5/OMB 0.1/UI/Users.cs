using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OMB
{
    
    public partial class Users : Form
    {
        DBManager DB = new DBManager();
        public Users()
        {
            InitializeComponent();
            ActiveControl = tb_name;
        }

        bool Validation(TabPage page)
        {
            bool isFull = true;
            foreach (Control tx in page.Controls)
            {
                if (tx is TextBox)
                {
                    if ((tx as TextBox).Text == "" && tx.Enabled==true)
                    {
                        tx.BackColor = Color.FromArgb(244, 169, 145);
                        isFull= false;
                    }

                }
                else if (tx is ComboBox)
                {
                    if ((tx as ComboBox).SelectedIndex == -1 && tx.Enabled == true)
                    {
                        tx.BackColor = Color.FromArgb(244, 169, 145);
                        isFull= false;
                    }

                }
                else if (tx is DateTimePicker)
                {
                    if ((tx as DateTimePicker).Text == "" && tx.Enabled == true)
                    {
                        tx.BackColor = Color.FromArgb(244, 169, 145);
                        isFull= false;
                    }

                }
                else if (tx is NumericUpDown)
                {
                    if ((tx as NumericUpDown).Value < 10) 
                    {
                        tx.BackColor = Color.FromArgb(244, 169, 145);
                        isFull = false;
                    }
                }

            }

            return isFull;
        }

        private void btn_regs_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dt_nacimiento.Text);
            if (Validation(tp_regis2))
            {
                DB.QueryAction(DB.AddClietnQuery(
                    tb_name.Text, 
                    tb_apPatern.Text, 
                    tb_apMatern.Text, 
                    dt_nacimiento.Text, 
                    (double)(tb_weight.Value), 
                    cb_blood.SelectedIndex.ToString(), 
                    tb_alerg.Text,
                    tb_email.Text,
                    tb_EmergPatern.Text, 
                    tb_numEmerg.Text, 
                    cb_tipo.SelectedIndex.ToString(),
                    1,
                    cb_sex.SelectedIndex.ToString(),
                    tb_telEmerg.Text,tb_ident.Text,
                    tb_street_num.Text,
                    tb_col.Text,
                    tb_cod_pos.Text,
                    tb_city.Text,
                    tb_state.Text,
                    tb_tel.Text,
                    tb_numTel.Text,
                    tb_telEmerg.Text));

                MessageBox.Show("¡Registro Exitoso!", "Registor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("¡ERROR EN EL REGISTRO!; Campos invalidos o vacios", 
                    "Registro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_close1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir sin guardar la información actual?", "Salir", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                if (MessageBox.Show("¿Seguro que desea salir sin guardar la información actual?", "Salir", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.Close();
                    return true;
                }

            }
            return base.ProcessDialogKey(keyData);
        }

        private void btn_cont_Click(object sender, EventArgs e)
        {
            if (Validation(tp_regis1))
            {
                tc_rmain.SelectedIndex = tc_rmain.SelectedIndex + 1;
            }
        }

        private void ckb_telDom_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked==true)
            {
                tb_tel.Enabled = true;
            }
            else
            {
                tb_tel.Enabled = false;
            }
        }

        private void btns_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                (sender as TextBox).BackColor = Color.White;
            }
            else if (sender is NumericUpDown)
            {
                (sender as NumericUpDown).BackColor = Color.White;
            }
            else if (sender is ComboBox)
            {
                (sender as ComboBox).BackColor = Color.White;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            tc_rmain.SelectedIndex = tc_rmain.SelectedIndex - 1;
        }

        //
        private void OnlyLetter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                    e.Handled = true;
            }
        }

        private void OnlyLetter_Space(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                if (!char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void OnlyEmail(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_street_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
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


        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("¿Seguro que desea salir sin guardar la información actual?", "Salir",
            //                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            //                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //{
                
            //}
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipo.SelectedIndex==0)
            {
                tb_mat.Clear();
                tb_mat.Enabled = true;
            }
            else if (cb_tipo.SelectedIndex == 2)
            {
                tb_mat.Enabled = false;
                tb_mat.Text = "15163336P";
            }
            else
            {
                tb_mat.Enabled = false;
                Matricula();
            }

        }
        void Matricula()
        {
            
            tb_mat.Text = "15173366A";
        }

        //
    }
}
