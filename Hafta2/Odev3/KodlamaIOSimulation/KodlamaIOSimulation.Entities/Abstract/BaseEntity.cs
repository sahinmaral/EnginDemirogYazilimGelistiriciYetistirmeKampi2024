namespace KodlamaIOSimulation.Entities.Abstract;

public abstract class BaseEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
}