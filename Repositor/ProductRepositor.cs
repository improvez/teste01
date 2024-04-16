using System.Linq;
using System.Threading.Tasks;

namespace _teste01 {

    public class ProductRepositor {
        public void Save(Product product) {
            DataSet.Products.Add(product);
        }

        public Product Retrieve(int id) {
            foreach(var p in DataSet.Products) {
                if( p.ProductId == id) {
                    return p;
                }

            }

            return null;
        }

    }

}
