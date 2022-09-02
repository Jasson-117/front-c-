using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;

namespace front
{
    public partial class EstudiantesForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
                HttpClient clienteHttp = new HttpClient();
                clienteHttp.BaseAddress = new Uri("https://localhost:44377/");
                var request = clienteHttp.GetAsync("Api/Estudiantes2/").Result;

               if (request.IsSuccessStatusCode)
                {
                    var resultado = request.Content.ReadAsStringAsync().Result;
                    var listado = JsonConvert.DeserializeObject<List<Estudiante>>(resultado);
                    if (listado == null)
                    {
                        Response.Write("No hay datos para consultar");
                    }
                    else
                    {
                        GridView2.DataSource = listado;
                        GridView2.DataBind();
                    }
                }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try {
                HttpClient st = new HttpClient();
                st.BaseAddress = new Uri("https://localhost:44377/");
                Estudiante estudiante = new Estudiante()
                {
                    id_estudiante = int.Parse(TextBox1.Text),
                    name = TextBox2.Text,
                    apellido = TextBox3.Text,
                    email = TextBox4.Text,
                    fecha_nacimiento = TextBox5.Text,
                    cargo = TextBox6.Text
                };
                var data = JsonConvert.SerializeObject(estudiante);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                var request = st.PostAsync("api/Estudiantes2", content).Result;
                if (request.IsSuccessStatusCode)
                {
                    var consult = request.Content.ReadAsStringAsync();
                    Label1.Text = "Registro creado";
                }
            }catch(Exception we)
            {
                Label1.Text = "El registro ya existe";
            }
            
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpClient st = new HttpClient();
            st.BaseAddress = new Uri("https://localhost:44377/");
            Estudiante estudiante = new Estudiante()
            {
                id_estudiante = int.Parse(TextBox1.Text),
                name = TextBox2.Text,
                apellido = TextBox3.Text,
                email = TextBox4.Text,
                fecha_nacimiento = TextBox5.Text,
                cargo = TextBox6.Text
            };
            int id = int.Parse(TextBox1.Text);
            var data = JsonConvert.SerializeObject(estudiante);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var request = st.PutAsync($"api/Estudiantes2/{id}", content).Result;
            if (request.IsSuccessStatusCode)
            {
                var consult = request.Content.ReadAsStringAsync();
                Label1.Text = "Registro actualizado";
            }
        }

     


 

        protected void Button5_Click(object sender, EventArgs e)
        {
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("https://localhost:44377/");

            var id = int.Parse(TextBox1.Text);
            var request = clienteHttp.GetAsync($"Api/Estudiantes2/{id}").Result;

            if (request.IsSuccessStatusCode)
            {
                var resultado = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<List<Estudiante>>(resultado);
                if (listado == null)
                {
                    Response.Write("No hay datos para consultar");
                }
                else
                {
                    GridView1.DataSource = listado;
                    GridView1.DataBind();
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("https://localhost:44377/");
            var id = int.Parse(TextBox1.Text);
            var request = clienteHttp.DeleteAsync($"Api/Estudiantes2/{id}").Result;
            if (request.IsSuccessStatusCode)
            {
                Label1.Text = "Registro borrado";
            }
        }
    }
}