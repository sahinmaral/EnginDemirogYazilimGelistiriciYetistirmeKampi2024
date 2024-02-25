using MaskeTakip.Entities.Concrete;

namespace MaskeTakip.Business.Abstract;

public interface IApplicantService
{
    void ApplyForMask(Person person);
    List<Person> GetList();
    Task<bool> CheckPersonAsync(Person person);
}
