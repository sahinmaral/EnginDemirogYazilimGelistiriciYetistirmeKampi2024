using IntroToWebAPI.Core.Entities;

namespace IntroToWebAPI.Entities.Concrete;

public class Brand : BaseEntity<string>
{
    public string Name { get; set; }
}