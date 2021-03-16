using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_jogador
{
    class Jogador
    {
        int vida = 100;
        bool vivo = true;
        string nome;

        public Jogador(String nome) // Construtor
        { 
            this.nome = nome; 
        }   
        public Jogador(String nome, int vida, bool vivo) // Construtor
        { 
            this.nome = nome;
            this.vida = vida;
            this.vivo = vivo;
        }
        ~Jogador() // Destrutor
        { 
            Console.WriteLine("O jogador {0} foi destruído", nome); 
        }  

        public string GetNome() 
        { 
            return nome; 
        }
        public bool GetVivo() 
        { 
            return vivo; 
        }
        public int GetVida() 
        { 
            return vida; 
        }
        public void SetNome(string nome) 
        { 
            this.nome = nome; 
        }
        public void SetVida(bool vivo) 
        { 
            this.vivo = vivo; 
        }
        public void SetVida(int vida) 
        { 
            this.vida = vida; 
        }

        public void info()
        {
            Console.WriteLine(nome);
            Console.WriteLine(vivo);
            Console.WriteLine(vida);
            Console.WriteLine();
        }
    }

    class poo_jogador
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador("Paulo");
            Jogador j2 = new Jogador("Ricardo", 0, false);

            j1.SetVida(80);

            j1.info();
            j2.info();

            Console.ReadLine();
        }
    }
}
