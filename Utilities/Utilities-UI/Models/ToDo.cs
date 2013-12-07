using System;
using System.ComponentModel.DataAnnotations;

namespace Utilities_UI.Models
{
    public class ToDo
    {

        public int Id { get; set; }
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime Due { get; set; }

        public int CalculatePercentage()
        {
            var now = DateTime.Now;
            if (now > Due)
                return 100;
            return (int)(((now - Created).Ticks*100)/(Due - Created).Ticks);
        }
    }
}