using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_S
{
    // Classe que tem a UNICA RESPONSABILIDADE de GERENCIAR os pedidos dos clientes
    public class OrderManager
    {
        private List<string> orders;

        public OrderManager()
        {
            orders = new List<string>();
        }

        public void AddOrder(string order)
        {
            orders.Add(order);
        }

        // Método para obter todos os pedidos
        public List<string> GetAllOrders()
        {
            return orders;
        }
    }
    // Classe Que Tem a UNICA RESPONSABILIDADE de EXIBIR os pedidos na tela
    public class OrderDisplay
    {
        public void ShowOrders(List<string> orders)
        {
            Console.WriteLine("Pedidos:");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
