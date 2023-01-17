using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IProducerRepository
    {
        void AddProducer(Producer producer);
        void RemoveProducer(Producer producer);
        void UpdateProducer(Producer producer);
        Producer GetProducer(int id);
        ICollection<Producer> GetAllProducers();
        ICollection<ProducerDetail> GetDetailsForProducer(int id);
    }
}
