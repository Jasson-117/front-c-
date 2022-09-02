<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstudiantesForm.aspx.cs" Inherits="front.EstudiantesForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link rel="stylesheet" href="style.css">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <header>
        <nav>
            <h2><a href="AsignaturasForm.aspx">Asignaturas</a></h2>
            <h2><a href="NotasForm.aspx">Notas</a></h2>
            <h2><a href="EstudiantesForm.aspx">Estudiante</a></h2>


        </nav>
    </header>
    <form id="form1" runat="server">
        <div class="grid-form">
 <div>
     <div>
                 <label for="">id</label>
                 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        
     </div>        
      <div>
                <label for="">nombre</label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
         
      </div>      
       <div>
                   <label for="">apellido</label>
                   <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
           
       </div>        
       <div>
                   <label for="">email</label>
                   <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
           
       </div>      
       
     <div>
                 <label for="">Fecha nacimiento</label>
                 <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
       
     </div>      
      <div>
                <label for="">cargo</label>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
       
      </div>       
      
      <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        
 </div>   <div class="butons">
                <asp:Button ID="Button1" runat="server" Text="Crear" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Actualizar" OnClick="Button2_Click" />
                <asp:Button ID="Button5" runat="server" Text="Buscar" OnClick="Button5_Click" />
                <asp:Button ID="Button3" runat="server" Text="Eliminar" OnClick="Button3_Click" />
            
        </div>    
        
<div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    
</div>          

<div>
       <asp:GridView ID="GridView2" runat="server"></asp:GridView>
    
</div>        </div>
    </form>
</body>
</html>
