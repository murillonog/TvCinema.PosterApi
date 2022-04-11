using AutoMapper;
using Microsoft.Extensions.Logging;
using TvCinema.PosterApi.Service.Application.DTOs;
using TvCinema.PosterApi.Service.Application.Interfaces;
using TvCinema.PosterApi.Service.Domain.Interfaces;

namespace TvCinema.PosterApi.Service.Application.Services
{
    public class PosterService : IPosterService
    {
        private readonly ILogger<PosterService> _logger;
        private readonly IMapper _mapper;
        private readonly IPosterRepository _posterRepository;

        public PosterService(
            ILogger<PosterService> logger, 
            IMapper mapper, 
            IPosterRepository posterRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _posterRepository = posterRepository;
        }

        public async Task<PostersDto> GetByImdbId(string imdbId)
        {
            try
            {
                return _mapper.Map<PostersDto>(await _posterRepository.GetByImdbId(imdbId));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                throw;
            }
        }
    }
}
