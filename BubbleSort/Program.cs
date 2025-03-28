while (true)
{
   Console.WriteLine("Choose an option:");
   Console.WriteLine("1. Use a prefilled array of 10 items");
   Console.WriteLine("2. Enter your own array");
   Console.WriteLine("3. Exit program");
   Console.Write("Enter your choice (1, 2, or 3): ");
   int choice = int.Parse(Console.ReadLine());

   int[] array;

   if (choice == 3)
   {
       Console.WriteLine("Exiting the program. Goodbye!");
       break;
   }

   if (choice == 1)
   {
       // Prefilled array of 10 items
       array = new int[] { 45, 23, 78, 12, 89, 34, 67, 91, 10, 56 };
       Console.WriteLine("Using prefilled array.");
   }
   else if (choice == 2)
   {
       // Input-based array
       Console.Write("Enter the size of the array: ");
       int size = int.Parse(Console.ReadLine());
       array = new int[size];

       Console.WriteLine("Enter the elements of the array:");
       for (int i = 0; i < size; i++)
       {
           Console.Write($"Element {i + 1}: ");
           array[i] = int.Parse(Console.ReadLine());
       }
   }
   else
   {
       Console.WriteLine("Invalid choice. Please try again.");
       return;
   }

   Console.WriteLine("\nArray before sorting:");
   DisplayArray(array);

   // Bubble Sort
   BubbleSort(array);

   Console.WriteLine("\nArray after sorting:");
   DisplayArray(array);
}