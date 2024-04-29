namespace _01_S
{
    /// <summary>
    ///  "S" que significa "Single Responsibility Principle" 
    ///  (Princípio da Responsabilidade Única). 
    ///  Este princípio afirma que uma classe deve ter apenas 
    ///  uma razão para mudar, ou seja, deve ter apenas uma responsabilidade.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
                ############################## S - O.L.I.D #######################################
                Este programa exemplifica o princípio S do SOLID, que significa 'Single Responsibility Principle' (Princípio da Responsabilidade Única).
                De acordo com esse princípio, uma classe deve ter apenas uma razão para mudar, ou seja, deve ter apenas uma responsabilidade.

                Neste programa, aplicamos o princípio S do SOLID da seguinte maneira:

                - Criamos duas classes distintas no Arquivo CoffeeShop.cs:
                    - OrderManager: Responsável por gerenciar os pedidos dos clientes.
                    - OrderDisplay: Responsável por exibir os pedidos na tela.

                - A classe OrderManager tem a responsabilidade única de gerenciar os pedidos, incluindo adicionar pedidos à lista e obter todos os pedidos.
                - A classe OrderDisplay tem a responsabilidade única de exibir os pedidos na tela.

                Ao separar essas responsabilidades em classes distintas, tornamos o código mais coeso e fácil de entender e manter, seguindo o princípio da responsabilidade única do SOLID.
            ");
            Console.WriteLine("##################### Exemplo de Execução #######################");

            Console.WriteLine("Iniciando Order Manager");
            OrderManager _orderManager = new OrderManager();
            Thread.Sleep(1000);
            Console.WriteLine("Adicionando Pedido: ");
            Thread.Sleep(1000);
            Console.WriteLine("01 - Café preto ");

            _orderManager.AddOrder("Café preto");
            Thread.Sleep(1000);
            Console.WriteLine("Adicionando Pedido: ");
            Thread.Sleep(1000);
            Console.WriteLine("01 - Café com leite ");
            _orderManager.AddOrder("Café com leite");


            Thread.Sleep(2000);
            Console.WriteLine("Exibindo Todos os Pedidos: ");
            Thread.Sleep(1000);
            OrderDisplay orderDisplay = new OrderDisplay();
            orderDisplay.ShowOrders(_orderManager.GetAllOrders());
            Console.ReadKey();
        }
    }
}
