using System.ComponentModel.DataAnnotations;

namespace FirstSite.Models
{
    public class FormKeyModel
    {
        [Required(ErrorMessage = "لطفا نام را تصحیح وارد کنید")]
        [MaxLength(10,ErrorMessage = "بیش از حد کاراکتر وارد کردی !!")]
        [MinLength(3,ErrorMessage = "حداقل ورودی کاراکتر 3 میباشد")]
        public string Name { get; set; }
        [Required(ErrorMessage = "لطفا فامیلی را تصحیح وارد کنید")]
        [MaxLength(10, ErrorMessage = "بیش از حد کاراکتر وارد کردی !!")]
        [MinLength(3, ErrorMessage = "حداقل ورودی کاراکتر 3 میباشد")]
        public string Family { get; set; }
        [Required(ErrorMessage = "لطفاکد ملی را صحیح وارد کنید")]
        
        public long Kodmeli { get; set; }
        [Required(ErrorMessage = "لطفا ایمیل  را تصحیح وارد کنید")]
        [MaxLength(40, ErrorMessage = "بیش از حد کاراکتر وارد کردی !!")]
        [MinLength(3, ErrorMessage = "حداقل ورودی کاراکتر 3 میباشد")]
        public string Email { get; set; }
    }
}
