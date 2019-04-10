namespace WindowsFormsApplication2
{
    partial class CadDisciplina
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvPeriodo = new System.Windows.Forms.DataGridView();
            this.lblNmDisciplina = new System.Windows.Forms.Label();
            this.txtNmDisciplina = new System.Windows.Forms.TextBox();
            this.txtHrFim = new System.Windows.Forms.MaskedTextBox();
            this.txtHrInic = new System.Windows.Forms.MaskedTextBox();
            this.lblHrSai = new System.Windows.Forms.Label();
            this.lblHrEntra = new System.Windows.Forms.Label();
            this.lblNmPeriodo = new System.Windows.Forms.Label();
            this.txtNmPeriodo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(241, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvPeriodo
            // 
            this.dgvPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodo.Location = new System.Drawing.Point(12, 197);
            this.dgvPeriodo.Name = "dgvPeriodo";
            this.dgvPeriodo.Size = new System.Drawing.Size(304, 97);
            this.dgvPeriodo.TabIndex = 5;
            // 
            // lblNmDisciplina
            // 
            this.lblNmDisciplina.AutoSize = true;
            this.lblNmDisciplina.Location = new System.Drawing.Point(9, 12);
            this.lblNmDisciplina.Name = "lblNmDisciplina";
            this.lblNmDisciplina.Size = new System.Drawing.Size(35, 13);
            this.lblNmDisciplina.TabIndex = 49;
            this.lblNmDisciplina.Text = "Nome";
            // 
            // txtNmDisciplina
            // 
            this.txtNmDisciplina.Location = new System.Drawing.Point(12, 28);
            this.txtNmDisciplina.Name = "txtNmDisciplina";
            this.txtNmDisciplina.Size = new System.Drawing.Size(122, 20);
            this.txtNmDisciplina.TabIndex = 0;
            // 
            // txtHrFim
            // 
            this.txtHrFim.Location = new System.Drawing.Point(12, 149);
            this.txtHrFim.Mask = "00:00";
            this.txtHrFim.Name = "txtHrFim";
            this.txtHrFim.Size = new System.Drawing.Size(100, 20);
            this.txtHrFim.TabIndex = 3;
            this.txtHrFim.ValidatingType = typeof(System.DateTime);
            // 
            // txtHrInic
            // 
            this.txtHrInic.Location = new System.Drawing.Point(12, 109);
            this.txtHrInic.Mask = "00:00";
            this.txtHrInic.Name = "txtHrInic";
            this.txtHrInic.Size = new System.Drawing.Size(100, 20);
            this.txtHrInic.TabIndex = 2;
            this.txtHrInic.ValidatingType = typeof(System.DateTime);
            // 
            // lblHrSai
            // 
            this.lblHrSai.AutoSize = true;
            this.lblHrSai.Location = new System.Drawing.Point(9, 133);
            this.lblHrSai.Name = "lblHrSai";
            this.lblHrSai.Size = new System.Drawing.Size(93, 13);
            this.lblHrSai.TabIndex = 47;
            this.lblHrSai.Text = "Horário de término";
            // 
            // lblHrEntra
            // 
            this.lblHrEntra.AutoSize = true;
            this.lblHrEntra.Location = new System.Drawing.Point(9, 94);
            this.lblHrEntra.Name = "lblHrEntra";
            this.lblHrEntra.Size = new System.Drawing.Size(85, 13);
            this.lblHrEntra.TabIndex = 46;
            this.lblHrEntra.Text = "Horário de início";
            // 
            // lblNmPeriodo
            // 
            this.lblNmPeriodo.AutoSize = true;
            this.lblNmPeriodo.Location = new System.Drawing.Point(9, 51);
            this.lblNmPeriodo.Name = "lblNmPeriodo";
            this.lblNmPeriodo.Size = new System.Drawing.Size(45, 13);
            this.lblNmPeriodo.TabIndex = 53;
            this.lblNmPeriodo.Text = "Período";
            // 
            // txtNmPeriodo
            // 
            this.txtNmPeriodo.Location = new System.Drawing.Point(12, 67);
            this.txtNmPeriodo.Name = "txtNmPeriodo";
            this.txtNmPeriodo.Size = new System.Drawing.Size(122, 20);
            this.txtNmPeriodo.TabIndex = 1;
            // 
            // CadDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 308);
            this.Controls.Add(this.lblNmPeriodo);
            this.Controls.Add(this.txtNmPeriodo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPeriodo);
            this.Controls.Add(this.lblNmDisciplina);
            this.Controls.Add(this.txtNmDisciplina);
            this.Controls.Add(this.txtHrFim);
            this.Controls.Add(this.txtHrInic);
            this.Controls.Add(this.lblHrSai);
            this.Controls.Add(this.lblHrEntra);
            this.Name = "CadDisciplina";
            this.Text = "Cadastro de Disciplina";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvPeriodo;
        private System.Windows.Forms.Label lblNmDisciplina;
        private System.Windows.Forms.TextBox txtNmDisciplina;
        private System.Windows.Forms.MaskedTextBox txtHrFim;
        private System.Windows.Forms.MaskedTextBox txtHrInic;
        private System.Windows.Forms.Label lblHrSai;
        private System.Windows.Forms.Label lblHrEntra;
        private System.Windows.Forms.Label lblNmPeriodo;
        private System.Windows.Forms.TextBox txtNmPeriodo;
    }
}