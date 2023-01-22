using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IPaymentMethodRepository
    {
        void AddPaymentMethod(PaymentMethod paymentMethod);
        void RemovePaymentMethod(PaymentMethod paymentMethod);
        void UpdatePaymentMethod(PaymentMethod paymentMethod);
        PaymentMethod GetPaymentMethod(long id);
        ICollection<PaymentMethod> GetAllPaymentMethods();
        PaymentType GetTypeForPaymentMethod(long id);
        //ApplicationUser GetUserForPaymentMethod(long id);
    }
}
