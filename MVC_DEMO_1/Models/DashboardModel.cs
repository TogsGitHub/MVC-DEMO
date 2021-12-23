using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DEMO_1.Models
{
    public class DashboardModel
    {
        public SelectList YearLists { get; set; }
        public int DropDownOne { get; set; }
        public int DropDownTwo { get; set; }
        public int DropDownThree { get; set; }
        public int DropDownFour { get; set; }
    }
}