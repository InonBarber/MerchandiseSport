using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MerchandiseSport.Models
{
    public enum UserType
    {
        Nothing,
        Client,
        Editor,
        Admin
    }


    public class Users
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Username need to be at least 4 letters")]
        [Display(Name = "User Name")]

        public string UserName { get; set; }
       
        [Required]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password need to be more then 8 letter")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]

        public string Password
        {
            get; set;
        }

        public UserType type { get; set; } = UserType.Nothing;

        internal object First()
        {
            throw new NotImplementedException();
        }

    }
}
