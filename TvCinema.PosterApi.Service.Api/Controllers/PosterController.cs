using Microsoft.AspNetCore.Mvc;
using TvCinema.PosterApi.Service.Application.DTOs;
using TvCinema.PosterApi.Service.Application.Interfaces;

namespace TvCinema.PosterApi.Service.Api.Controllers
{
    [ApiController]
    [Route("api/rating")]
    public class PosterController : Controller
    {
        private readonly IPosterService _posterService;

        public PosterController(IPosterService posterService)
        {
            _posterService = posterService;
        }

        [HttpGet("{imdbId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PostersDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(List<string>))]
        public async Task<IActionResult> Get(string imdbId)
        {
            try
            {
                var result = await _posterService.GetByImdbId(imdbId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message, null, null, null, null);
            }
        }
    }
}
