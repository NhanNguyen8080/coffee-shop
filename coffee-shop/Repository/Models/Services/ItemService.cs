using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void updateStatus(Item item, bool status)
        {
            item.Status = status;
            _dbContext.Entry<Item>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
