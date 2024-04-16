using System.Linq;
using System.Threading.Tasks;

namespace _teste01 {
    public class OrderItem {
        public int OrderItemId {get;set;}
        public Product Product {get;set;}
        public double Quantity {get;set;}

        public double PurchasePrice {get;set;}

        public bool Validate() {
            return true;
        }
        public OrderItem Retrieve() {
            return new OrderItem();
        }

        public void Save(OrderItem orderItem) {

        }
    }
}