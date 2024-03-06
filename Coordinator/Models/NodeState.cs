using Coordinator.Enums;

namespace Coordinator.Models;

public record NodeState(Guid TransactionId)
{
    public Guid Id { get; set; }
    public ReadyType IsReady { get; set; } // 1. Aşama durumu.
    public TransactionState TransactionState { get; set; } // 2. Aşama sonuç.
    public Node Node { get; set; }
}