using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TableFootball.Model
{
    class User
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [MaxLength(15, ErrorMessage = "نباید بیش از{1} کاراکتر باشد")]
        public string  Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [MaxLength(30, ErrorMessage = "نباید بیش از{1} کاراکتر باشد")]
        public string Family { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [MaxLength(15, ErrorMessage = "نباید بیش از{1} کاراکتر باشد")]
        public string UserName { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "موقعیت شغلی")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [MaxLength(20, ErrorMessage = "نباید بیش از{1} کاراکتر باشد")]
        public string JobPosition { get; set; }
    }
}
