using GoglikaRazor.Data;
using GoglikaRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoglikaRazor.Pages.Students
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Student Student { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;       
        }
        public void OnGet(int id)
        {
            Student = _db.Student.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            var studentFromDb = _db.Student.Find(Student.Id);
            if(studentFromDb != null)
            {
                _db.Student.Remove(studentFromDb);
                await _db.SaveChangesAsync();
                TempData["success"] = "Student deleted successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
