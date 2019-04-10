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
    public partial class frmHub : Form
    {
        public frmHub()
        {
            InitializeComponent();
            


        }

        public List<Aluno> aluno = new List<Aluno>();



        private void cdAlunoItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadAluno>().Count() == 1)
            {
                MessageBox.Show("Favor utilizar a tela de cadastro aberta.", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                CadAluno cadAluno = new WindowsFormsApplication2.CadAluno(aluno);
                cadAluno.MdiParent = this;
                cadAluno.Show();
            }
        }

        private void cadastrarProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadProfessor>().Count() == 1)
            {
                MessageBox.Show("Favor utilizar a tela de cadastro aberta.", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                CadProfessor cadProf = new CadProfessor();
                cadProf.MdiParent = this;
                cadProf.Show();
            }
        }

        private void cadastrarEscolaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<CadEscola>().Count() == 1)
            {
                MessageBox.Show("Favor utilizar a tela de cadastro aberta.", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                CadEscola cadEsc = new CadEscola();
                cadEsc.MdiParent = this;
                cadEsc.Show();
            }

        }

        private void cadastrarPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadPeriodo>().Count() == 1)
            {
                MessageBox.Show("Favor utilizar a tela de cadastro aberta.", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                CadPeriodo cadPer = new CadPeriodo();
                cadPer.MdiParent = this;
                cadPer.Show();
            }
        }

        private void cadastrarDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadDisciplina>().Count() == 1)
            {
                MessageBox.Show("Favor utilizar a tela de cadastro aberta.", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                CadDisciplina cadDis = new CadDisciplina();
                cadDis.MdiParent = this;
                cadDis.Show();
            }
        }

        private void frmHub_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.MdiParent = this;
            mnCadastro.Enabled = false;
            login.Show();
        }

        

        private void userLogin(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<frmLogin>().Count() == 1)
                {
                    MessageBox.Show("Favor utilizar a tela de login aberta.", "Erro", MessageBoxButtons.OK);
                }
                else
                {
                    frmLogin login = new frmLogin();
                    login.MdiParent = this;
                    login.Show();
                }
            }
            catch
            {

            }
        }

        private void mnLogout_Click(object sender, EventArgs e)
        {
            if (!mnLogin.Visible)
            {
                DialogResult result = MessageBox.Show("Você deseja efetuar logout do sistema?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {

                    List<Form> openForms = new List<Form>();
                    foreach(Form f in Application.OpenForms)
                    {
                        openForms.Add(f);
                    }

                    foreach(Form f in openForms)
                    {
                        if (f.Name != "frmHub")
                        {
                            f.Close();
                        }
                    }

                    mnLogout.Visible = false;
                    mnLogin.Visible = true;
                    mnCadastro.Enabled = false;
                    frmLogin login = new frmLogin();
                    login.MdiParent = this;
                    login.Show();

                }
            }
        }
    }
    }

