using Newtonsoft.Json;

<<<<<<< HEAD
namespace BlogUNAHApi.Dtos.Common
=======
namespace Application_books.Dtos.Common
>>>>>>> rama-libro-crud
{
    public class ResponseDto<T>
    {
        public T Data { get; set; }

        public string Message { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public bool Status {  get; set; }
    }
}
