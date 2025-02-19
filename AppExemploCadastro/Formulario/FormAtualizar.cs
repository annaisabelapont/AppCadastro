using AppExemploCadastro.Contexto;
using AppExemploCadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppExemploCadastro.Formulario
{
    public partial class FormAtualizar: Form
    {
        PessoaContext contexto = new PessoaContext();
        List<Pessoa> ListaPessoas = new List<Pessoa>();

        public FormAtualizar()
        {
            InitializeComponent();
            ListaPessoas = contexto.ListarPessoas();
            cbPessoa.DataSource = ListaPessoas;
            cbPessoa.DisplayMember = "Nome";
            cbPessoa.SelectedIndex = -1;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            var linhaSelec = cbPessoa.SelectedIndex;

            if (linhaSelec > -1)
            {
                var pessoaSelec = ListaPessoas[linhaSelec];
                pessoaSelec.Nome = txtNome.Text;
                pessoaSelec.Cpf = txtCpf.Text;
                pessoaSelec.Email = txtEmail.Text;
                pessoaSelec.RegistroGeral = txtRegistroGeral.Text;


                PessoaContext context = new PessoaContext();
                context.AtualizarPessoa(pessoaSelec);

                txtNome.Clear();
                txtEmail.Clear();
                txtCpf.Clear();
                txtRegistroGeral.Clear();

                txtNome.Select();
                ListaPessoas = context.ListarPessoas();

                cbPessoa.DataSource = ListaPessoas.ToList();
                cbPessoa.SelectedIndex = -1;
            }
        }

        private void cbPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = cbPessoa.SelectedIndex;
            if (linhaSelec > -1)
            {
                var pessoaSelec = ListaPessoas[linhaSelec];
                txtNome.Text = pessoaSelec.Nome;
                txtCpf.Text = pessoaSelec.Cpf;
                txtRegistroGeral.Text = pessoaSelec.RegistroGeral;
                txtEmail.Text = pessoaSelec.Email;
            }
            else
            {
                txtNome.Clear();
                txtEmail.Clear();
                txtCpf.Clear();
                txtRegistroGeral.Clear();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtRegistroGeral.Clear();
            cbPessoa.SelectedIndex = -1;
        }
    }
}
