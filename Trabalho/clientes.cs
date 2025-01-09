using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
   class clientes
    {
        int codigo;
        string nome_cliente;
        string telefone;
        string email;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
    }
}
