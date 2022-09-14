using System;
using System.Collections.Generic;

namespace Coaching.Data.Core.Coaching.Entities
{
    public partial class SpecialityLevelTest
    {
        public SpecialityLevelTest()
        {
            SpecialityLevelTestOption = new HashSet<SpecialityLevelTestOption>();
        }

        public int Id { get; set; }
        public int SpecialityLevelId { get; set; }
        public int Order { get; set; }
        public string Question { get; set; } = null!;
        public string? Answer { get; set; }

        public virtual SpecialityLevel SpecialityLevel { get; set; } = null!;
        public virtual ICollection<SpecialityLevelTestOption> SpecialityLevelTestOption { get; set; }
    }
}
