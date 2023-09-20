namespace WindowsForms
{
    partial class SplashScreen
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
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom;
            progressBar1.ForeColor = SystemColors.GradientActiveCaption;
            progressBar1.Location = new Point(184, 865);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(669, 23);
            progressBar1.TabIndex = 0;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Firefly_cria_uma_imagem_para_tela_de_carregamento_com_uma_engrenagem_e_um_computador_de_fundo_com_o_;
            ClientSize = new Size(1029, 900);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            Text = "SplashScreen";
            WindowState = FormWindowState.Maximized;
            Shown += SplashScreen_Shown_1;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
    }
}