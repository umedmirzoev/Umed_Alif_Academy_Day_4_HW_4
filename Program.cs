using Umed_Alif_Academy_Day_4_HW_4;

public class Program
{
    public static void Main()
    {
        // Services
        ClientService clientService = new ClientService();
        OrderService orderService = new OrderService();

        while (true) {
            Console.WriteLine("Веберите опцию (Создать клиета, Создать заказ, Выход): ");
            string command = Console.ReadLine().Trim().ToLower();

            if (command == "выход")
            {
                break;
            }else if(command == "создать клиента")
            {
                try
                {
                    Console.WriteLine("Введите ID клиента:");
                    int clientId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите Имя:");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Введите Фамилию:");
                    string lastName = Console.ReadLine();

                    Client client = clientService.CreateClient(clientId, firstName, lastName);

                    Console.WriteLine("Поздравляем Клиент Создан:");
                    Console.WriteLine("Клиент ID: " + client.ClientID);
                    Console.WriteLine("Имя: " + client.FirstName);
                    Console.WriteLine("Фамилия: " + client.LastName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка при создании клиента: " + ex.Message);
                }
            }else if (command == "создать заказ")
            {
                try
                {

                    // взять данные с Order
                    Console.WriteLine("Введите номер заказа:");
                    int orderId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите описание заказа:");
                    string description = Console.ReadLine();

                    Console.WriteLine("Введите цену заказа:");
                    decimal price = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Введите дату заказа (yyyy-MM-dd):");
                    DateTime orderDate = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Введите способ доставки (Express, Standard, Free):");
                    string deliveryType = Console.ReadLine();

                    Console.WriteLine("Введите адрес доставки:");
                    string deliveryAddress = Console.ReadLine();

                    // создать заказ с помощью orderService
                    Order order = orderService.CreateOrder(orderId, description, price, orderDate, deliveryType, deliveryAddress);

                    // вывести созданный товар
                    Console.WriteLine("Заказ создан:");
                    Console.WriteLine("Номер заказа: " + order.OrderID);
                    Console.WriteLine("Описание: " + order.Description);
                    Console.WriteLine("Цена: " + order.Price);
                    Console.WriteLine("Дата заказа: " + order.OrderDate);
                    Console.WriteLine("Способ доставки: " + order.DeliveryType);
                    Console.WriteLine("Адрес доставки: " + order.DeliveryAddress);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка при создании заказа: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Не известная команда. Пожалуйста попробуйте сново.");
            }
        }
    }
}
