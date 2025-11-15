using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreInMemoryDemo.Web.Models
{
    public class BoardGame
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        [DisplayName("Publishing Company")]
        public string PublishingCompany { get; set; }

        [DisplayName("Min Players")]
        public int MinPlayers { get; set; }

        [DisplayName("Max Players")]
        public int MaxPlayers { get; set; }

        [DisplayName("Is released")]

        public bool IsReleased { get; set; }

        [DisplayName("Difficulty level")]
        public ERank DifficultyLevel { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Release date")]
        public DateTime ReleaseDate { get; set; }
    }

    public enum ERank
    {
        Unassigned,
        Newbie,
        Junior,
        Mid,
        Master
    }
}
