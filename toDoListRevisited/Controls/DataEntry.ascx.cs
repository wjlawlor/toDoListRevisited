using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using toDoListRevisited.Models;

namespace toDoListRevisited.Controls
{
    public partial class DataEntry : UserControl
    {
        protected void Submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Description.Text))
            {
                ErrorMessage.Visible = false;

                ToDoItemData.AddItem(Description.Text, SelectCategories.Text);
                Description.Text = string.Empty;
            }
            else
            {
                ErrorMessage.Visible = true;
            }
        }

        protected void TODOs_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int index = int.Parse((string)e.CommandArgument);
            List<ToDoItem> todos = ToDoItemData.GetToDoItems();
            todos[index].Done = true;
        }
    }
}