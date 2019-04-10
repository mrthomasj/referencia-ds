namespace WindowsFormsApplication2
{
    partial class CadProfessor
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
            this.cmbBoxUF = new System.Windows.Forms.ComboBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblLograd = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtLogra = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvProfessor = new System.Windows.Forms.DataGridView();
            this.lblHrEntra = new System.Windows.Forms.Label();
            this.lblHrSai = new System.Windows.Forms.Label();
            this.txtHrEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtHrSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtDtNasc = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxUF
            // 
            this.cmbBoxUF.FormattingEnabled = true;
            this.cmbBoxUF.Location = new System.Drawing.Point(156, 176);
            this.cmbBoxUF.Name = "cmbBoxUF";
            this.cmbBoxUF.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxUF.TabIndex = 6;
            this.cmbBoxUF.Text = "Selecione...";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(417, 19);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(27, 13);
            this.lblRG.TabIndex = 31;
            this.lblRG.Text = "CPF";
            // 
            // lblLograd
            // 
            this.lblLograd.AutoSize = true;
            this.lblLograd.Location = new System.Drawing.Point(11, 74);
            this.lblLograd.Name = "lblLograd";
            this.lblLograd.Size = new System.Drawing.Size(53, 13);
            this.lblLograd.TabIndex = 30;
            this.lblLograd.Text = "Endereço";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(11, 120);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 29;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(11, 160);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 28;
            this.lblCidade.Text = "Cidade";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(153, 160);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(40, 13);
            this.lblUF.TabIndex = 27;
            this.lblUF.Text = "Estado";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(267, 20);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(104, 13);
            this.lblDtNasc.TabIndex = 26;
            this.lblDtNasc.Text = "Data de Nascimento";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Nome";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(420, 36);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 2;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(14, 176);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(14, 136);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // txtLogra
            // 
            this.txtLogra.Location = new System.Drawing.Point(14, 90);
            this.txtLogra.Name = "txtLogra";
            this.txtLogra.Size = new System.Drawing.Size(100, 20);
            this.txtLogra.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(486, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(209, 20);
            this.txtNome.TabIndex = 0;
            // 
            // dgvProfessor
            // 
            this.dgvProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessor.Location = new System.Drawing.Point(14, 247);
            this.dgvProfessor.Name = "dgvProfessor";
            this.dgvProfessor.Size = new System.Drawing.Size(547, 73);
            this.dgvProfessor.TabIndex = 24;
            // 
            // lblHrEntra
            // 
            this.lblHrEntra.AutoSize = true;
            this.lblHrEntra.Location = new System.Drawing.Point(417, 74);
            this.lblHrEntra.Name = "lblHrEntra";
            this.lblHrEntra.Size = new System.Drawing.Size(96, 13);
            this.lblHrEntra.TabIndex = 33;
            this.lblHrEntra.Text = "Horário de Entrada";
            // 
            // lblHrSai
            // 
            this.lblHrSai.AutoSize = true;
            this.lblHrSai.Location = new System.Drawing.Point(417, 113);
            this.lblHrSai.Name = "lblHrSai";
            this.lblHrSai.Size = new System.Drawing.Size(88, 13);
            this.lblHrSai.TabIndex = 35;
            this.lblHrSai.Text = "Horário de Saída";
            // 
            // txtHrEntrada
            // 
            this.txtHrEntrada.Location = new System.Drawing.Point(420, 89);
            this.txtHrEntrada.Mask = "00:00";
            this.txtHrEntrada.Name = "txtHrEntrada";
            this.txtHrEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtHrEntrada.TabIndex = 7;
            this.txtHrEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // txtHrSaida
            // 
            this.txtHrSaida.Location = new System.Drawing.Point(420, 129);
            this.txtHrSaida.Mask = "00:00";
            this.txtHrSaida.Name = "txtHrSaida";
            this.txtHrSaida.Size = new System.Drawing.Size(100, 20);
            this.txtHrSaida.TabIndex = 8;
            this.txtHrSaida.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtNasc
            // 
            this.txtDtNasc.Location = new System.Drawing.Point(270, 36);
            this.txtDtNasc.Mask = "00/00/0000";
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(100, 20);
            this.txtDtNasc.TabIndex = 2;
            this.txtDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // CadProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 342);
            this.Controls.Add(this.txtDtNasc);
            this.Controls.Add(this.txtHrSaida);
            this.Controls.Add(this.txtHrEntrada);
            this.Controls.Add(this.lblHrSai);
            this.Controls.Add(this.lblHrEntra);
            this.Controls.Add(this.cmbBoxUF);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblLograd);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtLogra);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvProfessor);
            this.Name = "CadProfessor";
            this.Text = "Cadastro de Professor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxUF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblLograd;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtLogra;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvProfessor;
        private System.Windows.Forms.Label lblHrEntra;
        private System.Windows.Forms.Label lblHrSai;
        private System.Windows.Forms.MaskedTextBox txtHrEntrada;
        private System.Windows.Forms.MaskedTextBox txtHrSaida;
        private System.Windows.Forms.MaskedTextBox txtDtNasc;
    }
}