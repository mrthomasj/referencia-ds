﻿namespace WindowsFormsApplication2
{
    partial class frmHub
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.cdAlunoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarEscolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPeríodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarDisciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUser,
            this.mnCadastro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnUser
            // 
            this.mnUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLogin,
            this.mnLogout});
            this.mnUser.Name = "mnUser";
            this.mnUser.Size = new System.Drawing.Size(59, 20);
            this.mnUser.Text = "Usuário";
            // 
            // mnLogin
            // 
            this.mnLogin.Name = "mnLogin";
            this.mnLogin.Size = new System.Drawing.Size(152, 22);
            this.mnLogin.Text = "Login...";
            this.mnLogin.Click += new System.EventHandler(this.userLogin);
            // 
            // mnLogout
            // 
            this.mnLogout.Name = "mnLogout";
            this.mnLogout.Size = new System.Drawing.Size(152, 22);
            this.mnLogout.Text = "Logout...";
            this.mnLogout.Visible = false;
            this.mnLogout.Click += new System.EventHandler(this.mnLogout_Click);
            // 
            // mnCadastro
            // 
            this.mnCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cdAlunoItem,
            this.cadastrarProfessorToolStripMenuItem,
            this.cadastrarEscolaToolStripMenuItem,
            this.cadastrarPeríodoToolStripMenuItem,
            this.cadastrarDisciplinaToolStripMenuItem});
            this.mnCadastro.Name = "mnCadastro";
            this.mnCadastro.Size = new System.Drawing.Size(66, 20);
            this.mnCadastro.Text = "Cadastro";
            // 
            // cdAlunoItem
            // 
            this.cdAlunoItem.Name = "cdAlunoItem";
            this.cdAlunoItem.Size = new System.Drawing.Size(178, 22);
            this.cdAlunoItem.Text = "Cadastrar Aluno";
            this.cdAlunoItem.Click += new System.EventHandler(this.cdAlunoItem_Click);
            // 
            // cadastrarProfessorToolStripMenuItem
            // 
            this.cadastrarProfessorToolStripMenuItem.Name = "cadastrarProfessorToolStripMenuItem";
            this.cadastrarProfessorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cadastrarProfessorToolStripMenuItem.Text = "Cadastrar Professor";
            this.cadastrarProfessorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProfessorToolStripMenuItem_Click);
            // 
            // cadastrarEscolaToolStripMenuItem
            // 
            this.cadastrarEscolaToolStripMenuItem.Name = "cadastrarEscolaToolStripMenuItem";
            this.cadastrarEscolaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cadastrarEscolaToolStripMenuItem.Text = "Cadastrar Escola";
            this.cadastrarEscolaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarEscolaToolStripMenuItem_Click);
            // 
            // cadastrarPeríodoToolStripMenuItem
            // 
            this.cadastrarPeríodoToolStripMenuItem.Name = "cadastrarPeríodoToolStripMenuItem";
            this.cadastrarPeríodoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cadastrarPeríodoToolStripMenuItem.Text = "Cadastrar Período";
            this.cadastrarPeríodoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPeríodoToolStripMenuItem_Click);
            // 
            // cadastrarDisciplinaToolStripMenuItem
            // 
            this.cadastrarDisciplinaToolStripMenuItem.Name = "cadastrarDisciplinaToolStripMenuItem";
            this.cadastrarDisciplinaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cadastrarDisciplinaToolStripMenuItem.Text = "Cadastrar Disciplina";
            this.cadastrarDisciplinaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarDisciplinaToolStripMenuItem_Click);
            // 
            // frmHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 384);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dummy System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHub_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cdAlunoItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEscolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPeríodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarDisciplinaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mnCadastro;
        public System.Windows.Forms.ToolStripMenuItem mnUser;
        public System.Windows.Forms.ToolStripMenuItem mnLogin;
        public System.Windows.Forms.ToolStripMenuItem mnLogout;
    }
}