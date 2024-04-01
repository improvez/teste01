namespace _teste01 {
    public class Customer {
        public string Name {get;set;}
        public string EmailAddress {get;set;}
        public string HomeAddress {get;set;}
        public string WorkAddress {get;set;}

        public bool Validate() {
            return true;
        }

        public Customer Retrieve() {
            return new Customer();
        }

        public void Save(Customer customer) {
            
        }

    }
}