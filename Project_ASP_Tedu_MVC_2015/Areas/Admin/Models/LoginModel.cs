using System.ComponentModel.DataAnnotations;

namespace Project_ASP_Tedu_MVC_2015.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required]
        public string UserName { set; get; }

        [Required]
        public string Password { set; get; }
        public bool RememberMe { set; get; }
    }
}
