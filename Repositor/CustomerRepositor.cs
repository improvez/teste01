using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using _teste01;

namespace _teste01 {

    public class CustomerRepositor {
        public void Save(Customer customer) {
            customer.CustomerId = this.GetNextId();
            DataSet.Customers.Add(customer);
        }

        public void Save(Customer customer, bool autoGenerateId = true) {
            if(autoGenerateId) customer.CustomerId = this.GetNextId();
            DataSet.Customers.Add(customer);
        }

        public Customer Retrieve(int id) {
            Customer customer = new Customer();
            customer = new Customer();
            foreach(var c in DataSet.Customers) {
                if( c.CustomerId == id) {
                    return c;
                }

            }

            return null;
        }
        public List<Customer> Retrieve() {
            return DataSet.Customers;
        }

        public List<Customer> RetrieveByName(string name) {
            List<Customer> retorno = new List<Customer>();
            foreach(var c in DataSet.Customers) {
                if(c.Name.Contains(name)) {
                    retorno.Add(c);
                }
            }
            return retorno;
        }

        public List<Customer> SearchByName(string name)
        {
            if (name.Length < 4) return new List<Customer>();
            name = name.ToLower();
            return DataSet.Customers.Where(c => c.Name.ToLower().Contains(name)).ToList();
        }

        public bool ImportFromTxt(string Line, string delimiter) {

            if(string.IsNullOrWhiteSpace(Line)) return false;

            string[] data = Line.Split(delimiter);

            if(data.Count() < 1) return false;

            Customer c = new Customer{
                CustomerId = Convert.ToInt32((data[0] == null ? 0 : data[0])),
                Name = (data[1] == null ? string.Empty : data[1]),
                EmailAddress = (data[2] ?? string.Empty)
            };

            Save(c, false);
            return true;

        }

        private int GetNextId() {
            int n = 0;
            foreach(var c in DataSet.Customers) {
                if(c.CustomerId > n) n = c.CustomerId; 
            }
            return ++n;
        }
    }

}
