using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin_API.Service
{
    public interface IServiceAdmin<AdminDetail>
    {
        public List<AdminDetail> getAdmin();
    }
}
