using System.Threading.Tasks;
using operations.api.dto;

namespace operations.api.services
{
    public interface IHubService
    {
        Task PublishOperationPendingAsync(OperationDto operation);
        Task PublishOperationCompletedAsync(OperationDto operation);
        Task PublishOperationRejectedAsync(OperationDto operation);
    }
}