using WebApiIntro.Entities.Abstracts;

namespace WebApiIntro.Entities.Concretes;

public class CarGallery : BaseEntity
{
    public string? Name { get; set; }
    public int CarId { get; set; }
    public ICollection<Car>? Cars { get; set; }
}