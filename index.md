<body>


	<div class="login">
      <h2>Giriş Yap</h2>
       <form id="form1" runat="server">
          <div class="k">
            <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı"></asp:Label>
              <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
          </div>
          <div class="k">
              <asp:Label ID="Label2" runat="server" Text="Şifre"></asp:Label>
              <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
          </div>
            <%--GİRİŞ BUTONU--%>
          <asp:Button ID="Button1" runat="server" Text="Giriş Yap" CssClass="button" OnClick="Button1_Click" />

      
           <%--HATA MESAJI--%>
          <br/> <asp:Label ID="Label3" runat="server" class="hata" ><strong>Hata!</strong> Kullanıcı Adı veya Şifre Hatalı!</asp:Label>
           </form>
	</div>
  
   
</body>
