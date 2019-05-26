using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableFootball.Model
{
    class Lig
    {
        [Key]
        public int ID { get; set; }

        [Display(Name ="نام لیگ")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [MaxLength(30, ErrorMessage = "نباید بیش از{1} کاراکتر باشد")]
        public string LigName { get; set; }

        [Display(Name = "کشور لیگ")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [MaxLength(15, ErrorMessage = "نباید بیش از{1} کاراکتر باشد")]
        public string CountryLig { get; set; }

        [Display(Name = "عکس لیگ")]
        public string Address { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
