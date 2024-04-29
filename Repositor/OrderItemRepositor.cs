using System.Linq;
using System.Threading.Tasks;

namespace _teste01 {

    public class OrderItemRepositor {
        public void Save(OrderItem orderItem) {
            DataSet.OrdersItems.Add(orderItem);
        }

        public OrderItem Retrieve(int id) {
            foreach(var o in DataSet.OrdersItems) {
                if( o.OrderItemId == id) {
                    return o;
                }

            }

            return null;
        }
    }

}
