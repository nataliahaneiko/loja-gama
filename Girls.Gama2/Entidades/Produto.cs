using System;
using System.Collections.Generic;
using System.Text;

namespace Girls.Gama2.Entidades
{
    public class Produto
    {
     
        public Produto(double valor,
                       string nomeproduto)
        {
            NomeProduto = nomeproduto;
            Valor = valor;
        }

        public string NomeProduto { get; set; }
        public double Valor { get; set; }
    }
     


}



