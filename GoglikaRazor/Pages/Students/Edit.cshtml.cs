using GoglikaRazor.Data;
using GoglikaRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoglikaRazor.Pages.Students
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Student Student { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;       
        }
        public void OnGet(int id)
        {
            Student = _db.Student.Find(id);
        }

        public async Task<IActionResult>OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Student.Update(Student);
                await _db.SaveChangesAsync();
                TempData["success"] = "Student updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
