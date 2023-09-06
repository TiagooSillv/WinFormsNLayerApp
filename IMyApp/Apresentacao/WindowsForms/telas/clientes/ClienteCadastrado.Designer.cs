namespace WindowsForms.telas.clientes
{
    partial class ClienteCadastrado
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNomeCompleto = new TextBox();
            txtCpf = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            txtTelefone = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            pictureBox1 = new PictureBox();
            cmbBolsaDeEstudo = new ComboBox();
            chkEhResposavel = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 40);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 87);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 133);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 180);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 3;
            label4.Text = "Bolsa de Estudos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 40);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 4;
            label5.Text = "Cpf";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(151, 60);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(253, 23);
            txtNomeCompleto.TabIndex = 5;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(410, 60);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(165, 23);
            txtCpf.TabIndex = 6;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(151, 105);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(114, 23);
            dtpDataNascimento.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(151, 151);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(123, 23);
            txtTelefone.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 133);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 8;
            label6.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(295, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 23);
            txtEmail.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.associese_azul;
            pictureBox1.Location = new Point(21, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // cmbBolsaDeEstudo
            // 
            cmbBolsaDeEstudo.FormattingEnabled = true;
            cmbBolsaDeEstudo.Location = new Point(151, 198);
            cmbBolsaDeEstudo.Name = "cmbBolsaDeEstudo";
            cmbBolsaDeEstudo.Size = new Size(121, 23);
            cmbBolsaDeEstudo.TabIndex = 12;
            // 
            // chkEhResposavel
            // 
            chkEhResposavel.AutoSize = true;
            chkEhResposavel.Location = new Point(150, 238);
            chkEhResposavel.Name = "chkEhResposavel";
            chkEhResposavel.Size = new Size(183, 19);
            chkEhResposavel.TabIndex = 13;
            chkEhResposavel.Text = "Cliente é  o responsavel legal?";
            chkEhResposavel.UseVisualStyleBackColor = true;
            // 
            // ClienteCadastrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkEhResposavel);
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
            Name = "ClienteCadastrado";
            Text = "ClienteCadastrado";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNomeCompleto;
        private TextBox txtCpf;
        private DateTimePicker dtpDataNascimento;
        private TextBox txtTelefone;
        private Label label6;
        private TextBox txtEmail;
        private PictureBox pictureBox1;
        private ComboBox cmbBolsaDeEstudo;
        private CheckBox chkEhResposavel;
    }
}