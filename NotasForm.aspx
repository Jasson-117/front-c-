<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NotasForm.aspx.cs" Inherits="front.NotasForm" %>

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
                   <label for="">id_notas</label>
                   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                
             </div>    
   <div>
              <label for="">id_estudiante</label>
              <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
   </div>           
           <div>
                 <label for="">id_asignatura</label>
                 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            
           </div>    
            <div>
                    <label for="">Asignatura</label>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                
            </div>    
            
           <div>
                 <label for="">nota 1</label>
                 <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            
           </div>    
             <div>
                   <label for="">nota 2</label>
                   <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                
             </div>    
    <div>
                    <label for="">nota 3</label>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        
    </div>          
    
   <div>
     <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
   </div>
          
    </div>   
    
      <div class="butons">
              <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
              <asp:Button ID="Button2" runat="server" Text="Crear" OnClick="Button2_Click" />
              <asp:Button ID="Button3" runat="server" Text="actualizar" OnClick="Button3_Click" />
              <asp:Button ID="Button4" runat="server" Text="Eliminar" OnClick="Button4_Click" />
        
      </div>     <div>
          <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        
      </div>    
      
<div>
          <asp:GridView ID="GridView2" runat="server"></asp:GridView>
    
</div>        </div>
    </form>
</body>
</html>
