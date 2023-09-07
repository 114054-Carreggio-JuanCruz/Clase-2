namespace estructuras;

public class Temperaturas{
    
    float temperatura;    
    int diasBajoCero=0;
    bool temperaturaExtrema=false;
    List<float>temperaturas=new List<float>();
    List<float>temperaturasCalidas=new List<float>();
    List<float>temperaturasFrias=new List<float>(); //Dias menores a 20grdos
            
    public void Calculotemperaturas(){
        Console.WriteLine("Ingrese una temperatura");
        temperatura=float.Parse(Console.ReadLine());

        while(temperatura!=1000){
            if(temperatura>=-20 && temperatura<=50){
                temperaturas.Add(temperatura);
                Console.WriteLine("Ingrese una temperatura | Si desea finalizar la carga ingrese 1000.");
                temperatura=float.Parse(Console.ReadLine());
            }
        }
        foreach(float temp in temperaturas){
            if(temp>=20){
                temperaturasCalidas.Add(temp);
            }
            if(temp<0){
                diasBajoCero++;
            }
            if(temp<20){
                temperaturasFrias.Add(temp);
            }
            if(temp>40){
                temperaturaExtrema=true;
            }
        }
        
        
        Console.WriteLine($"El total de dias con temperatura bajo cero fue de: {diasBajoCero} dias");
        Console.WriteLine($"El promedio de temperaturas totales fue de: {temperaturas.Average()} dias");
        Console.WriteLine($"EL promedio de tempreraturas con dias calidos fue de: {temperaturasCalidas.Average()} dias");
        if(temperaturaExtrema){
            Console.WriteLine("Hubo por lo menos un dia con mas de 40 grados;");
        }
        if(!temperaturaExtrema){
            Console.WriteLine("No hubo ni un dia con mas de 40 grados;");
        }
        Console.WriteLine($"La mayor temperatura de los dias frios fue de {temperaturasFrias.Max()}");
    }
}