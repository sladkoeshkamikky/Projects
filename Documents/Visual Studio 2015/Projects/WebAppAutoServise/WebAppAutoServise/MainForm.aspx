<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="WebAppAutoServise.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Autoservise</title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="form">
       
            <h3>Данные авто</h3>
            <div class="Auto">
                <div>
                    <label>Дата выпуска</label>
                    <input name="DateOfIssue" />
                </div>
                <div>
                    <label>Пробег</label>
                    <input name="Run" />
                </div>
                <div>
                    <label>Владелец</label>
                    <input name="CarOwner" />
                </div>
                <div>
                    <label>Марка авто</label>
                    <input name="CarBrand"/>
                </div>
                <input type="submit" value="Вставить в БД" />
            </div>
        
    </div>
         <style>
        .form { position: absolute; left: 50%; width: 470px; margin-left: -235px; background: #888; border-radius: 5px; top: 20px; }
        form { background: #fff; border-radius: 2px;  margin: 5px;  }
        .data { border-top: 1px solid #d5d5d5; padding: 10px 15px; }
        .data div { margin: 8px 0; }
        h3 { padding: 10px 15px; margin: 0; }
        label { min-width: 100px; display: block; float: left; }
        input[type="submit"] { margin-top: 10px; }
    </style>

    <div>
    
    </div>
    </form>
</body>
</html>
