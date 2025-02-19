using AppExemploCadastro.Contexto;
using AppExemploCadastro.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppExemploCadastro.Formulario
{
    public partial class FormDelete: Form
    {
        PessoaContext contexto = new PessoaContext();
        List<Pessoa> ListaPessoas = new List<Pessoa>();
        Pessoa pessoaSelecionada = new Pessoa();

        public FormDelete()
        {
            InitializeComponent();
            ListaPessoas = contexto.ListarPessoas();
            cbPessoa.DataSource = ListaPessoas;
            cbPessoa.DisplayMember = "Nome";
            cbPessoa.SelectedIndex = -1;
        }

        private void cbPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = cbPessoa.SelectedIndex;
            if (linhaSelec > -1)
            {
                pessoaSelecionada = ListaPessoas[linhaSelec];

                txtNome.Text = pessoaSelecionada.Nome;
                txtCpf.Text = pessoaSelecionada.Cpf;
                txtRegistroGeral.Text = pessoaSelecionada.RegistroGeral;
                txtEmail.Text = pessoaSelecionada.Email;
            }
            else
            {
                txtNome.Clear();
                txtCpf.Clear();
                txtRegistroGeral.Clear();
                txtEmail.Clear();
                
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            contexto.DeletarPessoa(pessoaSelecionada);

            txtNome.Clear();
            txtCpf.Clear();
            txtRegistroGeral.Clear();
            txtEmail.Clear();
            cbPessoa.SelectedIndex = -1;
        }
    }
}
