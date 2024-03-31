using P237_Nest.Services;

namespace Nest_AspNet.Services
{
    public interface ILayoutService
    {
        Task<UserGetDto> GetUser();
    }
}
