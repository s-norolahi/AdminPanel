using Domain.Entities;
using InfraStructure;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class InvoiceDetailRepository //: IInvoiceDetailRepository
    {
        /*
        private ApplicationDbContext context;

        public InvoiceDetailRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void AddInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            context.InvoiceDetails.Add(invoiceDetail);
            context.SaveChanges();
        }

        public void RemoveInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            context.InvoiceDetails.Remove(invoiceDetail);
            context.SaveChanges();
        }

        public void UpdateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            context.InvoiceDetails.Update(invoiceDetail);
            context.SaveChanges();
        }

        public InvoiceDetail GetInvoiceDetail(long id)
        {
            return context.InvoiceDetails.Find(id);
        }

        public ICollection<InvoiceDetail> GetAllInvoiceDetails()
        {
            return context.InvoiceDetails.ToList();
        }

        public Invoice GetInvoiceForInvoiceDetail(long id)
        {
            return context.InvoiceDetails.Find(id)?.Invoice;
        }

        public Product GetProductForInvoiceDetail(long id)
        {
            return context.InvoiceDetails.Find(id)?.Product;
        }
        */
    }
}
