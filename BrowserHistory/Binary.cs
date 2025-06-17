namespace Binary
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                int[] data = { 1, 3, 5, 7, 9, 11, 13, 15 };
                int target = 7;
                Console.WriteLine("Линейно търсене: " + LinearSearch(data, target));
                Console.WriteLine("Бинарно търсене: " + BinarySearch(data, target));

            }
            static int LinearSearch(int[] arr, int target)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == target)
                    {
                        return i; // Връща индекса на намерения елемент
                    }
                }
                return -1; // Ако елементът не е намерен
            }
            static int BinarySearch(int[] arr, int target)
            {
                int left = 0, right = arr.Length - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    if (arr[mid] == target)
                    {
                        return mid; //намерен елемент
                    }
                    if (arr[mid] < target)
                    {
                        left = mid + 1; // Търсене в дясната половина
                    }
                    else
                    {
                        right = mid - 1; // Търсене в лявата половина
                    }
                }
                return -1; // Ако елементът не е намерен
            }
        
    }
    
}
