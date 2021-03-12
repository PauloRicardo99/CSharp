using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Notes
    {

        // ENUM - cria um tipo de variável
        //          0      1       2        3
        //enum Cor { Azul = 33, Verde = 78, Amarelo /*=79*/, Vermelho }
        // ENUM COM SWITCH
        //enum Opcao { Criar=1, Deletar, Editar, Listar, Atualizar }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world!");  // nao precisa do \n
            //Console.WriteLine("Meu nome é Paulo.");


            // LIMPAR CONSOLE
            Console.Clear();


            // VARIAVEL
            //int var1;
            //var var2 = 2; // adivinha o tipo da variavel
            //dynamic var3; // possivel mudar o tipo de dado, nao recomendado


            // CONSTANTE
            //const double PI = 3.1415;


            // RECEBER VALOR DE USUARIO
            //string nome = "";
            //Console.WriteLine("Escreva seu nome");
            //nome = Console.ReadLine();
            //Console.WriteLine(nome);


            // CONVERSÃO DE VARIAVEL
            //int idade = int.Parse(Console.ReadLine());


            // CHAMAR FUNCAO
            //int oi = ExibirMsg(60);


            // ARRAY
            //string[] jogos = new string[5] { 
            //    "valorant", 
            //    "league of legends", 
            //    "fifa",
            //    "Minecraft",
            //    "R6"
            //};
            //
            //int[] valores = { 40, 50, 60, 70 };


            // MATRIZ
            //int[,] matriz = new int[3,5];
            //int[,] matriz2 = new int[3, 2] { { 10, 20 }, { 30, 40 }, { 50, 60 } };


            // SWITCH CASE
            //string cor = "azul";
            //switch (cor)
            //{
            //    case "vermelho":
            //        Console.WriteLine("Sua cor favorita é vermelho!");
            //        break;
            //    case "azul":
            //        Console.WriteLine("Sua cor favorita é azul!");
            //        break;
            //    default:
            //        Console.WriteLine("Sua cor favorita eu não sei!");
            //        break;
            //}


            // ENUM
            //Cor corFavorita = Cor.Vermelho;
            //Console.WriteLine((int)corFavorita);
            //Console.WriteLine((Cor)3);


            // ENUM COM SWITCH
            //Console.WriteLine("Selecione uma das opções abaixo: ");
            //Console.WriteLine("1- Criar\n2- Deletar\n3- Editar\n4- Listar\n5- Atualizar");
            //int index = int.Parse(Console.ReadLine());
            //Opcao opcaoSelecionada = (Opcao)index;
            //
            //switch (opcaoSelecionada)
            //{
            //    case Opcao.Criar:
            //        Console.WriteLine("Você quer criar algo");
            //        break;
            //    case Opcao.Deletar:
            //        Console.WriteLine("Você quer deletar algo");
            //        break;
            //    case Opcao.Editar:
            //        Console.WriteLine("Você quer editar algo");
            //        break;
            //    case Opcao.Listar:
            //        Console.WriteLine("Você quer listar algo");
            //        break;
            //    case Opcao.Atualizar:
            //        Console.WriteLine("Você quer atualizar algo");
            //        break;
            //    default:
            //        Console.WriteLine("Opção inválida");
            //        break;
            //}


            // FOREACH
            //string[] nomes = { "Paulo", "João", "Ivo", "André" };

            //foreach (string nome in nomes) // "Para cada nome em nomes, repita"
            //{
            //    Console.WriteLine(nome);
            //}


            // IMPRIMIR VARIAS VARIAVEIS EM UM PRINT
            //int n1 = 10, n2 = 20, n3 = 30;
            //Console.WriteLine("n1={0}, n2={1}, n3={2}", n1, n2, n3);


            // FORMATANDO SAIDAS
            //string produto = "Pastel";
            //double lucro = 0.1;
            //double valorCompra = 5.50;
            //double valorVenda = valorCompra + (valorCompra * lucro);
            //Console.WriteLine("Produto.......:{0,15}", produto);    //{indice,espaco}
            //Console.WriteLine("Val.Compra....:{0,15:c}", valorCompra);    //{indice,espaco:formatoMonetario}
            //Console.WriteLine("Lucro.........:{0,15:p}", lucro);    //{indice,espaco:formatoPorcentagem}
            //Console.WriteLine("Val.Venda.....:{0,15:p}", valorVenda);    //{indice,espaco:formatoMonetario}


            // BITWISE >>(METADE) <<(DOBRA)
            //int num = 10;
            //
            //num = num << 1;
            //Console.WriteLine(num);
            //num = 10;
            //num = num << 4;
            //Console.WriteLine(num);
            //
            //num = 10;
            //num = num >> 1;
            //Console.WriteLine(num);
            //num = 10;
            //num = num >> 4;
            //Console.WriteLine(num);


            // GOTO (go to) - coloca um comando para retornar a um label criado
            //inicio:     // label
            //Console.WriteLine("Isso deve repetir");
            //goto inicio;
            //Console.WriteLine("Isso não deve aparecer");







            Console.ReadLine(); // apenas para o programa nao encerrar
        }

        // FUNCAO
        //static int ExibirMsg(int preco)
        //{
        //    return preco;
        //}
    }
}
