using System.Linq;
using System.Threading.Tasks;
using _teste01;

namespace _teste01 {

    public class DataSet {
            public static List<Address> Addresses {get;set;} = new List<Address>();
            public static List<Customer> Customers {get;set;} = new List<Customer>();

            public static List<Product> Products {get;set;}
            public static List<Order> Orders {get;set;}
            public static List<OrderItem> OrdersItems {get;set;} 
         }

}
