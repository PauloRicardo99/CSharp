using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_jogador
{
    static class Jogador
    {
        public static int vida = 100;
        public static bool vivo = true;
        public static string nome;

        public static void iniciar(string n)
        {
            nome = n;
        }

        public static string GetNome()
        {
            return nome;
        }
        public static bool GetVivo()
        {
            return vivo;
        }
        public static int GetVida()
        {
            return vida;
        }


        public static void info()
        {
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Vivo: {0}", vivo);
            Console.WriteLine("Vida: {0}", vida);
            Console.WriteLine();
        }
    }

    class Inimigo
    {
        public static bool alerta;
        public string nome;

        public Inimigo(string n)
        {
            alerta = false;
            nome = n;
        }

        public void Info()
        {
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Alerta: {0}", alerta);
            Console.WriteLine();
        }
    }

    class poo_static
    {
        static void Main(string[] args)
        {
            Jogador.iniciar("Raze");
            Jogador.info();

            Inimigo i1 = new Inimigo("Jett");
            Inimigo i2 = new Inimigo("Reyna");
            Inimigo i3 = new Inimigo("Phoenix");

            Inimigo.alerta = true;

            i1.Info();
            i2.Info();
            i3.Info();

            Console.ReadLine();
        }
    }
}
