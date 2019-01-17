using System.ComponentModel;
using System.IO;

namespace SecondhandTrade.Models
{
    public class ItemListVm
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("ItemName")]
        public string ItemName { get; set; }

        [DisplayName("Description")]
        public int Description { get; set; }

        //[DisplayName("Image")]
        //public sealed class { get; set; }

        [DisplayName("Year")]
        public int Year { get; set; }

        [DisplayName("Price")]
        public int Price { get; set; }

        [DisplayName("UserId")]
        public int SellerUserId { get; set; }

        [DisplayName("UserId")]
        public int BuyerUserId { get; set; }
    }
}