using IntroToWebAPI.Business.Abstract;
using IntroToWebAPI.Business.Dtos.Requests;
using Microsoft.AspNetCore.Mvc;

namespace IntroToWebAPI.WebAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class BrandsController : ControllerBase
{
    private readonly IBrandService _brandService;

    public BrandsController(IBrandService brandService)
    {
        _brandService = brandService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_brandService.GetAll());
    }

    [HttpPost]
    public IActionResult Add([FromBody] CreateBrandRequest request)
    {
        return Created("", _brandService.Add(request));
    }

}
