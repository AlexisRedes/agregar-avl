using System;
using System.Collections.Generic;

namespace Tp3
{

	public class ArbolBinarioBusqueda{
		
		private IComparable dato;
		private ArbolBinarioBusqueda hijoIzquierdo;
		private ArbolBinarioBusqueda hijoDerecho;
		
		
		public ArbolBinarioBusqueda(IComparable dato){
			this.dato = dato;
		}
		
		
		public IComparable getDatoRaiz(){
			return this.dato;
		}
		
		public ArbolBinarioBusqueda getHijoIzquierdo(){
			return this.hijoIzquierdo;
		}
		
		public ArbolBinarioBusqueda getHijoDerecho(){
			return this.hijoDerecho;
		}
		
		public void agregarHijoIzquierdo(ArbolBinarioBusqueda hijo){
			this.hijoIzquierdo=hijo;
		}

		public void agregarHijoDerecho(ArbolBinarioBusqueda hijo){
			this.hijoDerecho=hijo;
		}
		
		public void eliminarHijoIzquierdo(){
			this.hijoIzquierdo=null;
		}
		
		public void eliminarHijoDerecho(){
			this.hijoDerecho=null;
		}
		
		public void agregar(IComparable elem) {
		if(elem.CompareTo(this.dato)==-1){
			if(this.getHijoIzquierdo()!=null){
				this.getHijoIzquierdo().agregar(elem);
			}
			else{
				this.agregarHijoIzquierdo(new ArbolBinarioBusqueda(elem));
			}
		}
		else{
			if(this.getHijoDerecho()!=null){
			this.getHijoDerecho().agregar(elem);
			}
			else{
				this.agregarHijoDerecho(new ArbolBinarioBusqueda(elem));
			}
		}	
		}
		public bool incluye(IComparable elem) {
			return false;
		}


		public void preorden() {
			Console.WriteLine(this.dato);
			if(this.getHijoIzquierdo()!=null){
				this.getHijoIzquierdo().preorden();
			}
			if(this.getHijoDerecho()!=null){
					this.getHijoDerecho().preorden();
				}
		}
		
		public void inorden() {
		}
		
		public void postorden() {
		}
		
		
	}
}