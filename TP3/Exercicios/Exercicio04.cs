using System;

namespace TP3.Exercicios
{
    internal class Exercicio04
    {
        class Ticket
        {
            public string showName;
            public double price;
            public int availableQuantity;

            public void setPrice(double newPrice)
            {
                this.price = newPrice;
            }

            public void setQuantity(int newQuantity)
            {
                this.availableQuantity = newQuantity;
            }

            public void viewInfo()
            {
                Console.WriteLine($"Nome do show: {showName}");
                Console.WriteLine($"Preço do ingresso: {price}");
                Console.WriteLine($"Quantidade disponível: {availableQuantity}");
            }
        }
        internal class AppTicket
        {
            public void Start()
            {
                Ticket ticket = new Ticket();
                ticket.showName = "Vocal Livre";
                ticket.setPrice(100.00);
                ticket.setQuantity(1000);
                ticket.viewInfo();
        }
        }
        
    }
}
