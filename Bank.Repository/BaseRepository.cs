using Bank.Base.Repository;
using Bank.Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace Bank.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : IId<int>, new()
    {
        private List<T> ItemList { get; set; }

        public BaseRepository()
        {
            ItemList = new List<T>();
        }

        public void Create(T model)
        {
            model.ID = GetNewID();
            ItemList.Add(model);
        }

        public void Delete(T model)
        {
            int? index = ItemList.FindIndex(x => x.ID == model.ID);
            if(index.HasValue)
            {
                ItemList.RemoveAt(index.Value);
            }
        }

        public T Retrieve(int modelId)
        {
            var savedModel = ItemList.SingleOrDefault(x => x.ID == modelId);
            return savedModel;
        }

        public void Update(T model)
        {
            var savedItem = ItemList.SingleOrDefault(x => x.ID == model.ID);
            savedItem = model;
        }
        
        private int GetNewID()
        {
            if (ItemList.Any())
                return ItemList.OrderByDescending(x => x.ID).FirstOrDefault().ID + 1;
            else
                return 1;
        }
    }
}
