using Microsoft.AspNetCore.Mvc;
using Orders.Backend.UnitsOfWork.Interfaces;
using Orders.Shared.Entites;

namespace Orders.Backend.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class CategoriesController : GenericController<Category>
{
    public CategoriesController(IGenericUnitOfWork<Category> unitOfWork) : base(unitOfWork)
    {
    }
}