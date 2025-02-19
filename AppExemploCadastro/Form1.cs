using AppExemploCadastro.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            new FormCadastro().ShowDialog();
        }

        private void btLista_Click(object sender, EventArgs e)
        {
            new FormLista().ShowDialog();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            new FormConsultaComb().ShowDialog();
        }

        private void btConsultaLista_Click(object sender, EventArgs e)
        {
            new FormConsulta().ShowDialog();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            new FormAtualizar().ShowDialog();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            new FormDelete().ShowDialog();
        }
    }
}
