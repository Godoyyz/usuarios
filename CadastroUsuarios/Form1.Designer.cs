namespace CadastroUsuarios
{
    partial class frmUsuarios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtRM = new TextBox();
            lblRM = new Label();
            lblCPF = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            mskCPF = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            lblDataNascimento = new Label();
            lblSexo = new Label();
            lblNaturalidade = new Label();
            comboBox2 = new ComboBox();
            btnExibir = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            btnVS = new Button();
            btnNote = new Button();
            btncalc = new Button();
            btnusuario = new Button();
            btnSistema = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txtRM
            // 
            txtRM.Location = new Point(57, 83);
            txtRM.Margin = new Padding(4, 5, 4, 5);
            txtRM.Name = "txtRM";
            txtRM.Size = new Size(141, 31);
            txtRM.TabIndex = 0;
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Location = new Point(57, 53);
            lblRM.Margin = new Padding(4, 0, 4, 0);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(39, 25);
            lblRM.TabIndex = 1;
            lblRM.Text = "RM";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(209, 53);
            lblCPF.Margin = new Padding(4, 0, 4, 0);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(42, 25);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(383, 53);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(383, 83);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(383, 31);
            txtNome.TabIndex = 4;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(209, 83);
            mskCPF.Margin = new Padding(4, 5, 4, 5);
            mskCPF.Mask = "###.###.###-##";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(154, 31);
            mskCPF.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(57, 165);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(305, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Feminino", "Masculino" });
            comboBox1.Location = new Point(383, 165);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 33);
            comboBox1.TabIndex = 8;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(57, 135);
            lblDataNascimento.Margin = new Padding(4, 0, 4, 0);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(170, 25);
            lblDataNascimento.TabIndex = 9;
            lblDataNascimento.Text = "Data de nascimento";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(383, 135);
            lblSexo.Margin = new Padding(4, 0, 4, 0);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(50, 25);
            lblSexo.TabIndex = 10;
            lblSexo.Text = "Sexo";
            // 
            // lblNaturalidade
            // 
            lblNaturalidade.AutoSize = true;
            lblNaturalidade.Location = new Point(581, 135);
            lblNaturalidade.Margin = new Padding(4, 0, 4, 0);
            lblNaturalidade.Name = "lblNaturalidade";
            lblNaturalidade.Size = new Size(113, 25);
            lblNaturalidade.TabIndex = 12;
            lblNaturalidade.Text = "Naturalidade";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Jaboticabal - SP", "Guariba - SP", "Matão - SP", "Monte Alto - SP", "Taquaritinga - SP", "Santa Ernestina - SP" });
            comboBox2.Location = new Point(594, 165);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(171, 33);
            comboBox2.TabIndex = 11;
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(57, 230);
            btnExibir.Margin = new Padding(4, 5, 4, 5);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(143, 60);
            btnExibir.TabIndex = 13;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(209, 230);
            btnLimpar.Margin = new Padding(4, 5, 4, 5);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(156, 60);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(373, 230);
            btnSair.Margin = new Padding(4, 5, 4, 5);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(129, 60);
            btnSair.TabIndex = 15;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnVS
            // 
            btnVS.Location = new Point(373, 353);
            btnVS.Margin = new Padding(4, 5, 4, 5);
            btnVS.Name = "btnVS";
            btnVS.Size = new Size(129, 83);
            btnVS.TabIndex = 18;
            btnVS.Text = "Visual Studio Code";
            btnVS.UseVisualStyleBackColor = true;
            btnVS.Click += btnVS_Click;
            // 
            // btnNote
            // 
            btnNote.Location = new Point(209, 353);
            btnNote.Margin = new Padding(4, 5, 4, 5);
            btnNote.Name = "btnNote";
            btnNote.Size = new Size(156, 83);
            btnNote.TabIndex = 17;
            btnNote.Text = "Bloco de Notas";
            btnNote.UseVisualStyleBackColor = true;
            btnNote.Click += btnNote_Click;
            // 
            // btncalc
            // 
            btncalc.Location = new Point(57, 353);
            btncalc.Margin = new Padding(4, 5, 4, 5);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(143, 83);
            btncalc.TabIndex = 16;
            btncalc.Text = "Calculadora";
            btncalc.UseVisualStyleBackColor = true;
            btncalc.Click += btncalc_Click;
            // 
            // btnusuario
            // 
            btnusuario.Location = new Point(373, 452);
            btnusuario.Margin = new Padding(4, 5, 4, 5);
            btnusuario.Name = "btnusuario";
            btnusuario.Size = new Size(129, 75);
            btnusuario.TabIndex = 21;
            btnusuario.Text = "Informações do usuário";
            btnusuario.UseVisualStyleBackColor = true;
            // 
            // btnSistema
            // 
            btnSistema.Location = new Point(209, 447);
            btnSistema.Margin = new Padding(4, 5, 4, 5);
            btnSistema.Name = "btnSistema";
            btnSistema.Size = new Size(156, 80);
            btnSistema.TabIndex = 20;
            btnSistema.Text = "Informações do sistema";
            btnSistema.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(523, 230);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(243, 304);
            listBox1.TabIndex = 22;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1143, 750);
            Controls.Add(listBox1);
            Controls.Add(btnusuario);
            Controls.Add(btnSistema);
            Controls.Add(btnVS);
            Controls.Add(btnNote);
            Controls.Add(btncalc);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnExibir);
            Controls.Add(lblNaturalidade);
            Controls.Add(comboBox2);
            Controls.Add(lblSexo);
            Controls.Add(lblDataNascimento);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(mskCPF);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCPF);
            Controls.Add(lblRM);
            Controls.Add(txtRM);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de usuários";
            WindowState = FormWindowState.Maximized;
            Load += frmUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRM;
        private Label lblRM;
        private Label lblCPF;
        private Label lblNome;
        private TextBox txtNome;
        private MaskedTextBox mskCPF;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label lblDataNascimento;
        private Label lblSexo;
        private Label lblNaturalidade;
        private ComboBox comboBox2;
        private Button btnExibir;
        private Button btnLimpar;
        private Button btnSair;
        private Button btnVS;
        private Button btnNote;
        private Button btncalc;
        private Button btnusuario;
        private Button btnSistema;
        private Button btngoogle;
        private ListBox listBox1;
    }
}
