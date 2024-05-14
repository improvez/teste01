using System.Linq;
using System.Threading.Tasks;

namespace _teste01 {

    public class AddressController {

        private AddressRepositor addressRepositor;

        public AddressController()
        {
            addressRepositor = new AddressRepositor();
        }

        public Address Insert(Address address)
        {            
            addressRepositor.Create(address);
            return address;
        }

        public Address Get(int id)
        {
            return addressRepositor.Read(id);
        }

        public List<Address> Get()
        {
            return addressRepositor.Read();
        }        
    }
}