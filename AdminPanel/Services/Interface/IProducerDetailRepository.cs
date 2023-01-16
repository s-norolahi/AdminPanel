using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IProducerDetailRepository
    {
        void AddProducerDetail(ProducerDetail producerDetail);
        void RemoveProducerDetail(ProducerDetail producerDetail);
        void UpdateProducerDetail(ProducerDetail producerDetail);
        ProducerDetail GetProducerDetail(long id);
        ICollection<ProducerDetail> GetAllProducerDetails();
        Producer GetProducerForProducerDetail(long id);
    }
}
