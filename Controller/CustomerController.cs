using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace _teste01 {

    public class CustomerController {

        private CustomerRepositor customerRepositor;

        public CustomerController() {
            customerRepositor = new CustomerRepositor();
        }
        public void Insert(Customer customer) {
            customerRepositor.Save(customer);

        }
        public Customer Get(int id) {
            return customerRepositor.Retrieve(id);
        }

        public Customer Delete(int id) {
            return customerRepositor.Retrieve(id);
        }

        public List<Customer> Get() {
            return customerRepositor.Retrieve();
        }

        public List<Customer> GetByName(string name) {
            return customerRepositor.RetrieveByName(name);
        }

        public bool ExportToDelimited() {
            List<Customer> list = customerRepositor.Retrieve();

            string fileContent = string.Empty;
            foreach(var c in list) {
                fileContent += $"{c.PrintToExportDelimited()}\n";
            }
            string fileName = $"Customer_{DateTimeOffset.Now.ToUnixTimeSeconds()}.txt";
            
            return ExportToFile.SaveToDelimitedTxt(fileName, fileContent);
        }

        public string ImportFromDelimited(string filePath, string delimiter) {

            bool result = true;
            string msgReturn = string.Empty;
            int lineCountSuccess = 0;
            int lineCountError = 0;
            int lineCountTotal = 0;
            try
            {
                if(!File.Exists(filePath))
                return "ERRO: Arquivo de importação não encontrado.";

                using(StreamReader sr = new StreamReader(filePath)) {
                    string line = string.Empty;
                    while((line = sr.ReadLine()) != null) {
                        lineCountTotal++;
                        if(!customerRepositor.ImportFromTxt(line, delimiter)) {
                            result = false;
                            lineCountError++;
                        } else {
                            lineCountSuccess++;
                        }

                    }
                }
            }
            catch (System.Exception ex)
            {
                return $"ERRO: {ex.Message}";
            }
            if(result) {
                msgReturn = "Dados importados com sucesso.";


            } else {
                msgReturn = "Dados parcialmente importados.";
            }

            msgReturn += $"\nTotal de linhas: {lineCountTotal}";
            msgReturn += $"\n Sucesso: {lineCountSuccess}";
            msgReturn += $"\n Erro: {lineCountError}";

            return msgReturn;
        }

    }
}