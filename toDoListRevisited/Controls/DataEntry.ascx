<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DataEntry.ascx.cs" Inherits="toDoListRevisited.Controls.DataEntry" %>

<asp:textbox id="Description" runat="server" />
<asp:button id="Submit" runat="server" text="Submit" onclick="Submit_Click" />

<asp:DropDownList ID="SelectCategories" runat="server" DataTextField="DataSourceField">
    <asp:ListItem value="Task">Task</asp:ListItem>
    <asp:ListItem value="Idea">Idea</asp:ListItem>
    <asp:ListItem value="ThirdItem">Third Item</asp:ListItem>
</asp:DropDownList>

<div>
    <asp:label id="ErrorMessage" runat="server" text="Please provide a description." forecolor="Red" visible="false" />
</div>