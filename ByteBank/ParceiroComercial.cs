using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ParceiroComercial
    {
        public string Senha { get; set; }
        public bool Auntenticar(string senha)
        {
            return Senha == senha;
        }

        public bool Logar(ParceiroComercial funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Auntenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem Vindo ao sistema !");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta !");
                return false;
            }
        }
    }
}
