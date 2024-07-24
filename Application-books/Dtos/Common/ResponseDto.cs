﻿using Newtonsoft.Json;
namespace Application_books.Dtos.Common
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
