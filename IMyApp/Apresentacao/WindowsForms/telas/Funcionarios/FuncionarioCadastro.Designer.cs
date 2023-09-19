namespace WindowsForms.telas.Funcionarios
{
    partial class FuncionarioCadastro
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
            chkAtivo = new CheckBox();
            cmbBolsaDeEstudo = new ComboBox();
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            label6 = new Label();
            dtpDataNascimento = new DateTimePicker();
            txtCpf = new TextBox();
            txtNomeCompleto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(177, 242);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 27;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // cmbBolsaDeEstudo
            // 
            cmbBolsaDeEstudo.FormattingEnabled = true;
            cmbBolsaDeEstudo.Location = new Point(177, 196);
            cmbBolsaDeEstudo.Name = "cmbBolsaDeEstudo";
            cmbBolsaDeEstudo.Size = new Size(121, 23);
            cmbBolsaDeEstudo.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.associese_azul;
            pictureBox1.Location = new Point(34, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(321, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 23);
            txtEmail.TabIndex = 24;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(177, 149);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(123, 23);
            txtTelefone.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 131);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 22;
            label6.Text = "Telefone";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(177, 103);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(114, 23);
            dtpDataNascimento.TabIndex = 21;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(436, 58);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(165, 23);
            txtCpf.TabIndex = 20;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(177, 58);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(253, 23);
            txtNomeCompleto.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 38);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 18;
            label5.Text = "Cpf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 178);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 17;
            label4.Text = "Bolsa de Estudos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 131);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 16;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 85);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 15;
            label2.Text = "Data de Nascimento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 38);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 14;
            label1.Text = "Nome completo";
            // 
            // button1
            // 
            button1.Location = new Point(290, 277);
            button1.Name = "button1";
            button1.Size = new Size(140, 28);
            button1.TabIndex = 28;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FuncionarioCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 317);
            Controls.Add(button1);
            Controls.Add(chkAtivo);
            Controls.Add(cmbBolsaDeEstudo);
            Controls.Add(pictureBox1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(label6);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtCpf);
            Controls.Add(txtNomeCompleto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FuncionarioCadastro";
            Text = "FuncionarioCadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkAtivo;
        private ComboBox cmbBolsaDeEstudo;
        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label label6;
        private DateTimePicker dtpDataNascimento;
        private TextBox txtCpf;
        private TextBox txtNomeCompleto;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}