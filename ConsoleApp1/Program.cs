using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String_Anagrams(); 

            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("a value :" + a);

            //while(a>0)
            //{
            //    UInt32 n = Convert.ToUInt32(Console.ReadLine());
            //    //numberReverse(n);
            //    swapBits(n);
            //    a--;
            //}

            //while (a >0)
            //{
            //    numberToBinary(a);
            //    a--;
            //string arrayElemets = Console.ReadLine();
            //string[] tokens = arrayElemets.Split(' ');
            //flipBits(Convert.ToInt32(tokens[0]), Convert.ToInt32(tokens[1]));
            //numberReverse(a);

            //string arrayElemets = Console.ReadLine();
            //string[] tokens = arrayElemets.Split(' ');
            //Console.WriteLine(

            //    (power(Convert.ToInt32(tokens[0]), Convert.ToInt32(tokens[1])))% 1000000007

            //    );

            //a--;
            // }
            //string position = Console.ReadLine();
            //int.TryParse(position, out b);
            //Console.WriteLine("b value :" + b);
            // while (a > 0)
            //{
            //    // DecimalToBinary(Convert.ToInt32(Console.ReadLine()));

            //    //PowerOf2(Convert.ToInt64(Console.ReadLine()));
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    int[] arr = new int[n + 1];
            //    //int i = 0;
            //    //while(n>0)
            //    //{
            //    //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    //    i++;
            //    //    n--;
            //    //}
            //    //MissingNumberInArray(arr,i);



            //    string arrayElemets = Console.ReadLine();
            //    string[] tokens = arrayElemets.Split(' ');

            //    int oneNum;
            //    for(int i =0;i<tokens.Length; i++)
            //    {
            //        if (Int32.TryParse(tokens[i], out oneNum))
            //            arr[i]= oneNum;

            //    }



            //    MissingNumberInArray(arr, n);

            //    a--;
            //}

            //ToArray<Int64>();

            //Console.WriteLine("Left Shift: " + LeftShift(a, b));
            //Console.WriteLine("Rt Shift: " + RtShift(a, b));
            //Console.WriteLine("Check bit of {0} and {1} is :{2}", a,b,checkBit(a,b));
            //Swap(a,b);

            //int n = 3;
            ////int[] arr = { -4, 3, -9, 0, 4, 1 };
            //int[] arr = { 1,2,3 };
            //subSet(n, arr);

            //DecimalToBinary(a,array);
            //test(n, arr);
            // Console.WriteLine("The a value is positive: " + checkPositiveNumber(a));
            Console.ReadLine();
        }
        static void Quadruples_XOR()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                int size = Convert.ToInt32(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int[] b = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int[] c = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int[] d = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                Quadruples_XOR_Result(a, b, c, d, size);

                n--;
            }
        }

        static void Quadruples_XOR_Result(int[] a, int[] b, int[] c, int[] d, int n)
        {


            int cnt = 0, x = 0;                //Here x is the final result 'a^b^c^d = x' We are computing it as 'a^b = x^c^d'
            List<int> lst1 = new List<int>();
            List<int> lst2 = new List<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    lst1.Add(a[i] ^ b[j]);
                    lst2.Add(x ^ c[i] ^ d[j]);
                }
            }

            lst1.Sort();

            for (int k = 0; k < lst2.Count; k++)
            {
                cnt += lst1.FindAll(item => item == lst2[k]).Count;
            }

            Console.WriteLine(cnt);

        }


        static void ApowerB()
        {
            int NumberOfLines = Convert.ToInt32(Console.ReadLine());
            while (NumberOfLines > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                ApowerBResult(n);
                NumberOfLines--;
            }
        }
        static void ApowerBResult(int n)
        {
            double z = Math.Sqrt(n);
            for (int i = 2; i <= z; i++)
            {
                int x = i;
                while (x <= n)
                {
                    x *= i;
                    if (x == n)
                    {
                        Console.WriteLine("Yes"); return;
                    }

                }
            }

            Console.WriteLine("No");

        }
        static void String_Anagrams()
        {
            int NumberOfLines = Convert.ToInt32(Console.ReadLine());
            while (NumberOfLines > 0)
            {
                string[] arrayWords = Console.ReadLine().Trim().Split(' ');
                Anagrams_Result(arrayWords[0], arrayWords[1]);
                NumberOfLines--;
            }
        }
        public static void Anagrams_Result(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                Console.WriteLine("False");
                return;
            }
            int[] cnt = new int[26];

            foreach (char c in s1)
                cnt[c - 97]++;

            foreach (char c in s2)
                cnt[c - 97]--;

            for (int i = 0; i < cnt.Length; i++)
            {
                if (cnt[i] != 0)
                {
                    Console.WriteLine("False");
                    return;
                }

            }
            Console.WriteLine("True");

        }
        public static void Cabinetspartitioning()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int NumberOfLines = Convert.ToInt32(Console.ReadLine());

            while (NumberOfLines > 0)
            {

                int[] arrayWords = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                Console.WriteLine(JobPartition(arrayElements, arrayWords[0], arrayWords[1]));
                NumberOfLines--;
            }
        }
        public static int JobPartition(int[] arr, int n, int k)
        {
            int lo = 0;
            int hi = GetSum(arr, ref lo);

            while (lo < hi)
            {
                int mid = lo + (hi - lo) / 2;
                int count = 1;
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (sum + arr[i] > mid)
                    {
                        sum = 0;
                        count++;
                    }

                    sum += arr[i];
                }

                if (count <= k) hi = mid;
                else lo = mid + 1;

            }
            return lo;
        }
        private static int GetSum(int[] arr, ref int max)
        {
            int sum = arr[0];
            max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] > max) max = arr[i];
            }

            return sum;
        }
        public static void Vowels_Consonants()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            while(size>0)
            {
                string input = Console.ReadLine().Trim();
                input = input.ToLower();
                Regex regex = new Regex("[ ]{2,}");
                input = regex.Replace(input, " ");

                int wordLength = 0, vowels = 0, consonants = 0;
                if(!string.IsNullOrEmpty(input))
                {
                    wordLength = input.Split(' ').Length;
                    vowels = countVowels(input, input.Length);
                    consonants = (input.Length - (wordLength - 1) - vowels);
                    if (consonants < 0)
                        consonants = consonants * -1;

                   
                }
                Console.Write(wordLength + " ");
                Console.Write(vowels + " ");
                Console.Write(consonants + " \n");


                size--;

            }
        }
        public static int countVowels(string str, int n)
        {
            if (n == 1)
                return isVowel(str[n - 1].ToString().ToUpper());

            return countVowels(str, n - 1) + isVowel(str[n - 1].ToString().ToUpper());
        }

        public static int isVowel(string ch)
        {
            
            if (ch == "A" || ch == "E" || ch == "I" ||
                 ch == "O" || ch == "U")
                return 1;
            else return 0;
        }
        public static void FirstRepeatingCharacter()
        {
            int size = Convert.ToInt32(Console.ReadLine());

            while (size > 0)
            {
                string input = Console.ReadLine().ToLower().Trim();
                Console.WriteLine(FirstRepeatingChar(input));
                size--;

            }
        }

        static char FirstRepeatingChar(string str)
        {
            int[] cnt = new int[26];
            foreach (char c in str)
            {
                cnt[c - 97]++;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (cnt[str[i] - 97] > 1) return str[i];
            }
            return '.';
        }
        public static Dictionary<char, int> FillStringFrequenct(char[] charArray)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (dic.ContainsKey(charArray[i]))
                    dic[charArray[i]]++;
                else
                    dic.Add(charArray[i], 1);
                    
            }
            return dic;
        }
        public static void FrequencyCheck()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int queries = Convert.ToInt32(Console.ReadLine());
            var result = SaveFrequency(arr, size);
            while (queries > 0)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(GetFrequency(result, k));
                queries--;
            }
        }

        static Dictionary<int, int> SaveFrequency(int[] arr, int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(arr[i]))
                    dict[arr[i]]++;
                else dict.Add(arr[i], 1);
            }
            return dict;
        }

        static int GetFrequency(Dictionary<int, int> dict, int key)
        {
            return dict.ContainsKey(key) ? dict[key] : 0;
        }

        public static void Distinctelements_Window()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                int[] arraySizeKElement = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                Distinctelements_Window_Result(arrayElements, arraySizeKElement[0], arraySizeKElement[1]);
                numberOfLines--;
            }
        }

        public static void Distinctelements_Window_Result(int[] array, int arraySize, int window)
        {
            var dicResult = new Dictionary<int, int>();
            int distinctCount = 0;

            for (int i = 0; i < window; i++)
            {
                if (dicResult.ContainsKey(array[i]))
                    dicResult[array[i]] += 1;
                else
                {
                    dicResult.Add(array[i], 1);
                    distinctCount++;
                }

            }

            Console.Write(distinctCount + " ");

            for (int i = window; i < arraySize; i++)
            {
                if (dicResult[array[i - window]] == 1)
                {
                    dicResult.Remove(array[i - window]);
                    distinctCount--;
                }
                else
                {
                    dicResult[array[i - window]] -= 1;
                }
                if (dicResult.ContainsKey(array[i]))
                    dicResult[array[i]] += 1;
                else
                {
                    dicResult.Add(array[i], 1);
                    distinctCount++;
                }
                Console.Write(distinctCount + " ");

            }
            //for(int i =0; i<= arraySize - window; i++)
            //{
            //    int j = i, count = 0;

            //    while(count < window)
            //    {
            //        if (dicResult.ContainsKey(array[j]))
            //            dicResult[array[j]] += 1;
            //        else
            //        {
            //            dicResult.Add(array[j], 1);
            //            distinctCount++;
            //        }
            //        count++;
            //        j++;
            //    }

            //    dicResult = new Dictionary<int, int>();
            //    Console.Write(distinctCount + " ");
            //    distinctCount = 0;

            //}

            Console.Write("\n");


        }

        public static void Pair_with_Difference_K()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                int[] arraySizeKElement = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                Pair_with_Difference_K_Result(arrayElements, arraySizeKElement[0], arraySizeKElement[1]);
                numberOfLines--;
            }
        }

        public static void Pair_with_Difference_K_Result(int[] array, int arraySize, int kthElement)
        {
            Array.Sort(array);

            int i = 0, j = 1;

            while (i < arraySize - 1 && j < arraySize - 1)
            {
                if (i != j && array[j] - array[i] == kthElement)
                {
                    Console.WriteLine("true");
                    return;
                }
                else if (array[j] - array[i] < kthElement)
                    j++;
                else
                    i++;
            }
            Console.WriteLine("false");





            //for (int i =0; i<arraySize-1; i++)
            //{
            //    int k = arraySize - 1;
            //    while (k>0)
            //    {
            //        if (array[k] - array[i] == kthElement)
            //        {
            //            Console.WriteLine("true");
            //            return;
            //        }
            //        k--;

            //    }
            //}

        }

        public static void NumberOftriangles()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());
                int[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                NumberOfTrainglesResult(arrayElements, arraySize);
                numberOfLines--;
            }
        }

        public static void NumberOfTrainglesResult(int[] arr, int arraySize)
        {
            int count = 0;
            Array.Sort(arr);

            for (int i = 0; i < arraySize - 2; ++i)
            {
                int k = i + 2;
                for (int j = i + 1; j < arraySize; ++j)
                {
                    while (k < arraySize && arr[i] + arr[j] > arr[k])
                        ++k;
                    count += k - j - 1;
                }

            }
            Console.WriteLine(count);

        }

        public static void FloorSearchInArray()
        {
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int NumberOfLines = Convert.ToInt32(Console.ReadLine());
            Array.Sort(arrayElements);
            while (NumberOfLines > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Floor(arrayElements, 0, arraySize - 1, n));
                NumberOfLines--;

            }

        }
        private static int Floor(int[] arr, int low, int high, int x)
        {
            if (low > high)
                return int.MinValue;
            if (x >= arr[high])
                return arr[high];

            int mid = (low + high) / 2;

            if (arr[mid] == x)
                return arr[mid];

            if (mid > 0 && arr[mid - 1] <= x && x < arr[mid])
                return arr[mid - 1];

            if (x < arr[mid])
                return Floor(arr, low, mid - 1, x);

            return Floor(arr, mid + 1, high, x);
        }


        public static void FindFloorInArray(int[] array, int n, int arraySize)
        {

            int fInd = -1;
            int fDist = 0;
            if (n < 0)
                fDist = int.MinValue;
            else
                fDist = int.MaxValue;

            for (int i = 0; i < arraySize - 1; i++)
            {

                if (n > 0)
                {
                    if (array[i] <= n && fDist > (n - array[i]))
                    {
                        fInd = i;
                        fDist = n - array[i];
                    }
                }
                else
                {
                    if (array[i] <= n && fDist < (array[i] - n))
                    {
                        fInd = i;
                        fDist = array[i] - n;
                    }
                }

            }

            if (fInd != -1)
                Console.WriteLine(array[fInd]);
            else
                Console.WriteLine(fDist);

        }


        public static void FindCeilInArray(int[] array, int n)
        {

            int cInd = -1;
            int cDist = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] >= n && cDist > (array[i] - n))
                {
                    cInd = i;
                    cDist = array[i] - n;
                }
            }

            if (cInd != -1)
                Console.WriteLine(array[cInd]);
            else
                Console.WriteLine(cDist);

        }
        static int ceilSearch(long[] arr, int low, int high, int x)
        {
            int mid;

            if (x <= arr[low])
                return low;

            if (x > arr[high])
                return -1;

            mid = (low + high) / 2;

            if (arr[mid] == x)
                return mid;

            else if (arr[mid] < x)
            {
                if (mid + 1 <= high && x <= arr[mid + 1])
                    return mid + 1;
                else
                    return ceilSearch(arr, mid + 1, high, x);
            }

            else
            {
                if (mid - 1 >= low && x > arr[mid - 1])
                    return mid;
                else
                    return ceilSearch(arr, low, mid - 1, x);
            }
        }

        public static void SumOfNumbers()
        {

        }
        public static void CeilSearchInArray()
        {
            int arraySize = Convert.ToInt32(Console.ReadLine());
            long[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), long.Parse);
            int NumberOfLines = Convert.ToInt32(Console.ReadLine());
            while (NumberOfLines > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Array.Sort(arrayElements);
                //FindCeilInArray(arrayElements,n);
                int index = ceilSearch(arrayElements, 0, n - 1, n);
                if (index == -1)
                    Console.WriteLine(int.MaxValue);
                else
                    Console.WriteLine(arrayElements[index]);

                NumberOfLines--;

            }

        }

        public static void DivisorsOfNumber()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                for (int i = 1; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        if (n / i == i)
                            count++;

                        else
                            count = count + 2;
                    }

                }
                Console.WriteLine(count);
                numberOfLines--;
            }

        }

        public static void maxConcequtiveNumber()
        {

            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                long input = Convert.ToInt64(Console.ReadLine());
                int count = 0;


                while (input != 0)
                {

                    input = (input & (input << 1));
                    count++;
                }

                Console.WriteLine(count);


                numberOfLines--;
            }



        }
        public static void NumberReverseSum()
        {

            int numberOfLines = Convert.ToInt32(Console.ReadLine());

            while (numberOfLines > 0)
            {
                long[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), long.Parse);
                long i1 = reverseNumber(arrayElements[0]);
                long i2 = reverseNumber(arrayElements[1]);


                Console.WriteLine(i1 + i2);

            }
        }

        public static long reverseNumber(long n)
        {
            long remainder, reverse = 0;
            while (n > 0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n /= 10;
            }
            return reverse;
        }


        public static void checkPalindrome()
        {

            int numberOfLines = Convert.ToInt32(Console.ReadLine());

            while (numberOfLines > 0)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());
                string strElement = Console.ReadLine();
                char[] tempElement = strElement.ToArray();

                string output = "";
                for (int i = arraySize - 1; i >= 0; i--)
                {
                    output += tempElement[i].ToString();
                }

                if (strElement == output)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
                numberOfLines--;
            }
        }

        public static void checkEvenNumber()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());

            while (numberOfLines > 0)
            {
                long arraySize = Convert.ToInt64(Console.ReadLine());
                if (arraySize > 2 && arraySize % 2 == 0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
                numberOfLines--;
            }
        }

        public static void cubeRoot()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            int flag = 1;
            while (numberOfLines > 0)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());
                if (arraySize < 0)
                    flag = -1;
                Console.WriteLine(flag * Math.Ceiling(Math.Pow(arraySize * flag, (double)1 / 3)));

                numberOfLines--;
            }
        }
        public static void FrequencySort()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());
                int[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                FrequencySortResult(arrayElements, arraySize);
                numberOfLines--;
            }
        }

        public static void FrequencySortResult(int[] array, int size)
        {
            Array.Sort(array);
            var dicResult = new Dictionary<int, int>();

            for (int i = 0; i < size; i++)
            {
                if (dicResult.ContainsKey(array[i]))
                    dicResult[array[i]] += 1;
                else
                    dicResult.Add(array[i], 1);

            }

            Dictionary<int, int> result = dicResult.OrderBy(pair => pair.Value)
                                            .ToDictionary(pair => pair.Key, pair => pair.Value);


            foreach (int key in result.Keys)
            {
                int temp = result[key];
                while (temp > 0)
                {
                    Console.Write(key + " ");
                    temp--;
                }
            }
            Console.Write("\n");

        }

        public static void LargestConcatenatedNumber()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());
                string[] arrayElements = Console.ReadLine().Trim().Split(' ');
                Console.WriteLine(CustomComparator(arrayElements, arraySize));
                numberOfLines--;
            }

        }

        public static string CustomComparator(string[] array, int size)
        {
            Array.Sort(array, new MyComparator());
            return string.Join("", array);

            //int maxNumberofDigits = 0;

            //if (array != null)
            //    maxNumberofDigits = array.Max().ToString().Length;

            //var dicResult = new Dictionary<int, int>();
            //string output = "";

            //for (int i = 0; i < size; i++)
            //{
            //    dicResult.Add(array[i], ExtendedNum(array[i], maxNumberofDigits));
            //}

            //Dictionary<int, int> result = dicResult.OrderByDescending(pair => pair.Value)
            //                                .ToDictionary(pair => pair.Key, pair => pair.Value);

            //foreach (int i in result.Keys)
            //    output += i.ToString();

            //Console.WriteLine(output);
        }

        public static int ExtendedNum(int arrayElement, int n)
        {
            string s = arrayElement.ToString();
            StringBuilder sb = new StringBuilder(s);

            StringBuilder sbResult = new StringBuilder();

            while (sbResult.Length <= n + 1)
            {
                sbResult.Append(sb);
            }

            s = sbResult.ToString().Substring(0, n + 1);
            return Convert.ToInt32(s);
        }

        public static int comparator(int a, int b)
        {
            return (a > b) ? a : b;
        }
        public static void RtAngleTraingle()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            while (numberOfLines > 0)
            {


                Console.WriteLine("Case #" + k + ":");

                int arraySize = Convert.ToInt32(Console.ReadLine());
                for (int i = arraySize - 1; i >= 0; i--)
                {

                    for (int j = i; j > 0; j--)
                    {
                        Console.Write(" ");

                    }

                    for (int j = arraySize - i; j > 0; j--)
                    {
                        Console.Write("*");

                    }
                    Console.Write("\n");
                }
                k++;
                numberOfLines--;

            }
        }

        public static void MaximumContiguousSubsequence()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());
                int[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                maxContiguousSequence(arrayElements, arraySize);
                numberOfLines--;
            }

        }

        public static int Min(int x, int y)
        {
            return (x < y) ? x : y;
        }
        public static int Max(int x, int y)
        {
            return (x > y) ? x : y;
        }

        public static void maxContiguousSequence(int[] array, int size)
        {
            Array.Sort(array);
            int max_length = 1;

            List<int> distinctArray = array.Distinct().ToList<int>();

            int count = distinctArray.Count();

            for (int i = 0; i < count - 1; i++)
            {
                int min = distinctArray[i], max = distinctArray[i];

                for (int j = i + 1; j < count; j++)
                {
                    min = Min(min, distinctArray[j]);
                    max = Max(max, distinctArray[j]);

                    if (max - min == j - i)
                        max_length = Max(max_length, max - min + 1);
                }
            }
            Console.WriteLine(max_length);


            //for(int i =0; i<size-1;i++)
            //{
            //    int min = array[i], max = array[i];

            //    for(int j=i+1;  j<size;j++)
            //    {
            //        min = Min(min, array[j]);
            //        max = Max(max, array[j]);

            //        if (max - min == j - i)
            //            max_length = Max(max_length, max-min + 1);
            //    }
            //}
            //Console.WriteLine(max_length);
        }
        public static void SelectionSort()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());
                int[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                SelectionSortMoves(arrayElements, arraySize);

                numberOfLines--;
            }
        }

        public static void SelectionSortMoves(int[] array, int size)
        {
            for (int i = size - 1; i > 0; i--)
            {
                int maxIndex = i;
                // loop through back till max index found
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j] >= array[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                //swap the elements
                array[maxIndex] = array[maxIndex] + array[i] - (array[i] = array[maxIndex]);
                Console.Write(maxIndex + " ");

            }
            Console.Write("\n");

        }

        public static void SumofPairs()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                int[] arraySize = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                SumOfPairsResult(arrayElements, arraySize[0], arraySize[1]);

                numberOfLines--;
            }
        }
        public static void TrippleSumofPairs()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                int[] arraySize = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                TrippleSumOfPairsResult(arrayElements, arraySize[0], arraySize[1]);

                numberOfLines--;
            }
        }

        public static void TrippleSumOfPairsResult(int[] array, int size, int sumElement)
        {
            Array.Sort(array);
            int lowIndex, highIndex;

            for (int i = 0; i < size - 2; i++)
            {
                lowIndex = i + 1;
                highIndex = size - 1;
                while (lowIndex < highIndex)
                {
                    if (array[i] + array[lowIndex] + array[highIndex] == sumElement)
                    {
                        Console.WriteLine("true");
                        return;
                    }
                    else if (array[i] + array[lowIndex] + array[highIndex] > sumElement)
                        highIndex--;
                    else
                        lowIndex++;


                }


            }
            Console.WriteLine("false");



        }
        public static void SumOfPairsResult(int[] array, int size, int sumElement)
        {
            Array.Sort(array);
            int lowIndex = 0, highIndex = size - 1;
            while (lowIndex < highIndex)
            {
                int sum = array[lowIndex] + array[highIndex];
                if (sum == sumElement)
                {
                    Console.WriteLine("True");
                    return;
                }

                if (sum > sumElement)
                    highIndex--;
                else
                    lowIndex++;
            }
            Console.WriteLine("False");


        }

        public static void InsertionSort()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());
                int[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                InsertionSortMoves(arrayElements, arraySize);

                numberOfLines--;
            }
        }
        public static void InsertionSortMoves(int[] arrayElements, int arraySize)
        {
            List<string> lstPositions = new List<string>();

            for (int i = 1; i < arraySize; i++)
            {
                int key = arrayElements[i];
                int j = i - 1;

                while (j >= 0 && arrayElements[j] > key)
                {
                    arrayElements[j + 1] = arrayElements[j];
                    j--;
                }
                arrayElements[j + 1] = key;
                lstPositions.Add(j + 1 + " ");
            }

            foreach (string s in lstPositions)
                Console.Write(s);

            Console.Write("\n");

        }


        public static void BubbleSort()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());
                int[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                BubbleSortMoves(arrayElements, arraySize);

                numberOfLines--;
            }
        }

        public static void BubbleSortMoves(int[] arrayElements, int arraySize)
        {
            bool swap = false;
            int moves = 0;

            for (int i = 0; i < arraySize - 1; i++)
            {
                swap = false;
                for (int j = 0; j < arraySize - i - 1; j++)
                {
                    if (arrayElements[j] > arrayElements[j + 1])
                    {
                        //Swap
                        arrayElements[j] = arrayElements[j] + arrayElements[j + 1] - (arrayElements[j + 1] = arrayElements[j]);
                        swap = true;
                        moves++;

                    }
                }

                if (!swap)
                    break;

            }

            Console.WriteLine(moves);
        }

        public static void ArrayDuplicate()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            while (numberOfLines > 0)
            {
                long arraySize = Convert.ToInt64(Console.ReadLine());
                long[] arrayElements = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), long.Parse);
                // DuplicateElements(arrayElements, arraySize);
                DuplicateSingleElement(arrayElements, arraySize);

                numberOfLines--;
            }
        }

        public static void DuplicateSingleElement(long[] array, long size)
        {

            var output = array
                .GroupBy(word => word)
                .OrderByDescending(group => group.Count())
                .Select(group => group.Key).Last();

            Console.WriteLine(output);


        }

        public static void DuplicateElements(long[] array, long size)
        {
            long[] count = new long[size];
            //string output = "";

            List<long> lstResult = new List<long>();

            for (int i = 0; i < size; i++)
            {
                if (count[array[i]] == 1)
                    lstResult.Add(array[i]);
                // output += array[i] + " ";

                else
                    count[array[i]]++;
            }

            lstResult.Sort();
            foreach (long l in lstResult)
                Console.Write(l + " ");


            Console.Write("\n");
        }
        public static void TowerOfHanoi()
        {
            int numberOfLines = Convert.ToInt32(Console.ReadLine());

            while (numberOfLines > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                List<String> lstResult = new List<string>();
                Hanoi(n, 'A', 'C', 'B', lstResult);
                Console.WriteLine(lstResult.Count());

                foreach (string s in lstResult)
                    Console.WriteLine(s);
                numberOfLines--;
            }
        }


        public static void Hanoi(int n, char fromRode, char toRod, char tempRod, List<string> lstResult)
        {

            if (n == 0) return;

            Hanoi(n - 1, fromRode, tempRod, toRod, lstResult);
            lstResult.Add("Move " + n + " from " + fromRode + " to " + toRod);
            Hanoi(n - 1, tempRod, toRod, fromRode, lstResult);
        }

        public static void swapBits(UInt32 n)
        {

            UInt32 even_bits = n & 0xAAAAAAAA;

            UInt32 odd_bits = n & 0x55555555;

            even_bits >>= 1;
            odd_bits <<= 1;

            Console.WriteLine(even_bits | odd_bits);


        }

        public static void numberReverse(int num)
        {
            //numberToBinary(num);
            string BinaryRev = "";

            for (int i = 0; i < 32; i++)
            {
                BinaryRev += ((num >> i) & 1) == 0 ? "0" : "1";
            }

            Console.WriteLine(Convert.ToUInt32(BinaryRev, 2));

        }

        public static int power(int x, int y)
        {
            int temp;
            if (y == 0)
                return 1;
            temp = power(x, y / 2);
            if (y % 2 == 0)
                return temp * temp;
            else
            {
                if (y > 0)
                    return x * temp * temp;
                else
                    return (temp * temp) / x;
            }
        }


        public static void numberToBinary(int n)
        {

            char[] output = Convert.ToString(n, 2).PadLeft(32, '0').ToCharArray();
            string result = "";
            for (int i = 31; i > 0; i--)
            {
                result += output[i];
            }

            int number = Convert.ToInt32(result, 2);

            Console.WriteLine(number);

        }
        public static void flipBits(int a, int b)
        {
            int result = a ^ b;
            result = result - ((result >> 1) & 0x55555555);
            result = (result & 0x33333333) + ((result >> 2) & 0x33333333);
            Console.WriteLine((((result + (result >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);

        }
        public static void MissingNumberInArray(int[] a, int n)
        {
            int i;
            int x1 = a[0]; /* For xor of all the elements in array */
            int x2 = 1; /* For xor of all the elements from 1 to n+1 */

            for (i = 1; i < n; i++)
                x1 = x1 ^ a[i];

            for (i = 2; i <= n + 1; i++)
                x2 = x2 ^ i;

            Console.WriteLine((x1 ^ x2));

        }

        public static void PowerOf2(Int64 x)
        {

            if (x == 0)
                Console.WriteLine("True");
            else
            {
                x = x & (x - 1);
                if (x == 0)
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }


        }
        public static void DecimalToBinary(int a)
        {
            int i = 0;

            string output = "";

            if (a == 0)
            {
                Console.Write(0);
            }
            else
            {
                while (a > 0)
                {
                    output = output + (a % 2);
                    a = a / 2;
                    i++;
                }
                char[] result = output.ToCharArray();

                for (int j = i - 1; j >= 0; j--)
                {
                    Console.Write(result[j]);
                }
            }

            Console.Write('\n');

        }
        public static void subSet(int n, int[] a)
        {
            for (int i = 0; i < (1 << n); i++)
            {
                Console.Write("{");
                for (int j = 0; j < n; j++)
                {
                    if ((i & (1 << j)) > 0)
                    {
                        Console.Write(a[j]);
                    }
                }
                Console.Write("}");
            }
        }

        public static int LeftShift(int n, int position)
        {
            return n << position;
        }
        public static int RtShift(int n, int position)
        {
            return n >> position;
        }
        public static int checkBit(int number, int position)
        {
            return (number >> position) & 1;
        }
        public static bool checkPositiveNumber(int a)
        {
            //if( (a >> 31  == 1))
            //{
            //    return false;
            //}
            if (a < 0)
                return false;

            return true;
        }
        public static void Swap(int a, int b)
        {
            a = a + b - (b = a);
            Console.WriteLine("a value is  :" + a);
            Console.WriteLine("b value is  :" + b);
        }
        public static void test(int n, int[] arr)
        {

            int PositiveSum = 0,
            negativeSum = 0,
            zeroSum = 0;
            string[] a;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                    negativeSum++;
                else if (arr[i] == 0)
                    zeroSum++;
                else
                    PositiveSum++;
            }




            //PositiveSum = Decimal.Round(PositiveSum / n, n);
            //negativeSum = Decimal.Round(negativeSum / n,n);
            //zeroSum = Decimal.Round(zeroSum / n,n);

            //a = new decimal[3] { PositiveSum, negativeSum, zeroSum };
            a = new string[3] { (PositiveSum / n).ToString("0.000000"), (negativeSum / n).ToString("0.000000"),
                 (zeroSum / n).ToString("0.000000")      };

        }
    }

    class MyComparator : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return (y + x).CompareTo(x + y);
        }

    }


}
