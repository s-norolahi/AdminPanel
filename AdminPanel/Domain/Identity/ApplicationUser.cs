using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UserDetail> Details { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<PaymentMethod> PaymentMethods { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
