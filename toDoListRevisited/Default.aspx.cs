using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using toDoListRevisited.Models;

namespace ToDoList
{
    public partial class Default : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        PopulateList();
        //    }
        //}

        //private void PopulateList()
        //{
        //    List<ToDoItem> todos = ToDoItemData.GetToDoItems();
        //    Debug.WriteLine(todos);

        //    ToDos.DataSource = todos;
        //    ToDos.DataBind();
        //}

        //protected void Submit_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrWhiteSpace(Description.Text))
        //    {
        //        ErrorMessage.Visible = false;

        //        ToDoItemData.AddItem(Description.Text,SelectCategories.Text);
        //        PopulateList();
        //        Description.Text = string.Empty;
        //    }
        //    else
        //    {
        //        ErrorMessage.Visible = true;
        //    }
        //}

        //protected void TODOs_ItemCommand(object source, RepeaterCommandEventArgs e)
        //{
        //    int index = int.Parse((string)e.CommandArgument);
        //    List<ToDoItem> todos = ToDoItemData.GetToDoItems();
        //    todos[index].Done = true;
        //    PopulateList();
        //}
    }
}