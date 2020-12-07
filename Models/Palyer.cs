using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDay51.Models
{
    [Table("PPicModel")]
    public class Player
    {
        [Key]
        public int PId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string PName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Profile Pic Name")]
        public string PTeam { get; set; }
        [NotMapped]
        [DisplayName("Upload Profile Pic")]
        public IFormFile PProfilePic { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Enter the Category")]
        public string PCategory { get; set; }
    }
}