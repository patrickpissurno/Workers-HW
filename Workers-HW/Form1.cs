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
            sexo.SelectedIndex = 0;
            estadocivil.SelectedIndex = 0;
            sangue.SelectedIndex = 0;
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (!string.IsNullOrWhiteSpace(saveFileDialog1.FileName))
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                foreach (Worker worker in workers)
                {
                    if (worker != null)
                    {
                        string line = "Nome: " + worker.nome + ". Idade: " + worker.idade + ". Sexo: " + worker.sexo + ". Tipo Sanguíneo: " + worker.tipoSanguineo + ". Profissão: " + worker.profissao + ". Salário: " + worker.salario + ". Estado civil: " + worker.estadoCivil + ". Número de filhos: " + worker.filhos;
                        writer.WriteLine(line);
                    }
                }
                writer.Close();
            }
            else
                MessageBox.Show("Digite um nome de arquivo válido.");
        }
    }
}
