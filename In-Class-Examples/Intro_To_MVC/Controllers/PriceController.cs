using Intro_To_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Intro_To_MVC.Controllers
{
    public class PriceController : Controller
    {
        // GET: PriceController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MIS()
        {
            //            ViewBag.Division = "MIS";
            //            ViewBag.Description = @"At Price College, our Management Information Systems (MIS) Division prepares students for the dynamic world of digital information systems. Our innovative program goes beyond traditional education, fostering a collaborative environment where students explore new ideas and push learning boundaries. With a cutting-edge curriculum, hands-on experiences, and industry partnerships, we equip students with the skills, knowledge, and mindset to thrive in their careers.

            //Our expanded 21-credit curriculum includes advanced courses on emerging technologies and analytical skills, making our graduates highly competitive. MIS Majors can now complete the Business Intelligence and Analytics (BIA) Certificate by choosing the ""BIA"" track, gaining dual credentials that enhance marketability for data-centric roles.

            //We offer specialized tracks within the MIS major, such as Systems Analyst, Digital Transformation, and Application Developer, aligned with industry needs and technological trends. The revised curriculum includes practical, hands-on experiences like the project-based competition in MIS 3213 Business Data Analysis, judged by industry professionals.

            //Join us at Price College's MIS Division, where we shape the future of information systems and empower the next generation of leaders. Explore your potential with us!";
            Division mis = new Division()
            {
                Name = "MIS",
                Description = @"At Price College, our Management Information Systems (MIS) Division prepares students for the dynamic world of digital information systems. Our innovative program goes beyond traditional education, fostering a collaborative environment where students explore new ideas and push learning boundaries. With a cutting-edge curriculum, hands-on experiences, and industry partnerships, we equip students with the skills, knowledge, and mindset to thrive in their careers.",
                Director = "Dr. Alexandra Durcikova"
            };

            return View(mis);
        }

    }
}
