package org.institutoserpis.ed;


public class Array {

	public static void main(String[] args) {
		
		int[] v = new int[]{5, 9, 7, 12, 21};
			
		
		for(int index=0; index<5; index++)
		
			System.out.println("Elemento con index= " +index+ " vale " +v[index]);
	
		System.out.println("Suma del array = " +suma(v));
		System.out.println("Suma de otro array = " +suma(new int[]{14,24}));
		System.out.println("Suma del array vacio= " +suma(new int[]{}));
		
		
		System.out.println("El valor menor de v es: " +menor(v));
		System.out.println("El valor menor de v es: " +indexOf(v,21));
	
	}

	public static int suma(int[] v){
		// numero de elementos del vector: v.lenght
		int suma=0;
		
		
		//for(int index=0; index<v.length; index++)
		
			//suma=suma + v[index];
		
		for(int item : v)
			suma=suma+item;
		
		
		
		return suma;
	}

	public static int menor(int[] v){
		
//		int menor=v[0];
//			for(int index=1;index<v.length;index++){
				
	//		if(v[index]<menor){
					
		//		menor=v[index];
					
			//	}
				
				
		//	}
		
		
	//	return menor;
		
		
		int posMenor=0;
		for(int index=1;index<v.length;index++)
			if(v[index]<v[posMenor])
				posMenor=index;
		return v[posMenor];
		
	}
	
	public static void sort(int[] v){
		
		
	}
	
	public static int indexOf(int[] v,int item){
		
		for(int index =0; index<v.length; index++)
		  if(v[index]==item)
			return index;
		return -1;
	
		
		
		
		
	}
}

