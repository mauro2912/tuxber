using System;
using System.ComponentModel.DataAnnotations;

namespace Tuxber.Web.Data.Entities
{
    public class TripDetailsEntity
    {
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }

        public DateTime DateLocal => Date.ToLocalTime();

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public TripEntity Trip { get; set; }
    }
}

