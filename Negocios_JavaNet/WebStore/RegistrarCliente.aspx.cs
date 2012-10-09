using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rnd = WebStore.serviciosrping;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Collections;


	
namespace WebStore
{
    public partial class RegistrarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            String dni;
            dni = txtDni.Text;
            DataTable dT = new DataTable();                 
            rnd.PersonaServiceImplService svc = new rnd.PersonaServiceImplService();
            var ObjPersona = svc.validaPersonaInfo(dni);
            DataTable dt = new DataTable();
            int estado = 0;
            foreach (var persona in ObjPersona) 
            {
                estado = persona.estado;
                txtNombres.Text = persona.nombres.ToString();
                txtApellidos.Text = persona.apellidos.ToString();
                txtDireccion.Text = persona.direccion.ToString();
                txtTelefono.Text = persona.telefono.ToString();          
            }

            if (estado == 1)
            {
                lblResultado.Text = "Usted esta autorizado para registrarse";
                lblResultado.ForeColor = System.Drawing.Color.Blue;
                //Response.AddHeader("REFRESH", "3;URL=Catalogo.aspx");                
            }
            else
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "Ustede No Puede Registrarse por encontrarse deshabilitado en la Reniec";
            }
            //String valida = wsRnd.validaPersonaInfo(txtDni.Text);
            //String csv = valida;
            //String[] parts = csv.Split(';');
            //List<String> list = new List<String>(parts);
            //String estado = list[0].ToString();
           
            //if (estado.Equals("1"))
            //{
            //    txtNombres.Text = list[1].ToString();
            //    txtApellidos.Text = list[2].ToString();
            //    txtTelefono.Text = list[3].ToString();
            //    txtDireccion.Text = list[4].ToString();
            //    lblResultado.Text = "Registro Completo ... ";
            //    lblResultado.ForeColor = System.Drawing.Color.Blue;
            //    Response.AddHeader("REFRESH", "6;URL=Catalogo.aspx");
            //}
            //else
            //{
            //    lblResultado.ForeColor = System.Drawing.Color.Red;
            //    lblResultado.Text = "Ustede No Puede Registrarse";
            //}            
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}