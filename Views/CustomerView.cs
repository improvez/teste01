using System.Linq;
using System.Threading.Tasks;

namespace _teste01 {

    public class CustomerView
    {

        private CustomerController customerController;
        private AddressView addressView;

        public CustomerView()
        {
            addressView = new AddressView();
            customerController = new CustomerController();
            this.Init();
        }
        
        public void Init()
        {
            Console.WriteLine("MENU CUSTOMER");
            Console.WriteLine("*************");
            Console.WriteLine("");

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Consumidor");
                Console.WriteLine("2 - Pesquisar Consumidor");
                Console.WriteLine("3 - Listar Consumidores");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch(menu)
                    {
                        case 0:
                            aux = false;
                        break;
                        case 1:
                        break;
                        case 2:
                        break;
                        case 3: 
                        break;
                        default: 
                            Console.WriteLine("Opção inválida.");
                            aux = true;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Opção inválida.");
                    menu = -1;
                }                
            }while(aux);
        }

        private void InsertCustomer() {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("INSERIR NOVO CONSUMIDOR");
            Console.WriteLine("*******************************************************");

            Customer customer = new Customer();
            Console.WriteLine("Nome: ");
            customer.Name = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Email: ");
            customer.EmailAddress = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Deseja informar endereço?");

            int aux = 0;
            do {
                Console.WriteLine("0 - NÃO");
                Console.WriteLine("1 - SIM");

                try {
                    aux = Convert.ToInt32(Console.ReadLine());
                    if(aux == 1) {
                        // carga endereço
                        customer.Addresses.Add(AddressView.Insert());
                    } else if(aux == 0){
                        break;
                    } else {
                        aux = 1;
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("Tente novamente");    
                    }
                }
                catch {
                    aux = 1;
                    Console.WriteLine("Opção inválida");
                    Console.WriteLine("Tente novamente");
                }
            }while(aux != 0);
        }

    }
}