using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Workers_HW
{
    public static class FileManager
    {
        #region Save
        public static void Save()
        {
            string path = Form1.reference.ShowSaveDialog();
            if (!string.IsNullOrWhiteSpace(path))
            {
                string data = "";
                foreach (Worker worker in Form1.reference.Workers)
                {
                    if (worker != null)
                    {
                        data += worker.estadoCivil + "|" + worker.filhos + "|" + worker.idade;
                        data += "|" + worker.nome + "|" + worker.profissao + "|" + worker.salario;
                        data += "|" + worker.sexo + "|" + worker.tipoSanguineo + ";";
                    }
                }
                if (!string.IsNullOrWhiteSpace(data))
                {
                    StreamWriter writer = new StreamWriter(path);
                    writer.Write(data);
                    writer.Close();
                }
            }
        }
        #endregion

        #region Load
        public static void Load()
        {
            string path = Form1.reference.ShowLoadDialog();
            if (!string.IsNullOrWhiteSpace(path))
            {
                try
                {
                    StreamReader reader = new StreamReader(path);
                    string input = reader.ReadToEnd();
                    reader.Close();
                    string[] datas = input.Split(';');
                    Form1.reference.Workers.Clear();
                    foreach (string data in datas)
                    {
                        if (!string.IsNullOrWhiteSpace(data))
                        {
                            string[] info = data.Split('|');
                            Worker worker = new Worker();
                            worker.estadoCivil = info[0];
                            worker.filhos = int.Parse(info[1]);
                            worker.idade = int.Parse(info[2]);
                            worker.nome = info[3];
                            worker.profissao = info[4];
                            worker.salario = int.Parse(info[5]);
                            worker.sexo = info[6];
                            worker.tipoSanguineo = info[7];
                            Form1.reference.Workers.Add(worker);
                        }
                    }
                    Form1.reference.Workers = Form1.reference.Workers;
                }
                catch
                {
                    MessageBox.Show("Erro ao ler o arquivo.");
                }
            }
        }
        #endregion
    }
}
