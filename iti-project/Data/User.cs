using Microsoft.EntityFrameworkCore;

namespace iti_project.Data {
 
    public class User {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Study { get; set; }
        public string CurrentSemester { get; set; }
        public string Age { get; set; }
        public string Birthday { get; set; }
        public string FacebookPassword { get; set; }

        public User() {
            this.Name = "Anton";
        }
    }
}