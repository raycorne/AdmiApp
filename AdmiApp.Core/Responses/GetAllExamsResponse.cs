using AdmiApp.Core.Data;

namespace AdmiApp.Core.Responses
{
    public class GetAllExamsResponse
    {
        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public List<Exams>? Content { get; set; }
    }
}
