using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProducerRepository: IProducerRepository
    {

        public void AddProducer(Producer producer)
        {
            context.Producers.Add(producer);
            context.SaveChanges();
        }

        public void RemoveProducer(Producer producer)
        {
            context.Producers.Remove(producer);
            context.SaveChanges();
        }

        public void UpdateProducer(Producer producer)
        {
            context.Producers.Update(producer);
            context.SaveChanges();
        }

        public Producer GetProducer(int id)
        {
            return context.Producers.Find(id);
        }

        public ICollection<Producer> GetAllProducers()
        {
            return context.Producers.ToList();
        }

        public ICollection<ProducerDetail> GetDetailsForProducer(int id)
        {
            return context.ProducerDetails.Where(pd => pd.ID == id).ToList();
        }
    }
}
