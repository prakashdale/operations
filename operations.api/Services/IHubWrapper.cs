using System.Threading.Tasks;

namespace operations.api.services
{
    public interface IHubWrapper
    {
        Task PublishToUserAsync(string userId, string message, object data);
        Task PublishToAllAsync(string message, object data);
    }
}