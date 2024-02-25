using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;

namespace MaskeTakip.Business.Concrete;

public class PttManager : ISupplyService
{
    private readonly IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }

    public async Task GiveMask(Person person)
    {
        var isPersonReal = await _applicantService.CheckPersonAsync(person);

        if (isPersonReal)
            Console.WriteLine(person.FirstName + " için maske verildi");
        else
            Console.WriteLine("Girilen kullanıcı geçerli değildir");
    }
}