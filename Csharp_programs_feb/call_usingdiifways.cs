
//   class call_usingdiifways
//    {
//    public static void Main(String[] args)
//    {
//        int actual_value = 15;
//        Console.WriteLine("_________call by Value_________");
//        Console.WriteLine("before call by value:"+actual_value);//15
//        value1(actual_value);//call by value
//        Console.WriteLine("after call by value:" + actual_value);//15
//        Console.WriteLine("_________call by reference_________");
//        int av = 48;
//        Console.WriteLine("before call by reference:" + av);//48
//        value2(ref av);
//        Console.WriteLine("after call by reference:" + av);//91
//    }
//    static void value2(ref int n2)//call by reference
//    {
//        n2 = 91;
//    }
//    static void value1(int num)//num=15   //call by value
//    {
//        num = 20;//num=20
//    }
//}
