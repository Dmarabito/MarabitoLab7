using MarabitoLab7.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MarabitoLab7.Controllers
{
    public class HomeController : Controller
    {
        //public TodoListItem? ListItemData { get; set; } = new TodoListItem() {completionStatus=false,itemDescription="Blah" ,priority=0 };


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm] bool bind, [FromForm]TodoListItem ListItemData)
        {
            //TodoListItem ListItemData = new TodoListItem() { completionStatus = false, itemDescription = "Blah", priority = 0 };
            if (bind)
            {
                await TryUpdateModelAsync<TodoListItem>(ListItemData, "", Todo => Todo.completionStatus,Todo => Todo.itemDescription,Todo => Todo.priority);
                //ListItemData.completionStatus = Request.Form["completionStatus"] == "on" ? true : true;
                //Console.WriteLine(ListItemData);
                //return View(ListItemData);
                //await TryUpdateModelAsync(ListItemData, "", l => l.completionStatus);
                return View("Results", ListItemData);
            }
            else { 
                //This is just at this point to make all paths return a view.
                return View("Results", ListItemData);
                //return View("Results", ListItemData);
            }
        }

        public IActionResult Results()
        {
            return View();
        }

    }
}
