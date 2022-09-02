using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace front
{
    public partial class AsignaturasForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("https://localhost:44377/");
            var request = clienteHttp.GetAsync("Api/Asignaturas/").Result;

            if (request.IsSuccessStatusCode)
            {
                var resultado = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<List<Asignatura>>(resultado);
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
            try
            {
                HttpClient st = new HttpClient();
                st.BaseAddress = new Uri("https://localhost:44377/");
                Asignatura estudiante = new Asignatura()
                {
                    id_asignatura = int.Parse(TextBox1.Text),
                    name = TextBox2.Text,
         
                };
                var data = JsonConvert.SerializeObject(estudiante);
                HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                var request = st.PostAsync("api/Asignaturas", content).Result;
                if (request.IsSuccessStatusCode)
                {
                    var consult = request.Content.ReadAsStringAsync();
                    Label1.Text = "Registro creado";
                }
            }
            catch (Exception we)
            {
                Label1.Text = "El registro ya existe";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpClient st = new HttpClient();
            st.BaseAddress = new Uri("https://localhost:44377/");
            Asignatura estudiante = new Asignatura()
            {
                id_asignatura = int.Parse(TextBox1.Text),
                name = TextBox2.Text,
               
            };
            int id = int.Parse(TextBox1.Text);
            var data = JsonConvert.SerializeObject(estudiante);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var request = st.PutAsync($"api/Asignaturas/{id}", content).Result;
            if (request.IsSuccessStatusCode)
            {
                var consult = request.Content.ReadAsStringAsync();
                Label1.Text = "Registro actualizado";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("https://localhost:44377/");

            var id = int.Parse(TextBox1.Text);
            var request = clienteHttp.GetAsync($"Api/Asignaturas/{id}").Result;

            if (request.IsSuccessStatusCode)
            {
                var resultado = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<List<Asignatura>>(resultado);
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

        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("https://localhost:44377/");
            var id = int.Parse(TextBox1.Text);
            var request = clienteHttp.DeleteAsync($"Api/Asignaturas/{id}").Result;
            if (request.IsSuccessStatusCode)
            {
                Label1.Text = "Registro borrado";
            }
        }
    }
}