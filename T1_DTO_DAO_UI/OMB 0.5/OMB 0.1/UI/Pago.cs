using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OMB
{
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();
        }



        void DisableAll()
        {
            foreach (Control tx in this.Controls)
            {
          

                if (tx.Enabled == true)
                {
                    tx.Enabled = false;

                }
                else
                {
                    tx.Enabled = true;
                }
                if (tx is Button)
                {
                    tx.Enabled = true;
                }
                
                if(tx is CheckBox)
                {
                    tx.Enabled = true;
                }

                if (tx is TextBox)
                {
                    if (tx.Enabled == false)
                    {
                        (tx as TextBox).Clear();

                    }
                }
            }

        }
        bool Validation( )
        {
            bool isFull = true;
            foreach (Control tx in Controls)
            {
                if (tx is TextBox)
                {
                    if ((tx as TextBox).Text == "" && tx.Enabled == true)
                    {
                        tx.BackColor = Color.FromArgb(244, 169, 145);
                        isFull = false;
                    }

                }
                else if (tx is ComboBox)
                {
                    if ((tx as ComboBox).SelectedIndex == -1 && tx.Enabled == true)
                    {
                        tx.BackColor = Color.FromArgb(244, 169, 145);
                        isFull = false;
                    }

                }
                else if (tx is DateTimePicker)
                {
                    if ((tx as DateTimePicker).Text == "" && tx.Enabled == true)
                    {
                        tx.BackColor = Color.FromArgb(244, 169, 145);
                        isFull = false;
                    }

                }
                else if (tx is NumericUpDown)
                {
                    if ((tx as NumericUpDown).Value < 5)
                    {
                        tx.BackColor = Color.FromArgb(244, 169, 145);
                        isFull = false;
                    }
                }

            }

            return isFull;
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

        private void Pago_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
             //  txt_Nombre.Text = Conexion.getName(txt_Matricula.Text);
             //  Conexion.AddPayQuery(txt_Matricula.Text, int.Parse(txt_pago.Text));
             //  txt_pago.Text = "$100 prro";
            }
        }


        private void Matricula_withoutSpace(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Valida que solo tenga numeros 
            {     
                    e.Handled = true;
                
            }
        }


        //La idea es que se haga una consulta a la base de datos con la matricula y obtener el nombre del socio y se rellene el campo con el resultado de la consulta.
        private void OnlyNameLetters(object sender, KeyPressEventArgs e) // Valida que solo tenga letras por que es para el nombre
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) 
            {
                if(!char.IsSeparator(e.KeyChar))
                e.Handled = true;

            }
        }

        private void txt_pago_TextChanged(object sender, EventArgs e) //esta en desarrollo por el momento
        {
            //200 alumno modelo
            //300 padre de alumno 
            //400 cliente regular
            

            if (cb_opciones.SelectedIndex == 0)
            {
                txt_pago.Text = "$ 200.00 MXN";
            }
            else if(cb_opciones.SelectedIndex == 1)
            {
                txt_pago.Text = "$ 300.00 MXN";
            }
            else if(cb_opciones.SelectedIndex == 2)
            {
                txt_pago.Text = "$ 400.00 MXN";
            }
        }

        private void cb_Existente_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Existente.Checked == true)
            {
                txt_Matricula.Enabled = true;
                cb_visita.Checked = false;
                txt_pago.Clear();
                DisableAll();
            }
        }

        private void cb_visita_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_visita.Checked == true)
            {
                DisableAll();
                cb_Existente.Checked = false;
                txt_Matricula.Enabled = false;
                cb_opciones.SelectedIndex = -1;
                txt_pago.Text = "$ 30.00 MXN";

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir sin guardar la información actual?", "Salir",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                         MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
                
            }
        }

        private void Pago_FormClosing(object sender, FormClosingEventArgs e)
        {
         // DialogResult result = MessageBox.Show("¿Seguro que desea salir sin guardar la información actual?", "Salir",
         //             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
         //                MessageBoxDefaultButton.Button2);
         //
         // if(result == DialogResult.Yes)
         // {
         //     
         // }
         // else if(result == DialogResult.No)
         // {
         //     this.Close();
         // }

        }
    }

}
