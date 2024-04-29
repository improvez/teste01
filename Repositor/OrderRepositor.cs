using System.Linq;
using System.Threading.Tasks;

namespace _teste01 {

    public class OrderRepositor {

        public void Save(Order order) {
            DataSet.Orders.Add(order);
        }

        public Order Retrieve(int id) {
            foreach(var o in DataSet.Orders) {
                if( o.OrderId == id) {
                    return o;
                }

            }

            return null;
        }

    }

}