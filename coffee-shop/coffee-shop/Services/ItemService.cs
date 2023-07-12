using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.Services
{
    public class ItemService : ServicesBase<Item>
    {
        CoffeeShopDBContext _dbContext;
        DbSet<Item> _items;

        public ItemService()
        {
            _dbContext = new CoffeeShopDBContext();
            _items = _dbContext.Items;
        }

        public void updateStatus(Item item, bool inStock)
        {
            var it = _items.Where(x => x.ItemId == item.ItemId).FirstOrDefault();
            it.InStock = inStock;
            _dbContext.Entry<Item>(it).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
