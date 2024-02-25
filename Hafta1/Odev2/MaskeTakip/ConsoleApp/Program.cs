

using MaskeTakip.Business.Concrete;
using MaskeTakip.Entities.Concrete;

Person person1 = new Person()
{
    FirstName = "Şahin",
    LastName = "MARAL",
    DateOfBirthYear = 2000,
    NationalIdentity = 31192144607 //Geçersiz
};

PttManager pttManager = new PttManager(new PersonManager());
await pttManager.GiveMask(person1);