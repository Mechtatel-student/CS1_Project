using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DummyData;
using Data.StoreData;
using Domain.Entities;
using Domain.Entities.Orders;
using Domain.Entities.Products;
using Domain.Entities.Users;
using NUnit.Framework;
using Domain.Entities.Clients;
using Domain.DAO;

namespace Test
{
    [TestFixture]
    class NUNitDAOQuerryTests
    {
        [Test]
        public void TestDAOForCategory()
        {
            ICategoryRepository category = new DummyDAOForCategory();
        }
        [Test]
        public void TestDAOForClientFindby()
        {
            IClientRepository client = new DummyDAOForClient();
            CollectionAssert.AreEqual(new List<Client> {Storage.Clients[2]}, client.FindBy(null, "Plemon", null));
        }

        [Test]
        public void TestDAOForComment()
        {

        }
        [Test]
        public void TestDAOForOrderGetByClient()
        {
            IOrderRepository order = new DummyDAOForOrder();
            CollectionAssert.AreEqual(new List<Order> { Storage.Orders[0] },order.GetByClient(Storage.Clients[0]));
        }
        [Test]
        public void TestDAOForOrderGetBy()
        {
            IOrderRepository order = new DummyDAOForOrder();
            CollectionAssert.AreEqual(new List<Order> { Storage.Orders[0], Storage.Orders[2] }, order.GetBy(null, Status.Opened, null));
            //CollectionAssert.AreEqual(new List<Order> { Storage.Orders[0], Storage.Orders[1] }, order.GetBy("a4325", Status.PaidUp));
        }

      
        [Test]
        public void TestDAOForPermission()
        {
            IPermissionRepository permission = new DummyDAOForPermission();
            CollectionAssert.AreEqual(new List<Permission> { Storage.Permissions[7] }, permission.GetByTitle("Add Client"));
        }
        [Test]
        public void TestDAOForProduct()
        {
            IProductRepository product = new DummyDAOForProduct();
            Assert.AreEqual(Storage.Products[1], product.GetBySKU("sfdfh3"));
        }
        [Test]
        public void TestDAOForProductGetBy()
        {
            IProductRepository product = new DummyDAOForProduct();
            CollectionAssert.AreEqual(new List<Product> { Storage.Products[1], Storage.Products[4] }, product.GetBy(null, null, Storage.Categories[1]));
            CollectionAssert.AreEqual(Storage.Products, product.GetBy(null, null, null));
            CollectionAssert.AreEqual(new List<Product> { Storage.Products[0], Storage.Products[3] }, product.GetBy(null, "Table", null));

        }
        [Test]
        public void TestDAOForRole()
        {

        }
        [Test]
        public void TestDAOForUser()
        {
            IUserRepository user = new DummyDAOForUser();
            CollectionAssert.AreEqual(new List<User> {Storage.Users[4] }, user.GetBy("Dir", null, null));
            //CollectionAssert.AreEqual(new List<User> { Storage.Users[3] }, user.GetBy(null, Storage.Persons[3]));
            
        }
    }
}
