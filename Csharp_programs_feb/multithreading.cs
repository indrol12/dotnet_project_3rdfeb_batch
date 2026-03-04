
class multithreading//1.create class
{
      void show()//2.create task for thread

    { 
        Console.WriteLine("Thread is executing");
        }
     void display()
    {
        Console.WriteLine("2nd thread is running");
    }
    public static void Main(string[] args)
    {
        multithreading ob1=new multithreading();

        Thread th1=new Thread(ob1.show);//3.create the instance of thread class
        Thread th2 = new Thread(ob1.display);
        th1.Start();//4.call start method
        th2.Start();
    }

}
