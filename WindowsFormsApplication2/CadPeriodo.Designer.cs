namespace WindowsFormsApplication2
{
    partial class CadPeriodo
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
            this.txtHrFim = new System.Windows.Forms.MaskedTextBox();
            this.txtHrInic = new System.Windows.Forms.MaskedTextBox();
            this.lblHrSai = new System.Windows.Forms.Label();
            this.lblHrEntra = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvPeriodo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHrFim
            // 
            this.txtHrFim.Location = new System.Drawing.Point(15, 117);
            this.txtHrFim.Mask = "00:00";
            this.txtHrFim.Name = "txtHrFim";
            this.txtHrFim.Size = new System.Drawing.Size(100, 20);
            this.txtHrFim.TabIndex = 2;
            this.txtHrFim.ValidatingType = typeof(System.DateTime);
            // 
            // txtHrInic
            // 
            this.txtHrInic.Location = new System.Drawing.Point(15, 77);
            this.txtHrInic.Mask = "00:00";
            this.txtHrInic.Name = "txtHrInic";
            this.txtHrInic.Size = new System.Drawing.Size(100, 20);
            this.txtHrInic.TabIndex = 1;
            this.txtHrInic.ValidatingType = typeof(System.DateTime);
            // 
            // lblHrSai
            // 
            this.lblHrSai.AutoSize = true;
            this.lblHrSai.Location = new System.Drawing.Point(12, 101);
            this.lblHrSai.Name = "lblHrSai";
            this.lblHrSai.Size = new System.Drawing.Size(93, 13);
            this.lblHrSai.TabIndex = 39;
            this.lblHrSai.Text = "Horário de término";
            // 
            // lblHrEntra
            // 
            this.lblHrEntra.AutoSize = true;
            this.lblHrEntra.Location = new System.Drawing.Point(12, 62);
            this.lblHrEntra.Name = "lblHrEntra";
            this.lblHrEntra.Size = new System.Drawing.Size(85, 13);
            this.lblHrEntra.TabIndex = 38;
            this.lblHrEntra.Text = "Horário de início";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 41;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(122, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvPeriodo
            // 
            this.dgvPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodo.Location = new System.Drawing.Point(15, 158);
            this.dgvPeriodo.Name = "dgvPeriodo";
            this.dgvPeriodo.Size = new System.Drawing.Size(304, 97);
            this.dgvPeriodo.TabIndex = 4;
            // 
            // CadPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 266);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPeriodo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtHrFim);
            this.Controls.Add(this.txtHrInic);
            this.Controls.Add(this.lblHrSai);
            this.Controls.Add(this.lblHrEntra);
            this.Name = "CadPeriodo";
            this.Text = "Cadastro de Período";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtHrFim;
        private System.Windows.Forms.MaskedTextBox txtHrInic;
        private System.Windows.Forms.Label lblHrSai;
        private System.Windows.Forms.Label lblHrEntra;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvPeriodo;
    }
}