namespace Ludus.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("Course")]
    public class Course
    {
        public Course()
        {
            this.CourseAwardLinks = new HashSet<CourseAwardLink>();
            this.CourseItemLinks = new HashSet<CourseItemLink>();
            this.Sections = new HashSet<Section>();
        }

        [Key]
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    
        public virtual ICollection<CourseAwardLink> CourseAwardLinks { get; set; }
        public virtual ICollection<CourseItemLink> CourseItemLinks { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
