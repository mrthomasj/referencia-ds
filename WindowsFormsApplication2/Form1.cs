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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Number> num = new List<Number>();

        private void Test()
        {
            List<Number> num1 = new List<Number>();
            Number myNum = new WindowsFormsApplication2.Number();
            myNum.number = 1;
            myNum.nome = "um";
            num1.Add(myNum);

            Number test2 = new Number();
            test2.number = 2;
            test2.nome = "dois";
            num1.Add(test2);

            dgvNum.DataSource = num1;
           
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Daora", "UHUUUUUL", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //Test();
            Cadastrar();
            

        }

        private void Cadastrar()
        {
            //num.Add(int.Parse(txtCadastrar.Text));

            

            Number me = new Number();
            me.nome = txtNome.Text;
            try
            {
                me.number = int.Parse(txtCadastrar.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Você digitou um valor inválido, por favor insira primeiro um valor numérico e depois seu nome por extenso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            num.Add(me);
            dgvNum.DataSource = null;
            dgvNum.DataSource = num;

        }

        public void RemoveMe()
        {
            var _result = num.FirstOrDefault(x => x.number == int.Parse(txtCadastrar.Text));
            num.RemoveAll(x => x.number == int.Parse(txtCadastrar.Text));
            dgvNum.DataSource = null;
            dgvNum.DataSource = num;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            RemoveMe();
        }
    }
    
}


   

