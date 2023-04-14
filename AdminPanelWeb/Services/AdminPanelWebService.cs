using AdminPanelWeb.Models;
using AdminPanelWeb.Helpers;
using AdminPanelWeb.Services.Interfaces;

namespace AdminPanelWeb.Services
{
    public class AdminPanelWebService : IAdminPanelWeb
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/find";

        public AdminPanelWebService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<UserModel>> Find()
        {
            var response = await _client.GetAsync(BasePath);

            return await response.ReadContentAsync<List<UserModel>>();
        }

       
    }
}

