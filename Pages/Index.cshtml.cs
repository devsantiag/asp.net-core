using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(50, MinimumLength = 7, ErrorMessage = "O nome deve ter entre 7 e 50 caracteres")]

        public string Name { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Qual seu nome? ";
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                Message = "Por favor, corrija os erros abaixo.";
                return;
            }
         
            Message = $"Seja bem-vindo, {Name}!";
        }
    }
}
