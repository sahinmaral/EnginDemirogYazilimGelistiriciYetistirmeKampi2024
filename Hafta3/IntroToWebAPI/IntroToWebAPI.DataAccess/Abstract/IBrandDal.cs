using IntroToWebAPI.Entities.Concrete;

namespace IntroToWebAPI.DataAccess.Abstract;

public interface IBrandDal
{
    void Add(Brand brand);
    List<Brand> GetAll();
}