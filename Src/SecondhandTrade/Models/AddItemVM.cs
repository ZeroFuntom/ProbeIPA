using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SecondhandTrade.Models
{
    public class AddItemVm
    {
        [DisplayName("Item Name")]
        [Required(ErrorMessage = "Please enter something!")]
        [StringLength(50, ErrorMessage = "You overran max-lenght")]
        public string ItemName { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Please enter something!")]
        [StringLength(50, ErrorMessage = "You overran max-lenght")]
        public string Description { get; set; }

        [DisplayName("Image")]
        [Required(ErrorMessage = "Please enter something!")]
        [StringLength(50, ErrorMessage = "You overran max-lenght")]
        public string Image { get; set; }

        [DisplayName("Year")]
        [Required(ErrorMessage = "Please enter something!")]
        [StringLength(50, ErrorMessage = "You overran max-lenght")]
        public string Year { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Please enter something!")]
        [StringLength(50, ErrorMessage = "You overran max-lenght")]
        public string Price { get; set; }
    }
}