using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace SmBusiness.Pages
{
    public class CustomerModel : PageModel
    {
        List<CustomerList> customerList = new List<CustomerList>();
        public void OnGet()
        {
        }
    }

    public class CustomerList
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public int Years { get; set; }
    }
}
