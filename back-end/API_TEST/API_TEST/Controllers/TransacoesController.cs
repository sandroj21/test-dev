using API_TEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_TEST.Controllers
{ 
    public class TransacoesController : ApiController
    {
        private static List<Transacao> transacao = new List<Transacao>();

        public List<Transacao> Get()
        {
            return transacao;
        }

        public IEnumerable<Transacao> Get(string tipo)
        {
            return transacao.Where(
                 p => string.Equals(p.name, tipo, StringComparison.OrdinalIgnoreCase));
        }

        public void Post(string name, string descricao, string data, decimal amount)
        {
            if (!string.IsNullOrEmpty(name))
                if (name.Equals("Saque"))
                {
                    
                    transacao.Add(new Transacao(name, descricao, data, amount));
                }
                else
                {
                    transacao.Add(new Transacao(name, descricao, data, amount));
                }
        }

    }
}

