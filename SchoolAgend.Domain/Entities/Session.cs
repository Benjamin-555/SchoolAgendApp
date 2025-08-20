using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAgend.Domain.Entities
{
    public class Session
    {
        [Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        [Range(1, 7)]
        public int DayOfWeek { get; set; } // 1=Monday ... 7=Sunday
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        [MaxLength(50)]
        public string Classroom { get; set; }
        // Relación
        [ForeignKey("CourseId")]
        public object? RowVersion { get; set; }
    }
}
