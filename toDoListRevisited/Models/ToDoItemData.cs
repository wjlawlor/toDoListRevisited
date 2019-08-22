using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace toDoListRevisited.Models
{
    /// <summary>
    /// 
    /// </summary>
    public static class ToDoItemData
    {
        // HACK: Using a static collection here
        // to work around not having a database.
        private static List<ToDoItem> Items = new List<ToDoItem>();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<ToDoItem> GetToDoItems()
        {
            return Items;
        }

        public static void AddItem(string description, string category)
        {
            ToDoItem item = new ToDoItem();
            item.Description = description;
            item.Category = category;
            item.Done = false;

            Items.Add(item);
        }
    }
}