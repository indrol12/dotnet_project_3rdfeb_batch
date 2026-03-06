
//    class synchronization
//    {
//    static object o = new object();
//    static void increment()
//    {
//        lock (o)//other thread will wait untill first thread is completed with the execution

//        {
//            Console.WriteLine(Thread.CurrentThread.Name + "Thread is executing");
//        }
//    }
//    public static void Main(String[] args)
//    {
//        Thread user1=new Thread(increment);
//        Thread user2=new Thread(increment);
//        user1.Name = "first user";
//        user2.Name = "second user";

//            user1.Start();
//          user2.Start();


//    }
//}
