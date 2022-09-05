using System;
using System.Collections.Generic;

namespace Coaching.Data.Core.Coaching.Entities
{
    public partial class Topic
    {
        public Topic()
        {
            Course = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public virtual ICollection<Course> Course { get; set; }
    }
}
