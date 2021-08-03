using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TEST.Models
{
    public class Transacao
    {
        public string name { get; set; }

        public string descricao { get; set; }

        public string data { get; set; }

        public decimal amount { get; set; }

        public Transacao()
        {
                
        }
        public Transacao(string name, string descricao, string data, decimal amount)
        {
            this.name = name;
            this.descricao = descricao;
            this.data = data;
            this.amount = amount;
        }

        
    }
}