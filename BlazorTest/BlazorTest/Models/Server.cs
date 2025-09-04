using System.ComponentModel.DataAnnotations;

namespace BlazorTest.Models
{
    public class Server
    {

        public int ServerID { get; set; }
        public bool IsOnline { get; set; }

        [Required]
        [StringLength(20,ErrorMessage = "Name not longer than 20 char")]
        public string? Name { get; set; }

        [Required]
        public string? City { get; set; }

        public Server()
        { 
            Random random = new Random();
            int randomNumber = random.Next(0,2);
            IsOnline = randomNumber == 0? false : true;
        }

    }
}
