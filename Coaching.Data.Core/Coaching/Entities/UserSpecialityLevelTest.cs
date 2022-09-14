using System;
using System.Collections.Generic;

namespace Coaching.Data.Core.Coaching.Entities
{
    public partial class UserSpecialityLevelTest
    {
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        public int UserSpecialityLevelId { get; set; }
        public decimal Points { get; set; }

        public virtual UserSpecialityLevel UserSpecialityLevel { get; set; } = null!;
    }
}
