using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Coaching.Core.DTO.Request
{
    public class TestRequest
    {
        [JsonPropertyName("is_approved")]
        public bool IsApproved { get; set; }

        [JsonPropertyName("points")]
        public decimal Points { get; set; }
    }
}
