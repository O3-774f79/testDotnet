using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DS.Report.Services.CA;
using DS.Report.Services.Shared;
using System.Web.Mvc;

namespace DS.Report.Controllers.CA
{
    public class CAController : Controller
    {
        public void SubmitReport()
        {
            var service = new CAService();
            service.SubmitReport();
        }
    }
}