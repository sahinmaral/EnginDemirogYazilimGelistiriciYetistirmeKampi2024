using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;
using MernisServiceReference;

namespace MaskeTakip.Business.Concrete;

public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {

    }

    public List<Person> GetList()
    {
        return null;
    }

    public async Task<bool> CheckPersonAsync(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        var dogrulaResult = await client.TCKimlikNoDogrulaAsync
        (TCKimlikNo: person.NationalIdentity,
        Ad: person.FirstName,
        Soyad: person.LastName,
        DogumYili: person.DateOfBirthYear);

        return dogrulaResult.Body.TCKimlikNoDogrulaResult;
    }
}
