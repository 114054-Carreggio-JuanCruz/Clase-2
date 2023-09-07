namespace estructuras;

public class FizzBuzz{
    
    
    public void EjecutarFizzBuzz(){
        
        string mostrar="";
        for (int i = 1; i < 101; i++)
        {
           if(i%3==0 && i%5==0){
            mostrar = "Fizzbuzz";
           }
           else if(i%3==0){
            mostrar = "Fizz";
           }
           else if(i%5==0){
            mostrar = "Buzz";
           }
           else{
            mostrar= i.ToString();
           }
           Console.Write($"{mostrar} ");
        }
    }
}