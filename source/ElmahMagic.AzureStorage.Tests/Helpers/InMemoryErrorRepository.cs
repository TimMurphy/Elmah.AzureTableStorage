using System.Collections.Generic;
using System.Threading.Tasks;
using ElmahMagic.Repository;

namespace ElmahMagic.AzureStorage.Tests.Helpers
{
    public class InMemoryErrorRepository : IErrorRepository
    {
        public Task<string> AddErrorAsync(ErrorRecord error)
        {
            throw new System.NotImplementedException();
        }

        public Task<ErrorRecord> GetErrorAsync(string errorId)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> GetErrorsAsync(int pageIndex, int pageSize, IDictionary<string, ErrorRecord> errors)
        {
            throw new System.NotImplementedException();
        }
    }
}