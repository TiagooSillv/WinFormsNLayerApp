using Database.Repositorios;
using Negocio.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsForms.telas.cargos
{
    public partial class CargoView : Form
    {
        int id = -1;
        public CargoView()
        {
            InitializeComponent();
        }

        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            groupBoxCargo.Visible = !groupBoxCargo.Visible;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novoCargo = new Cargo(txtCargo.Text, chkStatus.Checked);
            var cargoRepository = new CargoRepository();

            if (id > 0)
            {               

                var atualizarCargo = new CargoRepository();
                atualizarCargo.Atualizar(novoCargo, id);
                carregarCargos();

            }
            else
            {

                var resultado = cargoRepository.Inserir(novoCargo);

                if (!resultado) MessageBox.Show("Não foi possível cadastrar o cargo");

                MessageBox.Show("Cargo cadastrado com sucesso");

            }



        }
        private void carregarCargos()
        {
            var cargoRepository = new CargoRepository();
            var dataTable = cargoRepository.ObterTodos();
            dataGridView.DataSource = dataTable;
        }

        private void CargoView_Load(object sender, EventArgs e)
        {
            
            
            carregarCargos();
        }

        private void lblRecarregar_Click(object sender, EventArgs e)
        {

            carregarCargos();
        }
         
        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                groupBoxCargo.Show();
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                txtCargo.Text = row.Cells[1].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(row.Cells[2].Value.ToString());

                id = Convert.ToInt32 (row.Cells[0].Value) ;

            }
        }
    }
}
