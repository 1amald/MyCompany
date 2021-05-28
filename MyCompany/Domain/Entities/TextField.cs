using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Page name")]
        public override string Title { get; set; } = "Information page";

        [Display(Name = "Content")]
        public override string Text { get; set; } = "Content is filled in by the administrator";
    }
}
