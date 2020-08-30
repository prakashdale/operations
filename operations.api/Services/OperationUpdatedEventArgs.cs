using System;
using operations.api.dto;

namespace operations.api.services
{
    public class OperationUpdatedEventArgs : EventArgs
    {
        public OperationDto Operation { get; }

        public OperationUpdatedEventArgs(OperationDto operation)
        {
            Operation = operation;
        }
    }
}