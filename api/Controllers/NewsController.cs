using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Models;
using NewsApi.Services;

[ApiController]
[Route("api/[controller]")]
public class NewsController : ControllerBase
{
    private readonly NewsService _service;

    public NewsController(NewsService service) => _service = service;

    [HttpGet]
    public ActionResult<IEnumerable<NewsItem>> Get([FromQuery] string? q)
    {
        try
        {
            var result = _service.GetAll(q);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }
}
