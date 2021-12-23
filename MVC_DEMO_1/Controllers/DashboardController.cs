using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DEMO_1.Models;

namespace MVC_DEMO_1.Controllers
{
    public class DashboardController : Controller
    {
        DashboardModel objModel = new DashboardModel();
        List<SelectListItem> ddlYears = new List<SelectListItem>();
        public static DashboardModel cMain;
        public ActionResult Index()
        {
            ModelState.Clear();
            cMain = new DashboardModel();
            objModel.YearLists = cMain.YearLists = GetYears(DateTime.Now.Year);
            objModel.DropDownOne = DateTime.Now.Year;
            objModel.DropDownTwo = DateTime.Now.Year;
            objModel.DropDownThree = DateTime.Now.Year;
            objModel.DropDownFour = DateTime.Now.Year;
            return View(objModel);
        }


        public SelectList GetYears(int? iSelectedYear)
        {
            int CurrentYear = DateTime.Now.Year;
            int yearId = 0;

            for (int i = 2019; i <= CurrentYear; i++)
            {
                yearId = yearId + 1;
                ddlYears.Add(new SelectListItem
                {
                    Text = i.ToString(),
                    Value = i.ToString()
                });
            }

            return new SelectList(ddlYears, "Value", "Text", iSelectedYear);
        }
    }
}