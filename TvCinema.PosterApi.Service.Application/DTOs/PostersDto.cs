namespace TvCinema.PosterApi.Service.Application.DTOs
{
    public class PostersDto
    {
        public Guid Id { get; set; }
        public string? Link { get; set; }
        public double AspectRatio { get; set; }
        public string? Language { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string? ImdbId { get; set; }
    }
}
