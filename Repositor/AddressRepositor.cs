
using System.Linq;
using System.Threading.Tasks;

namespace _teste01 {

    public class AddressRepositor {
        public void Save(Address address) {
            DataSet.Addresses.Add(address);
        }

        public Address Retrieve(int id) {
            foreach(var a in DataSet.Addresses) {
                if( a.Id == id) {
                    return a;
                }

            }

            return null;
        }
    }

}
