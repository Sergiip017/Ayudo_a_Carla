//Recorremos recursivamente un numero, y comprobamos si sus digitos
//siguen un orden ascendente

using System;
class HelloWorld {
    
    static bool DigitosAscendentes(int numero) {
        
        bool ascendente = true;
        //numero = 122368
        Console.WriteLine(numero);
        
        //Obtenemos los dos ultimos digitos del numero
        int num1 = numero%10; //num1 = 8 
        int num2 = (numero/10)%10; //num2 = 6
        
        //Si numero es menor que 10, solo queda un digito
        if(numero<10){
            
            Console.WriteLine("Es el ultimo digito");
        }
        
        //Si num1 es mayor o igual que num2 seguimos iterando
        else if(num1 > num2 || num1 == num2) { 
            
            ascendente = DigitosAscendentes(numero/10);
        }
        
        //Si num1 es menor que num2, el numero no es ascendente
        else { 
            
            ascendente = false;
        }
        
        return ascendente;
    }
    
    static void Main() {
    
        bool resultado = DigitosAscendentes(122368);
        //bool resultado = DigitosAscendentes(435678);
        //bool resultado = DigitosAscendentes(111111);
        //bool resultado = DigitosAscendentes(987654);
        
        if(resultado) { Console.WriteLine("El numero es ascendente"); }
        else { Console.WriteLine("El numero no es ascendente"); }
    }
}
