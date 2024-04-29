using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using _teste01;

namespace _teste01 {

    public class CustomerRepositor {
        public void Save(Customer customer) {
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

        public List<Customer> SearchByName(string name)
        {
            if (name.Length < 4) return new List<Customer>();
            name = name.ToLower();
            return DataSet.Customers.Where(c => c.Name.ToLower().Contains(name)).ToList();
        }

    }

}
