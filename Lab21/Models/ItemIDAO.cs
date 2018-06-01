using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21.Models
{
    interface ItemIDAO
    {
        Item GetItem(int id);

        List<Item> GetItemList();

        void AddItem(Item item);

        void EditItem(Item item);

        void DeleteItem(int id);

        void Dispose();
    }
}
