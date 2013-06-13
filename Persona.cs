using System;
using System.Collections;

namespace Practica3
{
	public class Persona
	{
		public String nombre;
		public String telefono;
		public String face;
		public String Domicilio;
		public String codigo;
		
		
		public Persona(){
			this.codigo = "";
			this.nombre = "";
			this.Domicilio = "";
			this.face = "";
			this.telefono = "";
		}
		
		
		Hashtable hashtable = new Hashtable();     //se crea una nueva hashtable

		
		public void pedirdatos(Persona person){
			
			Console.WriteLine("Ingresa el codigo");
			person.codigo = Console.ReadLine();
		    Console.WriteLine("Dame tu nombre:");
		    person.nombre = Console.ReadLine();
			Console.WriteLine("Dame tu telefono:");
		    person.telefono=  Console.ReadLine() ;
			Console.WriteLine("Dame tu facebook:");
		    person.face = Console.ReadLine();
			Console.WriteLine("Dame tu Domicilio:");
		    person.Domicilio = Console.ReadLine();
			Console.WriteLine("");	
		}
		
		public void anadirTabla(Persona person){   // metodo que sirve para añadir objetos a la tabla
		hashtable.Add(person.codigo,person);
	
		}
		
		
		
		public void pedirCodigo(){
			Console.WriteLine("Introduce el codigo a buscar");
			string cod = Console.ReadLine();
			if(hashtable.ContainsKey(cod) == true){         //si encuentra en la busqueda dentro de la hashtable
			Persona persona = (Persona)this.hashtable[cod];      
			Console.WriteLine("Codigo encontrado!\n");	
			persona.mostrarDatos(persona);
			Console.WriteLine("Pulse cualquier tecla para continuar");	
			Console.ReadKey();	
			Console.Clear();
			Console.WriteLine("\nDesea eliminar este codigo e introducir uno nuevo? S/N");
			string opcion = Console.ReadLine();
			if(opcion == "s"){	
	        persona.editarDatos(persona);       //metodo para eliminar y editar nuevos datos
				}else{
					Console.Clear();
				}

			}else{
				Console.WriteLine("No existe");
			}
			}
		
		
		
			                       
		public void editarDatos(Persona person){
		/*string cod = "";
				Console.WriteLine("Dame el código para editar");
				cod = Console.ReadLine();
				if(hashtable.ContainsKey(cod)== true){
					Persona persona = (Persona)this.hashtable[cod];*/
					 hashtable.Remove(person);
				      person.pedirdatos(person);
			         hashtable.Add(person.codigo,person);
		}
		//}
		
		
		
	
		public void mostrarDatos(Persona person){
		Console.WriteLine(person.nombre);
		Console.WriteLine(person.telefono);
		Console.WriteLine(person.face);
	    Console.WriteLine(person.Domicilio);
		Console.WriteLine("\n");	
		}
		
		
		
		public void imprimeTodos(){
		 ICollection personas = this.hashtable.Values;
			Console.WriteLine("Imprimiendo todos los valores de la hashtable:\n");
	        foreach( object objeto in personas )
	        {
	            Persona persona = (Persona) objeto;
				this.mostrarDatos(persona);
	        }	
		}
		
	/*	private void muestraCodigo(){
		this.codigo = codigo;
		return codigo;
		}*/
		
	}
}

