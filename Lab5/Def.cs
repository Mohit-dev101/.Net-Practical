<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P5.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Select Date - Leave Application</title>
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
            padding: 30px;
            width: 100%;
            max-width: 450px;
            text-align: center;
        }

        .card h2 {
            color: #2c3e50;
            margin-bottom: 20px;
            font-size: 22px;
            font-weight: 600;
        }

        /* Styled ASP.NET Calendar */
        .styled-calendar {
            width: 100% !important;
            border-collapse: collapse;
            border: 1px solid #e2e8f0 !important;
            border-radius: 8px;
            overflow: hidden;
            margin-bottom: 20px;
        }

        .calendar-header {
            background-color: #3b82f6 !important;
            color: #ffffff !important;
            font-weight: bold;
            height: 40px;
        }

        .calendar-header a {
            color: #ffffff !important;
            text-decoration: none;
            font-size: 16px;
        }

        .calendar-title {
            background-color: #2563eb !important;
            color: #ffffff !important;
            font-weight: bold;
            height: 45px;
            font-size: 16px;
        }

        .calendar-title a {
            color: #ffffff !important;
            text-decoration: none;
        }

        .calendar-day-header {
            background-color: #f1f5f9 !important;
            color: #64748b !important;
            font-weight: 600;
            height: 35px;
        }

        .calendar-day {
            padding: 8px;
            color: #334155;
        }

        .calendar-day a {
            color: #334155;
            text-decoration: none;
            display: block;
            border-radius: 50%;
            width: 30px;
            height: 30px;
            line-height: 30px;
            margin: 0 auto;
        }

        .calendar-day a:hover {
            background-color: #e2e8f0;
        }

        .calendar-selected-day {
            background-color: #3b82f6 !important;
            color: #ffffff !important;
            border-radius: 50%;
            font-weight: bold;
        }

        .calendar-selected-day a {
            color: #ffffff !important;
        }

        .calendar-today {
            background-color: #fef08a !important;
            font-weight: bold;
            border-radius: 50%;
        }

        /* Label Styling */
        .date-label {
            display: block;
            font-size: 15px;
            font-weight: 600;
            color: #1e293b;
            margin-bottom: 20px;
            min-height: 22px;
        }

        /* Button Styling */
        .btn-apply {
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
        }

        .btn-apply:hover {
            background-color: #1d4ed8;
        }

        .btn-apply:active {
            transform: scale(0.98);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <h2>Select Leave Date</h2>

            <asp:Calendar 
                ID="Calendar1" 
                runat="server" 
                CssClass="styled-calendar"
                OnSelectionChanged="Calendar1_SelectionChanged"
                NextPrevStyle-CssClass="calendar-header"
                TitleStyle-CssClass="calendar-title"
                DayHeaderStyle-CssClass="calendar-day-header"
                DayStyle-CssClass="calendar-day"
                SelectedDayStyle-CssClass="calendar-selected-day"
                TodayDayStyle-CssClass="calendar-today"
                ShowGridLines="false">
            </asp:Calendar>

            <asp:Label ID="lblSelectedDate" runat="server" CssClass="date-label"></asp:Label>

            <asp:Button ID="btnApplyLeave" runat="server" Text="Apply Leave" CssClass="btn-apply" OnClick="btnApplyLeave_Click" />
        </div>
    </form>
</body>
</html>
