//Task1
// List<int> list1 = new List<int>{1, 2, 3, 4, 5};
// List<int> list2 = new List<int>{6, 7, 8, 9, 10};
// list1.AddRange(list2);
// list1.Sort();
// var list3 = list1.Distinct().ToList();
// foreach (int x in list3)
// {
//     Console.WriteLine(x);
// }

//Task2
// List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
// numbers.RemoveAll(x => x % 2 == 0);
// foreach (int x in numbers)
// {
//     Console.WriteLine(x);
// }

//Task3
// List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
// Random random = new Random();
// for(int i = 0; i < list1.Count; i++)
// {
//    int ind = random.Next(0, list1.Count - 1);
//     int temp = 0;
//     temp = list1[i];
//     list1[i] = list1[ind];
//     list1[ind] = temp;
// }
// foreach (int x in list1)
// {
//     Console.WriteLine(x + " ");
// }

//Task4




//Task5 
// List<string> list = new List<string> { "Apple", "Banana", "Orange" };
// System.Console.WriteLine(string.Join(" , " , list));


//Task6
// List<int> MergeArrays(int[] array1, int[] array2)
// {
//     List<int> mergedList = new List<int>(array1);
//     mergedList.AddRange(array2);
//     return mergedList.Distinct().ToList();
// }
// int[] array1 = { 1, 2, 3 };
// int[] array2 = { 3, 4, 5 };
// List<int> result = MergeArrays(array1, array2);
// foreach (int x in result)
// {
//     Console.WriteLine(x);
// }

//Task7
// int[] Unique(int[] array)
// {
//     return array.Distinct().ToArray();
// }
// int[] numbers = { 1, 2, 2, 3, 3, 4 };
// int[] result = Unique(numbers);
// foreach (int x in result)
// {
//     Console.WriteLine(x);
// }

//Task8
// class Program
// {
//     static void Main()
//     {
//         Shape circle = new Circle(5);
//         Shape rectangle = new Rectangle(4, 6);
//         Shape triangle = new Triangle(4, 5);
       

//         Console.WriteLine("Circle:");
//         Console.WriteLine("Area: " + circle.CalculateArea());
//         Console.WriteLine("Volume: " + circle.CalculateVolume());

//         Console.WriteLine();

//         Console.WriteLine("Rectangle:");
//         Console.WriteLine("Area: " + rectangle.CalculateArea());
//         Console.WriteLine("Volume: " + rectangle.CalculateVolume());

//         Console.WriteLine();

//         Console.WriteLine("Triangle:");
//         Console.WriteLine("Area: " + triangle.CalculateArea());
//         Console.WriteLine("Volume: " + triangle.CalculateVolume());
//         Console.WriteLine();
//         Console.WriteLine("Cylinder:");
//         Console.WriteLine();
//         Console.WriteLine("Cube:");
    
//     }
// }



