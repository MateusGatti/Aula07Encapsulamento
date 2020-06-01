using System;

namespace Aula07Encapsulamento
{
    public class MasterCard : Cartao
    {

        public int parcelas { get; set; }

        public void ComprarComDescontoMasterCard(float desconto){
            Console.WriteLine($"Compra realizada com {parcelas} parcelas e {desconto} de desconto");
        }

    }
}