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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento de carregamento do formulário
        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();

            // Loop enquanto nenhum usuário estiver logado
            while (CadastroUsuarios.UsuarioLogado == null)
            {
                // Torna o formulário atual invisível e mostra o formulário de login
                Visible = false;
                f.ShowDialog();

                // Se o botão de cancelar no formulário de login for pressionado
                if (FormLogin.Cancelar == true)
                {
                    // Encerra a aplicação
                    Application.Exit();
                    return;
                }
            }

            // Atualiza a label de boas-vindas com o nome do usuário logado
            label_BoasVindas.Text = "Bem Vindo(a) \n" + CadastroUsuarios.UsuarioLogado.Nome;
            Visible = true; // Torna o formulário atual visível novamente
        }
    }
}