using AdminPanelApi.Models;
using AdminPanelWeb.Models;

namespace AdminPanelWeb.Services.Interfaces
{
    public interface IAdminPanelWeb
    {
        Task<IEnumerable<UserModel>> Find();
    }
}
