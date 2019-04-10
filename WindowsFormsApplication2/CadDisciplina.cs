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
    public partial class CadDisciplina : Form
    {

        List<Disciplina> disc = new List<Disciplina>();
        Validacoes val = new Validacoes();

        public CadDisciplina()
        {
            InitializeComponent();
            dgvPeriodo.DataSource = disc;
        }

        private void cadastra()
        {
            Disciplina cdDisc = new Disciplina();
            cdDisc.nmDisciplina = txtNmDisciplina.Text;
            cdDisc.nome = txtNmPeriodo.Text;
            cdDisc.horaInic = txtHrInic.Text;
            cdDisc.horaFim = txtHrFim.Text;
            disc.Add(cdDisc);
            dgvPeriodo.DataSource = null;
            dgvPeriodo.DataSource = disc;
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
