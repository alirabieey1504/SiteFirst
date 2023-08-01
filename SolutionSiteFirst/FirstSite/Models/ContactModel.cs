using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstSite.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(10,ErrorMessage ="لطفا ایمیل را صحیح وارد کنید")]
        [MaxLength(100,ErrorMessage = "حداکثر طول ایمل 100 کاراکتر است")]
        [EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل صحیح نیست")]
        public string Email { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]

        public string Tell { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]

        public string Text { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]

        public string Password { get; set; }

        public SelectList Services { get; set; }

        public int Service { get; set; }
    }
}
