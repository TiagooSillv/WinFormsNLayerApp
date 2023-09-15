namespace WindowsForms.telas.cargos
{
    partial class CargoView
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
            groupBoxCargo = new GroupBox();
            btnSalvar = new Button();
            txtCargo = new TextBox();
            chkStatus = new CheckBox();
            btnNovoCargo = new Button();
            dataGridView = new DataGridView();
            lblRecarregar = new Button();
            label2 = new Label();
            groupBoxCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCargo
            // 
            groupBoxCargo.Controls.Add(btnSalvar);
            groupBoxCargo.Controls.Add(txtCargo);
            groupBoxCargo.Controls.Add(chkStatus);
            groupBoxCargo.Location = new Point(12, 42);
            groupBoxCargo.Name = "groupBoxCargo";
            groupBoxCargo.Size = new Size(769, 60);
            groupBoxCargo.TabIndex = 0;
            groupBoxCargo.TabStop = false;
            groupBoxCargo.Text = "Novo cargo";
            groupBoxCargo.Visible = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(562, 22);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(124, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(9, 22);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(175, 23);
            txtCargo.TabIndex = 3;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(217, 25);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(89, 19);
            chkStatus.TabIndex = 1;
            chkStatus.Text = "Cargo Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // btnNovoCargo
            // 
            btnNovoCargo.Location = new Point(12, 13);
            btnNovoCargo.Name = "btnNovoCargo";
            btnNovoCargo.Size = new Size(102, 23);
            btnNovoCargo.TabIndex = 3;
            btnNovoCargo.Text = "Novo Cargo";
            btnNovoCargo.UseVisualStyleBackColor = true;
            btnNovoCargo.Click += btnNovoCargo_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 165);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(769, 226);
            dataGridView.TabIndex = 6;
            dataGridView.CellMouseDoubleClick += dataGridView_CellMouseDoubleClick;
            // 
            // lblRecarregar
            // 
            lblRecarregar.Location = new Point(706, 136);
            lblRecarregar.Name = "lblRecarregar";
            lblRecarregar.Size = new Size(75, 23);
            lblRecarregar.TabIndex = 7;
            lblRecarregar.Text = "Recarregar";
            lblRecarregar.UseVisualStyleBackColor = true;
            lblRecarregar.Click += lblRecarregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 140);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 8;
            label2.Text = "Todos os Cargos";
            // 
            // CargoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 410);
            Controls.Add(label2);
            Controls.Add(lblRecarregar);
            Controls.Add(dataGridView);
            Controls.Add(btnNovoCargo);
            Controls.Add(groupBoxCargo);
            Name = "CargoView";
            Text = "CargoView";
            Load += CargoView_Load;
            groupBoxCargo.ResumeLayout(false);
            groupBoxCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCargo;
        private Button btnSalvar;
        private TextBox txtCargo;
        private CheckBox chkStatus;
        private Button btnNovoCargo;
        private DataGridView dataGridView;
        private Button lblRecarregar;
        private Label label2;
    }
}