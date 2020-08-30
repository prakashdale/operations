using operations.api.types;

namespace operations.api.dto
{
    public class OperationDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public OperationState State { get; set; }
        public string Code { get; set; }
        public string Reason { get; set; }
    }
}