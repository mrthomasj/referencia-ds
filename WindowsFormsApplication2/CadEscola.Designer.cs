namespace WindowsFormsApplication2
{
    partial class CadEscola
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtLogra = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvEscola = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscola)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxUF
            // 
            this.cmbBoxUF.FormattingEnabled = true;
            this.cmbBoxUF.Location = new System.Drawing.Point(169, 172);
            this.cmbBoxUF.Name = "cmbBoxUF";
            this.cmbBoxUF.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxUF.TabIndex = 22;
            this.cmbBoxUF.Text = "Selecione...";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(265, 15);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(34, 13);
            this.lblRG.TabIndex = 31;
            this.lblRG.Text = "CNPJ";
            // 
            // lblLograd
            // 
            this.lblLograd.AutoSize = true;
            this.lblLograd.Location = new System.Drawing.Point(24, 70);
            this.lblLograd.Name = "lblLograd";
            this.lblLograd.Size = new System.Drawing.Size(53, 13);
            this.lblLograd.TabIndex = 30;
            this.lblLograd.Text = "Endereço";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(24, 116);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 29;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(24, 156);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 28;
            this.lblCidade.Text = "Cidade";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(166, 156);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(40, 13);
            this.lblUF.TabIndex = 27;
            this.lblUF.Text = "Estado";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Nome";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(268, 32);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(100, 20);
            this.txtCNPJ.TabIndex = 18;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(27, 172);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 21;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(27, 132);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 20;
            // 
            // txtLogra
            // 
            this.txtLogra.Location = new System.Drawing.Point(27, 86);
            this.txtLogra.Name = "txtLogra";
            this.txtLogra.Size = new System.Drawing.Size(100, 20);
            this.txtLogra.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(499, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(209, 20);
            this.txtNome.TabIndex = 17;
            // 
            // dgvEscola
            // 
            this.dgvEscola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscola.Location = new System.Drawing.Point(27, 243);
            this.dgvEscola.Name = "dgvEscola";
            this.dgvEscola.Size = new System.Drawing.Size(547, 73);
            this.dgvEscola.TabIndex = 24;
            // 
            // CadEscola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 337);
            this.Controls.Add(this.cmbBoxUF);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblLograd);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtLogra);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvEscola);
            this.Name = "CadEscola";
            this.Text = "Cadastro de Escola";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscola)).EndInit();
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
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtLogra;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvEscola;
    }
}