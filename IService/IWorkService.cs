using BlazorMongoDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMongoDB.IService
{
    public interface IWorkService 
    {
        void SaveOrUpdate(Work work);
        Work GetWork(string workId);
        List<Work> GetWorks();
        string Delete(string workId);
    }
}
