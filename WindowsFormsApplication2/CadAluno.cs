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


namespace WindowsFormsApplication2
{
    public partial class CadAluno : Form
    {

        List<Aluno> aluno = new List<Aluno>();
        Validacoes val = new Validacoes();
        
        

        public CadAluno(List<Aluno> li)
        {
            InitializeComponent();

            List<Aluno> aluno = li;
            dgvAluno.DataSource = aluno;
            string[] UF = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };
            cmbBoxUF.Items.AddRange(UF);

        }

        public void cadastra()
        {
            Aluno al = new Aluno();
            al.nome = txtNome.Text;
            al.dtNasc = txtDtNasc.Text;
            al.lograd = txtLogra.Text;
            al.bairro = txtBairro.Text;
            al.cidade = txtCidade.Text;
            al.uf = cmbBoxUF.SelectedItem.ToString();
            al.rg = txtRG.Text;
            aluno.Add(al);
            /*dgvAluno.DataSource = null;
            dgvAluno.DataSource = aluno;*/
        }

        
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            LogManager lm = new LogManager();
            

            if (val.checkEmpty(this) == false) return;
            if (val.validaData(txtDtNasc.Text, txtDtNasc)==false) return;
            try
            {
                if (val.validaUF(cmbBoxUF.SelectedItem.ToString(), cmbBoxUF) == false) return;
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, selecione um dos itens da lista.", "Erro");
                cmbBoxUF.Focus();
                return;
            }
            cadastra();
            DAO.DAO_Collection dao = new DAO.DAO_Collection();
            
            dao.insertAluno(txtNome.Text, DateTime.Parse(txtDtNasc.Text) , txtRG.Text, txtLogra.Text, txtBairro.Text, txtCidade.Text, cmbBoxUF.Text.ToString());
            lm.createLog(this);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DAO.DAO_Collection dao = new DAO.DAO_Collection();
            dgvAluno.DataSource = dao.selectAluno();
        }
    }
}
