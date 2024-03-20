using DAL.Veh;
using DAL.Veh.Implementation;
using DAL.Veh.Model;
using Microsoft.EntityFrameworkCore;
using Service.Veh.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Veh.Implementation
{
    public class VehService : Repository<Vehicle>, IVehService
    {
        private VehDbContext _db;
        public VehService(DbContext db) : base(db)
        {
            _db = db as VehDbContext;
        }

        
    }
}
