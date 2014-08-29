using MVC5Course.Automapper.Domain.BasicDomainExample;

namespace MVC5Course.Automapper.Models.Basic
{
    public class CustomerInfoViewModel
    {
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public void LoadCustomer(Customer customer)
        {
            this.Name = string.Format("{0} {1}",customer.FirstName,customer.LastName);
            this.Address1 = customer.Address1;
            this.Address2 = customer.Address2;
            this.City = customer.City;
            this.State = customer.State;
            this.Zip = customer.Zip;
        }
    }
}