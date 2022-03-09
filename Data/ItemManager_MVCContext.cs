#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ItemManager_MVC.Models;

namespace ItemManager_MVC.Data
{
    public class ItemManager_MVCContext : DbContext
    {
        public ItemManager_MVCContext (DbContextOptions<ItemManager_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<ItemManager_MVC.Models.Item> Item { get; set; }
    }
}
