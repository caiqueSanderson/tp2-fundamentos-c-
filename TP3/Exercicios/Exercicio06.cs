using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exercicios
{
    internal class Exercicio06
    {
        class Ticket
        {
            private string showName;
            private double price;
            private int availableQuantity;
            public Ticket(string showName,double price, int availableQuantity)
            {
                this.showName = showName;
                this.price = price;
                this.availableQuantity = availableQuantity;
            }

            public string GetShowName()
            {
                return this.showName;
            }
            public double GetPrice()
            {
                return this.price;
            }
            public int GetQuantity()
            {
                return this.availableQuantity;
            }
            public void SetShowName(string newShowName)
            {
                this.showName = newShowName;
            }
            public void SetPrice(double newPrice)
            {
                this.price = newPrice;
            }

            public void SetQuantity(int newQuantity)
            {
                this.availableQuantity = newQuantity;
            }

            public void ViewInfo()
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
                Ticket ticket = new Ticket("Vocal Livre", 100.00, 1000);

                ticket.ViewInfo();
            }
        }
    }
}
