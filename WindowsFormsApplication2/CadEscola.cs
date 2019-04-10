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
    public partial class CadEscola : Form
    {

        List<Escola> esc = new List<Escola>();
        Validacoes val = new Validacoes();


        public CadEscola()
        {
            InitializeComponent();
            string[] UF = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };
            cmbBoxUF.Items.AddRange(UF);

        }


        public void cadastra()
        {
            Escola esco = new Escola();
            esco.nome = txtNome.Text;
            esco.cnpj = txtCNPJ.Text;
            esco.lograd = txtLogra.Text;
            esco.bairro = txtBairro.Text;
            esco.cidade = txtCidade.Text;
            esco.uf = cmbBoxUF.SelectedItem.ToString();
            
            esc.Add(esco);
            dgvEscola.DataSource = null;
            dgvEscola.DataSource = esc;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LogManager lm = new LogManager();
            if (val.checkEmpty(this) == false) return;
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
            
            if (val.validaCpfCnpj(txtCNPJ.Text, txtCNPJ) == false) return;
            cadastra();
            lm.createLog(this);
        }
    }
}
