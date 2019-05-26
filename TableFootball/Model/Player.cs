using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableFootball.Model
{
    class Player
    {
        [Key]
        public int ID { get; set; }

        
        public int? IDTeam { get; set; }

        [Display(Name ="نام ")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [MaxLength(20, ErrorMessage = "نباید بیش از{1} کاراکتر باشد")]
        public string Name { get; set; }


        [Display(Name ="نام خانوادگی")]
        [MaxLength(30, ErrorMessage = "نباید بیش از{1} کاراکتر باشد")]
        public string Family { get; set; }


        [Display(Name ="تاریخ تولد")]
        [DataType(DataType.DateTime)]
        public DateTime Age { get; set; }

        [ForeignKey("IDTeam")]
        public virtual Team Team { get; set; }

    }
}
