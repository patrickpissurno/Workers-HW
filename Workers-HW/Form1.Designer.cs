namespace Workers_HW
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.idade = new System.Windows.Forms.TextBox();
            this.profissao = new System.Windows.Forms.TextBox();
            this.salario = new System.Windows.Forms.TextBox();
            this.filhos = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.estadocivil = new System.Windows.Forms.ComboBox();
            this.sangue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.salvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(265, 12);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 1;
            // 
            // idade
            // 
            this.idade.Location = new System.Drawing.Point(265, 38);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(100, 20);
            this.idade.TabIndex = 2;
            // 
            // profissao
            // 
            this.profissao.Location = new System.Drawing.Point(265, 64);
            this.profissao.Name = "profissao";
            this.profissao.Size = new System.Drawing.Size(100, 20);
            this.profissao.TabIndex = 3;
            // 
            // salario
            // 
            this.salario.Location = new System.Drawing.Point(265, 90);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(100, 20);
            this.salario.TabIndex = 4;
            // 
            // filhos
            // 
            this.filhos.Location = new System.Drawing.Point(265, 116);
            this.filhos.Name = "filhos";
            this.filhos.Size = new System.Drawing.Size(100, 20);
            this.filhos.TabIndex = 5;
            // 
            // sexo
            // 
            this.sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.sexo.Location = new System.Drawing.Point(265, 142);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(100, 21);
            this.sexo.TabIndex = 6;
            // 
            // estadocivil
            // 
            this.estadocivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadocivil.FormattingEnabled = true;
            this.estadocivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Viuvo",
            "Divorciado"});
            this.estadocivil.Location = new System.Drawing.Point(265, 169);
            this.estadocivil.Name = "estadocivil";
            this.estadocivil.Size = new System.Drawing.Size(100, 21);
            this.estadocivil.TabIndex = 7;
            // 
            // sangue
            // 
            this.sangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sangue.FormattingEnabled = true;
            this.sangue.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.sangue.Location = new System.Drawing.Point(265, 196);
            this.sangue.Name = "sangue";
            this.sangue.Size = new System.Drawing.Size(100, 21);
            this.sangue.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Profissão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Salário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nº de filhos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado civil:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tipo sanguíneo:";
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(250, 242);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 17;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Exportar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files|*.txt";
            this.saveFileDialog1.Title = "Exportar dados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 277);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sangue);
            this.Controls.Add(this.estadocivil);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.filhos);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.profissao);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox idade;
        private System.Windows.Forms.TextBox profissao;
        private System.Windows.Forms.TextBox salario;
        private System.Windows.Forms.TextBox filhos;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.ComboBox estadocivil;
        private System.Windows.Forms.ComboBox sangue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

