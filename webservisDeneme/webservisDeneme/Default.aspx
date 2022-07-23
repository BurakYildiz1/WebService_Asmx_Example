<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webservisDeneme.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap" />
<script src="//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
<div class="container">
	<div class="row">
		<div class="panel panel-default">
                        <div class="form-group">
                            <label for="source_name" class="col-md-2 control-label">Source name</label>
                            <div class="col-md-8">
<asp:TextBox ID="txttckno" Text="Tckno girin" cssclass="form-control" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-2">
<asp:Button OnClick="Btnsorgula_Click" cssclass="btn btn-success" ID="Btnsorgula" runat="server" Text="TcSorgula" />
                            </div>
                        </div>
                <div class="panel-body" id="query-box" style="display: block">
                    <br /><br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
                    <br />
                        <div class="form-group">
                            <div class="col-md-offset-2 col-md-10">            

            <asp:Button ID="Btngetir" CssClass="btn btn-success" Text="Bütün Bilgileri Getir" OnClick="Btngetir_Click" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
        </div>
    </div>
        </div>
    </form>
</body>
</html>
