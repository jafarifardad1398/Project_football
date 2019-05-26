using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableFootball.Model
{
    class Team
    {
        [Key]
        public int IDTeam { get; set; }

        public int LigID { get; set; }

        [Display(Name = "نام تیم")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [MaxLength(20, ErrorMessage = "نباید بیش از{1} کاراکتر باشد")]
        public string TeamName { get; set; }

        [Display(Name = "امتیاز")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        public int Point { get; set; }

        [Display(Name = "رنگ پیراهن اول")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [MaxLength(20, ErrorMessage = "نباید بیش از{1} کاراکتر باشد")]
        public string Color1 { get; set; }

        [Display(Name = "رنگ پیراهن دوم")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [MaxLength(15, ErrorMessage = "نباید بیش از{1} کاراکتر باشد")]
        public string Color2 { get; set; }

        [Display(Name = "نام اسپانسر")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [MaxLength(20, ErrorMessage = "نباید بیش از{1} کاراکتر باشد")]
        public string SpanserName { get; set; }

        [Display(Name = "لگو باشگاه")]
        public string LOGO { get; set; }

        [ForeignKey("LigID")]
        public virtual Lig Lig { get; set; }

        public virtual ICollection<Player> Players { get; set; }

    }
}
