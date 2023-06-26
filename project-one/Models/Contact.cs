using System.ComponentModel.DataAnnotations;

namespace project_one.Models
{
    public class Contact
    {
        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Write pls")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Write pls")]
        public string Surname { get; set; }

        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Write pls")]
        public int Age { get; set; }

        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Write pls")]
        public string Email { get; set; }

        [Display(Name = "Введите сообщение")]
        [Required(ErrorMessage = "Write pls")]
        [StringLength(30, ErrorMessage = "Текст не менее 30 символов")]
        public string Message { get; set; }

    }
}
