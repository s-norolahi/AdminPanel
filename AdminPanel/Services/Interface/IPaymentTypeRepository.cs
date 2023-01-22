using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IPaymentTypeRepository
    {
        void AddPaymentType(PaymentType paymentType);
        void RemovePaymentType(PaymentType paymentType);
        void UpdatePaymentType(PaymentType paymentType);
        PaymentType GetPaymentType(int id);
        ICollection<PaymentType> GetAllPaymentTypes();
    }
}
