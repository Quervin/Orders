using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orders.Backend.Data;
using Orders.Backend.UnitsOfWork.Interfaces;
using Orders.Shared.Entites;

namespace Orders.Backend.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class CountriesController : GenericController<Country>
{
    public CountriesController(IGenericUnitOfWork<Country> unitOfWork) : base(unitOfWork)
    {
    }
}