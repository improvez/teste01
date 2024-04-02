using System.Linq;
using System.Threading.Tasks;

namespace _teste01 {
    public class Order {
        public Customer Customer {get;set;}
        public DateTime OrderDate {get;set;}
        public string ShippingAddress {get;set;}
        public List<OrderItem> OrderItems {get;set;}
        public bool Validate() {
            return true;
        }
        public Order Retrieve() {
            return new Order();
        }

        public void Save(Order order) {

        }
    }

}
