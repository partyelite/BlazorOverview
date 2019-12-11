using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorOverviewShared.Pages.User
{
    public class UserModel
    {
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
        [StringLength(10, ErrorMessage = "Max 10 znakova")]
        public string LastName { get; set; }

        [Range(0,9,ErrorMessage = "Between 0 and 9")]
        public int Level { get; set; }
    }
}
