using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.Modelo
{
    internal class Quiz
    {
        public string Nome { get; set; }
        public List<Questao> Questoes { get; set; }
        public int Nota { get; set; }

        public Quiz(string nome, List<Questao> questoes)
        {
            Nome = nome;
            Questoes = questoes;
            Nota = 0;
        }

        public void AplicarQuiz()
        {
            foreach (Questao q in Questoes)
            {
                Console.WriteLine(q.Texto);
                foreach (Alternativa alt in q.Alternativas)
                {
                    Console.WriteLine(alt.Letra + ". " + alt.Texto);
                }
                string resposta = Console.ReadLine();
                q.Responder(resposta);
                Console.WriteLine("Resposta do usuário: " + resposta + "\n");
                if (q.Acertou)
                {
                    this.Nota++;
                }
            }
            Console.WriteLine("Você acertou " + Nota + "/" + Questoes.Count + " respostas!");
        }
    }
}
