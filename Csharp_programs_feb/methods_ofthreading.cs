
//     class methods_ofthreading
//    {
      
//    static void largestnum()
//    {

//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine(Thread.CurrentThread.Name+":-"+i);
//            Thread.Sleep(1000);
//        }
//    }
//    public static void Main(String[] args)
//    {
//        Thread anita = new Thread(largestnum);
//        anita.Name = "first thread";
//        anita.Start();
//        anita.Join();

//        Thread kavita = new Thread(largestnum);
//        kavita.Name = "second thread";
//        kavita.Start();
//    }
//}
