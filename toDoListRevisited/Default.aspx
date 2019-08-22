<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ToDoList.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>To Dos</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <h1>To Dos</h1>
        <uc:ListGeneration id="ListGeneration" runat="server" NumberOfRecordsToDisplay="3" CategoryFilter="Idea" />             

        <h2>Add New To Do</h2>

        <uc:DataEntry runat="server" />
    </div>
    <br />
    <div>
        <uc:ListGeneration id="ListGeneration1" runat="server" />   
    </div>
    </form>
</body>
</html>
