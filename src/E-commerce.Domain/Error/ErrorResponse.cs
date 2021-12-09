using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Domain.Error
{
    public class ErrorResponse
    {
        public ErrorResponse(int statusCode, string msg = null)
        {
            StatusCode = statusCode;
            Message = msg ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "",
                401 => "",
                404 => "",
                500 => "",
                _ => null
            };
        }
    }
}
