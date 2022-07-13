using Admin_API.Models;
using Admin_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin_API.Service
{
    public class ServiceAdmin : IServiceAdmin<AdminDetail>
    {
        private readonly IAdminRepo<AdminDetail> adminRepo;
        public ServiceAdmin(IAdminRepo<AdminDetail> adetails)
        {
            adminRepo = adetails;
        }

        public List<AdminDetail> getAdmin()
        {
            return adminRepo.getAdminDetails();
        }

    }
}
