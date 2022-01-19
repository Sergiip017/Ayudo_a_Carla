using System;
class HelloWorld {
    
  static void Main() {
    
    int aux = 0, aux2 = 0;
    string[] nombres = new string[10];
    nombres[0] = "Alicia";
    nombres[1] = "Bruno";
    nombres[2] = "Carla";
    nombres[3] = "David";
    nombres[4] = "Eliseo";
    nombres[5] = "Fatima";
    nombres[6] = "Gonzalo";
    nombres[7] = "Hector";
    nombres[8] = "Ivan";
    nombres[9] = "Jose";
    
    for(int i=2; i<nombres.Length; i++) {
        
        if(nombres.Length%i == 0) {
            
            aux = nombres.Length/i; // 6/2 = 3 -> Numero de grupos
            aux2 = i;               // 2 -> Numero de integrantes del grupo
            //Console.WriteLine("Aux: " + aux);
            //Console.WriteLine("Aux2: " + aux2);
            
            //j=0 k=0
            //j=0 k=1
            
            //j=1 k=2
            //j=1 k=3
            
            //j=2 k=4
            //j=2 k=5
            
            Console.WriteLine("Grupos de " + aux2 + " integrantes: ");
            
            for(int j=0; j<aux; j++) {
                
                for(int k=0; k<aux2; k++) {
                        
                    Console.Write(nombres[j*aux2+k]);
                }
                
                Console.WriteLine();
            }
            
            Console.WriteLine();
        }
    }
  }
}
