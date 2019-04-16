using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao(); 
            UsarSistema();

            Console.ReadLine(); 
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            sistemaInterno.Logar(roberta,"abc");
            sistemaInterno.Logar(roberta,"123");

            GerenteDeConta camila = new GerenteDeConta(4000, "326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "123";
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(camila, "123");



        }

        //public static void CalcularBonificacao() 
        //{

        //    GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

        //    Funcionario pedro = new Designer("833.222.048-39");
        //    pedro.Nome = "Pedro";



        //    Funcionario igor = new Auxiliar("981.198.778-53");
        //    igor.Nome = "Igor";



        //    Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20"); 
        //    guilherme.Nome = "Guilherme"; 

        //    gerenciadorBonificacao.Registrar(guilherme);
        //    gerenciadorBonificacao.Registrar(pedro);
        //    gerenciadorBonificacao.Registrar(roberta);
        //    gerenciadorBonificacao.Registrar(igor);
        //    gerenciadorBonificacao.Registrar(camila);

        //    Console.WriteLine("Total de bonificações do mês " +
        //        gerenciadorBonificacao.GetTotalBonificacao());
        //}
    }
}