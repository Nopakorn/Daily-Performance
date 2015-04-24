using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Daily_Performance.DataContext
{
    public class Work
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        [Display( Name = "Project Name")]
        public string ProjectName { get; set; }

        [StringLength(255)]
        public string Task { get; set; }

        public string Member { get; set; }

        [Display(Name = "Work Hours")]
        public double WorkHours { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }
}