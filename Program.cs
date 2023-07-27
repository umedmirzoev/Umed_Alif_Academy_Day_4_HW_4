using Umed_Alif_Academy_Day_4_HW_4;

public class Program
{
    public static void Main()
    {
        // Services
        ClientService clientService = new ClientService();
        OrderService orderService = new OrderService();

        while (true) {
            Console.WriteLine("Enter a command (Create Client, Create Order, Exit):");
            string command = Console.ReadLine().Trim().ToLower();

            if (command == "exit")
            {
                break;
            }else if(command == "create client")
            {
                try
                {
                    Console.WriteLine("Enter Client ID:");
                    int clientId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter First Name:");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Enter Last Name:");
                    string lastName = Console.ReadLine();

                    Client client = clientService.CreateClient(clientId, firstName, lastName);

                    Console.WriteLine("Client Created:");
                    Console.WriteLine("Client ID: " + client.ClientId);
                    Console.WriteLine("First Name: " + client.FirstName);
                    Console.WriteLine("Last Name: " + client.LastName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error creating client: " + ex.Message);
                }
            }else if (command == "create order")
            {
                try
                {

                    // взять данные с Order
                    Console.WriteLine("Enter Order ID:");
                    int orderId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Order Description:");
                    string description = Console.ReadLine();

                    Console.WriteLine("Enter Order Price:");
                    decimal price = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter Order Date (yyyy-MM-dd):");
                    DateTime orderDate = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Enter Delivery Type (Express, Standard, Free):");
                    string deliveryType = Console.ReadLine();

                    Console.WriteLine("Enter Delivery Address:");
                    string deliveryAddress = Console.ReadLine();

                    // создать заказ с помощью orderService
                    Order order = orderService.CreateOrder(orderId, description, price, orderDate, deliveryType, deliveryAddress);

                    // вывести созданный товар
                    Console.WriteLine("Order Created:");
                    Console.WriteLine("Order ID: " + order.OrderId);
                    Console.WriteLine("Description: " + order.Description);
                    Console.WriteLine("Price: " + order.Price);
                    Console.WriteLine("Order Date: " + order.OrderDate);
                    Console.WriteLine("Delivery Type: " + order.DeliveryType);
                    Console.WriteLine("Delivery Address: " + order.DeliveryAddress);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error creating order: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid command. Please try again.");
            }
        }
    }
}
