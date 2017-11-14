using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace dojoSurvey.Controllers{
    public class SurveyController: Controller{
        
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            ViewBag.Errors = new List<string>();
            return View();
        }
        [HttpPost]
        [Route("process")]
        public IActionResult Process(string yourName, string location, string language,string comment){

            ViewBag.Errors = new List<string>();
            if(yourName == null){
                ViewBag.Errors.Add("Name cannot be empty!");
            }
            if(location == null){
                ViewBag.Errors.Add("You must select a location!");
            }
            if(language == null){
                ViewBag.Errors.Add("Please select a location!");
            }
            if(comment == null){
                comment="";
            }
            if(ViewBag.Error.Count>0){
                return View("Index");
            }
            ViewBag.yourName=yourName;
            ViewBag.location=location;
            ViewBag.language=language;
            ViewBag.comment=comment;

            return View("Success");
        }
    }
}