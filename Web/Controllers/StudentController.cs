using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services.StudentServices.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class StudentController : Controller
    {

        private readonly IGetAllStudentsQuery _IGetAllStudentsQuery;

        // Controller
        public StudentController(IGetAllStudentsQuery iGetAllStudentsQuery)
        {
            _IGetAllStudentsQuery = iGetAllStudentsQuery;
        }


        // Index
        public IActionResult Index()
        {
            return View();
        }



        // Get All Students
        public IActionResult GetAll_Students()
        {
            _IGetAllStudentsQuery.GetAll_Students();

            return View();
        }
    }
}
