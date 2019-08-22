<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListGeneration.ascx.cs" Inherits="toDoListRevisited.Controls.List" %>

<asp:repeater id="ToDos" runat="server" onitemcommand="TODOs_ItemCommand">
    <headertemplate>
        <table>
            <tr>
                <th>Category</th>
                <th>Description</th>
                <th>&nbsp;</th>
            </tr>
    </headertemplate>
    <itemtemplate>
        <tr>
            <td>
                <asp:label runat="server" 
                    id="Category1"
                    text='<%# Eval("Category") %>'
                    font-strikeout='<%# Eval("Done") %>' />
            </td>
            <td>
                <asp:label runat="server" 
                    id="Description" 
                    text='<%# Eval("Description") %>'
                    font-strikeout='<%# Eval("Done") %>' />
            </td>
            <td>
                <asp:button runat="server"
                    id="Done"
                    text="Done"
                    commandname="Done" 
                    commandargument='<%# Container.ItemIndex %>'
                    visible='<%# !((bool)Eval("Done")) %>' />
            </td>
        </tr>
    </itemtemplate>
    <footertemplate>
        </table>
    </footertemplate>
</asp:repeater>

<asp:Button ID="DecPage" runat="server" Text="-" OnClick="DecPage_Click" visible="false" />
<asp:Label ID="PageNumber" runat="server" Text="1" Visible="false" />
<asp:Button ID="IncPage" runat="server" Text="+" OnClick="IncPage_Click" visible="false" />
