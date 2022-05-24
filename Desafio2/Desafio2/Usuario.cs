using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Usuario(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        public string ObterLogin() {
            return this.Email.Split("@")[0];
        }
    }
}
