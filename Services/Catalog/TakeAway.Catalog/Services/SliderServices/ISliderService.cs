using TakeAway.Catalog.Dtos.SliderDtos;

namespace TakeAway.Catalog.Services.SliderServices
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetAllSliderAsync();
        Task CreateSliderAsync(CreateSliderDto createSliderDto);
        Task UpdateSliderAsync(UpdateSliderDto updateSliderDto);
        Task DeleteSliderAsync(string id);
        Task<GetByIdSliderDto> GetByIdSliderAsync(string id);
    }
}
