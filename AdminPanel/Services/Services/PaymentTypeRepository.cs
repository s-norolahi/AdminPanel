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
    public class PaymentTypeRepository//: IPaymentTypeRepository
    {
        /*
        private ApplicationDbContext context;

        public PaymentTypeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void AddPaymentType(PaymentType paymentType)
        {
            context.PaymentTypes.Add(paymentType);
            context.SaveChanges();
        }

        public void RemovePaymentType(PaymentType paymentType)
        {
            context.PaymentTypes.Remove(paymentType);
            context.SaveChanges();
        }

        public void UpdatePaymentType(PaymentType paymentType)
        {
            context.PaymentTypes.Update(paymentType);
            context.SaveChanges();
        }

        public PaymentType GetPaymentType(int id)
        {
            return context.PaymentTypes.Find(id);
        }

        public ICollection<PaymentType> GetAllPaymentTypes()
        {
            return context.PaymentTypes.ToList();
        }
        */
    }
}
