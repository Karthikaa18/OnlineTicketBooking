<%@ Page Language="C#" CodeBehind="Default.aspx.cs" Inherits="OnlineTicketBooking._Default"%>
<%--<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>--%>
<html>
<%--<link rel="stylesheet" href="style.css">--%>



<body>
	<section>
		<div class="color"></div>
		<div class="color"></div>
		<div class="color"></div>
		<div class="box">
			<div class="square" style="--i:0;"></div>
			<div class="square" style="--i:1;"></div>
			<div class="square" style="--i:2;"></div>
			<div class="square" style="--i:3;"></div>
			<div class="square" style="--i:4;"></div>
			<div class="square" style="--i:5;"></div>
			<div class="container">
				<div class="form">
					<h2>Login Form</h2>
					<form name="Login" method="post" runat="server" >
						<div class="inputBox">
							<input type="text" placeholder="Username">

							<input type="password" placeholder="Password">
							<div class="inputBox">
							<asp:button ID="Button2" class="button" runat="server" OnClick="check_login2"  Text="Login"/>
								<p class="forget">Don't have an account?
									<a href="Signup.aspx">Sign up</a>
								</p>
							</div>
						</div>
					</form>

				</div>
			</div>
		</div>
	</section>
</body>
    <script>
        $('#logincheckbox,#signupcheckbox').click(() => { $('#emaillog,#pswdlog').val('') });
        $('#logincheckbox,#signupcheckbox').click(() => { $('#name,#email,#password').val('') });
    </script>
</html>
