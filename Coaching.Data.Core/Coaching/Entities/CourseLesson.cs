using System;
using System.Collections.Generic;

namespace Coaching.Data.Core.Coaching.Entities
{
    public partial class CourseLesson
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string Description { get; set; } = null!;
        public string? Icon { get; set; }
        public bool IsLink { get; set; }
        public string? Link { get; set; }
        public int CourseId { get; set; }
        public int Order { get; set; }

        public virtual Course Course { get; set; } = null!;
    }
}
