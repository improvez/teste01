using System.Linq;
using System.Threading.Tasks;

namespace _teste01 {
    public class Product {

        public int ProductId {get;set;}
        public string ProductName {get;set;}
        public string Description {get;set;}
        public float CurrentPrice {get;set;}
        public bool Validate() {
            return true;
        }
        public Product Retrieve() {
            return new Product();
        }

        public void Save(Product product) {

        }
    }
}