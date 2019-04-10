using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class CadProfessor : Form
    {

        List<Professor> prof = new List<Professor>();
        Validacoes val = new Validacoes();

        public CadProfessor()
        {
            InitializeComponent();
            string[] UF = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };
            cmbBoxUF.Items.AddRange(UF);
            dgvProfessor.DataSource = prof;
        }

        public void cadastra()
        {
            Professor pro = new Professor();
            pro.nome = txtNome.Text;
            pro.dtNasc = txtDtNasc.Text;
            pro.lograd = txtLogra.Text;
            pro.bairro = txtBairro.Text;
            pro.cidade = txtCidade.Text;
            pro.uf = cmbBoxUF.SelectedItem.ToString();
            pro.cpf = txtCPF.Text;
            pro.horaEntrada = txtHrEntrada.Text;
            pro.horaSaida = txtHrSaida.Text;
            prof.Add(pro);
            dgvProfessor.DataSource = null;
            dgvProfessor.DataSource = prof;
        }


        

        private void btnSave_Click(object sender, EventArgs e)
        {
            LogManager lm = new LogManager();
            if (val.checkEmpty(this) == false) return;
            if (val.validaData(txtDtNasc.Text, txtDtNasc) == false) return;
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
            //if (val.validaNumero(txtCPF.Text, txtCPF) == false) return;
            if (val.validaCpfCnpj(txtCPF.Text, txtCPF) == false) return;
            if (val.validaHr(txtHrEntrada.Text, txtHrEntrada) == false) return;
            if (val.validaHr(txtHrSaida.Text, txtHrSaida) == false) return;
            cadastra();
            lm.createLog(this);
        }
    }
}
