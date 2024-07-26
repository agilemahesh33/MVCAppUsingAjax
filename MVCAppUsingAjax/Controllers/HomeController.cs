using System;
using System.Web.Mvc;
using System.Xml.Linq; //For using LINQ to XML

namespace MVCAppUsingAjax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public String GetScore()
        {
            //Gets the physical path of the file for the given virtual path
            string physicalPath = Server.MapPath("~/Matches/Score.xml");
            //Loads the XML file into the application from the specified location
            var doc = XElement.Load(physicalPath);
            //Reads the value or content of "Score" element from the xml file which is loaded.
            string score = doc.Element("Score").Value;
            return score;

            //Above code can be written using single line 
            //XElement.Load(Server.MapPath("~/Matches/Score.xml")).Element("Score").Value;
        }
    }
}