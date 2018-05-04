using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace iti_project.Data {
 
    [Table("users")]
    public class User {
        [Key]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Study { get; set; }
        public string Semester { get; set; }
        public string Age { get; set; }
        public string Birthday { get; set; }
        public string FacebookPassword { get; set; }

        public User() {
            this.Name = "Anton";
        }
    }
}