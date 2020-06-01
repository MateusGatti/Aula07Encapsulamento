using System;

namespace Aula07Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set; }

        public string titular { get; set; }

        public string bandeira { get; set; }

        private string token = "65t636rr33r3r3r3r3r5rr53";

        protected string cvv { get ; set; }


        public void AprovarCompra(){
            Console.WriteLine("Compra Aprovada");
        }

        private bool ValidarToken(){
            return true;
        }

        protected bool ValidarCompra(){
            return true;
        }





    }
}