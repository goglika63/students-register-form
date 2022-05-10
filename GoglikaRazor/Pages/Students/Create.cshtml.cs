using GoglikaRazor.Data;
using GoglikaRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoglikaRazor.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Student Student { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;       
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult>OnPost(Student student)
        {
            if (ModelState.IsValid)
            {
                await _db.Student.AddAsync(student);
                await _db.SaveChangesAsync();
                TempData["success"] = "Student created successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
