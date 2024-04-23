using _teste01;

bool aux = true;
do{
    Console.WriteLine("**********************");
    Console.WriteLine("MEU PROGRAMA DE PEDIDOS");
    Console.WriteLine("**********************");
    Console.WriteLine();

    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Produtos");
    Console.WriteLine("3 - Pedidos");
    Console.WriteLine("0 - SAIR");

    int menu = 0;

    try
    {
        menu = Convert.ToInt32(Console.ReadLine());

        switch(menu)
        {
            case 1:
                CustomerView customerView = 
                    new CustomerView();
            break;
            
            case 2:
                ProductView productView = new ProductView();
            break;

            case 3:
                OrderView orderView = new OrderView();
            break;

            case 0:
                aux = false;
                Console.WriteLine("Obrigado e volte sempre!");
            break;

            default:
                Console.WriteLine("Opção inválida.");                         
            break;
        }
    }
    catch
    {
        Console.WriteLine("Opção inválida.");
        menu = -1;
        aux = true;
    }

}while(aux);

/*
System.Console.WriteLine("hello2");

Customer c1 = new Customer();
c1.CustomerId = 1;
c1.Name = "Jaguara";
c1.EmailAddress = "jaguara@pixote.net";

// Construtor por Instanciação
Customer c2 = new Customer(2);
c1.Name = "Boca-Mole";
c1.EmailAddress = "bocamole@pixote.net";

// Construtor por atribuição
Customer c3 = new Customer{
    CustomerId = 3,
    Name = "Nerso",
    EmailAddress = "nerso@quixote.com",
};

*/