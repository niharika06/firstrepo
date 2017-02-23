using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace InventoryUnitTesting
{
    public class Testing
    {
        private readonly IList<Product> _productList;
        private readonly IList<Cart> _cartList;
        private readonly IList<Inventory> _inventoryList;

        [Fact]
        public void WhenAddingProductToInventory_InventoryListShouldbeIncreased()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 6,
                ProductId = 5,
                Quantity = 5,

            };

            var prgm = new Program();
            var list = prgm.AddInventory(inventory);
            Assert.Equal(6, db.InventoryList.Count);
        }
        [Fact]
        public void WhenDeleteProductFromInventory_InventoryListShoulddecrease()
        {
            var db = new Database();
            var inventoryOb = db.InventoryList.ToList().FirstOrDefault(x => x.Id == 2);
            
            var prgm = new Program();
            var list = prgm.DeleteInventory(inventoryOb);
            Assert.NotEqual(2, db.InventoryList.Count);
        }
        [Fact]
        public void WhenAnyChangeDoneToInventryList_ListShouldBeUpdated()
        {

            var db = new Database();
            var inventoryOb = db.InventoryList.ToList().FirstOrDefault(x => x.Id == 4);
            inventoryOb.Price = 240;
            
            var prgm = new Program();
            var list = prgm.UpdateInventory(inventoryOb);

            Assert.Equal(240, db.InventoryList.Count);

        }
        [Fact]
        public void WhenCartCheckoutIsDone_UpdateInventory()
        {
            var db = new Database();
            var cartOb = db.CartList.ToList().FirstOrDefault(x => x.Id == 3);
            cartOb.OrderedQuantity = 2;           
            
            var inventory = new Inventory()
            {
                Quantity = 2,
            };
            var prgm = new Program();
            Assert.Equal(3, db.CartList.Count);
            Assert.Equal(8, db.InventoryList.Count);
           
        }
        public void TocheckExistance()
        {
            var db = new Database();
            var inventoryOb = db.InventoryList.ToList().FirstOrDefault(x => x.Id == 4);
            Assert.Equal(4, db.InventoryList.Count);
        }

    }
}

    

