namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List
            //List<int> lists = new List<int>();
            //lists.Add(1);
            //lists.Add(2);
            //lists.Add(3);
            //lists.Add(4);
            //lists.Add(5);
            ////Console.WriteLine(lists.Remove(1));     //true
            ////Console.WriteLine(lists.Remove(2));     //true
            ////Console.WriteLine(lists.Remove(30));    //false
            //foreach(var list in lists)
            //{
            //    Console.WriteLine(list);
            //}
            #endregion

            #region Queue
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Peek());

            #endregion

            #region Stack
            //Stack<int> stacks = new Stack<int>();
            //stacks.Push(1);
            //stacks.Push(2);
            //stacks.Push(3);
            //Console.WriteLine(stacks.Pop());
            //Console.WriteLine(stacks.Peek());
            //Console.WriteLine(stacks.Peek());
            #endregion

            #region ArrayList

            //ArrayList list = new ArrayList();
            //list.Add(15);
            //list.Add(24);
            //list.Add(30);
            //foreach (object item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("*************************");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.WriteLine("*************************");
            //list.Remove(24);      //Remove- ədədi alır və həmin ədədi silir.
            //foreach (object o in list)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine("*************************");
            //list.RemoveAt(0);   //ReamoveAt-index alır,indexdəki ədədi silir.
            //foreach (object o in list)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine("*************************");
            //list.Insert(list.Count - 1, 16);
            //foreach (object o in list)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine("*************************");
            //list.Insert(0, 3);
            //foreach (object o in list)
            //{
            //    Console.WriteLine(o);
            //}
            //int index = list.IndexOf(30);  //Indexof-ededin indexsini qaytarir
            //Console.WriteLine(index);

            #endregion

            #region LinkedList

            //LinkedList<string> linkedlist = new LinkedList<string>();
            //Console.WriteLine("Show elements:");
            //linkedlist.AddLast("Surayya");
            //linkedlist.AddLast("Ali");
            //linkedlist.AddLast("Orkhan");
            //foreach (var list in linkedlist)
            //{
            //    Console.WriteLine(list);
            //}
            //Console.WriteLine("*********************");
            //Console.WriteLine(linkedlist.Remove("Su"));

            #endregion

            #region HashSet

            //HashSet<int> hashSet = new HashSet<int>();
            //hashSet.Add(12);
            //hashSet.Add(20);
            //hashSet.Add(33);
            //hashSet.Add(45);

            //foreach(var set in hashSet)
            //{
            //    Console.WriteLine(set);
            //}
            //Console.WriteLine(hashSet.Remove(12));


            #endregion

            #region Dictionary

            //Dictionary<int, string> dictionary = new Dictionary<int, string>()
            //{
            //    {1,"Azerbaijan"},
            //    {2,"Turkey" },
            //    {3,"German" },
            //    {4,"USA" }
            //};

            //dictionary.Add(5, "China");

            //foreach (var key in dictionary)
            //{
            //    Console.WriteLine($"{key.Key}:{key.Value}");
            //}

            #endregion

            #region Tuple

            //Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(1, "Doctor",true);

            //Console.WriteLine($"{tuple.Item1} {tuple.Item2} {tuple.Item3}");

            #endregion

            #region IEnumerable

            //IEnumerable<string> enumerable = new List<string>() { "Hello", "Cutentag", "Bonjour" };

            //foreach (var item in enumerable)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region ICollection

            //ICollection<int> collection=new List<int>() { 12,23,34,45,56};

            //foreach(var item in collection)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }
    }
}
