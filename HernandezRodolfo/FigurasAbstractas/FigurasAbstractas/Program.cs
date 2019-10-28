using System;
using System.Collections.Generic;

namespace figura
{
     abstract class Figura 
    {
        protected int x;
        protected int y;
        protected string color;

        public Figura(int x, int y, string color){
            this.x = x; this.y = y; this.color = color;
        }

        public abstract void dibuja();
        
    

       // public abstract  void printColor();
         
    
    }

    class Circulo:Figura 
    {
        public Circulo(int x, int y, string color):base(x , y, color){
        }

        public override void dibuja(){
            Console.WriteLine("Se dibuja un circulo en la ubicacion x= {0}, y ={1}, color {2}",x,y,color);
        }
    }

    class Rect:Figura 
    {
        public Rect(int x, int y, string color):base(x , y, color){
            
        }

        public override void dibuja(){
            Console.WriteLine("Se dibuja un Cuadrado  en la ubicacion x= {0}, y = {1}, del color {2}",x,y,color);
        }

    }
    class Triangulo:Figura 
    {
        public Triangulo(int x, int y, string color):base(x , y, color){
            
        }

        public override void dibuja(){
            Console.WriteLine("Se dibuja un Triangulo  en la ubicacion x= {0}, y = {1}, del color {2}",x,y,color);
        }

    }
    class Cuadrado:Figura 
    {
        public Cuadrado(int x, int y, string color):base(x , y, color){
            
        }

        public override void dibuja(){
            Console.WriteLine("Se dibuja un Cuadrado  en la ubicacion x= {0}, y = {1}, del color {2}",x,y,color);
        }

    }
    class Hexagono:Figura 
    {
        public Hexagono(int x, int y, string color):base(x , y, color){
            
        }

        public override void dibuja(){
            Console.WriteLine("Se dibuja un Hexagono  en la ubicacion x= {0}, y = {1}, del color {2}",x,y,color);
        }

    }
    class Trapecio:Figura 
    {
        public Trapecio(int x, int y, string color):base(x , y, color){
            
        }

        public override void dibuja(){
            Console.WriteLine("Se dibuja un Trapecio  en la ubicacion x= {0}, y = {1}, del color {2}",x,y,color);
        }

    }

    class Octagono:Figura 
    {
        public Octagono(int x, int y, string color):base(x , y, color){
            
        }

        public override void dibuja(){
            Console.WriteLine("Se dibuja un Octagono  en la ubicacion x= {0}, y = {1}, del color {2}",x,y,color);
        }

    }
    class Program{
        static void Main(string[] args)
        {
           List<Figura>  fig = new List <Figura>();
           fig.Add(new Circulo(10,20,"Rojo"));
           fig.Add(new Rect(15,25,"Azul"));
           fig.Add(new Triangulo(20,22,"Verde"));
           fig.Add(new Cuadrado(11,22,"Morado"));
           fig.Add(new Hexagono(20,30,"Amarillo"));
           fig.Add(new Trapecio(29,35,"Negro"));
           fig.Add(new Octagono(29,33,"Blanco"));

           foreach(var figu in fig)
           {
               figu.dibuja();
           }

            }
        }
}