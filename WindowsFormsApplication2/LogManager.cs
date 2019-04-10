using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class LogManager
    {
        string fileName;
        public void createLog(Form frm)
        {
            if (Directory.Exists(@"C:\_Logs") == false)
                Directory.CreateDirectory(@"C:\_Logs");
            string formName = frm.Name.ToString();
            
            switch (formName)
            {
                case "CadAluno":
                    fileName = @"C:\_Logs\LogAluno.txt";
                    break;

                case "CadDisciplina":
                    fileName = @"C:\_Logs\LogDisciplina.txt";
              
                    break;

                case "CadEscola":
                    fileName = @"C:\_Logs\LogEscola.txt";
                  
                    break;

                case "CadPeriodo":
                    fileName = @"C:\_Logs\LogPeriodo.txt";
                    
                    break;

                case "CadProfessor":
                    fileName = @"C:\_Logs\LogProfessor.txt";
                    
                    break;
            }


            if (File.Exists(fileName) == false)
            {
                    using (StreamWriter logFile = new StreamWriter(fileName, true))
                    {
                        logFile.WriteLine("Início do log");
                    logFile.Write(DateTime.Now.ToString() + " |");
                    foreach (Control ct in frm.Controls)
                    {
                        if (ct is TextBox)
                        {
                            logFile.Write(" " + ct.Text.ToString() + " |");
                        }
                        else if (ct is ComboBox || ct is MaskedTextBox)
                        {
                            logFile.Write(" " + ct.Text.ToString() + " |");
                        }

                    }
                    logFile.WriteLine("");
                }
            }
            else
            {
                using (StreamWriter logFile = new StreamWriter(fileName, true))
                {

                    logFile.Write(DateTime.Now.ToString() + " |");
                    foreach (Control ct in frm.Controls)
                    {
                        if (ct is TextBox)
                        {
                            logFile.Write(" " + ct.Text.ToString() + " |");
                        }
                        else if (ct is ComboBox || ct is MaskedTextBox)
                        {
                            logFile.Write(" " + ct.Text.ToString() + " |");
                        }

                    }
                    logFile.WriteLine("");
                }
            }

        }

    }
}
