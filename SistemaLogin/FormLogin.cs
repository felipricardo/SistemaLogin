using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        // Variável para rastrear se o botão de cancelar foi pressionado
        public static bool Cancelar = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        // Evento de clique no botão "Cancelar"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true; // Define a variável Cancelar como verdadeira
            this.Close(); // Fecha o formulário de login
        }

        // Evento de clique no botão "Login"
        private void btnSenha_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (CadastroUsuarios.Login(nome, senha))
            {
                this.Close(); // Fecha o formulário de login se o login for bem-sucedido
            }
            else
            {
                // Exibe uma mensagem de erro e limpa os campos de entrada
                MessageBox.Show("Acesso negado!");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                this.Close(); // Fecha o formulário de login após exibir a mensagem
            }
        }
    }
}