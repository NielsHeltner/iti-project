using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iti_project.Data
{
    [Table("newsletter")]
    public class Email
    {
        [Key]
        public string email { get; set; }

        public Email(string email)
        {
            this.email = email;
        }
    }
}
