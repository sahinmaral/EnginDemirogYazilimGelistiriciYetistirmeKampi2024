using IntroToWebAPI.DataAccess.Abstract;
using IntroToWebAPI.Entities.Concrete;

namespace IntroToWebAPI.DataAccess.Concrete;

public class BrandDal : IBrandDal
{
    List<Brand> _brands;

    public BrandDal()
    {
        _brands = new List<Brand>(){
            new Brand(){Id = "de67f5e3-3463-4c05-b0d1-28e256dfd523",Name = "BMW",CreatedAt= DateTime.UtcNow},
            new Brand(){Id = "430d263c-c070-4cbe-8a68-5adb57c54603",Name = "Mercedes",CreatedAt= DateTime.UtcNow},
            new Brand(){Id = "3d001bf8-7ace-4072-baa7-79985055975a",Name = "Alfa Romeo",CreatedAt= DateTime.UtcNow},
        };
    }

    public void Add(Brand brand)
    {
        _brands.Add(brand);
    }

    public List<Brand> GetAll()
    {
        return _brands;
    }
}