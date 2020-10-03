using System;

namespace Tp3
{

	public class AVL{
		
		private IComparable dato;
		private AVL hijoIzquierdo;
		private AVL hijoDerecho;
		//private int altura;
		
		public AVL(IComparable dato){
			this.dato = dato;
		}
		
		public IComparable getDatoRaiz(){
			return this.dato;
		}
		
		public AVL getHijoIzquierdo(){
			return this.hijoIzquierdo;
		}
		
		public AVL getHijoDerecho(){
			return this.hijoDerecho;
		}

		public void setDatoraiz(IComparable dato){
			this.dato = dato;
		}
		
		public void setHijoderecho(AVL hijoDerecho){
			this.hijoDerecho = hijoDerecho;
		}

		public void setHijoizquierdo(AVL hijoIzquierdo){
			this.hijoDerecho = hijoIzquierdo;
		}
	
		public void agregarHijoIzquierdo(AVL hijo){
			this.hijoIzquierdo=hijo;
		}

		public void agregarHijoDerecho(AVL hijo){
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
				if(this.getHijoIzquierdo()!=null){
					this.balancear();
				}
			}
			else{
				this.agregarHijoIzquierdo(new AVL(elem));
			}
		}
		else{
			if(this.getHijoDerecho()!=null){
			this.getHijoDerecho().agregar(elem);
			if(this.getHijoDerecho()!=null){
					this.balancear();
				}
			}
			else{
				this.agregarHijoDerecho(new AVL(elem));
			}
		}	
	}
		public void rotacionSimpleDerecha() {
			AVL nodoPrincipal = this;
			AVL nodopIzquierdo = this.getHijoIzquierdo();
			nodoPrincipal.agregarHijoDerecho(new AVL(nodoPrincipal.getDatoRaiz()));

			this.setDatoraiz(hijoIzquierdo.getDatoRaiz());
			hijoIzquierdo.setDatoraiz(hijoIzquierdo.getHijoIzquierdo().getDatoRaiz());

			nodopIzquierdo.eliminarHijoIzquierdo();
		}
		public void rotacionSimpleIzquierda() {
			AVL nodoPrincipal = this;
			AVL hijoDerecho= nodoPrincipal.getHijoDerecho();
			nodoPrincipal.agregarHijoIzquierdo(new AVL(nodoPrincipal.getDatoRaiz()));

			this.setDatoraiz(hijoDerecho.getDatoRaiz());
			hijoDerecho.setDatoraiz(hijoDerecho.getHijoDerecho().getDatoRaiz());

			hijoDerecho.eliminarHijoDerecho();

		}
		public void rotacionDobleDerecha() {
		
		}	
		public void rotacionDobleIzquierda() {
		
		}
		public int altura(){
			if(this!=null){
				int izq=0;
				int der=0;
				if(this.getHijoIzquierdo()!=null){
					izq = this.getHijoIzquierdo().altura() +1;
				}
				if(this.getHijoDerecho()!=null){
					der = this.getHijoDerecho().altura() +1;
				}
				if(izq>der) return izq;
				return der;
			}
			return -1;
		}

		public void balancear(){
			AVL hijoIzquierdo = this.getHijoIzquierdo();
			AVL hijoDerecho = this.getHijoDerecho();
			int izq = 0;
			int der = 0;
			if(this.getHijoIzquierdo()!=null){
					izq = hijoIzquierdo.altura();
				}
			if(this.getHijoDerecho()!=null){
					der = hijoDerecho.altura();
				}

			if(izq>=1 && hijoDerecho==null){
				this.rotacionSimpleDerecha();
			}
			if(der>=1 && hijoIzquierdo==null){
				this.rotacionSimpleIzquierda();
			}                                       
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
		
	}
}