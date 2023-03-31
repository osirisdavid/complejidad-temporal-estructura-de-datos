/*
 * Creado por SharpDevelop.
 * Usuario: osiri
 * Fecha: 30/3/2023
 * Hora: 17:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_1
{
	public class ArbolBinario<T>
	{
		
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
		private Cola<T> cola = new Cola<T>();
	
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		
		public bool incluye(T elem){
			bool res = false;
			
			if(this.dato.Equals(elem)){
				return true;
			}
			if(hijoIzquierdo != null){
				res =  this.getHijoIzquierdo().incluye(elem);
			}
			if(hijoDerecho != null && !res){
				res = this.getHijoDerecho().incluye(elem);
			}
			return res;
		}
		
		//Se procesa primero la raíz y luego sus hijos, izquierdo y derecho.
		public void preorden() {
			Console.WriteLine(dato);
			if(this.hijoIzquierdo != null){
				hijoIzquierdo.preorden();
			}
			if(this.hijoDerecho!= null){
				this.hijoDerecho.preorden();
			}
		}
		
		//Se procesa el hijo izquierdo, luego la raíz y último el hijo derecho
		public void inorden() {
			if(this.hijoIzquierdo != null){
				this.hijoIzquierdo.inorden();
			}
			Console.WriteLine(this.dato);
			if(this.hijoDerecho != null){
				this.hijoDerecho.inorden();
			}
		}
		
		//Se procesan primero los hijos, izquierdo y derecho, y luego la raíz
		public void postorden() {
			if(this.hijoIzquierdo != null){
				this.hijoIzquierdo.postorden();
			}
			if(this.hijoDerecho != null){
				this.hijoDerecho.postorden();
			}
			Console.WriteLine(this.dato);
		}
		
		public void recorridoPorNiveles(){
			
		}
	
		public int contarHojas() {
			int res = 0;
			if(esHoja())
				res += 1;
			if(this.hijoIzquierdo != null)
				res += this.hijoIzquierdo.contarHojas();
			
			if(this.hijoDerecho != null)
				res += this.hijoDerecho.contarHojas();
			return res;
		}
		
		//imprime el recorrido por niveles de los elementos del árbol receptor entre los niveles n y m (ambos inclusive)
		public void recorridoEntreNiveles(int n,int m) {
			/*this.cola.encolar(this);
			while(cola.esVacia()){
				Console.WriteLine (this.cola.desencolar());
				if(this.hijoIzquierdo != null)
					this.cola.encolar(this.hijoIzquierdo);
				if(this.hijoDerecho != null)
					this.cola.encolar((T)this.hijoDerecho);
			}*/
		}
	}

}
