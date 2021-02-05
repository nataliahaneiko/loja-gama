using System;
using System.Collections.Generic;
using System.Text;

namespace Girls.Gama2.Entidades
{
    public abstract class Pagamento : Produto
    {
        public Pagamento(double valor)
        {
            Id = Guid.NewGuid();
            Valor = valor;
            
        }

        public Guid Id { get; set; }
        public DateTime DataPagamento { get; set; }
        public bool Confirmacao { get; set; }
        public string Cpf { get; set; }


        public virtual void Pagar()
        {
            DataPagamento = DateTime.Now;
            Confirmacao = true;
        }
    }
}
