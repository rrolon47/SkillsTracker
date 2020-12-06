using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsController.Controllers
{
    public class SkillsController1 : Controller
    {
        //GET: /skills/
        [HttpGet("/skills/")]
        public IActionResult Index()
        {
            string html = $"<h1>Skills Tracker</h1>" +
                $"<h2>Programming Languages</h2>" +
                $"<ol>" +
                $"  <li>C#</li>" +
                $"  <li>JavaScript</li>" +
                $"  <li>Java</li>" +
                $"</ol>";


            return Content(html, "text/html");
        }

        //Get: /skills/form
        [HttpGet]
        [Route("/skills/form")]
        public IActionResult Form()
        {
            string progressDropDown = $"  <option value = 'Learning Basics' > Learning Basics </option>" +
                $"  <option value = 'Making Apps' > Making Apps </option>" +
                $"  <option value = 'Master Coder' > Master Coder </option>";

            string html = $"<form method ='post' action='/skills/form' >" +
                $"<label for='date'>Date: </lable>" +
                $"<input type='date' id='date' name='date'> " +
                $"<br>" +
                $"<label >Select learning progress for C#</lable>" +
                $" <select name = 'csharp'>" +
                $"{progressDropDown}" +
                $" </select>" +
                $"<br>" + 
                $"<label >Select learning progress for JavaScript</lable>" +
                $" <select name = 'js'>" +
                $"{progressDropDown}" +
                $" </select>" +
                $"<br>" +
                $"<label >Select learning progress for Java</lable>" +
                $" <select name = 'java'>" +
                $"{progressDropDown}" +
                $" </select>" +
                $"<br>" +
                $"<input type='submit' value='Submit'/>" +
                $"</form>";
                      
            return Content(html, "text/html");
        }

        [HttpPost]
        [Route("/skills/form")]
        public IActionResult FormResults(string date, string csharp, string js, string java)
        {
            //string html = $"<h1>Learning Progress: {date}</h1>" +
            //    $"<ol>" +
            //    $"  <li>C#: {csharp}</li>" +
            //    $"  <li>JavaScript: {js}</li>" +
            //    $"  <li>Java: {java}</li>" +
            //    $"</ol>";

            string html = $"<h1>Learning Progress as of {date}</h1>" + 
                $"<table>" +
                $"<tr>" +
                $"  <th>Programming Language</th>" +
                $"  <th>Skill Level</th>" +
                $"</tr>" +
                $"<tr>" +
                $"  <td>C#</td>" +
                $"  <td>{csharp}</td>" +
                $"</tr>" +
                $"<tr>" +
                $"  <td>JavaScript</td>" +
                $"  <td>{js}</td>" +
                $"</tr>" +
                $"<tr>" +
                $"  <td>Java</td>" +
                $"  <td>{java}</td>" +
                $"</tr>" +
                $"</table";

            return Content(html, "text/html");
        }
    }
}
