using Admin_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin_API.Repository
{
    public interface IAdminRepo<AdminDetail>
    {
        public List<AdminDetail> getAdminDetails();
    }
}
