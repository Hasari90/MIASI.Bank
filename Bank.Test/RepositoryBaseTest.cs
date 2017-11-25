using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank.Test.Repository;

namespace Bank.Test
{
    [TestClass]
    public class RepositoryBaseTest
    {
        [TestMethod]
        public void RepositoryBase_SetIDBeforeCreate()
        {
            TestRepository repo = new TestRepository();

            TestModel model = new TestModel()
            {
                Name = "Test",
                Value = 1,
            };
            Assert.AreEqual(0, model.ID);
            repo.Create(model);
            Assert.AreEqual(1, model.ID);
        }

        [TestMethod]
        public void RepositoryBase_UniqueID()
        {
            TestRepository repo = new TestRepository();

            TestModel model = new TestModel()
            {
                Name = "Test",
                Value = 1,
            };
            repo.Create(model);

            TestModel model2 = new TestModel()
            {
                Name = "Test2",
                Value = 2,
            };
            repo.Create(model2);
            Assert.AreEqual(2, model2.ID);
        }

        [TestMethod]
        public void RepositoryBase_Retrieve()
        {
            TestRepository repo = new TestRepository();

            TestModel model = new TestModel()
            {
                Name = "Test",
                Value = 1,
            };
            repo.Create(model);

            TestModel model2 = new TestModel()
            {
                Name = "Test2",
                Value = 2,
            };
            repo.Create(model2);

            var retrieved = repo.Retrieve(model2.ID);
            Assert.AreEqual("Test2", retrieved.Name);
            Assert.AreEqual(2, retrieved.Value);
        }

        [TestMethod]
        public void RepositoryBase_RetrieveChangeAndSave()
        {
            TestRepository repo = new TestRepository();

            repo.Create(new TestModel()
            {
                Name = "Test",
                Value = 1,
            });
            repo.Create(new TestModel()
            {
                Name = "Test2",
                Value = 2,
            });
            repo.Create(new TestModel()
            {
                Name = "Test2",
                Value = 3,
            });

            var retrieved = repo.Retrieve(3);
            retrieved.Name = "Test0";
            retrieved.Value = 0;

            var retrieved2 = repo.Retrieve(3);
            Assert.AreEqual("Test0", retrieved2.Name);
            Assert.AreEqual(0, retrieved2.Value);
        }
    }
}
