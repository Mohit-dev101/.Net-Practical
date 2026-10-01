<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Leave.aspx.cs" Inherits="LeaveApp.Leave" %>

 

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Leave Application</title>
    <style>
        * {
            box-sizing: border-box;
            margin: 0;
            padding: 0;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        body {
            background-color: #f4f7f6;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            padding: 20px;
        }

        .card {
            background: #ffffff;
            border-radius: 12px;
            box-shadow: 0 8px 24px rgba(0, 0, 0, 0.08);
            padding: 32px;
            width: 100%;
            max-width: 500px;
        }

        .card h2 {
            color: #1e293b;
            margin-bottom: 24px;
            font-size: 22px;
            font-weight: 600;
            text-align: center;
            border-bottom: 2px solid #f1f5f9;
            padding-bottom: 12px;
        }

        .form-table {
            width: 100%;
            border-collapse: separate;
            border-spacing: 0 14px;
        }

        .form-table td {
            vertical-align: middle;
        }

        .form-table td:first-child {
            width: 35%;
            font-weight: 600;
            color: #475569;
            font-size: 14px;
        }

        .form-table td:last-child {
            width: 65%;
        }

        /* Input Controls Styling */
        .form-control, 
        .form-table input[type="text"], 
        .form-table select, 
        .form-table textarea {
            width: 100%;
            padding: 10px 12px;
            border: 1px solid #cbd5e1;
            border-radius: 6px;
            font-size: 14px;
            color: #1e293b;
            background-color: #f8fafc;
            transition: all 0.2s ease;
        }

        .form-table input[type="text"]:focus, 
        .form-table select:focus, 
        .form-table textarea:focus {
            outline: none;
            border-color: #2563eb;
            background-color: #ffffff;
            box-shadow: 0 0 0 3px rgba(37, 99, 235, 0.15);
        }

        .form-table textarea {
            resize: vertical;
            min-height: 80px;
        }

        /* Dynamic Date Label */
        .leave-date-highlight {
            font-weight: 600;
            color: #2563eb;
            background-color: #eff6ff;
            padding: 6px 12px;
            border-radius: 6px;
            display: inline-block;
            font-size: 14px;
        }

        /* Checkbox Container */
        .checkbox-container {
            display: flex;
            align-items: center;
            gap: 8px;
            font-size: 14px;
            color: #475569;
            cursor: pointer;
        }

        /* Submit Button Styling */
        .btn-submit {
            background-color: #2563eb;
            color: #ffffff;
            border: none;
            padding: 12px 24px;
            font-size: 15px;
            font-weight: 600;
            border-radius: 6px;
            cursor: pointer;
            width: 100%;
            transition: background-color 0.2s ease, transform 0.1s ease;
            margin-top: 10px;
        }

        .btn-submit:hover {
            background-color: #1d4ed8;
        }

        .btn-submit:active {
            transform: scale(0.98);
        }

        /* Message Label */
        .msg-label {
            display: block;
            text-align: center;
            margin-top: 18px;
            font-size: 14px;
            font-weight: 600;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div class="card">
            <h2>Leave Application</h2>
            
            <table class="form-table">
                <tr>
                    <td>Employee Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Leave Date:</td>
                    <td>
                        <asp:Label ID="lblLeaveDate" runat="server" CssClass="leave-date-highlight"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Leave Type:</td>
                    <td>
                        <asp:DropDownList ID="ddlLeaveType" runat="server">
                            <asp:ListItem Text="Select Leave Type" Value="" />
                            <asp:ListItem Text="Casual Leave" Value="Casual" />
                            <asp:ListItem Text="Sick Leave" Value="Sick" />
                            <asp:ListItem Text="Earned Leave" Value="Earned" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Reason:</td>
                    <td>
                        <asp:TextBox ID="txtReason" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Remember Name:</td>
                    <td>
                        <label class="checkbox-container">
                            <asp:CheckBox ID="chkRemember" runat="server" Text="Remember my name" />
                        </label>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit Leave" CssClass="btn-submit" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>

            <asp:Label ID="lblMessage" runat="server" CssClass="msg-label" ForeColor="#16a34a"></asp:Label>
        </div>
    </form>
</body>
</html>
