using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NotesApp.Models
{
    public class Note
    {
    public int ID { get; set; }


        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }


        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
      
        public DateTime CreatedOn { get; set; }

    }
}