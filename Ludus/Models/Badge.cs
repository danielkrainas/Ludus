namespace Ludus.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("Badge")]
    public class Badge
    {
        public Badge()
        {
            this.StudentBadgeLinks = new HashSet<StudentBadgeLink>();
        }

        [Key]
        public int Id { get; set; }
        public int SectionId { get; set; }
        public string Name { get; set; }
    
        public virtual Section Section { get; set; }
        public virtual ICollection<StudentBadgeLink> StudentBadgeLinks { get; set; }


        [Display(Name = "Badge Earned")]
        [Required]
        public System.DateTime Due { get; set; }

        [Display(Name = "Badge Mini Description")]
        [Required]
        public string ShortDescription { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Earned")]
        [Required]
        public bool Complete { get; set; }
    }
}
