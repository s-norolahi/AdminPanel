using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IInvoiceRepository
    {
        void AddInvoice(Invoice invoice);
        void RemoveInvoice(Invoice invoice);
        void UpdateInvoice(Invoice invoice);
        Invoice GetInvoice(long id);
        ICollection<Invoice> GetAllInvoices();
        ApplicationUser GetUserForInvoice(long id);
        Order GetOrderForInvoice(long id);
        ICollection<InvoiceDetail> GetDetailsForInvoice(long id);
    }
}
