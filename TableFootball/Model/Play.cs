using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TableFootball.Model
{
    class Play
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "کد تیم اول")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        public int IDteam1 { get; set; }

        [Display(Name = "کد تیم دوم")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        public int IDteam2 { get; set; }

        [Display(Name = " تاریخ برگزاری بازی")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Display(Name = "گل تیم اول")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        public int countgoal1 { get; set; }

        [Display(Name = "گل تیم دوم")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        public int countgoal2 { get; set; }

    }
}
