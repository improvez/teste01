using System.Linq;
using System.Threading.Tasks;

namespace _teste01 {

    public class AddressController {

        private AddressRepositor addressRepositor;

        public AddressController() {
            this.addressRepositor = new AddressRepositor();
        }
        
        public Address Insert(Address address) {
            this.addressRepositor.Save(address);
            return address;
        }
    }
}