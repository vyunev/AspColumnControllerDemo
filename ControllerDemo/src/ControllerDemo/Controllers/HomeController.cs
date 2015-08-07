using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace ControllerDemo.Controllers
{
	public class HomeController : Controller
	{
		private readonly string _time;

		public HomeController()
		{
			this._time = DateTime.Now.ToString("G");
		}

		// GET: /Home/
		public IActionResult Index() 
		{
			return this.Content("Hello ASP.NET MVC 6");
		}

		// GET: /Home/Echo/
		public IActionResult Echo(string message)
		{
			return this.Content($"{this._time} > {message}");
		}


		// GET: /Home/EchoAsync/
		public async Task<IActionResult> EchoAsync(string message)
		{
			await Task.Delay(100);
			return this.Content($"{this._time} > {message}");
		}
	}
}
