using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeApp.Data;
using EmployeeApp.Models;

namespace EmployeeApp.Controllers
{
	public class ContactUs : Controller
	{
		public IActionResult Index()
		{
			return View("ContactUs");
		}
	}
}