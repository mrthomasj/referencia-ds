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
    public partial class CadPeriodo : Form
    {
        List<Periodo> per = new List<Periodo>();
        Validacoes val = new Validacoes();

        public CadPeriodo()
        {
            InitializeComponent();
        }

        private void cadastra()
        {
            Periodo peri = new Periodo();
            peri.nome = txtNome.Text;
            peri.horaInic = txtHrInic.Text;
            peri.horaFim = txtHrFim.Text;
            per.Add(peri);
            dgvPeriodo.DataSource = null;
            dgvPeriodo.DataSource = per;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LogManager lm = new LogManager();
            if (val.checkEmpty(this) == false) return;
            if (val.validaHr(txtHrInic.Text, txtHrInic) == false) return;
            if (val.validaHr(txtHrFim.Text, txtHrFim) == false) return;
            cadastra();
            lm.createLog(this);
        }
    }
}
