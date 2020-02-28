
namespace AdvertApi.Models
{
    public class CreateAdvertResponse
    {
        public string Id { get; set; }

        public CreateAdvertResponse()
        {
            
        }

        public CreateAdvertResponse(string id)
        {
            Id = id;
        }
    }
}
