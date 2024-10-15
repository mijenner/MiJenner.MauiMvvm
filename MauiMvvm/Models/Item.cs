using MiJenner.ServicesGeneric;

namespace MauiMvvm.Models
{
    public class Item : IHasGuid 
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
