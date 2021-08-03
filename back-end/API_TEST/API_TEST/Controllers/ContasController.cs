using API_TEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_TEST.Controllers
{
    public class ContasController : ApiController
    {
        private static List<Conta> contas = new List<Conta>();

        public List<Conta> Get()
        {
            return contas;
        }

        public void Post(string nome, string email, string senha) 
        {
            if (!string.IsNullOrEmpty(nome))
            {
                contas.Add(new Conta(nome, email, senha));
            }
        }


    }
}
