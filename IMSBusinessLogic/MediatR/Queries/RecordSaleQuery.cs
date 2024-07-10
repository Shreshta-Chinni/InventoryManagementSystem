using IMSDomain;
using MediatR;

namespace IMSBusinessLogic.MediatR.Queries
{
    public class RecordSaleQuery: IRequest<(List<Product>, List<string>)>
    {
        public List<Order> sales { get; set; }

        public RecordSaleQuery(List<Order> sales)
        {
            this.sales = sales;
        }
    }
}
