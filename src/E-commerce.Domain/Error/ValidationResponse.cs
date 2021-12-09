using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Domain.Error
{
    public class ValidationResponse : ErrorResponse
    {
        public ValidationResponse() : base(400)
        {

        }
        
        public IEnumerable<string> Errors { get; set; }
    }
}
