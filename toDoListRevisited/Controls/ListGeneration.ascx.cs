using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using toDoListRevisited.Models;

namespace toDoListRevisited.Controls
{
    public partial class List : System.Web.UI.UserControl
    {
        public int? NumberOfRecordsToDisplay { get; set; }
        public string CategoryFilter { get; set; }
        bool StuffEnabled { get; set; }

        // Saves the current page across button presses.
        private const string CurrentPageViewStateKey = "CurrentPage";
        public int currentPage
        {
            get
            {
                object viewStateNumber = ViewState[CurrentPageViewStateKey];
                if (viewStateNumber != null)
                {
                    return (int)viewStateNumber;
                }
                else
                {
                    // Start on page 1 as default.
                    return 1;
                }
            }
            set
            {
                ViewState[CurrentPageViewStateKey] = value;
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void PopulateList()
        {
            List<ToDoItem> todos = ToDoItemData.GetToDoItems();
            List<ToDoItem> todosFiltered = new List<ToDoItem>();

            if (CategoryFilter != null)
            {
                foreach (ToDoItem todo in todos)
                {
                    if (todo.Category == CategoryFilter)
                    {
                        todosFiltered.Add(todo);
                    }
                }
            }
            else
            {
                todosFiltered = todos;
            }

            // If the user control has a max number of items to display per page.
            if (NumberOfRecordsToDisplay.HasValue && NumberOfRecordsToDisplay > 0 && todosFiltered.Count > NumberOfRecordsToDisplay)
            {
                // Enable pagination interface.
                DecPage.Visible = true;
                PageNumber.Visible = true;
                IncPage.Visible = true;

                // Calculate total pages from the amount of items.
                int totalPages = (int)Math.Ceiling((double)todosFiltered.Count / (double)NumberOfRecordsToDisplay.Value);

                //  Repeater bind with Skip/Takes to make pages.
                ToDos.DataSource = todosFiltered.Skip((currentPage-1)*NumberOfRecordsToDisplay.Value).Take(NumberOfRecordsToDisplay.Value).ToList();
                ToDos.DataBind();

                // Set page number.
                PageNumber.Text = currentPage.ToString();
                
                // Disable Buttons that will bring you out of bounds of the list.
                IncPage.Enabled = currentPage < totalPages;
                DecPage.Enabled = currentPage > 1;
            }
            // Default repeater bind, no pagination.
            else
            {
                ToDos.DataSource = todosFiltered;
                ToDos.DataBind();
            }
        }

        protected void TODOs_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int index = int.Parse((string)e.CommandArgument);
            List<ToDoItem> todos = ToDoItemData.GetToDoItems();
            List<ToDoItem> todosFiltered = new List<ToDoItem>();

            if (CategoryFilter != null)
            {
                foreach (ToDoItem todo in todos)
                {
                    if (todo.Category == CategoryFilter)
                    {
                        todosFiltered.Add(todo);
                    }
                }
            }
            else
            {
                todosFiltered = todos;
            }

            // Janky formula that will get the Done button job done across pages.
            todosFiltered[index+(NumberOfRecordsToDisplay.Value*(currentPage-1))].Done = true;
        }

        protected void DecPage_Click(object sender, EventArgs e)
        {
            currentPage--;
        }

        protected void IncPage_Click(object sender, EventArgs e)
        {
            currentPage++;
        }
    }
}