namespace OMB
{
    partial class Pago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_fichaPago = new System.Windows.Forms.Label();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_opciones = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_pago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.cb_Existente = new System.Windows.Forms.CheckBox();
            this.cb_visita = new System.Windows.Forms.CheckBox();
            this.lbl_Client = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_fichaPago
            // 
            this.lbl_fichaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.lbl_fichaPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_fichaPago.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_fichaPago.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_fichaPago.Location = new System.Drawing.Point(0, 0);
            this.lbl_fichaPago.Name = "lbl_fichaPago";
            this.lbl_fichaPago.Size = new System.Drawing.Size(434, 23);
            this.lbl_fichaPago.TabIndex = 0;
            this.lbl_fichaPago.Text = "Ficha de pago";
            this.lbl_fichaPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.lbl_Matricula.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Matricula.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Matricula.Location = new System.Drawing.Point(244, 76);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(72, 19);
            this.lbl_Matricula.TabIndex = 1;
            this.lbl_Matricula.Text = "Matricula:";
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Matricula.Location = new System.Drawing.Point(322, 72);
            this.txt_Matricula.MaxLength = 10;
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(94, 25);
            this.txt_Matricula.TabIndex = 2;
            this.txt_Matricula.Enter += new System.EventHandler(this.btns_Enter);
            this.txt_Matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Matricula_withoutSpace);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Membresia:";
            // 
            // cb_opciones
            // 
            this.cb_opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_opciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_opciones.FormattingEnabled = true;
            this.cb_opciones.Items.AddRange(new object[] {
            "Alumno Modelo",
            "Familiar Modelista",
            "Miembro Particular"});
            this.cb_opciones.Location = new System.Drawing.Point(99, 174);
            this.cb_opciones.Name = "cb_opciones";
            this.cb_opciones.Size = new System.Drawing.Size(317, 25);
            this.cb_opciones.TabIndex = 6;
            this.cb_opciones.SelectedIndexChanged += new System.EventHandler(this.txt_pago_TextChanged);
            this.cb_opciones.Enter += new System.EventHandler(this.btns_Enter);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(335, 328);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(87, 38);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Registrar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(229, 328);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(87, 38);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_total.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_total.Location = new System.Drawing.Point(174, 228);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(94, 19);
            this.lbl_total.TabIndex = 11;
            this.lbl_total.Text = "Total a pagar:";
            // 
            // txt_pago
            // 
            this.txt_pago.Enabled = false;
            this.txt_pago.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txt_pago.Location = new System.Drawing.Point(151, 250);
            this.txt_pago.Name = "txt_pago";
            this.txt_pago.Size = new System.Drawing.Size(140, 34);
            this.txt_pago.TabIndex = 12;
            this.txt_pago.TextChanged += new System.EventHandler(this.txt_pago_TextChanged);
            this.txt_pago.Enter += new System.EventHandler(this.btns_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre de miembro:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Nombre.Location = new System.Drawing.Point(160, 126);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(256, 25);
            this.txt_Nombre.TabIndex = 14;
            this.txt_Nombre.Enter += new System.EventHandler(this.btns_Enter);
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNameLetters);
            // 
            // cb_Existente
            // 
            this.cb_Existente.AutoSize = true;
            this.cb_Existente.Checked = true;
            this.cb_Existente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Existente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Existente.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_Existente.Location = new System.Drawing.Point(160, 74);
            this.cb_Existente.Name = "cb_Existente";
            this.cb_Existente.Size = new System.Drawing.Size(86, 23);
            this.cb_Existente.TabIndex = 17;
            this.cb_Existente.Text = "Existente ";
            this.cb_Existente.UseVisualStyleBackColor = true;
            this.cb_Existente.CheckedChanged += new System.EventHandler(this.cb_Existente_CheckedChanged);
            // 
            // cb_visita
            // 
            this.cb_visita.AutoSize = true;
            this.cb_visita.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_visita.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_visita.Location = new System.Drawing.Point(74, 74);
            this.cb_visita.Name = "cb_visita";
            this.cb_visita.Size = new System.Drawing.Size(81, 23);
            this.cb_visita.TabIndex = 16;
            this.cb_visita.Text = "Visitante";
            this.cb_visita.UseVisualStyleBackColor = true;
            this.cb_visita.CheckedChanged += new System.EventHandler(this.cb_visita_CheckedChanged);
            // 
            // lbl_Client
            // 
            this.lbl_Client.AutoSize = true;
            this.lbl_Client.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Client.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Client.Location = new System.Drawing.Point(12, 75);
            this.lbl_Client.Name = "lbl_Client";
            this.lbl_Client.Size = new System.Drawing.Size(56, 19);
            this.lbl_Client.TabIndex = 15;
            this.lbl_Client.Text = "Cliente:";
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(434, 382);
            this.Controls.Add(this.cb_Existente);
            this.Controls.Add(this.cb_visita);
            this.Controls.Add(this.lbl_Client);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pago);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cb_opciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Matricula);
            this.Controls.Add(this.lbl_Matricula);
            this.Controls.Add(this.lbl_fichaPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(450, 421);
            this.MinimumSize = new System.Drawing.Size(450, 421);
            this.Name = "Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pago_FormClosing);
            this.Load += new System.EventHandler(this.Pago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fichaPago;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.TextBox txt_Matricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_opciones;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_pago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.CheckBox cb_Existente;
        private System.Windows.Forms.CheckBox cb_visita;
        private System.Windows.Forms.Label lbl_Client;
    }
}