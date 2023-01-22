namespace LojaDeGames.Controllers;

using Microsoft.AspNetCore.Mvc;

[Route("/api/[controller]")]
[Produces("application/json")]
[ApiController]
public class BaseApiController<T> : ControllerBase
{

}