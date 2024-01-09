#region Task
Console.WriteLine("Task:");
//var response=await GetDataAsync();
//Console.WriteLine(response);
//async Task<string> GetDataAsync()
//{
//    HttpClient client = new HttpClient();
//    string result =await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
//    return result;
//}
#endregion
#region Thread
//Thread thread1 = new Thread(WriteB);
//Thread thread2 = new Thread(WriteA);
//thread1.Start();
//thread2.Start();
//thread1.Join();
//thread2.Join();
//Console.WriteLine("Thread:");


//void WriteA()
//{
//    for (int i = 0; i < 1000; i++)
//    {
//        //Thread.Sleep(1000);
//        Console.Write("a ");
//    }
//}

//void WriteB()
//{
//    for (int i = 0; i < 1000; i++)
//    {
//        //Thread.Sleep(1000);
//        Console.Write("b ");
//    }
//}


//int counter = 0;
//var lock1 = new Object();
//var lock2 = new Object();
//Thread t1 = new Thread(Increase);
//Thread t2 = new Thread(Decrease);
////t1.Start();
//t2.Start();

//Console.WriteLine(counter);


//void Increase()
//{
//    for (int i = 0; i < 1000000; i++)
//    {
//        lock (lock1)
//        {
//            lock (lock2)
//            {
//                counter++;
//            }
//        }
//    }
//}

//void Decrease()
//{
//    for (int i = 0; i < 1000000; i++)
//    {
//        lock (lock2)
//        {
//            lock(lock1)
//            {
//                counter--;
//            }
//        }
//    }
//}
#endregion


