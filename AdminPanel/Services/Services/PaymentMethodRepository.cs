﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PaymentMethodRepository: IPaymentMethodRepository
    {


        public void AddPaymentMethod(PaymentMethod paymentMethod)
        {
            context.PaymentMethods.Add(paymentMethod);
            context.SaveChanges();
        }

        public void RemovePaymentMethod(PaymentMethod paymentMethod)
        {
            context.PaymentMethods.Remove(paymentMethod);
            context.SaveChanges();
        }

        public void UpdatePaymentMethod(PaymentMethod paymentMethod)
        {
            context.PaymentMethods.Update(paymentMethod);
            context.SaveChanges();
        }

        public PaymentMethod GetPaymentMethod(long id)
        {
            return context.PaymentMethods.Find(id);
        }

        public ICollection<PaymentMethod> GetAllPaymentMethods()
        {
            return context.PaymentMethods.ToList();
        }

        public PaymentType GetTypeForPaymentMethod(long id)
        {
            return context.PaymentTypes.Find(
                context.PaymentMethods.Find(id)?.PaymentTypeID
            );
        }

        public ApplicationUser GetUserForPaymentMethod(long id)
        {
            return (ApplicationUser)context.Users.Find(
                context.PaymentMethods.Find(id)?.ApplicationUser
            );
        }
    }
}
