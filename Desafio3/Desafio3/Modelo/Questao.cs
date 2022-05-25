using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.Modelo
{
    internal class Questao
    {
        public string Texto { get; set; }
        public List<Alternativa> Alternativas { get; set; }
        public bool Acertou { get; set; }

        public Questao(string texto, List<Alternativa> alternativas)
        {
            Texto = texto;
            Alternativas = alternativas;
        }

        private static string OrdenarString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }

        public void Responder(string resposta)
        {
            string alternativasCorretas = "";
            foreach (Alternativa alt in this.Alternativas)
            {
                if (alt.Correto)
                {
                    alternativasCorretas += alt.Letra;
                }
            }
            alternativasCorretas = OrdenarString(alternativasCorretas);
            resposta = OrdenarString(resposta);

            if (resposta == alternativasCorretas)
            {
                this.Acertou = true;
            } 
            else
            {
                this.Acertou = false;
            }
        }
    }
}
