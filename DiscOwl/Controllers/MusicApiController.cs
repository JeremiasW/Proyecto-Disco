using DiscOwl.BusinessAccessLayer;
using DiscOwl.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DiscOwl.Controllers
{
    public class MusicApiController : ApiController
    {
        [HttpPost]
        public ICollection<DiscViewModel> Get()
        {
            DiscBusiness bal = new DiscBusiness();

            return bal.Get();
        }

        [HttpPost]
        public ICollection<DiscViewModel> SearchByName(String name)
        {
            DiscBusiness bal = new DiscBusiness();

            return bal.GetByName(name);
        }
    }
}