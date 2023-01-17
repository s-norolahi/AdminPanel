using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IInvoiceDetailRepository
    {
        void AddInvoiceDetail(InvoiceDetail invoiceDetail);
        void RemoveInvoiceDetail(InvoiceDetail invoiceDetail);
        void UpdateInvoiceDetail(InvoiceDetail invoiceDetail);
        InvoiceDetail GetInvoiceDetail(long id);
        ICollection<InvoiceDetail> GetAllInvoiceDetails();
        Invoice GetInvoiceForInvoiceDetail(long id);
        Product GetProductForInvoiceDetail(long id);
    }
}
