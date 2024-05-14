using System.Linq;
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

        public List<Customer> Get() {
            return customerRepositor.Retrieve();
        }

        public List<Customer> GetByName(string name) {
            return customerRepositor.RetrieveByName(name);
        }
    }
}