using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Models
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public long Celular { get; set; }
    }
}