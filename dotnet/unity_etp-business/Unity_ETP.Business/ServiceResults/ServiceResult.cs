using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_ETP.Business.ServiceResults
{
    public class ServiceResult<T>
    {
        public T Result { get; set; }
        public List<T> Results { get; set; }
        public string ErrorMsg { get; set; }
        public int ErrorCode { get; set; }
    }
}
