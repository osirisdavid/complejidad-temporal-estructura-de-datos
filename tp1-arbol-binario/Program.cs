/*
 * Creado por SharpDevelop.
 * Usuario: osiri
 * Fecha: 30/3/2023
 * Hora: 17:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			var arbol7 = new ArbolBinario<int>(7);
			var arbol6 = new ArbolBinario<int>(6);
			var arbol5 = new ArbolBinario<int>(5);
			var arbol4 = new ArbolBinario<int>(4);
			var arbol3 = new ArbolBinario<int>(3);
			var arbol2 = new ArbolBinario<int>(2);
			var arbol1 = new ArbolBinario<int>(1);
			
			arbol1.agregarHijoIzquierdo(arbol2);
			arbol1.agregarHijoDerecho(arbol3);
			
			arbol2.agregarHijoIzquierdo(arbol4);
			arbol2.agregarHijoDerecho(arbol5);
			
			arbol3.agregarHijoIzquierdo(arbol6);
			arbol3.agregarHijoDerecho(arbol7);
			
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("INCLUYE");
			Console.WriteLine(arbol1.incluye(7));
			
			
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("PREORDEN");
			arbol1.preorden();
			
			
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("INORDEN");
			arbol1.inorden();
			
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("POSTORDEN");
			arbol1.postorden();
			
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("CONTAR HOJAS");
			Console.WriteLine( arbol1.contarHojas());
			
			
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("ENTRE NIVELES");
			arbol1.recorridoEntreNiveles(1,3);
			
			Console.ReadKey(true);
		}
	}
}