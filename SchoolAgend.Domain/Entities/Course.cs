﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAgend.Domain.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Teacher { get; set; }
        [MaxLength(20)]
        public string Color { get; set; }
        // Relaciones

        public object RowVersion { get; set; }
    }
}
