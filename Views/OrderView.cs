using System.Linq;
using System.Threading.Tasks;

namespace _teste01 {

    public class OrderView
    {

        public OrderView()
        {
            this.Init();
        }
        
        public void Init()
        {
            Console.WriteLine("MENU ORDER");
            Console.WriteLine("*************");
            Console.WriteLine("");

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Ordem");
                Console.WriteLine("2 - Pesquisar Ordem");
                Console.WriteLine("3 - Listar Ordens");
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

    }
}