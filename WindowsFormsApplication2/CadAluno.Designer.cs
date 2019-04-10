namespace WindowsFormsApplication2
{
    partial class CadAluno
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
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLogra = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblLograd = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.cmbBoxUF = new System.Windows.Forms.ComboBox();
            this.txtDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(23, 262);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(547, 73);
            this.dgvAluno.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(209, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(495, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLogra
            // 
            this.txtLogra.Location = new System.Drawing.Point(23, 105);
            this.txtLogra.Name = "txtLogra";
            this.txtLogra.Size = new System.Drawing.Size(150, 20);
            this.txtLogra.TabIndex = 3;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(23, 151);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(23, 191);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(403, 51);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(276, 35);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(104, 13);
            this.lblDtNasc.TabIndex = 10;
            this.lblDtNasc.Text = "Data de Nascimento";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(162, 175);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(40, 13);
            this.lblUF.TabIndex = 11;
            this.lblUF.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(20, 175);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(20, 135);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 13;
            this.lblBairro.Text = "Bairro";
            // 
            // lblLograd
            // 
            this.lblLograd.AutoSize = true;
            this.lblLograd.Location = new System.Drawing.Point(20, 89);
            this.lblLograd.Name = "lblLograd";
            this.lblLograd.Size = new System.Drawing.Size(53, 13);
            this.lblLograd.TabIndex = 14;
            this.lblLograd.Text = "Endereço";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(400, 34);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 15;
            this.lblRG.Text = "RG";
            // 
            // cmbBoxUF
            // 
            this.cmbBoxUF.FormattingEnabled = true;
            this.cmbBoxUF.Location = new System.Drawing.Point(165, 191);
            this.cmbBoxUF.Name = "cmbBoxUF";
            this.cmbBoxUF.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxUF.TabIndex = 6;
            this.cmbBoxUF.Text = "Selecione...";
            // 
            // txtDtNasc
            // 
            this.txtDtNasc.Location = new System.Drawing.Point(279, 50);
            this.txtDtNasc.Mask = "00/00/0000";
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(100, 20);
            this.txtDtNasc.TabIndex = 1;
            this.txtDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(23, 233);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "Query";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // CadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 347);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtDtNasc);
            this.Controls.Add(this.cmbBoxUF);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblLograd);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtLogra);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvAluno);
            this.Name = "CadAluno";
            this.Text = "Cadastro de Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLogra;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblLograd;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.ComboBox cmbBoxUF;
        private System.Windows.Forms.MaskedTextBox txtDtNasc;
        private System.Windows.Forms.Button btnSelect;
    }
}