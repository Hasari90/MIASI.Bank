using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository.Base.Interface
{
    public interface IBaseRepository<T>
        where T : IId<int>,new()
    {
        void Create(T model);
        T Retrieve(int modelId);
        void Update(T model);
        void Delete(T model);
    }
}
