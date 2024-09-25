<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>GridView with Sticky Header</title>
    <style>
        .sticky-header {
            width: 100%;
            border-collapse: collapse;
            table-layout: fixed; /* Ensures the table doesn't stretch beyond its container */
        }

        .sticky-header th {
            position: sticky;
            top: 0; /* Sticks the header to the top */
            background-color: #f1f1f1; /* Background color for the header */
            z-index: 100; /* Ensures the header stays above other content */
        }

        .sticky-header th,
        .sticky-header td {
            padding: 8px;
            text-align: left;
            border: 1px solid #ddd; /* Borders for cells */
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>GridView with Sticky Header</h2>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="sticky-header">
                <Columns>
                    <asp:BoundField DataField="Column1" HeaderText="Column 1" />
                    <asp:BoundField DataField="Column2" HeaderText="Column 2" />
                    <asp:BoundField DataField="Column3" HeaderText="Column 3" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
