using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;

namespace MaskeTakip.Business.Concrete;

public class ForeignManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CheckPersonAsync(Person person)
    {
        throw new NotImplementedException();
    }

    public List<Person> GetList()
    {
        throw new NotImplementedException();
    }
}