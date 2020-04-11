using StudentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentBlazor.Services
{
    public class NavBarService 
    {
        private readonly BlazorDbContext _db;

        public NavBarService(BlazorDbContext db)
        {
            _db = db;
        }

        public List<NavBarInfo> GetNav()
        {
            var result = _db.NavBarInfo.ToList();

            return result;
        }
        public string AddNavBar(NavBarInfo nav)
        {
            if (_db.NavBarInfo.Any(x => x.LinkName == nav.LinkName))
            {
                return "Can not generate link with same name with same name";
            }
            else
            {
                _db.NavBarInfo.Add(nav);
                _db.SaveChanges();
                return "Successfully";

            }
        }
    }
}
