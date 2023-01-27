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
    public class ProducerDetailRepository//: IProducerDetailRepository
    {
        /*
        private ApplicationDbContext context;

        public ProducerDetailRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void AddProducerDetail(ProducerDetail producerDetail)
        {
            context.ProducerDetails.Add(producerDetail);
            context.SaveChanges();
        }

        public void RemoveProducerDetail(ProducerDetail producerDetail)
        {
            context.ProducerDetails.Remove(producerDetail);
            context.SaveChanges();
        }

        public void UpdateProducerDetail(ProducerDetail producerDetail)
        {
            context.ProducerDetails.Update(producerDetail);
            context.SaveChanges();
        }

        public ProducerDetail GetProducerDetail(long id)
        {
            return context.ProducerDetails.Find(id);
        }

        public ICollection<ProducerDetail> GetAllProducerDetails()
        {
            return context.ProducerDetails.ToList();
        }

        public Producer GetProducerForProducerDetail(long id)
        {
            return context.Producers.Find(
                context.ProducerDetails.Find(id)?.ProducerID
            );
        }
        */
    }
}
