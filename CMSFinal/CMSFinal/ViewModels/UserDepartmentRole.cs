using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CMSFinal.Models;

namespace CMSFinal.ViewModels
{
    public class UserDepartmentRole
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string DepartmentName { get; set; }

        public string RoleName { get; set; }
    }
}