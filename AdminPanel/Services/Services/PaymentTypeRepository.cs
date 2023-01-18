using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PaymentTypeRepository: IPaymentTypeRepository
    {

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
    }
}
