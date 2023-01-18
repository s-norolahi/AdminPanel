using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class InvoiceRepository: IInvoiceRepository
    {
        public void AddInvoice(Invoice invoice)
        {
            context.Invoices.Add(invoice);
            context.SaveChanges();
        }

        public void RemoveInvoice(Invoice invoice)
        {
            context.Invoices.Remove(invoice);
            context.SaveChanges();
        }

        public void UpdateInvoice(Invoice invoice)
        {
            context.Invoices.Update(invoice);
            context.SaveChanges();
        }

        public Invoice GetInvoice(long id)
        {
            return context.Invoices.Find(id);
        }

        public ICollection<Invoice> GetAllInvoices()
        {
            return context.Invoices.ToList();
        }

        public ApplicationUser GetUserForInvoice(long id)
        {
            return context.Invoices.Find(id)?.ApplicationUser;
        }

        public Order GetOrderForInvoice(long id)
        {
            return context.Invoices.Find(id)?.Order;
        }

        public ICollection<InvoiceDetail> GetDetailsForInvoice(long id)
        {
            return context.Invoices.Find(id)?.Details;
        }
    }
}
