<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customer.aspx.cs" Inherits="WebApplication1.home2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 963px;
            height: 537px;
        }

        * {
  box-sizing: border-box;
}

body {
  margin: 0;
  font-family: Arial;
  font-size: 17px;
}

#myVideo {
  position: fixed;
  right: 0;
  bottom: 0;
  min-width: 100%; 
  min-height: 100%;
}

.content {
  position: fixed;
  bottom: 0;
  background: rgba(0, 0, 0, 0.5);
  color: #f1f1f1;
  width: 100%;
  padding: 20px;
}

#myBtn {
  width: 200px;
  font-size: 18px;
  padding: 10px;
  border: none;
  background: #000;
  color: #fff;
  cursor: pointer;
}

#myBtn:hover {
  background: #ddd;
  color: black;
}
    </style>
</head>


<body>

    <video autoplay muted loop id="myVideo">
  <source src="video.mp4" type="video/mp4">
  Your browser does not support HTML5 video.
</video>
    <div class="content">
        <h1><center> Customer Service</center></h1>
    <iframe
    allow="microphone;"
    width="350"
    height="430"
        style="margin-left: 580px"
    src="https://console.dialogflow.com/api-client/demo/embedded/643d1579-e537-41d5-86f5-8472991adfee">
</iframe>
                <a href="AddNewEmployee.aspx" style="color:white"><h4><center> Manage Customer</center></h4></a>

    </div>
</body>
</html>
