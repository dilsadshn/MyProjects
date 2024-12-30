using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace WebUygulamaProje1.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public int OgrenciNo { get; set; }

        public string? Adres {  get; set; }
        public string? Fakulte { get; set; }
        public string? Bolum { get; set; }

    }
}
