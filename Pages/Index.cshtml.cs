using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TextEditor.Pages
{
    public class IndexModel : PageModel
    {
        private string filePath;

        public IndexModel(IWebHostEnvironment environment)
        {
            filePath = Path.Combine(environment.ContentRootPath, "text.html");
        }

        [BindProperty]
        public string Text { get; set; }

        public void OnGet()
        {
            if (System.IO.File.Exists(filePath))
            {
                Text = System.IO.File.ReadAllText(filePath);
            }
        }

        public IActionResult OnPost()
        {
            if (Text == null)
            {
                Text = "";
            }

            System.IO.File.WriteAllText(filePath, Text);

            return RedirectToPage();
        }
    }
}
