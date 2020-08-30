using Convey.CQRS.Queries;
using operations.api.dto;

namespace operations.api.queries
{
    public class GetOperation : IQuery<OperationDto>
    {
        public string OperationId { get; set; }
    }
}