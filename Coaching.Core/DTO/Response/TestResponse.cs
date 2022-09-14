using Coaching.Data.Core.Coaching.Entities;
using Coaching.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Coaching.Core.DTO.Response
{
    public class TestReponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("orer")]
        public int Order { get; set; }
        [JsonPropertyName("question")]
        public string Question { get; set; }
        [JsonPropertyName("answer")]
        public string? Answer { get; set; }
        
        [JsonPropertyName("options")]
        public string[] Options { get; set; }

        public class Builder
        {
            private TestReponse dto;
            private List<TestReponse> collection;

            public Builder()
            {
                this.dto = new TestReponse();
                this.collection = new List<TestReponse>();
            }
            public Builder(TestReponse dto)
            {
                this.dto = dto;
                this.collection = new List<TestReponse>();
            }
            public Builder(List<TestReponse> collection)
            {
                this.dto = new TestReponse();
                this.collection = collection;
            }

            public TestReponse Build() => dto;
            public List<TestReponse> BuildAll() => collection;

            public static Builder From(SpecialityLevelTest entity, string tipoConstructor = ConstantHelpers.CONSTRUCTOR_DTO_SINGLE)
            {
                var dto = new TestReponse();
                dto.Id = entity.Id;
                dto.Order = entity.Order;
                dto.Question = entity.Question;
                dto.Answer = entity.Answer;
                dto.Options = entity.SpecialityLevelTestOption.Select(x => x.Option).ToArray();
                return new Builder(dto);
            }

            public static Builder From(IEnumerable<SpecialityLevelTest> entities)
            {
                var collection = new List<TestReponse>();

                foreach (var entity in entities)
                    collection.Add(From(entity, ConstantHelpers.CONSTRUCTOR_DTO_LIST).Build());

                return new Builder(collection);
            }
        }
    }
}
