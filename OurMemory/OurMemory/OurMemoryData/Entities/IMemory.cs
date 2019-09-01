namespace OurMemoryData.Entities
{
    public interface IMemory
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
    }
}
