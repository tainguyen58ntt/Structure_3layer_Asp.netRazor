using Abby.Models;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _3Layer_Test_V1.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		private ApplicationDbContext _db;
        public IEnumerable<Category> Category { get; set; }
       
		public IndexModel(ApplicationDbContext db) {
			_db = db;
		}
		public void OnGet()
		{
			Category = _db.Category;
		}
	}
}