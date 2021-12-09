using E_commerce.Domain.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Domain.Exceptions
{
    public class ApiExceptions : ErrorResponse
    {


        public ApiExceptions(int statusCode, string msg = null, string details = null) : base(statusCode, msg)
        {
        }

        public string Details { get; set; }
    }
}
