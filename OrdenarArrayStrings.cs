using System;

//No es necesario usar esto, se puede usar CompareTo(), pero ya que lo saqué quise guardarlo

public class Program
{
	public static void printArray(string[] nombres) {
		
		for(int i=0; i<4; i++) {
			Console.WriteLine(nombres[i]);
		}
		Console.WriteLine();
	}
	
	public static void Main()
	{
		string a = "David Martínez";
		string b = "Daniel Torregrosa";
		string c = "David López";
		string d = "Eliseo Fuentes";
		
		string[] nombres = new string[4];
		
		nombres[1] = a;
		nombres[2] = b;
		nombres[3] = c;
		nombres[0] = d;
		
		printArray(nombres);
		
		string nombre1, nombre2, nombreIntercambio;
		
		for(int i=0; i<nombres.Length; i++) {
			
			for(int j=i+1; j<nombres.Length; j++) {
			
				for(int k=0; k<nombres[i].Length && k<nombres[j].Length; k++) {
					
					nombre1 = nombres[i];
					nombre2 = nombres[j];
					
					Console.WriteLine(nombre1[k] + ", " + nombre2[k]);
					
					if(nombre1[k] < nombre2[k]) {
						break;	
					}
					
					if(nombre1[k] > nombre2[k]) {
						
						nombreIntercambio = nombres[i];
						nombres[i] = nombres[j];
						nombres[j] = nombreIntercambio;
						
						printArray(nombres);
						break;
					}
				}
				
				Console.WriteLine();
			}
		}
	}
}
