using IntroToWebAPI.Business.Abstract;
using IntroToWebAPI.Business.Dtos.Requests;
using IntroToWebAPI.Business.Dtos.Responses;
using IntroToWebAPI.DataAccess.Abstract;
using IntroToWebAPI.Entities.Concrete;

namespace IntroToWebAPI.Business.Concrete;

public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
    {
        Brand newBrand = new Brand()
        {
            Name = createBrandRequest.Name,
            CreatedAt = DateTime.UtcNow
        };

        _brandDal.Add(newBrand);

        CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse()
        {
            Id = newBrand.Id,
            Name = newBrand.Name,
            CreatedAt = newBrand.CreatedAt
        };

        return createdBrandResponse;
    }

    public List<GetAllBrandResponse> GetAll()
    {
        var brands = _brandDal.GetAll();

        return brands.Select(x => new GetAllBrandResponse()
        {
            Name = x.Name,
            Id = x.Id,
            CreatedAt = x.CreatedAt
        }).ToList();
    }
}