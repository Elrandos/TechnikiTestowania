using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EFCoreInMemoryDemo.Web.Models
{
    public class PlayerModel
    {
        public int ID { get; set; }

        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }

        public int Age { get; set; }

        public string Game { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Member from")]
        public DateTime MemberFrom { get; set; }

        [DisplayName("Enter QRCode Text")]
        public string QRCodeText { get; set; }
    }
}