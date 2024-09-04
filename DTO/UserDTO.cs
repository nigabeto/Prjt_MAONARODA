using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace DTO
{
    public class UserDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Preencha o campo Usuário!!!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha!!!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Preencha o campo Email!!!")]
        public string Email { get; set; }

        public string Imagepath { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome!!!")]
        public string Name { get; set; }

        public bool isAdmin { get; set; }
        [Display(Name = "User Image")] 
        public HttpPostedFileBase UserImage { get; set; }

        public void SetPasswordHash()
        {
            Password = Password.GerarHash();
        }
    }
}