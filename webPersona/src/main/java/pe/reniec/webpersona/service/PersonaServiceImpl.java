package pe.reniec.webpersona.service;

import java.util.ArrayList;
import java.util.Collection;

import javax.jws.WebParam;
import javax.jws.WebService;

import pe.reniec.webpersona.dao.dao;
import pe.reniec.webpersona.excepcion.DAOExcepcion;
import pe.reniec.webpersona.modelo.Persona;
import pe.reniec.webpersona.negocio.PersonaNegocio;

@SuppressWarnings("restriction")
@WebService(endpointInterface = "pe.reniec.webpersona.service.PersonaService")
public class PersonaServiceImpl implements PersonaService {

	public String validaPersona(@WebParam(name = "dni") String dni) {
		System.out.println("antes del dao");
		dao objDato = new dao();
		System.out.println("despues del dao");
		System.out.println(dni);
		int valor = 0;
		try {
			valor = objDato.login(dni);
		} catch (DAOExcepcion e) {
			System.out.println("ocurrio el mensaje");
			System.out.println(e.getMessage());
			e.printStackTrace();
		}
		return String.valueOf(valor);
	}

	public Persona[] validaPersonaInfo(@WebParam(name = "dni") String dni) {
		PersonaNegocio objNegocio = new PersonaNegocio();
		Collection lst = null;
		try {
			System.out.println("implemen");
			lst = objNegocio.ValidarInfoNegocio(dni);
			ArrayList<Persona> lPersona = (ArrayList<Persona>) lst; 
			Persona[] lTarea = new Persona[lPersona.size()];
			for(int i = 0;i < lPersona.size(); i++){
				lTarea[i] = (Persona)lPersona.get(i);;
			}
			return lTarea;
		} catch (DAOExcepcion e) {
			e.printStackTrace();
			return new Persona[0];
		}
	
	}
	
	
	
//	public BTarea[] obtenerTareas(int idUsuario, String fecha){		
//		DTarea dTarea = new DTarea();
//		try{			
//			ArrayList<BTarea> lTareas = dTarea.obtenerTareas(idUsuario, fecha, this.con); 
//			BTarea[] lTarea = new BTarea[lTareas.size()];
//			for(int i = 0;i < lTareas.size(); i++){
//				lTarea[i] = (BTarea)lTareas.get(i);
//			}	
//			return lTarea;
//		}
//		catch(Exception e){
//			e.printStackTrace(System.out);
//			return new BTarea[0];
//		}
//	}

	public Collection<Persona> validaPersonaInfoTest(String dni) {
		PersonaNegocio objNegocio = new PersonaNegocio();
		Collection lst = null;
		try {
			System.out.println("implemen");
			lst = objNegocio.ValidarInfoNegocio(dni);
			// return objNegocio.ValidarInfoNegocio(dni);
			// /System.out.println(lst.size());
		} catch (DAOExcepcion e) {
			e.printStackTrace();
		}
		return lst;
	}
}