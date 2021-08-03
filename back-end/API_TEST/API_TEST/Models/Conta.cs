using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TEST.Models
{
    public class Conta
    {

        public string nome { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public Conta() { }
        public Conta(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }



    }
}