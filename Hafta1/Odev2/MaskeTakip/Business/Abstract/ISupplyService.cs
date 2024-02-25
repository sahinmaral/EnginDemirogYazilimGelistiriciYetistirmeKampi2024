using MaskeTakip.Entities.Concrete;

namespace MaskeTakip.Business.Abstract;

public interface ISupplyService
{
    Task GiveMask(Person person);
}