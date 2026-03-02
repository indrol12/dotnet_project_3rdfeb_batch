
//     class multi_di
//    {

//    public static void Main(String[] args)
//    {
//        //[10,20]           [50,60]
//        //[30,40]           [70,80]

//        long[,,] rollno =
//        {
//            { { 10,20},{30,40 } },//1st array
//            { { 50,60},{70,80 } }//2nd array
//        };
//        Console.WriteLine("total length:"+rollno.Length);
//        Console.WriteLine("matrix"+rollno.GetLength(0));//1st dimension
//        Console.WriteLine("row" + rollno.GetLength(1));//2nd dimension
//        Console.WriteLine("column" + rollno.GetLength(2));//3rd dimension
//        for (int m=0;m<rollno.GetLength(0);m++)
//        {//m=0 
//            for(int r=0;r<rollno.GetLength(1);r++)
//            {//r=0
//                for(int c=0;c<rollno.GetLength(2);c++)
//                {//c=0 c=1
//                    Console.Write(rollno[m,r,c]+" ");//0,0,0=10   0,0,1 =20
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine("-----------------------------");
//        }
//    }
//}
