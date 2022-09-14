using System;
using System.Collections.Generic;

namespace Coaching.Data.Core.Coaching.Entities
{
    public partial class SpecialityLevelTestOption
    {
        public int Id { get; set; }
        public int SpecialityLevelTestId { get; set; }
        public string Option { get; set; } = null!;

        public virtual SpecialityLevelTest SpecialityLevelTest { get; set; } = null!;
    }
}
