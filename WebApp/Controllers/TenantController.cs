using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class TenantController : Controller
    {
        public ActionResult Index()
        {
            var tenants = new List<Tenant>()
            {
                new Tenant
                {
                    Name = "SVCC"
                    ,DomainName = "www.siliconcvalley-codecamp.com"
                    ,Id = 1
                    ,Default = true
                },
                new Tenant
                {
                    Name = "ANGU"
                    ,DomainName = "angularu.com"
                    ,Id = 3
                    ,Default = false
                },
                new Tenant
                {
                    Name = "CSSC"
                    ,DomainName = "codestartssummit.com"
                    ,Id = 2
                    ,Default = false
                },
            };
            return View(tenants);
        }

    }
}