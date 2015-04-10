using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Workers_HW
{
    public partial class Form1 : Form
    {
        public static Form1 reference;
        private List<Worker> workers = new List<Worker>();
        #region Get/Set
        public List<Worker> Workers
        {
            get
            {
                return this.workers;
            }
            set
            {
                this.workers = value;
                listBox1.Items.Clear();
                List<string> names = new List<string>();
                foreach (Worker worker in workers)
                {
                    if(worker != null)
                        names.Add(worker.nome);
                }
                listBox1.Items.AddRange(names.ToArray());
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            reference = this;
            sexo.SelectedIndex = 0;
            estadocivil.SelectedIndex = 0;
            sangue.SelectedIndex = 0;
            
        }

        #region Add User
        private void salvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nome.Text) && !string.IsNullOrWhiteSpace(idade.Text) && !string.IsNullOrWhiteSpace(profissao.Text) &&
                !string.IsNullOrWhiteSpace(salario.Text) && !string.IsNullOrWhiteSpace(filhos.Text))
            {
                bool found = false;
                Worker worker = new Worker();
                foreach (Worker _worker in workers)
                {
                    if (_worker != null)
                    {
                        if (_worker.nome.Equals(nome.Text))
                        {
                            found = true;
                            worker = _worker;
                            break;
                        }
                    }
                }

                try
                {
                    worker.nome = nome.Text;
                    worker.idade = int.Parse(idade.Text);
                    worker.profissao = profissao.Text;
                    worker.salario = float.Parse(salario.Text);
                    worker.sexo = sexo.Text;
                    worker.tipoSanguineo = sangue.Text;
                    worker.filhos = int.Parse(filhos.Text);
                    worker.estadoCivil = estadocivil.Text;
                    if (!found)
                        Workers.Add(worker);
                    Workers = workers;
                }
                catch
                {
                    MessageBox.Show("Por favor preencha todos os campos de maneira correta.");
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos de maneira correta.");
            }
        }
        #endregion

        #region Select User
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Worker worker in workers)
            {
                if (worker != null && listBox1.SelectedItem != null)
                {
                    if (worker.nome.Equals(listBox1.SelectedItem.ToString()))
                    {
                        nome.Text = worker.nome;
                        idade.Text = worker.idade.ToString();
                        sexo.Text = worker.sexo;
                        salario.Text = worker.salario.ToString();
                        profissao.Text = worker.profissao;
                        sangue.Text = worker.tipoSanguineo;
                        filhos.Text = worker.filhos.ToString();
                        estadocivil.Text = worker.estadoCivil;
                    }
                }
            }
        }
        #endregion

        #region Remove User
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Worker worker in workers)
            {
                if (worker != null)
                {
                    if (worker.nome.Equals(nome.Text))
                    {
                        workers.Remove(worker);
                        Workers = workers;

                        //Resets the form
                        sexo.SelectedIndex = 0;
                        estadocivil.SelectedIndex = 0;
                        sangue.SelectedIndex = 0;
                        nome.Text = "";
                        idade.Text = "";
                        salario.Text = "";
                        profissao.Text = "";
                        filhos.Text = "";
                        break;
                    }
                }
            }
        }
        #endregion

        #region Export Data
        private void export_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (!string.IsNullOrWhiteSpace(saveFileDialog1.FileName))
            {
                StreamWriter writer;
                switch(saveFileDialog1.FilterIndex)
                {
                    case 1: //TXT Export
                        #region TXT
                        writer = new StreamWriter(saveFileDialog1.FileName);
                        foreach (Worker worker in workers)
                        {
                            if (worker != null)
                            {
                                string line = "Nome: " + worker.nome + ". Idade: " + worker.idade + ". Sexo: " + worker.sexo + ". Tipo Sanguíneo: " + worker.tipoSanguineo + ". Profissão: " + worker.profissao + ". Salário: " + worker.salario + ". Estado civil: " + worker.estadoCivil + ". Número de filhos: " + worker.filhos;
                                writer.WriteLine(line);
                            }
                        }
                        writer.Close();
                        #endregion
                        break;
                    case 2: //HTML Export
                        #region HTML
                        writer = new StreamWriter(saveFileDialog1.FileName);
                        writer.Write("<!doctype html>\r<meta charset=utf-8>\r<head>\r<title>\rFuncionários\r</title>\r");
                        writer.Write("<style>\rtable\r{\rfont-family: 'Trebuchet MS', Arial, Helvetica, sans-serif;\nwidth: 100%;\rborder-collapse: collapse;\r}\rtd, th\r{\rfont-size: 1em;\rborder: 1px solid #98bf21;\rpadding: 3px 7px 2px 7px;\r}\rth\r{\rfont-size: 1.1em;\rtext-align: left;\rpadding-top: 5px;\rpadding-bottom: 4px;\rbackground-color: #A7C942;\rcolor: #ffffff;\r}\rtr.alt td\r{\rcolor: #000000;\rbackground-color: #EAF2D3;\r}\r</style>\r");
                        writer.Write("</head>\r<body>\r<center>\r<h1 style='color:#98bf21; font-family: 'Trebuchet MS', Arial, Helvetica, sans-serif;'>Tabela de Funcionários</h1>\r<table>\r");
                        writer.Write("<tr>\r<th>\rNome\r</th>\r<th>\rIdade\r</th>\r<th>\rSexo\r</th>\r<th>\rTipo Sanguíneo\r</th>\r<th>\rProfissão\r</th>\r<th>\rSalário\r</th>\r<th>\rEstado civíl\r</th>\r<th>\rNúmero de filhos\r</th>\r</tr>");
                        bool alt = false;
                        foreach (Worker worker in workers)
                        {
                            if (worker != null)
                            {
                                string line = "";
                                if(alt)
                                    line += "<tr class='alt'>\r";
                                else
                                    line += "<tr>\r";
                                line += "<td>\r" + worker.nome + "\r</td>\r";
                                line += "<td>\r" + worker.idade + "\r</td>\r";
                                line += "<td>\r" + worker.sexo + "\r</td>\r";
                                line += "<td>\r" + worker.tipoSanguineo + "\r</td>\r";
                                line += "<td>\r" + worker.profissao + "\r</td>\r";
                                line += "<td>\rR$ " + worker.salario + "\r</td>\r";
                                line += "<td>\r" + worker.estadoCivil + "\r</td>\r";
                                line += "<td>\r" + worker.filhos + "\r</td>\r";
                                line += "</tr>\r";
                                writer.Write(line);
                                alt = !alt;
                            }
                        }
                        writer.Write("</table>\r</center>\r</body>\r</html>");
                        writer.Close();
                        #endregion
                        break;
                }
                MessageBox.Show("Exportado com sucesso!");
            }
            else
                MessageBox.Show("Digite um nome de arquivo válido.");
        }
        #endregion

        #region Show Save Dialog
        public string ShowSaveDialog()
        {
            saveFileDialog2.ShowDialog();
            return saveFileDialog2.FileName;
        }
        #endregion

        #region Show Load Dialog
        public string ShowLoadDialog()
        {
            openFileDialog1.ShowDialog();
            return openFileDialog1.FileName;
        }
        #endregion

        #region Open Button
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager.Load();
        }
        #endregion

        #region Save Button
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager.Save();
        }
        #endregion
    }
}
