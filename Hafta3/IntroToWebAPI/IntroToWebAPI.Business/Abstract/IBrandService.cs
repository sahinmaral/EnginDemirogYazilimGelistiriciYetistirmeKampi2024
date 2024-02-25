using IntroToWebAPI.Business.Dtos.Requests;
using IntroToWebAPI.Business.Dtos.Responses;

namespace IntroToWebAPI.Business.Abstract;

public interface IBrandService
{
    CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);
    List<GetAllBrandResponse> GetAll();
}