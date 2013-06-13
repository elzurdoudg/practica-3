using System;
using System.Collections;


namespace Practica3
{
	class Principal
	{	
		public Principal(){
			
		}
		
		
		public static void Main (string[] args)
		{
		Persona programa= new Persona();	
		Persona persona = new Persona();
		Persona persona2 = new Persona();
		Persona persona3 = new Persona();
		Persona persona4 = new Persona();
			
			persona.pedirdatos(persona);
			programa.anadirTabla(persona);
		    persona2.pedirdatos(persona2);
			programa.anadirTabla(persona2);
			persona3.pedirdatos(persona3);
			programa.anadirTabla(persona3);
		    persona4.pedirdatos(persona4);
			programa.anadirTabla(persona4);
			
            programa.pedirCodigo();
			programa.imprimeTodos();
		}
	}
}
