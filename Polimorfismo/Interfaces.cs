using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Interfaces
    {
        public interface IAutenticavel
        {
            void Autenticar();
            void Deslogar();
        }

        public class UsuarioSistma : IAutenticavel
        {
            public void Autenticar()
            {
                Console.WriteLine("Usuário Logado!!!");
            }

            public void Deslogar()
            {
                Console.WriteLine("Usuário Deslogado!!!");
            }
        }
        public static class Executor
        {
            public static void Executar()
            {
                var usuario = new UsuarioSistma();
                usuario.Autenticar();

                usuario.Deslogar();

            }
        }

    }
}
