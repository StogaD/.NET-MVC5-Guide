using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTestApp.ViewModels
{
    public class CustomerModelView
    {
        public int customerId { get; set; }
        public string name { get; set; }
        public string ForeName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}