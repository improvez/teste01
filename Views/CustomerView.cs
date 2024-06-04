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
                Console.WriteLine("4 - Deletar Consumidor");
                Console.WriteLine("5 - Exportar dados delimitados");
                Console.WriteLine("6 - Importar dados delimitados");
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
                            InsertCustomer();
                        break;
                        case 2:
                            SearchCustomer();

                        break;
                        case 3:
                            ListCustomers(); 
                        break;
                        case 4:
                            DeleteCustomer();
                        break;
                        case 5:
                            if(customerController.ExportToDelimited()) {
                                Console.WriteLine("Arquivo criado com sucesso");
                            } else {
                                Console.WriteLine("Falha ao criar o arquivo");
                            }
                        break;
                        case 6:
                            ImportFromDelimited();
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

        private void ImportFromDelimited() {
            System.Console.WriteLine("Informe o caminho do arquivo: ");
            string pathFile = Console.ReadLine();

            System.Console.WriteLine("Informe o caracter delimitador");
            string delimiter = Console.ReadLine();

            string response = customerController.ImportFromDelimited(pathFile, delimiter);
            Console.WriteLine(response);
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
                        customer.Addresses.Add(addressView.Insert());
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

            try {
                customerController.Insert(customer);
                Console.WriteLine("Customer inserido com sucesso!");
            } catch {
                Console.WriteLine("Ops! Ocorreu um erro.");
            }
        }

        private void SearchCustomer() {

            int aux = -1;
            do {
                Console.WriteLine("PESQUISAR CLIENTE");
                Console.WriteLine("*********************");
                Console.WriteLine("1 - Buscar por id");
                Console.WriteLine("2 - Buscar por nome");
                Console.WriteLine("0 - Sair");

                string menuOpt = Console.ReadLine();
                aux = Convert.ToInt16(menuOpt);    
                switch(aux) {
                    case 1:
                        Console.WriteLine("Informe o id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        ShowCustomerById(id);
                    break;
                    case 2:
                        Console.WriteLine("Informe o nome: ");
                        string name = Console.ReadLine();
                        ShowCustomerByName(name);
                    break;
                    case 0:
                    break;
                    default:
                        aux = -1;
                        Console.WriteLine("Opção inválida!");
                    break;
                }

            } while(aux != 0);
        }

        private void ShowCustomerById(int id) {
            Customer c = customerController.Get(id);
            if(c != null) {
                Console.WriteLine(c.ToString());
            } else {
                Console.WriteLine($"Consumidor de id {id} não encontrado!");
            }
        }

        private void ShowCustomerByName(string name) {
            List<Customer> result = customerController.GetByName(name);
            // if(result == null) {
            //     Console.WriteLine("Não encontrado!");
            //     return;
            // }
            // if(result??result?.Count() == 0) {
            if(result == null || result?.Count == 0 && (result?.Count < 3)) {
                Console.WriteLine("Não encontrado!");
                return;
            }
            foreach(Customer customer in result) {
                Console.WriteLine(customer.ToString());
            }
        }

        private void ListCustomers() {
            List<Customer> result = customerController.Get();
            if(result == null || result?.Count == 0 && (result?.Count < 3)) {
                Console.WriteLine("Não encontrado!");
                return;
            }
            foreach(Customer customer in result) {
                Console.WriteLine(customer.ToString());
            }
        }

        private void DeleteCustomer() {
            int aux = -1;
            do {
                Console.WriteLine("PESQUISAR CLIENTE");
                Console.WriteLine("*********************");
                Console.WriteLine("1 - Buscar por id");
                Console.WriteLine("2 - Buscar por nome");
                Console.WriteLine("0 - Sair");

                string menuOpt = Console.ReadLine();
                aux = Convert.ToInt16(menuOpt);    
                switch(aux) {
                    case 1:
                        Console.WriteLine("Informe o id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        ShowCustomerById(id);
                    break;
                    case 2:
                        Console.WriteLine("Informe o nome: ");
                        string name = Console.ReadLine();
                        ShowCustomerByName(name);
                    break;
                    case 0:
                    break;
                    default:
                        aux = -1;
                        Console.WriteLine("Opção inválida!");
                    break;
                }

            } while(aux != 0);        
            return;
        }

        private void ExportCustomer() {

            return;
        }

    }
}