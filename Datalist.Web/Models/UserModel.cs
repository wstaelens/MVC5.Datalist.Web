using Datalist;
using System;
using System.ComponentModel.DataAnnotations;

namespace Datalist.Web.Models
{
    public class PersonModel
    {
        [DatalistColumn(Hidden = true)]
        public Int32 Id { get; set; }

        [DatalistColumn]
        [Display(Name = "Name")]
        public String Name { get; set; }

        [DatalistColumn]
        [Display(Name = "Surname")]
        public String Surname { get; set; }

        [DatalistColumn]
        [Display(Name = "Age")]
        public Int32 Age { get; set; }

        [DatalistColumn(Format = "{0:d}")]
        [Display(Name = "Birthday", ShortName = "Birth")]
        public DateTime Birthday { get; set; }

        public Boolean? IsWorking { get; set; }
    }
}
