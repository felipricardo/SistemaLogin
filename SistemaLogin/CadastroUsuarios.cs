using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuarios
    {
        // Array de objetos Usuario pré-cadastrados
        private static Usuario[] usuarios =
        {
            new Usuario(){ Nome = "Felipe", Senha = "sator" },
            new Usuario(){ Nome = "Luca", Senha = "omagaa" },
            new Usuario(){ Nome = "Joao", Senha = "indie" },
            new Usuario(){ Nome = "Marcelo", Senha = "jec" },
            new Usuario(){ Nome = "Knies", Senha = "gremio"}
        };

        // Armazena o usuário logado
        private static Usuario _userLogado = null;

        // Propriedade pública para acessar o usuário logado
        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        // Método para realizar o login
        public static bool Login(string nome, string senha)
        {
            // Itera sobre a lista de usuários
            foreach (Usuario usuario in usuarios)
            {
                // Verifica se o nome e senha correspondem a um usuário cadastrado
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    // Define o usuário como logado e retorna verdadeiro
                    UsuarioLogado = usuario;
                    return true;
                }
            }

            // Se não encontrar um usuário correspondente, retorna falso
            return false;
        }
    }
}