﻿/*
 * Creado por SharpDevelop.
 * Usuario: osiri
 * Fecha: 30/3/2023
 * Hora: 20:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP_1
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola<T>
	{

		
		private List<T> datos = new List<T>();
	
		public void encolar(T elem) {
			this.datos.Add(elem);
		}
	
		public T desencolar() {
			T temp = this.datos[0];
			this.datos.RemoveAt(0);
			return temp;
		}
		
		public T tope() {
			return this.datos[0]; 
		}
		
		public bool esVacia() {
			return this.datos.Count == 0;
		}
	}
}
