using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.Modelo
{
    public class Alternativa
    {
        public char Letra { get; set; }
        public string Texto { get; set; }
        public bool Correto { get; set; }

        public Alternativa(char letra, string texto, bool correto)
        {
            Letra = letra;
            Texto = texto;
            Correto = correto;
        }
    }
}
