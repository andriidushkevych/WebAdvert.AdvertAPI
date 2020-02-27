using System.Threading.Tasks;
using AdvertApi.Models;

namespace AdvertAPI.Services
{
    public interface IAdvertStorageService
    {
        Task<string> Add(AdvertModel model);
        Task Confirm(ConfirmAdvertModel model);
    }
}
