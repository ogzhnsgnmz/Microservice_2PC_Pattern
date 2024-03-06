namespace Coordinator.Models;

public record Node(string Name)
{
    public Guid Id { get; set; }
    public ICollection<NodeState> NodeSatates { get; set; }
}
