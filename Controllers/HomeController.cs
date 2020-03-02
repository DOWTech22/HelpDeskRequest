
using System.IO;

using System.Web.Mvc;


// My Home controller and actions. thinking about deleting the about and contacts page.

namespace HelpDeskRequest.Controllers
{
    public class HomeController : Controller
    {
       

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string yourName, string calender, string techName, string info)
        {
           
            return Content($" Name: {yourName} <br/> ------------------ <br/> Date: {calender} <br/> ----------------- <br/>  Technician: {techName} <br/> ----------------- <br/> Information:<br/><br/>{info}");
        }

        public ActionResult About()
        {
            ViewBag.Message = "My final exam!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Email me";

            return View();
        }

        // Creating a file to save to.
        public void CreateFile(string yourName, string calender, string techName, string info)
        {
            
            //path has to be exacted.
            string fdir = @"C:\\Users\\DanWilliams\\Desktop\\test data\\HelpDeskDataList.csv";
            var path = new FileInfo(fdir);
            

            //TODO: have to get all input and store it to a .csv file.
            
           
            // This Creates a text file using streamWriter and write to file.
            using (StreamWriter sw = System.IO.File.AppendText(fdir))
            {
                
                sw.WriteLine($"Name: {yourName}");
                sw.WriteLine($"Date: {calender}");
                sw.WriteLine($"Technician: {techName}");
                sw.WriteLine($" Description: {info}");

                //close
                sw.Close();
                
            }
            

        }
    }
}