using System;

namespace OurMemory.Interfaces
{
    public interface IPost
    {
        Guid Id { get; set; }
        string Content { get; set; }
    }
}
