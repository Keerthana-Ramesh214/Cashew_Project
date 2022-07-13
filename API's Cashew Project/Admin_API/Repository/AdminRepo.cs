using Admin_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin_API.Repository
{
    public class AdminRepo : IAdminRepo<AdminDetail>
    {
        private readonly ShoppingContext db;
        public AdminRepo(ShoppingContext _db)
        {
            db = _db;
        }

        public List<AdminDetail> getAdminDetails()
        {
            return db.AdminDetails.ToList();
        }
    }
}
