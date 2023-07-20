using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services.Interfaces
{
    public class ProducersServices : EntityBaseRepository<ProducerModel>, IProducersServices
    {
        public ProducersServices(AppDbContext context) : base(context) { }
    }
}
