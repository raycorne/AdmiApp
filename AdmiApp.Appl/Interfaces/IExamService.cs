using AdmiApp.Core.Responses;

namespace AdmiApp.Appl.Interfaces
{
    public interface IExamService
    {
        public Task<GetAllExamsResponse> GetAllExams();

    }
}
