using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Numerics;

#region Self-written library

using LinkedList.SinLinkedList;
using System.Net;

namespace LinkedList
{
    // tạo SinglyLinkList
    namespace SinLinkedList
    {
        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }

            public static void PrintSinglyLinkedList(SinglyLinkedListNode node,
                                                                    string sep)
            {
                while(node != null)
                {
                    Console.Write(node.data);

                    node = node.next;

                    if (node != null)
                    {
                        Console.Write(sep);
                    }
                }
            }

            public static void CreateCycle(SinglyLinkedList linkedList, 
                                                                  int cycleIndex)
            {
                if (cycleIndex == -1) return;

                SinglyLinkedListNode cycleNode = linkedList.head;

                for (int i = 0; i < cycleIndex; i++)
                {
                    if (cycleNode != null)
                    {
                        cycleNode = cycleNode.next;
                    }
                }

                linkedList.tail.next = cycleNode;
            }
        }
    }

}

#endregion



#region Algorithms Easy 1

#if false // Solve Me First
namespace SolveMeFirst
{
    /// <summary> // Algorithms Problem
    /* 
     Tính tổng 2 biến interger
    */
    /// </summary>

    internal class Deploy
    {
        public static int SolveMeFirst(int a, int b)
        {
            int sum = 0;
            return sum = a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int result = Deploy.SolveMeFirst(a, b);
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
#endif

#if false // Simple Array Sum
namespace SimpleArrraySum
{
    /// <summary> Algorithms Problem
    /*
    Tính tổng các phần tử trong mảng;
    Sample Input: n = 6 => 1 2 3 4 10 11
    Sample Output: 31
    */
    /// </summary

    internal class Deploy
    {
        public static int SimpleArraySum(List<int> ar)
        {
            int sum = 0;

            foreach (int i in ar)
            {
                sum += i;
            }

            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ar = new List<int>();
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter elements {i + 1}: ");
                int elements = int.Parse(Console.ReadLine());
                ar.Add(elements);
            }

            int result = Deploy.SimpleArraySum(ar);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Compare The Triplets
namespace CompareTheTriplets
{
    /// <summary> Algorithms Problem
    /*
    Cho hai người chơi Alice và Bob
    Mỗi người có một danh sách gồm ba số nguyên điểm khác nhau
    so sánh các bộ ba này và tính điểm cho mỗi người 
    dựa trên quy tắc sau:
    Alice = (a[0], a[1], a[2])
    Bob   = (b[0], b[1], b[2])
    so sánh từng cặp a[0] và b[0], a[1] và  b[1], a[2] và b[2]
    nếu a[0] > b[0] thì Alice + 1 điểm
    nếu a[0] < b[0] thì  Bob + 1 điểm
    nếu a[0] = b[0] thì 0 ai có điểm
    so sánh tiếp tục cho đến hết 3 cặp điểm
    sau đó in ra điểm của Alice, Bob
    Sample Input: n = 3 => a = 17 28 30
                  m = 3 => b = 99 16 8
    Sample Output: Alice = 2, Bob = 1
    */
    /// </summary>

    internal class Deploy
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int Alice = 0;
            int Bob = 0;

            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                {
                    Alice++;
                }
                if (a[i] < b[i])
                {
                    Bob++;
                }
            }

            return new List<int>{Alice, Bob};
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            List<int> b = new List<int>();

            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter m = ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0;i < n; i++)
            {
                Console.Write($"Please enter a elements {i + 1}: ");
                int elements = int.Parse(Console.ReadLine());
                a.Add(elements);
            }

            for (int i = 0; i < m; i++)
            {
                Console.Write($"Please enter b elements {i + 1}: ");
                int elements = int.Parse(Console.ReadLine());
                b.Add(elements);
            }

            List<int> result = Deploy.CompareTriplets(a, b);
            Console.WriteLine(String.Join(", ", result));

            Console.ReadLine();
        }
    }

}
#endif

#if false // A Very Big Sum
namespace AVeryBigSum
{
    /// <summary> Algorithms Problem
    /*
    tính tổng các phần tử trong mảng với số cực lớn
    int: -2,147,483,648 đến 2,147,483,647
    Long:-9,223,372,036,854,775,808 đến 9,223,372,036,854,775,807
    Sample Input: n = 5 =>[1000000001 1000000002 1000000003
                           1000000004 1000000005]
    Output: 5000000015
    */
    /// </summary>

    internal class Deploy
    {
        public static long AVeryBigSum(List<long> ar)
        {
            long sum = 0;

            foreach (var item in ar)
            {
                sum += item;
            }

            return sum;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<long> s = new List<long>();

            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter element {i + 1}: ");
                long elements = long.Parse(Console.ReadLine());
                s.Add(elements);
            }

            long result = Deploy.AVeryBigSum(s);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Diagonal Difference (List<List<int>>)
namespace DiagonalDifference
{
    /// <summary> Algorithms Problem
    /*
    cho một List 2 chiều n = 3 => 1 2 3
                                  4 5 6
                                  7 8 9
    tính tổng 2 đường chéo 1 + 5 + 9 = a và 3 + 5 + 7 = b
    in ra c = a - b
    Sample Input: n = 3 => 11 2 4
                           4  5 6
                           10 8 -12
    Sample Output: 15
    */
    /// </summary>
    
    internal class Deploy
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                primaryDiagonal += arr[i][i];
                secondaryDiagonal += arr[i][arr.Count - i - 1];
            }

            return Math.Abs(primaryDiagonal - secondaryDiagonal);
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();

            Console.Write("Please enter nRow = ");
            int nRows = int.Parse(Console.ReadLine());
            Console.Write("Please enter nColums = ");
            int nColumns = int.Parse(Console.ReadLine());

            for (int i = 0;i < nRows; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0;j < nColumns; j++)
                {
                    Console.Write($"Please enter elements rows {i}, Columns {j}: ");
                    int elements = int.Parse(Console.ReadLine());
                    row.Add(elements);
                }
                arr.Add(row);
            }

            int result = Deploy.DiagonalDifference(arr);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Plus Minus
namespace PlusMinus
{
    /// <summary> Algorithms Problem
    /*
    cho một List có n = 5 => [1, 1, 0 , -1, -1]
    có 2 số dương, 2 âm và 1 zero trong list
    ta có 2 dương: 2/5 = 0,400000 ratios
    ta có 2 âm:    2/5 = 0,400000 ratios
    ta có 1 zero:  1/5 = 0.200000 ratios
    in ra các tỉ lệ này: dương, âm, zero với 6 số sau dấu thập phân
    Sample Input: n = 6 => -4 3 -9 0 4 1
    Sample Output: 0.500000 0.333333 0.166667
    */
    /// </summary>

    internal class Deploy
    {
        public static void PlusMinus(int n, List<int> ar)
        {
            int positiveNumber = 0;
            int negativeNumber = 0;
            int zero = 0;

            foreach (int i in ar)
            {
                if (i > 0)
                {
                    positiveNumber++;
                }
                else if (i < 0)
                {
                    negativeNumber++;
                }
                else
                {
                    zero++;
                }
            }

            double positiveRatios = (double)positiveNumber / n;
            double negativeRatios = (double)negativeNumber / n;
            double zeroRatios = (double)zero / n;

            Console.WriteLine(positiveRatios.ToString("F6"));
            Console.WriteLine(negativeRatios.ToString("F6"));
            Console.WriteLine(zeroRatios.ToString("F6"));
        }
    }
    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> ar = new List<int>();
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter elements {i}: ");
                int elements = int.Parse(Console.ReadLine());
                ar.Add(elements);
            }

            Deploy.PlusMinus(n, ar);

            Console.ReadLine();
        }
    }
}
#endif

#if false // StairCase
namespace StairCase
{
    /// <summary> Algorithms Problem
    /*
    cho n = 4 in ra cầu thang 4 tầng như sau: *
                                             **
                                            ***
                                           ****
    Sample Input:
    in ra các tầng * theo số n = 6
    */
    /// </summary>

    internal class Deploy
    {
        public static void StairCase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string hashes = new string('#', i);

                Console.WriteLine(spaces + hashes);
            }
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            Deploy.StairCase(n);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Mini-MaxSum
namespace MiniMaxSum
{
    /// <summary> Algorithms Problem
    /*
    Cho một danh sách số nguyên [1, 3, 5, 7, 9]
    tính tổng nhỏ nhất loại bỏ phần tử lớn nhất 1 + 3 + 5 + 7 = 16
    tính tổng lớn nhất loại bỏ phần tử bé nhất  3 + 5 + 7 + 9 = 24
    In ra tổng bé nhất và tổng lớn nhất: 16, 24
    Sample Input: n = 5 => 1 2 3 4 5
    Sample Output: 10 14
    */
    /// </summary>
    
    internal class Deploy
    {
        public static void MiniMaxSum(List<int> arr)
        {
            long sumElement = arr.Sum(x => (long) x);
            int minElement = arr.Min();
            int maxElement = arr.Max();

            long sumMax = sumElement - minElement;
            long sumMin = sumElement - maxElement;

            Console.WriteLine($"{sumMin} {sumMax}");
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();

            Console.Write("please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter elements {i}: ");
                int elements = int.Parse(Console.ReadLine());
                arr.Add(elements);
            }

            Deploy.MiniMaxSum(arr);

            Console.ReadLine();
        }
    }

}
#endif

#if false // Birthday Cake candles
namespace BirthdayCakeCandles
{
    /// <summary> Algorithms Problem
    /*
    Đếm số lượng cây nến cao nhất trên một bánh sinh nhật:
    cho List a = [4, 4, 1, 3]
    có 2 cây nến cao nhất là 4 thì in ra 2
    Sample Input: n = 4 => 3 2 1 3
    Sample Output: 2
    */
    /// </summary>
    
    internal class Deploy
    {
        public static int BirthdayCakeCandles(List<int> arr)
        {
            int countMaxCakeCandles = arr.Count(c => c == arr.Max());

            return countMaxCakeCandles;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();

            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter Elements {i}: ");
                int elements = int.Parse(Console.ReadLine());
                arr.Add(elements);
            }

            int result = Deploy.BirthdayCakeCandles(arr);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

}

#endif

#if false // Time Conversion
namespace TimeConversion
{
    /// <summary> Algorithms Problem
    /*
    Cho một chuỗi s, biểu diễn thời gian hh:mm:ss:Period
    hh là từ 1h đến 12h
    mm là từ 00 đến 59
    ss là từ 00 đến 59
    Period là AM & PM
    cần chuyển đổi này sang định dạng 24h:
    nếu 12AM thì chuyển thành 00
    nếu 12PM thì giữ nguyên
    nếu là giờ AM nhưng k phải 12AM thì giữ nguyên giờ
    nếu là giờ PM nhưng k phải 12PM thì cộng thêm 12.
    in ra chuyển đổi định dạng từ 12h sang 24h đó?
    Sample Input: 07:05:45PM
    Sample Output: 19:05:45
    */
    /// </summary>
    
    internal class Deploy
    {
        public static string TimeConversion(string s)
        {
            string period = s.Substring(s.Length - 2);
            int hour = int.Parse(s.Substring(0, 2));
            string minutes = s.Substring(3, 2);
            string seconds = s.Substring(6, 2);

            if (period == "PM" && hour != 12)
            {
                hour += 12;
            }
            if (period == "AM" && hour == 12)
            {
                hour = 0;
            }

            return hour.ToString("D2") + ":" + minutes + ":" + seconds;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter time (hh:mm:ss AM/PM): ");
            string s = Console.ReadLine();

            string result = Deploy.TimeConversion(s);
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
#endif

#endregion

#region Algorithms Easy 2

#if false // Grading Students
namespace GradingStudents
{
    /// <summary> Algorithms Problem
    /*
    Làm tròn số điểm trong danh sách điểm:
    Cho điểm số của học sinh là một số nguyên từ 0 đến 100 trong List
    - nếu điểm dưới 38 thì giữ nguyên k dc làm tròn vì là điểm rớt
    - nếu lớn hơn 38 và điểm chênh lệch gần nhất với bội số của 5 
    là nhỏ hơn 3 thì làm tròn lên bội số của 5 đó
    ví dụ: điểm là 84 bội số gần nhất của 5 lớn hơn hoặc bằng 84 là 85
    Vì 85 - 84 = 1 (chênh lệch nhỏ hơn 3) nên điểm làm tròn thành 85.
    - nếu số điểm k cần làm tròn thì giữ nguyên.
    Sample Input: n = 4 => grades[73 67 38 33]
    Sample Output: grades[75 67 40 33]
    */
    /// </summary>

    internal class Deploy
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> roundedGrades = new List<int>();

            foreach (int grade in grades)
            {
                // thuật toán tìm bội số tiếp theo của 5
                int nextMultipleOfFive = ((grade / 5) + 1) * 5;
                if (grade >= 38)
                {
                    if (nextMultipleOfFive - grade < 3)
                    {
                        roundedGrades.Add(nextMultipleOfFive);
                    }
                    else
                    {
                        roundedGrades.Add(grade);
                    }
                }
                else
                {
                    roundedGrades.Add(grade);
                }
            }

            return roundedGrades;

        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter elements {i}: ");
                int elements = int.Parse(Console.ReadLine());
                grades.Add(elements);
            }

            List<int> result = Deploy.gradingStudents(grades);
            Console.WriteLine(String.Join(" ", result));

            Console.ReadLine();
        }
    }
}
#endif

#if false // Apple And Orange
namespace AppleAndOrange
{
    /// <summary> Algorithms Problem
    /*
    Cho một đoạn nhà trên đoạn thẳng kéo dài từ s đến t
    cây táo đứng vị trí a và cây cam đứng vị trí b trên đoạn thẳng
    (-)          a          s          t          b         (+)
    mỗi quả táo và cam có thể rơi âm về trước cây và dương phía sau cây
    s và t: vị trí bắt đầu và kết thúc của đoạn nhà.
    a: vị trí của cây táo.
    b: vị trí của cây cam.
    apples: danh sách các khoảng cách mà mỗi quả táo rơi từ cây táo.
    oranges: danh sách các khoảng cách mà mỗi quả cam rơi từ cây cam.
    Tính toán số quả táo và cam rơi trong nhà từ s đến t.
    Sample Input: s = 7, t = 11, a = 5, b = 15
                  n = 3 quả táo rơi ở vị trí -2, 2, 1
                  m = 2 quả cam rơi ở vị trí 5, -6
    Sample Output: 1 ( 1 quả táo và 1 quả cam rơi trong nhà)
                   1
    */
    /// </summary>

    internal class Deploy
    {
        public static void AppleAndOrange(int s, int t, int a, int b,
            List<int> apples, List<int> oranges)
        {
            int appleCount = apples.Count(apple => (apple + a) >= s &&
                             (apple + a) <= t);
            int orangeCount = oranges.Count(orange => (orange + b) >= s &&
                             (orange + b) <= t);

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter s = ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Please enter t = ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Please enter a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter b = ");
            int b = int.Parse(Console.ReadLine());

            List<int> apples = new List<int>();
            List<int> oranges = new List<int>();

            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter elements {i}: ");
                int elements = int.Parse(Console.ReadLine());
                apples.Add(elements);
            }

            Console.Write("Please enter m = ");
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Please enter elements {i}: ");
                int elements = int.Parse(Console.ReadLine());
                oranges.Add(elements);
            }

            Deploy.AppleAndOrange(s, t, a, b, apples, oranges);

            Console.ReadLine();

        }
    }

}
#endif

#if false // Number Line jumps - Kangaroo
namespace NumberLineJumps
{
    /// <summary> Algorithms Problem
    /*
    Cho con Kangaroo 1 xuất phát tại x1 với vận tốc v1
    Cho con Kangaroo 1 xuất phát tại x2 với vận tốc v2
    xác định hai con Kangaroo có thể gặp nhau tại cùng 1 vị trí hay ko
    trả về YES nếu hai con Kangaroo gặp nhau tại 1 điểm
    trả về NO nếu không
    Sample Input: x1 = 0, v1 = 4
                  x2 = 3, v2 = 2
    Sample Output: YES
    */
    /// </summary>

    internal class Deploy
    {
        public static string NumberLineJump(int x1, int x2,
                                            int v1, int v2)
        {
            if (x1 == x2 && v1 != v2)
            {
                return "NO";
            }

            // tránh vòng lặp vô tận
            if (x1 > x2 && v1 >= v2 ||  x2 > x1 && v2 >= v1)
            {
                return "NO";
            }

            while(x1 != x2)
            {
                x1 += v1;
                x2 += v2;

                if (x1 == x2)
                {
                    return "YES";
                }

                if (x1 > x2 && v1 >= v2 || x2 > x1 && v2 >= v1)
                {
                    return "NO";
                }
            }

            return "YES";

        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter x1= ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter v1= ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter x2= ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Please enter v2= ");
            int v2 = int.Parse(Console.ReadLine());

            string result = Deploy.NumberLineJump(x1, v1, x2, v2 );
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Between Two Sets
namespace BetweenTwoSets
{
    /// <summary> Algorithms Problem
    /*
     Yêu cầu là tìm số lượng số nguyên x sao cho:
     1.Mỗi phần tử của list a là một ước của x. tức là (x % a[i] == 0)
     2.x là một ước của mỗi phần tử trong list b. tức là (b[i] % x == 0)
     Sample Input: n = 2 => a = (2, 4)
                   m = 3 => b = (16, 32, 96)
     Sample Output: 3
    */
    /// </summary>
    internal class Deploy
    {
        // thuật toán tìm ước chung lớn nhất của 2 số
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        // thuật toán tìm bội chung nhỏ nhất của 2 số
        public static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        public static int GCDIL(List<int> la)
        {
            return la.Aggregate((a, b) => GCD(a, b));
        }

        public static int LCMIL(List<int> lb)
        {
            return lb.Aggregate((a, b) => LCM(a, b));
        }

        public static int GetTotalX(List<int> a, List<int> b)
        {
            int lcm = LCMIL(a);
            int gcd = GCDIL(b);
            int countX = 0;

            for (int i = lcm; i <= gcd; i += lcm)
            {
                if (gcd % i == 0)
                {
                    countX++;
                }
            }

            return countX;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            List<int> b = new List<int>();

            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter m = ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter {i + 1} in List a: ");
                int element = int.Parse(Console.ReadLine());
                a.Add(element);
            }

            for (int i = 0; i < m; i++)
            {
                Console.Write($"Please enter {i + 1} in List b: ");
                int element = int.Parse(Console.ReadLine());
                b.Add(element);
            }

            int result = Deploy.GetTotalX(a, b);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}BetweenTwoSets  BetweenTwoSets
#endif

#if false // Breaking The Record
namespace BreakingTheRecord
{
    /// <sumary> Algorithms Problem
    /*
    Thuật toán Breaking Records xử lý danh sách các điểm số theo
    thứ tự lần lược và đếm số lần kỷ lục cao nhất và kỷ lục thấp nhất.
    Sample Input: n = 10 => 3 4 21 36 10 28 35 5 24 42
    Sample Output: max = 4 ; min = 0
    */
    /// <sumary>

    internal class Deploy
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            int minScores = scores[0];
            int maxScores = scores[0];
            int minCounts = 0;
            int maxCounts = 0;

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] > maxScores)
                {
                    maxCounts++;
                    maxScores = scores[i];
                }
                else if (scores[i] < minScores)
                {
                    minCounts++;
                    minScores = scores[i];
                }
            }

            return new List<int> { maxCounts, minCounts };
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> records = new List<int>();

            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter elements {i + 1}: ");
                int elements = int.Parse(Console.ReadLine());
                records.Add(elements);
            }

            List<int> result = Deploy.breakingRecords(records);
            Console.WriteLine($"Max Recored: {result[0]},Min Recored: {result[1]}");

            Console.ReadLine();
        }
    }

}
#endif

#if false // Subarray Division - Birthday Chocolate
namespace SubarrayDivision
{
    ///<summary> Algorithms Problem
    /*
    ví dụ cho một mảng s bên dưới, thì lấy m = 2 phần tử đầu tiên
    cộng lại nếu bằng d thì biến count tăng 1, tiếp tục 2 phần tử
    tiếp theo cộng lại nếu bằng d thì tiếp tục tăng count, 
    duyệt đến hết mảng sau đó in ra biến count này.
    Sample Input: n = 5 => s[1, 2, 1, 3, 2]
                           d = 3 và m = 2
    Sample Output: 2
    */
    ///</summary>
    
    internal class Deploy
    {
        public static int BirthDayChocolate(List<int> s, int d, int m) 
        {
            int count = 0;

            for (int i = 0; i <= s.Count - m; i++)
            {
                int sum = 0;

                for (int j = 0; j < m; j++)
                {
                    sum += s[i + j];
                }

                if (sum == d)
                {
                    count++;
                }
            }

            return count;
        }
    }
    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> s = new List<int>();

            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0;i < n; i++)
            {
                Console.Write($"Please enter element {i + 1}: ");
                int elements = int.Parse(Console.ReadLine());
                s.Add(elements);
            }

            Console.Write("Please enter d = ");
            int d = int.Parse(Console.ReadLine());

            Console.Write("Please enter m = ");
            int m = int.Parse(Console.ReadLine());


            int result = Deploy.BirthDayChocolate(s, d, m);
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
#endif

#if false // Divisible Sum Pairs
namespace DivisibleSumPairs
{
    /// <summary> Algorithms Problem
    /*
    cho một list ar = [1, 2, 3, 4, 5, 6] và cho k = 5
    duyệt qua các cặp i và j: [1, 2] [1, 3] [1, 4]....
    duyệt qua các cặp i và j: [2, 3] [2, 4] [2, 5]....
    tiếp tục duyệt hết các cặp nếu i + j % k == 0
    thì count tăng lên 1 => in ra biến count
    Sample Input: n = 6 => 1 3 2 6 1 2
                  k = 3
    Sample Output: 5
    */
    /// </summary>

    internal class Deploy
    {
        public static int DivisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> ar = new List<int>();
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter elements {i + 1}: ");
                int elements = int.Parse(Console.ReadLine());
                ar.Add(elements);
            }

            Console.Write("Please enter k = ");
            int k = int.Parse(Console.ReadLine());

            int result = Deploy.DivisibleSumPairs(n, k, ar);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Migratory Birds (Dictionary)
namespace MigratoryBirds
{
    /// <summary> Algorithms Problem
    /*
    cho một List các Id loài chim [1, 1, 2, 2, 3], ta thấy rằng
    loài chim có Id 1, và Id 2 xuất hiện 2 lần và Id 3 xuất hiện 1 lần
    bài toán yêu cầu in ra loài chim xuất hiện nhiều nhất.
    vì đang có 2 loài chim xuất hiện bằng nhau là số 1 và số 2 đều xuất
    hiện 2 lần, vậy thì ta in ra loài chim có id thấp nhất nếu có cùng
    số lần xuất hiện, tức in ra loài chim số 1.
    Sample Input: n = 11 => 1 2 3 4 5 4 3 2 1 3 4
    Sample Output: 3
    */
    /// </summary>

    internal class Deploy
    {
        public static int MigratoryBirds(List<int> arr)
        {
            Dictionary<int, int> birdCount = new Dictionary<int, int>();

            foreach (int id in arr)
            {
                if (birdCount.ContainsKey(id))
                {
                    birdCount[id]++;
                }
                else
                {
                    birdCount[id] = 1;
                }
            }

            int maxCount = 0;
            int mostFrequentBirdId = int.MaxValue;

            foreach (var bird in birdCount)
            {
                if (bird.Value > maxCount || (bird.Value == maxCount 
                                    && bird.Key < mostFrequentBirdId))
                {
                    maxCount = bird.Value;
                    mostFrequentBirdId = bird.Key;
                }
            }

            return mostFrequentBirdId;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();

            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter Elements {i}: ");
                int elements = int.Parse(Console.ReadLine());
                arr.Add(elements);
            }

            int result = Deploy.MigratoryBirds(arr);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

}

#endif

#if false // Day Of The Programer
namespace DayOfTheProgramer
{
    /// <summary> Algorithms Problem
    /*
    Tình ngày chính xác của ngày thứ 256 trong một năm cụ thể.
    Điều này phụ thuộc vào lịch mà quốc gia đó sử dụng trong năm đó,
    Lịch julius: áp dụng từ 1700 đến 1917 ở Nga.
    Lịch Gregorian: áp dụng từ 1919 trở đi ở Nga.
    Trong đó năm 1918 là năm đặc biệt khi chuyển lịch từ Julius sang Gregorian
    Quy tắc tính ngày: 
     - Lịch Julius: năm nhuận chia hết cho 4, ngày thứ 256 của năm nhuận 
    là 12/09 và năm không nhuận là 13/09.
     - Lịch Gregorian: năm nhuận là năm chia hết cho 400 or 4, nhưng k chia 
    hết cho 100. Ngày thứ 256 của năm nhuận là 12/09, còn năm không nhuận
    là 13/09
    - Năm 1918: do đổi lịch từ ngày 31/01/1918 sang 14/02/1918, nên ngày
    thứ 256 là 26/09.
    Kiểm tra xem năm thuộc lịch nào và ngày thứ 256 của năm đó là ngày gì
    có phải nhuận hay không?
    in ra (ngày tháng năm) của ngày 256 của năm đó?
    Sample Input: 2016
    Sample Output: 12.09.2016
    */
    /// </summary>
    
    internal class Deploy
    {
        public static string DayOfTheProgramer (int year)
        {
            if (year == 1918)
            {
                return "26.09.1918";
            }

            bool isLeapYear = (year < 1918 && year % 4 == 0) ||
                            (year > 1918 && (year % 400 == 0 ||
                            (year % 4 == 0 && year % 100 != 0)));

            if (isLeapYear)
            {
                return $"12.09.{year}";
            }
            else
            {
                return $"13.09.{year}";
            }
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter year = ");
            int year = int.Parse(Console.ReadLine());

            string result = Deploy.DayOfTheProgramer(year);
            Console.Write($"Ngày thứ 256 trong năm {year} là: ");
            Console.WriteLine(result);

            Console.ReadLine();
           
        }
    }

}
#endif

#if false // Bill Division - Bon Appetit
namespace BonAppetit
{
    /// <summary> Algorithms Problem
    /*
    tính toán chia tiền giữa 2 người Anna và Brian đi ăn tối cùng nhau
    bill là danh sách các biến int đại diện cho giá tiền từng món
    k là chỉ số món ăn mà Anna k ăn
    b là số tiền brian thu từ Anna
    tính tổng hóa đơn trừ món mà Anna k ăn, chia 2 người
    tính số tiền mà Brian thu từ Anna nếu thu đúng thì in ra Bon Appetit
    nếu thu quá số tiền mà Anna phải trả thì in ra khoảng tiền chệnh lệch
    Sample Input: n = 4 => Bill[3 10 2 9] k = 1 và b = 12
    Sample Output: 5
    */
    /// </summary>
    
    internal class Deploy
    {
        public static void BonAppetit(List<int> bill, int k, int b)
        {
            int totalExcludeK = bill.Sum() - bill[k];
            int annaShare = totalExcludeK / 2;

            if (b == annaShare)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                int overCharge = b - annaShare;
                Console.WriteLine(overCharge);
            }
        }
    }
    
    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> bill = new List<int>();
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int elements = int.Parse(Console.ReadLine());
                bill.Add(elements);
            }

            Console.Write("Please enter k: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Please enter b: ");
            int b = int.Parse(Console.ReadLine());

            Deploy.BonAppetit(bill, k, b);

            Console.ReadLine();
        }
    }
}
#endif

#endregion

#region Algorithms Easy 3

#if false // Sales By Match - SockMerchant (Dictionary)
namespace SalesByMatch
{
    /// <summary> Algorithms Problem
    /*
    Cho một danh sách các chiếc tất, 
    mỗi chiếc tất đại diện bằng 1 con số nguyên
    tìm ra các cặp tất cùng màu trong List tất này
    n: Số lượng tất trong danh sách
    ar: Danh sách các số nguyên, mỗi số đại diện cho màu của một chiếc tất.
    Trả về số lượng cặp tất có thể ghép được.
    Sample Input:  n = 9 => 10 20 20 10 10 30 50 10 20
    Sample Output: 3
    */
    /// </summary>
    
    internal class Deploy
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            Dictionary<int, int> socksCount = new Dictionary<int, int>();

            foreach (int sock in ar)
            {
                if (socksCount.ContainsKey(sock))
                {
                    socksCount[sock]++;
                }
                else
                {
                    socksCount[sock] = 1;
                }
            }

            int pairs = 0;

            foreach (int count in socksCount.Values)
            {
                pairs += count / 2;
            }

            return pairs;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> ar = new List<int>();

            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter elements {i}: ");
                int element = int.Parse(Console.ReadLine());
                ar.Add(element);
            }

            int result = Deploy.sockMerchant(n, ar);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Drawing Book - PageCount
namespace DrawingBook 
{
    /// <summary> Algorithms Problem
    /*
    Cho một cuốn sách có tổng cộng n trang và bạn muốn mở đến trang p,
    mỗi trang của cuốn sách chứa 2 trang mặt trái là số lẻ và mặt phải
    là số chẵn, ngoại trừ trang đầu tiên là số lẽ và đứng 1 mình
    bạn có thể lật từ mặt trước trang 1 và mặt sau trang n
    Tìm số trang ít nhất mà bạn cần phải lật đến trang p, có thể lật 
    từ đầu cuốn sách hoặc từ cuối cuốn sách.
    - lật từ đầu trang từng trang 1 cho đến trang p: p / 2
    - lật từ cuối trang từng trang cho đến trang p: (n / 2) - (p / 2)
    Sample Input: n = 6, p = 2
    Sample Output: 1
    */
    /// </summary>

    internal class Deploy
    {
        public static int pageCount(int n, int p)
        {
            int fromFront = p / 2;
            int fromBack = (n / 2) - (p / 2);

            return Math.Min(fromFront, fromBack);
        }

    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter p = ");
            int p = int.Parse(Console.ReadLine());

            int result = Deploy.pageCount(n, p);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

}
#endif

#if false // Counting Valleys
namespace countingValleys
{
    /// <summary> Algorithms Problem
    /*
    Xác định số lượng thung lũng mà một người đi qua trong suốt hành trình
    cho một chuỗi đầu vào gồm steps = 8 => Path = D D U U U U D D
    bắt đấu từ mực nước biển với độ cao = 0
    U tượng trưng cho Up và D tượng trưng cho Down
    Mỗi khi bước đi U, người leo núi sẽ tăng độ cao lên 1.
    Mỗi khi bước đi D, người leo núi sẽ giảm độ cao xuống 1.
    Một thung lũng được xác định đi qua khi người leo núi:
    Đi xuống dưới mực nước biển (độ cao âm).
    Sau đó quay trở lại mực nước biển (độ cao bằng 0).
    thì dc tính 1 lần qua thung lũng 
    in ra số lần qua thung lũng đó dựa trên chuỗi đầu vào path đã cho
    Sample Input: steps = 8 => U D D D U D U U
    Sample Output: 1
    */
    /// </summary>
    
    internal class Deploy
    {
        public static int countingValleys(int steps, string path)
        {
            int valleysCount = 0;
            int currentLevel = 0;

            foreach (var step in path)
            {
                if (step == 'U')
                {
                    currentLevel++;
                    if (currentLevel == 0)
                    {
                        valleysCount++;
                    }
                }
                else if (step == 'D')
                {
                    currentLevel--;
                }
            }
            return valleysCount;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter steps = ");
            int steps = int.Parse(Console.ReadLine());
            Console.Write("Please enter Path: ");
            string path = Console.ReadLine();

            int result = Deploy.countingValleys(steps, path);
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }

}
#endif

#if false // Electronics Shop - Get Money Spent
namespace getmoneyspent
{
    /// <summary> Algorithms Problem
    /*
    Tìm ra số tiền lớn nhất để mua Keyboard và Usb với ngân sách b
    đã cho, nếu không thể mua cả hai trả về -1.
    keyboards[]: Một mảng chứa giá tiền của các bàn phím.
    drives[]: Một mảng chứa giá tiền của các ổ đĩa USB.
    b: ngân sách chi tiêu
    - Tìm tổ hợp của một giá bàn phím và một giá ổ đĩa sao cho tổng 
    của chúng nhỏ hơn hoặc bằng ngân sách b và càng lớn càng tốt.
    - Nếu không thể mua cả hai sản phẩm trong ngân sách, trả về -1.
    Sample Input: b = 10, n = 2 => keyboards[3 1] 
                          m = 3 => drives[5 2 8]
    Sample Output: 9
    */
    /// </summary>

    internal class Deploy
    {
        public static int getMoneySpent(int[] Keyboards, int[] drives, int b)
        {
            int maxSpent = -1;

            for (int i = 0; i < Keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    int total = Keyboards[i] + drives[j];

                    if (total <= b && total > maxSpent)
                    {
                        maxSpent = total;
                    }
                }
            }
            return maxSpent;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("please enter b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] keyboards = new int[n];
            for (int i = 0;i < n; i++)
            {
                Console.Write($"Please enter element {i}: ");
                keyboards[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Please enter m = ");
            int m = int.Parse(Console.ReadLine());
            int[] drives = new int[m];
            for (int i = 0; i < m ; i++)
            {
                Console.Write($"Please enter element {i}: ");
                drives[i] = int.Parse(Console.ReadLine());
            }

            int result = Deploy.getMoneySpent(keyboards, drives, b);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Cats And A Mouse
namespace CatsAndMouse
{
    /// <summary> Algorithms Problem
    /*
    Có 2 con mèo, mèo A ở vị trí x và mèo B ở vị trí y
    Có 1 con chuột ở vị trí z trên cùng 1 đường thẳng
    tính toán con mèo nào đến chỗ con chuột trước?
    in ra con mèo Cat A hoặc Cat B
    Nếu 2 con mèo đến cùng lúc thì chuột sẽ thoát in ra Mouse C.
    Sample Input: x = 1, y = 2, z = 3
    Sample Output: Cat B
    */
    /// </summary>
    
    internal class Deploy
    {
        public static string CatsAndAMouse(int x, int y, int z)
        {
            int distanceCatA = Math.Abs(x - z);
            int distanceCatB = Math.Abs(y - z);

            if (distanceCatA < distanceCatB)
            {
                return "Cat A";
            }
            else if (distanceCatA > distanceCatB)
            {
                return "Cat B";
            }
            else
            {
                return "Mouse C";
            }
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Please enter y = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Please enter z = ");
            int z = int.Parse(Console.ReadLine());

            string result = Deploy.CatsAndAMouse(x, y, z);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Picking Numbers
namespace pickingNumbers
{
    /// <summary> Algorithms Problem
    /*
    Cho một danh sách các số nguyên dương [1, 1, 2, 2, 4, 4, 5, 5, 5]
    Tỉm dãy con subarray thỏa mản 2 điều kiện là có độ dài lớn nhất 
    và chênh lệch giữa bất kì 2 con số nào không được lớn hơn 1. ta có:
    1 xuất hiện 2 lần.
    2 xuất hiện 2 lần.
    4 xuất hiện 2 lần.
    5 xuất hiện 3 lần.
    xét từng cặp tìm dãy dài nhất k lớn hơn 1 ta có:
    Dãy dài nhất là [4, 4, 5, 5, 5] với độ dài là 5.
    vì vậy in ra : 5
    Sample Input: n = 6 => 4 6 5 3 3 1
    Sample Output: 3
    */
    /// </summary>
    
    internal class Deploy
    {
        public static int pickingNumbers(List<int> a)
        {
            int[] frequency = new int[101];

            foreach (int num in a)
            {
                frequency[num]++;
            }

            int maxLength = 0;

            for (int i = 0; i < 100; i++)
            {
                int currentLength = frequency[i] + frequency[i + 1];

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }

            return maxLength;

        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int elements = int.Parse(Console.ReadLine());
                a.Add(elements);
            }

            int result = Deploy.pickingNumbers(a);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // The Hurdle Race
namespace theHurdleRace
{
    /// <summary> Algorithms Problem
    /*
    Cho 1 danh sách các chiều cao của hàng rào height = [1, 6, 3, 5, 2]
    cho k là khả năng tối đa mà người chơi có thể nhảy qua k = 4
    Nếu một hàng rào có chiều cao lớn hơn k thì người chơi cần potions để 
    có thể nhảy qua hàng rào đó ở đây hàng rào cao nhất là 6 và k là 4
    Tính potions tối thiểu để người chơi cần sử dụng để có thể nhảy qua hàng rào
    cao nhất: 6 - 4 = 2 vậy cần 2 potions để có thể nhảy qua hàng rào cao nhất.
    Nếu khả năng nhảy (k) lớn hơn tất cả chiều cao hàng rào thì k cần potions.
    in ra potions
    Sample Input: n = 5 => 1 6 3 5 2 và k = 4
    Sample Output: 2
    */
    /// </summary>

    internal class Deploy
    {
        public static int hurdleRace(int k, List<int> height)
        {
            int maxHeight = height.Max();

            if (maxHeight <= k)
            {
                return 0;
            }

            return maxHeight - k;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> height = new List<int>();
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int elements = int.Parse(Console.ReadLine());
                height.Add(elements);
            }

            Console.Write("Please enter k = ");
            int k = int.Parse(Console.ReadLine());

            int result = Deploy.hurdleRace(k, height);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // The Designer PDF Viewer
namespace theDesignerPDFViewer
{
    /// <summary> Algorithms Problem
    /*
    Cho 1 danh sách h chữa 26 số nguyên, mỗi số đại diện cho chiều cao của 
    1 ký tự trong bảng chữ cái từ a đến z.
    chuỗi word là chuỗi cần tính toán diện tích, mỗi ký tự có chiều cao riêng
    Diện tích của 1 vùng hiển thị là chiều cao của ký tự cao nhất nhân với
    độ dài của từ đó. in ra diện tích của vùng chữ đó.
    Sample Input:n= 26 => 1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5
                 abc
    Sample Output: 9
    */
    /// </summary>

    internal class Deploy
    {
        public static int designPDFViewer(List<int> h, string word) 
        {
            int maxHeight = 0;

            foreach (int i in word)
            {
                int index = i - 'a';

                if (h[index] > maxHeight)
                {
                    maxHeight = h[index];
                }
            }

            return maxHeight * word.Length;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> h = new List<int>();
            Console.WriteLine("n = 26 interger ");
            int n = 26;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int elements = int.Parse(Console.ReadLine());
                h.Add(elements);
            }

            Console.Write("Please enter string word: ");
            string word = Console.ReadLine();

            int result = Deploy.designPDFViewer(h, word);
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
#endif

#if false // Angry Professor
namespace angryProfessor
{
    /// <summary> Algorithms Problem
    /*
    Xác định xem lớp học có bị hủy hay không dựa trên số lượng sinh viên đến 
    lớp đứng giờ.
    Cho List a chứa thời gian đến lớp của từng sinh viên
    nếu sinh viên đến sớm hoặc đúng giờ thì time <= 0.
    nếu sinh viên đến muộn time > 0.
    Cho k là số sinh viên tối thiểu cần phải có mặt đúng giờ
    trả về NO nếu có đủ (k) sinh viên đến đúng giờ hoặc sốm hơn
    trả về YES nếu có ít hơn (k) sinh viên đến đúng giờ
    Sample Input: n = 4, => -1 -3 4 2 và k = 3
    Sample Output:YES
    */
    /// </summary>

    internal class Deploy
    {
        public static string angryProfessor(int k, List<int> a)
        {
            int ontimeStudents = a.Count(time => time <= 0);

            if (ontimeStudents >= k)
            {
                return "NO";
            }
            else
            {
                return "YES";
            }
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int element = int.Parse(Console.ReadLine());
                a.Add(element);
            }

            Console.Write("Please enter k = ");
            int k = int.Parse(Console.ReadLine());

            string result = Deploy.angryProfessor(k, a);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Beautiful Days
namespace beautifulDays
{
    /// <summary> Algorithms Problem
    /*
    Tìm ra số ngày đẹp trong một khoảng từ ngày i đến ngày j. Một ngày dc
    coi là đẹp nếu chênh lệch ngày đó và số đảo ngược của nó chia hết cho k.
    Tính chênh lệch ngày bằng cách trừ ngày và số ngược của nó đảm bảo
    luôn là giá trị dương sau đó chia hết cho k.
    in ra số ngày đẹp trong khoảng từ i đến j.
    Sample Input: i = 20, j = 23, k = 6
    Sample Output: 2
    */
    /// </summary>

    internal class Deploy
    {
        public static int beautifulDays(int i, int j, int k)
        {
            int beautifulDayCount = 0;

            for (int day = i; day < j; day++)
            {
                int reversed = ReverseNumber(day);

                int difference = Math.Abs(day - reversed);

                if (difference % k == 0)
                {
                    beautifulDayCount++;
                }
            }

            return beautifulDayCount;
        }
        
        public static int ReverseNumber(int num)
        {
            int reversed = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;
                reversed = reversed * 10 + lastDigit;
                num /= 10;
            }

            return reversed;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter i= ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Please enter j= ");
            int j = int.Parse(Console.ReadLine());
            Console.Write("Please enter k= ");
            int k = int.Parse(Console.ReadLine());

            int result = Deploy.beautifulDays(i, j, k);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#endregion

#region Algorithms Easy 4

#if false // Viral Afvertising
namespace viralAdvertising
{
    /// <summary> Algorithms Problem
    /*
    Tính toán mô phỏng 1 chiến dịch quảng cáo mà mỗi ngày quảng cáo sẽ được
    chia sẽ giữa người dùng theo cách lan toả dần.
    Ban đầu quảng cáo dc chia sẽ cho 5 người.
    mỗi ngày một nữa số người xem quảng cáo, sẽ chia sẽ nó cho 3 người khác.
    (làm tròn xuống số người chia sẽ nếu cần).
    tính tổng số người đã thích quảng cáo sau n ngày.
    Sample Input: 3
    Sample Output: 9
    */
    /// </summary>

    internal class Deploy
    {
        public static int viralAdvertising(int n)
        {
            int shared = 5;
            int totalLiked = 0;

            for (int day = 0; day < n; day++)
            {
                int liked = shared / 2;
                totalLiked += liked;
                shared = liked * 3;
            }

            return totalLiked;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            int result = Deploy.viralAdvertising(n);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Save The Prisoner
namespace saveThePrisoner
{
    /// <summary> Algorithms Problem
    /*
    Xác định tù nhân nhận dc viên kẹo nguy hiểm cuối cùng.
    n là số lượng tù nhân.
    m là số viên kẹo sẽ được phát.
    s là vị trí đầu tiên nhận kẹo.
    Viên kẹo đầu tiên dc phát cho tù nhân có số thứ tự s, Các tù nhân 
    ngồi thành vòng tròn và kẹo dc phát tuần tự cho các tù nhân tiếp theo, 
    theo chiều kim đồng hồ, nếu phát hết tù nhân thứ n ta quay lại 
    tù nhân thứ 1, tính xem ai nhận dc viên kẹo cuối cùng. 
    final position = (s + m - 1) % n;

    Sample Input: n = 5, m = 2, s = 1
    Sample Output: 2
    */
    /// </summary>

    internal class Deploy
    {
        public static int saveThePrisoner(int n, int m, int s)
        {
            // Công thức circular distribution
            int result = (s + m - 1) % n;

            if (result == 0)
            {
                // nếu kết quả = 0 thì viên kẹo sẽ rơi vào tù nhân cuối cùng.
                return n;
            }
            else
            {
                return result;
            }
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Please enter s = ");
            int s = int.Parse(Console.ReadLine());

            int result = Deploy.saveThePrisoner(n, m, s);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

}
#endif

#if false // Circular Array Rotations
namespace circularArrayRotations
{
    /// <summary> Algorithms Problem
    /*
    Xoay mảng tròn yêu cầu xoay các phần tử trong một mảng theo một số bước
    nhất định, sau đó trả về giá trị các phần tử tại các vị trí nhất định.
    cho một mảng a gồm n phần tử.
    cần xoay k lần, mỗi lần xoay, phần tử cuối cùng của mảng sẽ được đưa lên
    đầu mảng và các phần tử khác sẽ dời vị trí về phía sau.
    Sau khi xoay xong, có một danh sách queries, mỗi queries là một chỉ số
    của mảng và cần phải trả về giá trị tại các chỉ số đó sau khi xoay.
    Sample Input: a = 3 => 1 2 3, k = 2, queries = 3 => 0 1 2
    Sample Output: 2 3 1
    */
    /// </summary>

    internal class Deploy
    {
        public static List<int> circularArrayRotations(List<int> a, int k, 
                                                       List<int> queries)
        {
            int n = a.Count;
            k = k % n; // để tối ưu số lần xoay

            List<int> result = new List<int>();

            foreach (int query in queries)
            {
                // công thức tính chỉ số sau khi xoay
                int index = (query - k  + n) % n;
                result.Add(a[index]);
            }

            return result;
        }
    }

    internal class Problem
    {
        static void Main(String[] args)
        {
            List<int> a = new List<int>();
            Console.Write("Plese enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int element = int.Parse(Console.ReadLine());
                a.Add(element);
            }

            Console.Write("Please enter k = ");
            int k = int.Parse(Console.ReadLine());

            List<int> queries = new List<int>();
            Console.Write("Plese enter m = ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int element = int.Parse(Console.ReadLine());
                queries.Add(element);
            }

            List<int> result = Deploy.circularArrayRotations(a, k, queries);
            Console.WriteLine(String.Join(" ", result));

            Console.ReadLine();
        }
    }
}
#endif

#if false // Sequence Equation
namespace sequenceEquation
{
    /// <summary> Algorithms Problem
    /*
    Cho một danh sách số nguyên p, là một hoán vị của các số từ 1 đến n
    (Tức là mỗi số trong khoảng tứ 1 đến n xuất hiện đúng 1 lần).
    Tìm một dãy số mới y sao cho với mỗi số nguyên x (1 <= x <= n)
    tìm dc y(x) thỏa mãn p(p(y(x))) = x

    Hiểu đơn giản:
    Bạn có một dãy p trong đó p[i] là giá trị ở vị trí thứ i + 1
    (Lưu ý chỉ số bắt đầu từ 1).
    với mỗi giá trị x (1, 2, 3,..., n) phải tìm một vị trí y(x)
    sao cho nếu bạn lấy giá trị ở vị trí y(x) trong dãy p
    sau đó lại lấy giá trị ở vị trí được xác định bởi giá trị đó, 
    bạn sẽ nhận lại được giá trị x.

    Ví dụ cụ thể:
    Cho p = [5,2,1,3,4].
    Ban đầu x = 1.
    tìm chỉ số i sao cho p[i] = x (ở đây x = 1).
    trong dãy p = [5,2,1,3,4]. 1 nằm ở vị trí thứ 3 vì chỉ số bắt đầu từ 1
    theo đề bài.
    vì vậy ta có vị trí 3 đã dc tìm, sau đó ta tìm số 3 trong p = [5,2,1,3,4]
    ta tìm dc số 3 ở vị trí thứ 4. sau đó thêm số 4 vảo mảng kết quả.
    Tiếp tục làm tương tự cho các giá trị x = 2, 3, 4, 5 đúng với (1 <= x <= n)
    Kết quả của dãy y(x) sẽ là [4, 2, 5, 1, 3].

    Sample Input: n = 5 => p =  4 3 5 1 2
    Sample Output: 1 3 5 4 2
    */
    /// </summary>

    internal class Deploy
    {
        public static List<int> permutationEquation(List<int> p)
        {
            int n = p.Count;

            List<int> result = new List<int>();

            // Duyệt qua tất cả các giá trị x từ 1 đến n
            for (int x = 1; x <= n; x++)
            {
                // Tìm vị trí i sao cho p[i] == x
                int i = p.IndexOf(x) + 1; //vì chỉ số bắt đầu từ 1 theo đề bài
                                          // nên cộng thêm 1.
                // Tìm vị trí j sao cho p[j] == i
                int j = p.IndexOf(i) + 1;

                result.Add(j);
            }

            return result;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> p = new List<int>();
            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i}: ");
                int element = Convert.ToInt32(Console.ReadLine());
                p.Add(element);
            }

            List<int> result = Deploy.permutationEquation(p);
            Console.WriteLine(string.Join(" ", result));

            Console.ReadLine();
        }
    }
}
#endif

#if false // Jumping On The Cloud (Array)
namespace jumpingOnTheCloud
{
    /// <summary> Algorithms Problem
    /*
    Cho một mảng đám mây, mỗi đám mây có giá trị 0 là an toàn và giá trị 1 là 
    nguy hiểm. bắt đầu tại vị trí đầu tiên index = 0, và nhảy qua các đám mây với 
    bước nhảy cố định là k.

    Khi thực hiện 1 bước nhảy, sẽ phải tránh các đám mây nguy hiểm (đám mây có giá
    trị 1) mỗi lần nhảy sẽ mất đi 1 điểm năng lượng, và nếu nhảy vào đám mây 
    nguy hiểm thì sẽ mất thêm 2 năng lượng.

    Tính toán năng lượng còn lại sau khi thực hiện xong các bước nhảy qua tất cả 
    đám mây và quay trở lại vị trí ban đầu.
    Cho năng lượng ban đầu là 100.

    Sample Input: n = 8 => 0 0 1 0 0 1 1 0 , k = 2
    Sample Output: 92
    */
    /// </summary>

    internal class Deploy
    {
        // bởi vì người chơi sẽ thực hiện ít nhất 1 lần nhảy nên sẻ dùng vòng lặp
        // (do-while) thay vì vòng lặp for hay while, (nếu dùng for hay while vẫn dc)
        // do-while: khối lệnh được thực thi ít nhất một lần,
        // bất kể điều kiện ban đầu có đúng hay không.
        public static int jumpingOnClouds(int[] c, int k)
        {
            int energy = 100;
            int i = 0;

            do
            {
                i = (i + k) % c.Length; // Nhảy đến đám mây tiếp theo
                energy--;

                if (c[i] == 1)
                {
                    energy -= 2;
                }
            }
            while (i != 0); // Tiếp tục cho đến khi quay lại vị trí ban đầu

            return energy;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] clouds = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i} is state clouds 0 or 1: ");
                int element = Convert.ToInt32(Console.ReadLine());
                clouds[i] = element;
            }

            Console.Write("Please enter k = ");
            int k = Convert.ToInt32(Console.ReadLine());

            int result = Deploy.jumpingOnClouds(clouds, k);
            Console.WriteLine($"Energy after jumping on clouds: {result}");

            Console.ReadLine();
        }
    }
}
#endif

#if false // Find Digits
namespace findDigits
{
    /// <summary> Algorithms Problem
    /*
    Cho một số nguyên n, đếm có bao nhiêu chữ số của n có thể chia hết cho n.
    ví dụ: n = 124 thì kiểm tra 124 % 1 == 0, nếu có thì biến count tăng 1.
    tiếp tục số 124 % 2 == 0, và 124 % 4 == 0.
    in ra biến count = 3 nếu số 124 đều chia hết cho 1, 2, 4.
    Sample Input: 1012
    Sample Output: 3
    */
    /// </summary>

    internal class Deploy
    {
        public static int findDigits(int n)
        {
            int count = 0;
            int temp = n; // Dùng biến tạm để giữ giá trị của n

            while (temp > 0)
            {
                int digit = temp % 10;  // Lấy chữ số cuối cùng
                temp /= 10; // Loại bỏ chữ số cuối cùng

                // Bỏ qua nếu chữ số là 0
                if (digit == 0)
                {
                    continue;
                }

                if (n % digit == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = Deploy.findDigits(n);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Append And Delete
namespace anppendAndDelette
{
    /// <summary> Algorithmns Problem
    /*
    xác định xem có thể chuyển đổi chuỗi S thành chuỗi T bằng cách thực hiện một số 
    thao tác xóa và thêm trong bằng hoặc ít hơn K bước hay không, 
    trả về Yes nếu có và trả về No nếu k.
    Input:
    Chuỗi s: chuỗi ban đầu.
    Chuỗi t: chuỗi mục tiêu.
    Số nguyên k: số lượng thao tác bạn có thể thực hiện.
    Output: Chuỗi "Yes" hoặc ""No"
    Sample Input: S = hackerhappy, T = hackerrank, K = 9
    Sample Output: Yes
    */
    /// </summary>

    internal class Deploy
    {
        public static string appendAndDelete(string s, string t, int k)
        {
            // Tìm chiều dài của phần tiền tố chung giữa chuỗi s và t
            int commonLength = 0;

            for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
            {
                if (s[i] == t[i])
                {
                    commonLength++;
                }
                else
                {
                    break; // Dừng lại khi gặp ký tự khác nhau
                }
            }
            
            // số ký tự cần xóa từ s + số ký tự cần thêm vào từ t
            int totalOperations = (s.Length - commonLength) + (t.Length - commonLength);

            // (k - totalOperations) % 2 == 0 Kiểm tra xem số thao tác dư ra có phải là
            // số chẵn không (để có thể thêm và xóa đồng thời) vì nếu là số lẻ thì bị thiếu 1 
            // thao tác vì chuyển đổi chuổi cần phải có xóa và thêm mới hợp lý.
            if (totalOperations <= k && (k - totalOperations) % 2 == 0) 
            {
                return "Yes";
            }
            else if (s.Length + t.Length <= k)
            {
                return "Yes"; // Có thể chuyển đổi bằng cách xóa toàn bộ và thêm toàn bộ
            }
            else
            {
                return "No";
            }
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter s = ");
            string s = Console.ReadLine();
            Console.Write("Please enter t = ");
            string t = Console.ReadLine();
            Console.Write("Please enter k = ");
            int k = Convert.ToInt32(Console.ReadLine());

            string result = Deploy.appendAndDelete(s, t, k);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Squares
namespace squares
{
    /// <summary> Algprithms Problem
    /*
    Xác định số lượng số chính phương trong một khoảng số nguyên cho trước.

    Định nghĩa số chính phương:
    một số được gọi là số chính phương khi nó có căn bậc hai là một số nguyên.
    ví dụ: 4 = 2^2, 9 = 3^2 vậy 4 và 9 là 2 số chính phương...v...v...

    Sample Input: 3 9
    Sample Output: 2
    */
    /// </summary>

    internal class Deploy
    {
        public static int squares(int a, int b)
        {
            // Tính số chính phương đầu tiên lớn hơn hoặc bằng a
            int start = (int)Math.Ceiling(Math.Sqrt(a));

            // Tính số chính phương cuối cùng nhỏ hơn hoặc bằng b
            int end = (int)Math.Floor(Math.Sqrt(b));

            return Math.Max(0, end - start + 1);
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = Deploy.squares(a, b);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Library Fine
namespace libraryFine
{
    /// <summary> Algprithms Problem
    /*
    tính toán tiền phạt trả sách muộn cho một thư viện dựa trên ngày trả dự kiến và 
    ngày trả thực tế. 

    Ta có hai ngày:
    - Ngày trả sách thực tế: d1 (ngày), m1 (tháng), y1 (năm)
    - Ngày trả sách dự kiến: d2 (ngày), m2 (tháng), y2 (năm)

    Mức phạt được tính theo các quy tắc sau:
    - Nếu sách được trả đúng hạn hoặc trước ngày trả dự kiến (tức là y1 < y2, 
    hoặc y1 == y2 và m1 < m2, hoặc y1 == y2 và m1 == m2 và d1 <= d2): Không có phạt (trả về 0).
    - Nếu sách được trả muộn trong cùng một tháng và cùng một năm: 
    Tiền phạt là 15 Hackos cho mỗi ngày muộn: (d1 - d2) * 15.
    - Nếu sách được trả muộn trong cùng một năm nhưng khác tháng:
    Tiền phạt là 500 Hackos cho mỗi tháng muộn: (m1 - m2) * 500.
    - Nếu sách được trả muộn sau năm dự kiến: Tiền phạt là 10,000 Hackos.


    Sample Input:  d1 = 9, m1 = 6, y1 = 2015, d2 = 6, m2 = 6, y2 = 2015
    Sample Output: 45
    */
    /// </summary>

    internal class Deploy
    {
        public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            // Nếu năm trả sách lớn hơn năm dự kiến
            if (y1 > y2)
            {
                return 10000; // Tiền phạt là 10,000 Hackos.
            }
            // Nếu năm trả sách nhỏ hơn năm dự kiến, không có phạt
            if (y1 < y2)
            {
                return 0;
            }
            // Nếu năm trả sách bằng năm dự kiến
            else
            {
                // Nếu tháng trả sách lớn hơn tháng dự kiến
                if (m1 > m2)
                {
                    return (m1 - m2) * 500;
                }
                else if (m1 < m2)
                {
                    return 0;
                }
                // Nếu tháng và năm trả sách bằng nhau
                else
                {
                    // Nếu ngày trả sách lớn hơn ngày dự kiến
                    if (d1 > d2)
                    {
                        return (d1 - d2) * 15;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter d1: ");
            int d1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter m1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter d2: ");
            int d2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter m2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            int result = Deploy.libraryFine(d1, m1, y1, d2, m2, y2);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Cut the Sticks
namespace cutTheSticks
{
    /// <summary> Algprithms Problem
    /*
    cắt bỏ các phần tử có độ dài nhỏ nhất từ danh sách các que và tiếp tục cắt
    cho đến khi không còn que nào nữa.

    Cho một mảng chứa các số nguyên dương, mỗi số đại diện cho chiều dài của một que.

    Giả sử danh sách ban đầu là [5, 4, 4, 2, 2, 8].
    Bước 1: Danh sách ban đầu có 6 que. Ta thêm số 6 vào danh sách kết quả.
    Bước 2: Cắt độ dài nhỏ nhất là 2: Danh sách sau khi cắt: [3, 2, 2, 0, 0, 6] 
    (loại bỏ 0). Còn lại 4 que. Thêm số 4 vào danh sách kết quả.
    Bước 3: Cắt độ dài nhỏ nhất là 2: Danh sách sau khi cắt: [1, 0, 0, 0] (loại bỏ 0).
    Còn lại 3 que. Thêm số 3 vào danh sách kết quả.
    Bước 4: Cắt độ dài nhỏ nhất là 1: Danh sách sau khi cắt: [0, 0, 0].
    Còn lại 1 que. Thêm số 1 vào danh sách kết quả.

    Kết quả cuối cùng là [6, 4, 2, 1].

    Sample Input:  [5, 4, 4, 2, 2, 8]
    Sample Output: [6, 4, 2, 1]
    */
    /// </summary> 

    internal class Deploy
    {
        public static List<int> cutTheSticks(List<int> arr)
        {
            List<int> result = new List<int>();

            while(arr.Count > 0)
            {
                result.Add(arr.Count);

                int minValue = arr.Min();

                arr = arr.Select(x => x - minValue).Where(x => x > 0).ToList();
            }

            return result;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please eneter element {i}: ");
                int element = Convert.ToInt32(Console.ReadLine());
                arr.Add(element);
            }

            var result = Deploy.cutTheSticks(arr);
            Console.WriteLine(string.Join(", ", result));

            Console.ReadLine();
        }
    }
}
#endif

#endregion

#region Algorithms Easy 5

#if false // Repeated String
namespace repeatedString
{
    /// <summary> Algprithms Problem
    /*
    Cho có một chuỗi nhỏ s và cần lặp lại chuỗi này nhiều lần để tạo ra một 
    chuỗi lớn có độ dài n.  Sau đó, cần đếm số lần xuất hiện của ký tự 'a' 
    trong chuỗi lớn đó.

    Ví dụ:
    Chuỗi s = "abcac".
    muốn lặp lại chuỗi s để tạo thành một chuỗi lớn có độ dài n = 10.
    Sau khi lặp lại chuỗi s, chuỗi lớn sẽ là "abcacabcac" (có độ dài đúng 10).
    Trong chuỗi lớn đó, ký tự 'a' xuất hiện 4 lần.

    in ra 4.

    Sample Input: s =  aba , n  = 10
    Sample Output: 7
    */
    /// </summary> 

    internal class Deploy
    {
        public static long repeatedString(string s, long n)
        {
            // Đếm số lượng 'a' trong chuỗi s
            long countA = s.Count(c => c == 'a');

            // Tính số lần lặp lại đầy đủ trong chuỗi s
            long fullRepeats = n / s.Length;

            // nếu dư thì Tính phần dư chưa đầy đủ của chuỗi s
            long remainder = n % s.Length;

            // Đếm số 'a' trong phần dư của chuỗi s
            long countRemainderA = s.Substring(0, (int)remainder).
                                                                 Count(c => c == 'a');

            // Tính tổng số 'a' trong chuỗi độ dài n
            return fullRepeats * countA + countRemainderA;

        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter s = ");
            string s = Console.ReadLine();
            Console.Write("Please enter n = ");
            long n = long.Parse(Console.ReadLine());

            long result = Deploy.repeatedString(s, n);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Jumping On The Cloud 2
namespace jumpingOnTheCloud2
{
    /// <summary> Algorithms Problem
    /*
    cho một dãy số đại diện cho các đám mây
    Mỗi phần tử của mảng c là 0 hoặc 1:
    - 0 biểu thị đám mây an toàn mà có thể nhảy lên.
    - 1 biểu thị đám mây có sấm sét mà không được nhảy lên.

    tính toán số bước nhảy ít nhất cần thiết để đi từ đám mây đầu tiên (vị trí 0) 
    đến đám mây cuối cùng (vị trí cuối cùng của mảng). 
    có thể nhảy tối đa 2 bước mỗi lần, nhưng chỉ được nhảy lên các đám mây an toàn

    Ví dụ:
    Dãy c = [0, 1, 0, 0, 0, 1, 0].
    Bắt đầu từ vị trí 0.
    Nhảy 2 bước đến vị trí 2.
    Nhảy 2 bước đến vị trí 4.
    Nhảy 2 bước đến vị trí 6.
    vậy cần 3 lần nhảy in ra 3

    Sample Input: n = 7 =>  0 0 1 0 0 1 0
    Sample Output: 4
    */
    /// </summary>

    internal class Deploy
    {
        public static int jumpingOnClouds2(List<int> c )
        {
            int jumps = 0;
            int i = 0;

            // Duyệt qua các đám mây từ vị trí đầu tiên đến gần cuối
            while (i < c.Count - 1)
            {
                if ( i + 2 < c.Count && c[i + 2] == 0)
                {
                    i += 2;
                }
                else
                {
                    i += 1;
                }

                jumps++;
            }

            return jumps;

        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> c = new List<int>();
            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter element {i} is 0 or 1: ");
                int element = Convert.ToInt32(Console.ReadLine());
                c.Add(element);
            }

            int result = Deploy.jumpingOnClouds2(c);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#endregion

#region Algorithms Medium 1

#if false // Forming A Magic Square (List<List<int>>)
namespace FormingAMagicSquare
{
    /// <summary> Algorithms Problem
    /*
    Biến đổi một ma trận 3x3 thành một ma trận ma thuật với chi phí
    biến đổi nhỏ nhất, mỗi ma trận ma thuật là một ma trận vuông,
    tổng các số trên mỗi hàng và mỗi cột và hai đường chéo
    đều phải bằng 15.
    Vì ma trận ma thuật là ma trận vuông 3x3 có các con số từ 
    1 đến 9 và tổng cột hàng đường chéo đều bằng 15
    nên chỉ có 8 trường hợp có thể xảy ra:

    [8, 1, 6]    [6, 1, 8]    [4, 9, 2]    [2, 9, 4]
    [3, 5, 7]    [7, 5, 3]    [3, 5, 7]    [7, 5, 3]
    [4, 9, 2]    [2, 9, 4]    [8, 1, 6]    [6, 1, 8]

    [8, 3, 4]    [4, 3, 8]    [6, 7, 2]    [2, 7, 6]
    [1, 5, 9]    [9, 5, 1]    [1, 5, 9]    [9, 5, 1]
    [6, 7, 2]    [2, 7, 6]    [8, 3, 4]    [4, 3, 8]

    Tính toán chi phí biến đổi nhỏ nhất để ma trận đầu vào trở thành
    1 trong những ma trận trên, chi phí biến đổi là tổng các trị
    tuyệt đối của sự khác biệt giữa từng phần tử của ma trận đầu vào
    và ma trận ma thuật tương ứng.
    cách tính chi phí biến đổi nhỏ nhất:
    Ví dụ ma trận đầu vào:  4 9 2 và ma trận ma thuật đầu tiên 8 1 6 
                            3 5 7                              3 5 7
                            8 1 5                              4 9 2
    Chi phí biến đổi: |4 - 8| = 4 + |9 - 1| = 8 + ... = 31
    so sánh ma trận đầu vào với 7 ma trận ma thuật tiếp theo 
    để tìm ra chi phí biến đổi nhỏ nhất sau đó 
    in ra giá trị chi phí biến đổi nhỏ nhất này?
    Sample Input: 4 9 2
                  3 5 7
                  8 1 5
    Sample Output: 1
    */
    /// </summary>

    internal class Deploy
    {
        public static int formingMagicSquare(List<List<int>> s)
        {
            List<int[,]> magicSquares = new List<int[,]>
            {
                new int[,] { { 8, 1, 6}, { 3, 5, 7}, { 4, 9, 2} },
                new int[,] { { 6, 1, 8}, { 7, 5, 3}, { 2, 9, 4} },
                new int[,] { { 4, 9, 2}, { 3, 5, 7}, { 8, 1, 6} },
                new int[,] { { 2, 9, 4}, { 7, 5, 3}, { 6, 1, 8} },
                new int[,] { { 8, 3, 4}, { 1, 5, 9}, { 6, 7, 2} },
                new int[,] { { 4, 3, 8}, { 9, 5, 1}, { 2, 7, 6} },
                new int[,] { { 6, 7, 2}, { 1, 5, 9}, { 8, 3, 4} },
                new int[,] { { 2, 7, 6}, { 9, 5, 1}, { 4, 3, 8} }
                
            };

            int minCost = int.MaxValue;

            foreach (var magicSquare  in magicSquares)
            {
                int currentCost = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        currentCost += Math.Abs(s[i][j] - magicSquare[i, j]);
                    }
                }

                minCost = Math.Min(minCost, currentCost);
            }

            return minCost;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<List<int>> s = new List<List<int>>();
            Console.Write("Please enter nRow = ");
            int nRow = int.Parse(Console.ReadLine());
            Console.Write("Please enter nColumn = ");
            int nCols = int.Parse(Console.ReadLine());

            for (int i = 0; i < nRow; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < nCols; j++)
                {
                    Console.Write($"Please enter element rows {i}: ," +
                                  $" columns {j}: ");
                    int elements = int.Parse(Console.ReadLine());
                    row.Add(elements);

                }
                s.Add(row);
            }

            int result = Deploy.formingMagicSquare(s);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

}
#endif

#if false // Climbing The Leaderboard
namespace climbingTheLeaderboard
{
    /// <summary> Algorithms Problem
    /*
    Cho 1 list các thứ hạng được sắp xếp giảm giần và có thể có các giá trị trùng
    lặp như sau: Ranked[100, 90, 90, 80]
    cho 1 list các điểm người chơi sau mỗi lần chơi, người chơi có thể đạt điểm 
    mới như sau: player[70, 50, 105)
    Sau đó in ra thứ hạng của người chơi sau mỗi lần chơi 
    ví dụ Ranked[100, 90, 90, 80] thì 100 hạng 1, 90 hạng 2, và 80 hạng 3
    player[70, 50, 105) thì 70 thấp hơn hạng 3 là 80 nên in ra 4
    tiếp tục 50 ít hơn hạng 3 là 80 luôn nên in ra 4
    tiếp tục 105 cao hơn hạng 1 là 100 nên i ra 1
    vậy in ra 4, 4, 1
    Sample Input: n = 6 Ranked [100 90 90 80 75 60]
                  m = 5 Player [50 65 77 90 102]
    Sample Output: 6 5 4 2 1
    */
    /// </summary>

    internal class Deploy
    {
        public static List<int> climbingTheLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> uniqueRanks = ranked.Distinct().ToList();

            List<int> result = new List<int>();

            int index = uniqueRanks.Count - 1;

            foreach (int score in player)
            {
                while (index >= 0 && score >= uniqueRanks[index])
                {
                    index--;
                }

                result.Add(index + 2);
            }

            return result;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> ranked = new List<int>();
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i =  0; i < n; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int elements = int.Parse(Console.ReadLine());
                ranked.Add(elements);
            }

            List<int> player = new List<int>();
            Console.Write("Please enter m = ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0;i < m; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int elements = int.Parse(Console.ReadLine());
                player.Add(elements);
            }

            List<int> result = Deploy.climbingTheLeaderboard(ranked, player);
            Console.WriteLine(String.Join(" ", result));

            Console.ReadLine();

        }
    }
}
#endif

#if false // Utopian Tree
namespace utopianTree
{
    /// <summary> Algorithms Problem
    /*
    Tính toán sự phát triển của một cái cây theo 2 mùa 
    mùa xuân cây tăng gấp đôi chiều cao
    mùa hè cây tăng thêm 1 đơn vị chiều cao
    ban đầu cây có chiều cao là 1
    với 1 chu kỳ: mùa xuân và 1 mùa hè dc coi là 1 chu kỳ 2 mùa
    tính chiều cao của cây sau n chu kỳ
    cho mùa xuân là chu kỳ lẽ và mùa hè là chu kì chẵn
    Sample Input: n =  1 
    Sample Output:     2    
    */
    /// </summary>

    internal class Deploy
    {
        public static int utopianTree(int n)
        {
            int height = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    height *= 2;
                }
                else
                {
                    height += 1;
                }
            }

            return height;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            int result = Deploy.utopianTree(n);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Extra Long Factorials
namespace extraLongFactorials
{
    /// <summary> Algorithms Problem
    /*
    Tính giai thừa của một số nguyên n.
    n! = n x ( n - 1 ) x ( n - 2 ) x ( n - 3 ) x  ... x 1
    5! = 5 × 4 × 3 × 2 × 1 = 120
    sử dụng BigInteger kiểu dữ liệu đặc biệt có thể lưu trữ các số lớn
    từ thư viện System.Numerics
    BigInteger lưu trữ dữ liệu lớn hơn cả long và int.
    Sample Input: 25
    Sample Output: 1 5 5 1 1 2 1 0 0 4 3 3 3 0 9 8 5 9 8 4 0 0 0 0 0 0 
    */
    /// </summary>

    internal class Deploy
    {
        public static void extraLongFactorials(int n)
        {
            BigInteger factorial = 1;

            for (int i = 2; i <= n ; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            Deploy.extraLongFactorials(n);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Non-Divisible Subset
namespace NonDivisibleSubset
{
    /// <summary> Algprithms Problem
    /*
    tìm tập hợp con lớn nhất trong một danh sách các số nguyên sao cho không có cặp nào
    trong tập hợp đó có tổng chia hết cho một số nguyên k nhất định.

    Cho một danh sách các số nguyên và một số nguyên k, tìm tập hợp con lớn nhất 
    từ danh sách đó sao cho không có cặp nào trong tập hợp con có tổng chia hết cho k.

    trả về kích thước của tập hợp con lớn nhất mà k có tổng chia hết cho 3

    Sample Input: S = [1, 7, 2, 4]
    Sample Output: 3
    */
    /// </summary> 

    internal class Deploy
    {
        public static int nonDivisibleSubset(int k, List<int> s)
        {
            // Tạo mảng đếm với kích thước k
            int[] count = new int[k];

            // Đếm các số theo mod k
            foreach (int number in s)
            {
                count[number % k]++; // Tăng số lượng phần tử theo mod k
            }

            // Khởi tạo kích thước của tập hợp không chia hết
            int result = Math.Min(count[0], 1);

            for (int i = 1; i <= k / 2; i++)
            {
                if (i != k - i) // Kiểm tra không phải là k/2
                {
                    result += Math.Max(count[i], count[k - i]);
                }
            }

            // Nếu k là số chẵn, thêm một phần tử k/2
            if (k % 2 == 0)
            {
                result++;
            }

            return result;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            var s = new List<int>();

            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int element = Convert.ToInt32(Console.ReadLine());
                s.Add(element);
            }

            Console.Write("Please enter k = ");
            int k = Convert.ToInt32(Console.ReadLine());

            int result = Deploy.nonDivisibleSubset(k , s);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#endregion


#region Data Structures Easy 1

#if false // ArrayDS - Reverse Array
namespace arrayDS
{
    /// <summary> Data Structures
    /*
    Cho một danh sách, đảo ngược danh sách đó lại như sau
    A = 1 2 3 => 3 2 1
    Sample Input:n = 4 => 1 4 3 2
    Sample Output: 2 3 4 1
    */
    /// </summary>

    internal class Deploy
    {
        public static List<int> reverseArray(List<int> a)
        {
            a.Reverse();
            return a;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter elements {i}: ");
                int elements = int.Parse(Console.ReadLine());
                a.Add(elements);
            }

            List<int> result = Deploy.reverseArray(a);
            Console.WriteLine(string.Join(" ", result));

            Console.ReadLine();
        }
    }
}
#endif

#if false // 2D ArrayDS - HourGlass (List<List<int>>)
namespace hourGlassSum
{
    /// <summary> Algorithms Problem
    /*
    Cho 1 danh sách 2 chiều 6x6
    Tính tổng lớn nhất của một hình đồng hồ cát trong ma trận 6 x 6
    một hình đồng hồ cát có cấu trúc như sau: a b c
                                                d
                                              e f g
    arr[i][j],   arr[i][j+1],   arr[i][j+2]         // hàng trên
                 arr[i+1][j+1]                      // phần giữa
    arr[i+2][j], arr[i+2][j+1], arr[i+2][j+2]       // hàng dưới

    Sample Input: 1 1 1 0 0 0
                  0 1 0 0 0 0
                  1 1 1 0 0 0
                  0 0 2 4 4 0
                  0 0 0 2 0 0
                  0 0 1 2 4 0
    Sample Output: 19
    */
    /// </summary>

    internal class Deploy
    {
        public static int hourGlass(List<List<int>> arr)
        {
            int maxSum = int.MinValue;

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    int currentSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
                                     arr[i + 1][j + 1] + 
                        arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            return maxSum;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            Console.Write("Please enter nRow = ");
            int nRow = int.Parse(Console.ReadLine());
            Console.Write("Please enter nColumn = ");
            int nCol = int.Parse(Console.ReadLine());

            for (int i = 0;i < nRow; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < nCol; j++)
                {
                    Console.Write($"Please enter element row{i} col{j}: ");
                    int element = int.Parse(Console.ReadLine());
                    row.Add(element);
                }

                arr.Add(row);

            }

            int result = Deploy.hourGlass(arr);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Dynamic Array
namespace dynamicArray
{
    /// <summary> Data Structers
    /*
    xủ lý các truy xuất query dựa trên số lượng sublist
    Cho một danh sách 2 chiều các loại query và một biến n số lượng sublist
    cần xử lý 2 loại truy vấn:
    query1: 1 x y thêm phần tử y vào danh sách dc chọn dựa trên công thức:
    index = ( x ^ lastAnswer) % n. ( ^ là XOR) lastAnswer ban đầu = 0.
    query2: 2 x y tìm phần tử y % size trong danh sách được chọn dựa trên
    công thức ở query1 , sau đó gán giá trị này cho lastAnswer, và thêm
    lastAnswer vào danh sách kết quả.

    ví dụ: n = 2 , q = 5 => 1 0 5       => x = 0, y = 5 query1
                            1 1 7       => x = 1, y = 7 query1
                            1 0 3       => x = 0, y = 3 query1
                            2 1 0       => x = 1, y = 0 query2
                            2 1 1       => x = 1, y = 1 query2

    Query 1 0 5: index = (0 ^ 0) % 2 = 0,thêm 5 vào seqList[0].
    Query 1 1 7: index = (1 ^ 0) % 2 = 1,thêm 7 vào seqList[1].
    Query 1 0 3: index = (0 ^ 0) % 2 = 0, thêm 3 vào seqList[0].
    Query 2 1 0: index = (1 ^ 0) % 2 = 1, size = 1, lấy phần tử 
    0 % 1 = 0 từ seqList[1] chính là 7 gán lastAnswer = 7, thêm 7 List result.
    Query 2 1 1: index = (1 ^ 7) % 2 = 0, size = 2, lấy phần tử 1 % 2 = 1 
    từ seqList[0] (phần tử 3), gán lastAnswer = 3, thêm 3 vào kết quả.

    in ra danh sách result chứa các lastAnswer dc lưu vào là [7, 3].
    Sample Input: n = 3, q = 6 => 1 1 5
                                  1 1 7
                                  1 0 3
                                  2 1 0
                                  2 1 1
                                  1 2 9
    Sample Output: [5, 7]
    */
    /// </summary>

    internal class Deploy
    {
        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            // tạo List 2 chiều seqList rỗng.
            List<List<int>> seqList = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                seqList.Add(new List<int>());
            }

            int lastAnswer = 0;
            List<int> result = new List<int>();

            foreach (var query in queries)
            {
                int queryType = query[0];
                int x = query[1];
                int y = query[2];

                int index = (x ^ lastAnswer) % n;

                if (queryType == 1)
                {
                    seqList[index].Add(y);
                }
                else if (queryType == 2)
                {
                    int size = seqList[index].Count;
                    lastAnswer = seqList[index][y % size];
                    result.Add(lastAnswer);
                }
            }

            return result;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            List<List<int>> queries = new List<List<int>>();
            Console.Write("Please enter nRow= ");
            int nRow = int.Parse(Console.ReadLine());
            Console.Write("Please enter nCol= ");
            int nCol = int.Parse(Console.ReadLine());

            for (int i = 0; i < nRow; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < nCol; j++)
                {
                    Console.Write($"Please enter element row {i} col {j}: ");
                    int element = int.Parse(Console.ReadLine());
                    row.Add(element);
                }
                queries.Add(row);
            }

            List<int> result = Deploy.dynamicArray(n, queries);
            Console.WriteLine(String.Join(", ", result));

            Console.ReadLine();
        }
    }

}
#endif

#if false // Left Rotation
namespace leftRotation
{
    /// <summary> Data Structures
    /*
    Xoay vòng 1 mảng gồm n phần tử sang trái d lần, nghĩa là dịch chuyển 
    mỗi phần tử trong mảng sang trái, còn phần tử đầu mảng sẽ đẩy về cuối
    ví dụ: [1, 2, 3, 4, 5] d = 2 => [3, 4, 5, 1, 2]
    Sample Input: n = 5 => 1 2 3 4 5 và d = 4
    Sample Output: 5 1 2 3 4
    */
    /// </summary>

    internal class Deploy
    {
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            int n = arr.Count;

            // số lần xoay d nếu lớn hơn hoặc bé hơn n thì ta có d = d % n
            // còn d mà bằng n thì vẫn giữ nguyên vị trí ban đầu
            d = d % n;

            List<int> rotateArray = arr.GetRange(d, n - d)
                                        .Concat(arr.GetRange(0, d)).ToList();

            return rotateArray;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            Console.Write("Please enter d = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i  = 0; i < n; i++)
            {
                Console.Write($"Please enter Elements {i}: ");
                int elements = int.Parse(Console.ReadLine());
                arr.Add(elements);
            }

            List<int> result = Deploy.rotateLeft(d, arr);
            Console.WriteLine(String.Join(" ", result));

            Console.ReadLine();

        }
    }
}
#endif

#if false // Print the Element of a Linked List (Sinly Linked List)
namespace printTheElementOfALinkedList
{
    /// <summary> Data Structures
    /*
    Singly Linked List bao gồm nhiều nút, mỗi nút chưa dữ liệu và tham chiếu
    đến nút tiếp theo, nếu là nút cuối cùng giá trị tham chiếu đến nút tiếp
    theo sẽ là null;
    Nhận tham chiếu head đến nút đầu tiên của SinglyLinkedList thực hiện
    duyệt qua các nút từ đầu đến cuối và in ra giá trị của từng nút.
    Sample Input: n = 2 nút, 16 13
    Sample Output: 16 13
    */
    /// </summary>

    internal class Deploy
    {
        public static void printLinkedList(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode currentNode = head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList Linkedlist = new SinglyLinkedList();

            Console.Write("Please enter nNode = ");
            int nNode = int.Parse(Console.ReadLine());

            for (int i = 0; i < nNode; i++)
            {
                Console.Write($"Please enter node {i}: ");
                int node = int.Parse(Console.ReadLine());
                Linkedlist.InsertNode(node);
            }

            Deploy.printLinkedList(Linkedlist.head);

            Console.ReadLine();

        }
    }
}
#endif

#if false // Insert A Node At The Tail Of A Linked List
namespace insertANodeAtTheTailOfALinkedList
{
    /// <summary> Data Structures
    /*
    Thêm một node mới vào cuối SinglyLinkedList.
    Nếu danh sách trống thì node mới là phần đầu head của danh sách
    nếu danh sách k rỗng thì duyệt qua từng node đến phần tử cuối cùng
    sau đó tạo node mới sau node cuối cùng.
    Sample Input: nNode = 5 => 141 474 302 164 530 
    Sample Output: 141 302 164 530 474
    */
    /// </summary>

    internal class Deploy
    {
        public static SinglyLinkedListNode insertNodeAtTail(
                                        SinglyLinkedListNode head, int data)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            if (head == null)
            {
                return newNode;
            }

            SinglyLinkedListNode currentNode = head;

            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            currentNode.next = newNode;

            return head;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList linklist = new SinglyLinkedList();
            Console.Write("Please enter nnode = ");
            int nNode = int.Parse(Console.ReadLine());

            for (int i = 0; i < nNode; i++)
            {
                Console.Write($"Please enter value to insert at tail: ");
                int newNodeData = int.Parse(Console.ReadLine());
                linklist.head = Deploy.insertNodeAtTail(linklist.head, 
                                                        newNodeData);
            }

            // Print the linked list
            SinglyLinkedListNode current = linklist.head;
            Console.WriteLine("Linked List values:");
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

            Console.ReadLine();
        }
    }
}
#endif

#if false // Insert A Node At The Head Of A Linked List
namespace insertANodeAtTheHeadOfALinkedList
{
    /// <summary> Data Structures
    /*
    Thêm một nút mới vào đầu SinglyLinkedLList.
    Sample Input: nNode = 5 => 383 484 392 975 321
    Sample Output: 321 975 392 484 383
    */
    /// </summary>

    internal class Deploy
    {
        public static SinglyLinkedListNode insertNodeAtHead(
                                        SinglyLinkedListNode llist, int data)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            newNode.next = llist;

            return newNode;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList LinkedList = new SinglyLinkedList();

            Console.Write("Please enter nNode = ");
            int nNode = int.Parse(Console.ReadLine());

            for (int i = 0; i < nNode; i++)
            {
                Console.Write("Please enter value to insert at head: ");
                int newNodeData = int.Parse(Console.ReadLine());
                LinkedList.head = Deploy.insertNodeAtHead(LinkedList.head, 
                                                          newNodeData);
            }

            // Print the linked list
            SinglyLinkedListNode currentNode = LinkedList.head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }

            Console.ReadLine();
        }
    }
}
#endif

#if false // Insert A Node At A Specific Position In A Linked List
namespace insertANodeAtASpecificPositionInALinkedList
{
    /// <summary> Data Structures
    /*
    Chén 1 nút mới có giá trị data vào Linked List với vị trí position,
    Vị trí này bắt đầu từ 0 giống như chỉ số của mảng.
    Sample Input: nNode = 3 => llist[16 13 7], data = 1, position = 2
    Sample Output: 16 13 1 7
    */
    /// </summary>

    internal class Deploy
    {
        public static SinglyLinkedListNode insertNodeAtPosition(
                            SinglyLinkedListNode llist, int data, int position)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            // trường hợp đặc biệt: chèn vào đầu danh sách
            if (position == 0)
            {
                newNode.next = llist;
                return newNode;
            }
            // Tìm vị trí trước vị trí cần chèn position - 1
            SinglyLinkedListNode currentNode = llist;
            for (int i = 0; i < position - 1; i++)
            {
                currentNode = currentNode.next;
            }

            // gán tham chiếu nút mới cho nút tiếp theo, và gán tham chiếu
            // nút trước đó cho nút mới.
            newNode.next = currentNode.next;
            currentNode.next = newNode;

            return llist;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList linkedList = new SinglyLinkedList();
            Console.Write("Please enter nNode = ");
            int nNode = int.Parse(Console.ReadLine());

            for (int i = 0;i < nNode; i++)
            {
                Console.Write($"Please enter value Node {i}: ");
                int node = int.Parse(Console.ReadLine());
                linkedList.InsertNode(node);
            }

            Console.Write("Please enter Data = ");
            int data = int.Parse(Console.ReadLine());

            Console.Write("Please enter position = ");
            int position = int.Parse(Console.ReadLine());

            // Insert a node at a specific position
            SinglyLinkedListNode result = Deploy.insertNodeAtPosition
                                            (linkedList.head, data, position);

            // in danh sách bằng cách sử dụng hàm in trong thư viện
            SinglyLinkedList.PrintSinglyLinkedList(result," ");

            Console.ReadLine();
        }
    }
}
#endif

#if false // Delete A Node
namespace deleteANode
{
    /// <summary> Data Structures
    /*
    Xóa một nút trong danh sách liên kết đơn đã cho, và vị trí node cần xóa
    sau đó trả về danh sách được cập nhật.
    Sample Input: n = 8 => 20 6 2 19 7 4 15 9, position = 3
    Sample Output: 20 6 2 7 4 15 9
    */
    /// </summary>

    internal class Deploy
    {
        public static SinglyLinkedListNode deleteNode(
                                     SinglyLinkedListNode llist, int position)
        {
            if (position == 0)
            {
                return llist.next;
            }

            SinglyLinkedListNode currentNode = llist;

            // Duyệt qua danh sách để tìm node trước vị trí cần xóa
            for (int i = 0; i < position - 1; i++)
            {
                currentNode = currentNode.next;
            }

            // Bỏ qua node ở vị trí cần xóa
            currentNode.next = currentNode.next.next;

            return llist;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList linkedList = new SinglyLinkedList();
            Console.Write("Please enter nNode = ");
            int nNode = int.Parse(Console.ReadLine());

            for (int i = 0; i < nNode; i++)
            {
                Console.Write($"Please enter value of Node {i}: ");
                int nodeData = int.Parse(Console.ReadLine());
                linkedList.InsertNode(nodeData);
            }

            Console.Write("Please enter postion = ");
            int p = int.Parse(Console.ReadLine());

            SinglyLinkedListNode result = Deploy.deleteNode(linkedList.head,p);
            SinglyLinkedList.PrintSinglyLinkedList(result, " ");

            Console.ReadLine();
        }
    }
}
#endif

#if false // Print in Reverse (sử dụng đệ quy)
namespace printReverse
{
    /// <summary> Data Structures
    /*
    In ra các giá trị của LinkedList theo thứ tự từ cuối đến đầu.
    sử dụng đệ quy
    Sample Input: n = 5 => 16 12 4 2 5
    Sample Output: 5 2 4 12 16
    */
    /// </summary>

    internal class Deploy
    {
        public static void reversePrint(SinglyLinkedListNode llist)
        {
            // Kiểm tra nếu danh sách liên kết không rỗng
            if (llist == null) return;

            // Gọi đệ quy với nút tiếp theo
            reversePrint(llist.next);

            Console.WriteLine(llist.data);
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList linkedList = new SinglyLinkedList();
            Console.Write("Please enter nNode = ");
            int nNode = int.Parse(Console.ReadLine());

            for (int i = 0; i < nNode; i++)
            {
                Console.Write("Please enter Node data: ");
                int nodeData = int.Parse(Console.ReadLine());
                linkedList.InsertNode(nodeData);
            }

            Deploy.reversePrint(linkedList.head);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Print in Reverse (sử dụng stack)
namespace printReverse2
{
    /// <summary> Data Structures
    /*
    In ra các giá trị của LinkedList theo thứ tự từ cuối đến đầu.
    sử dụng stack
    Sample Input: n = 5 => 5 1 18 3 13
    Sample Output: 13 3 18 1 5
    */
    /// </summary>

    internal class Deploy
    {
        public static void reversePrint(SinglyLinkedListNode llist)
        {
            Stack<int> stack = new Stack<int>();
            SinglyLinkedListNode current = llist;

            // Đẩy từng giá trị vào stack
            while (current != null)
            {
                stack.Push(current.data);
                current = current.next;
            }

            // In giá trị ra từ stack
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList linkedList = new SinglyLinkedList();
            Console.Write("Please enter nNode = ");
            int nNode = int.Parse(Console.ReadLine());

            for (int i = 0; i < nNode; i++)
            {
                Console.Write("Please enter nodeData: ");
                int nodeData = int.Parse(Console.ReadLine());
                linkedList.InsertNode(nodeData);
            }

            Deploy.reversePrint(linkedList.head);

            Console.ReadLine();
        }
    }
}
#endif

#endregion

#region Data Structures Easy 2

#if false // Reverse a Linked List
namespace reverseALinkedList
{
    /// <summary> Data Structures
    /*
    Đảo ngược Linked List
    Sample Input: n = 5 => 1 2 3 4 5
    Sample Output: 5 4 3 2 1
    */
    /// </summary>

    internal class Deploy
    {
        public static SinglyLinkedListNode reverse(SinglyLinkedListNode llist)
        {
            SinglyLinkedListNode prev = null;
            SinglyLinkedListNode current = llist;
            SinglyLinkedListNode nextNode = null;

            while (current != null)
            {
                nextNode = current.next; 
                current.next = prev; // Đảo hướng nút hiện tại trỏ về nút trước đó

                prev = current; 
                current = nextNode;
            }

            return prev;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList linkedList = new SinglyLinkedList();
            Console.Write("Please enter nNode = ");
            int nNode = int.Parse(Console.ReadLine());

            for (int i = 0; i < nNode; i++)
            {
                Console.Write($"Please enter NodeData {i}: ");
                int nodeData = int.Parse(Console.ReadLine());
                linkedList.InsertNode(nodeData);
            }

            SinglyLinkedListNode reversedList = Deploy.reverse(linkedList.head);
            SinglyLinkedList.PrintSinglyLinkedList(reversedList, " ");

            Console.ReadLine();
        }
    }
}
#endif

#if false // Compare two LinkedList
namespace compareTwoLinkedList
{
    /// <summary> Data Structures
    /*
    Duyệt qua 2 LinkedList và so sánh từng phần tử của chúng, nếu tất cả các nút và dữ 
    liệu tương ứng của chúng giống nhau, danh sách được xem là giống nhau. Nếu có sự
    khác biệt hoặc độ dài của 2 LinkedList k bằng nhau thì hai danh sách k giống nhau.
    giống nhau trả về True hay 1 còn khác nhau return false hay 0.
    Sample Input: nNode1 = 3 => 1 2 3 và nNode2 = 3 => 1 2 3
    Sample Output: 1 hay true
    */
    /// </summary>

    internal class Deploy
    {
        public static bool compareList(SinglyLinkedListNode head1,
                                                            SinglyLinkedListNode head2)
        {
            SinglyLinkedListNode currentNode1 = head1;
            SinglyLinkedListNode currentNode2 = head2;

            while(currentNode1 != null && currentNode2 != null)
            {
                if (currentNode1.data != currentNode2.data)
                    return false;

                currentNode1 = currentNode1.next;
                currentNode2 = currentNode2.next;
            }

            return currentNode1 == null && currentNode2 == null;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList linkedList1 = new SinglyLinkedList();
            Console.Write("Please enter nNode1 = ");
            int nNode1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nNode1; i++)
            {
                Console.Write($"Please enter nodeData {i}: ");
                int nodeData = Convert.ToInt32(Console.ReadLine());
                linkedList1.InsertNode(nodeData);
            }

            SinglyLinkedList linkedList2 = new SinglyLinkedList();
            Console.Write("Please enter nNode1 = ");
            int nNode2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nNode1; i++)
            {
                Console.Write($"Please enter nodeData {i}: ");
                int nodeData = Convert.ToInt32(Console.ReadLine());
                linkedList2.InsertNode(nodeData);
            }

            bool isSame = Deploy.compareList(linkedList1.head, linkedList2.head);
            Console.WriteLine(isSame ? "true" : "false");

            Console.ReadLine();
        }
    }
}
#endif

#if false // Merge Two Sorted Linked Lists
namespace mergeTwoSortedLists
{
    /// <summary> Data Structures
    /*
    hợp nhất hai singly linked lists  thành một singly linked lists mới,  với mục tiêu tạo ra
    một  singly linked lists đã được sắp xếp.
    Example: headA 1 -> 3 -> 7 -> null
             headB 1-> 2 -> null
             the new list: 1 -> 1 -> 2 -> 3 -> 7 -> null
    Sample Input: nNode1 = 3 => 1 -> 2 -> 3 -> null, nNode2 = 2 => 3 -> 4 -> null
    Sample Output: 1 -> 2 -> 3 -> 3 -> 4 -> null
    */
    /// </summary>

    internal class Deploy
    {
        public static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1,
                                                      SinglyLinkedListNode head2)
        {
            // tạo 1 Node tạm thời ngay đầu LinkedList mới
            SinglyLinkedListNode dummyNode = new SinglyLinkedListNode(0);
            SinglyLinkedListNode tail = dummyNode;

            while (head1 != null && head2 != null)
            {
                if (head1.data <= head2.data)
                {
                    tail.next = head1;
                    head1 = head1.next;
                }
                else
                {
                    tail.next = head2;
                    head2 = head2.next;
                }

                tail = tail.next;
            }

            if (head1 != null)
            {
                tail.next = head1;
            }
            if (head2 != null)
            {
                tail.next = head2;
            }

            return dummyNode.next;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList linkedList1 = new SinglyLinkedList();
            SinglyLinkedList linkedList2 = new SinglyLinkedList();

            Console.Write("Please enter nnode1 = ");
            int nNode = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nNode; i++)
            {
                Console.Write($"Please enter value Node {i}: ");
                int nodeData = Convert.ToInt32(Console.ReadLine());
                linkedList1.InsertNode(nodeData);
            }

            Console.Write("Please enter nnode2 = ");
            int nNode2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nNode2; i++)
            {
                Console.Write($"Please enter value Node {i}: ");
                int nodeData = Convert.ToInt32(Console.ReadLine());
                linkedList2.InsertNode(nodeData);
            }

            SinglyLinkedListNode mergedList = Deploy.mergeLists(linkedList1.head, linkedList2.head);
            SinglyLinkedList.PrintSinglyLinkedList(mergedList, " -> ");

            Console.ReadLine();
        }
    }
}
#endif

#if false // Get Node Value
namespace getNodeValue
{
    /// <summary> Data Structures
    /*
    lấy giá trị của một nút trong danh sách liên kết đơn (Singly Linked List), 
    dựa trên vị trí tính từ cuối danh sách, Điều này có nghĩa là thay vì đếm
    từ đầu danh sách, ta cần đếm từ đuôi danh sách về đầu.

    Ta có một danh sách liên kết đơn (Singly Linked List) và một vị trí
    positionFromTail tính từ đuôi. Nhiệm vụ là tìm giá trị của nút tại vị trí đó.

    Sample Input: nNode = 3 => 3 -> 2 -> 1 -> null, 
                  positionFromTail = 2.   
    Sample Output: 3
    */
    /// </summary>

    internal class Deploy
    {
        public static int getNode(SinglyLinkedListNode llist,int positionFromTail)
        {
            // Đếm số lượng phần tử trong danh sách liên kết
            int length = 0;
            SinglyLinkedListNode current = llist;

            while (current != null)
            {
                length++;
                current = current.next;
            }

            // xác định vị trí từ đầu danh sách (indexFromHead)
            int indexFromHead = length - positionFromTail - 1;

            // Duyệt lại danh sách để lấy giá trị tại vị trí đó
            current = llist;
            for (int i = 0; i < indexFromHead; i++)
            {
                current = current.next;
            }

            return current.data;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList linkedList = new SinglyLinkedList();

            Console.Write("Please enter nNode = ");
            int nNode = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nNode; i++)
            {
                Console.Write($"Please enter value Node {i}: ");
                int nodeData = Convert.ToInt32(Console.ReadLine());
                linkedList.InsertNode(nodeData);
            }

            Console.Write("Please enter positionFromTail = ");
            int positionFromTail = Convert.ToInt32(Console.ReadLine());

            int nodeValue = Deploy.getNode(linkedList.head, positionFromTail);
            Console.WriteLine(nodeValue);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Delete Duplicate-value from a sorted linked list
namespace deleteDuplicateValueFromASortedLinkedList
{
    /// <summary> Data Structures
    /*
    yêu cầu loại bỏ tất cả các giá trị trùng lặp trong Singly Linked List
    sao cho mỗi giá trị chỉ xuất hiện một lần. 

    Sample Input: nNode = 5 => 1 -> 2 -> 2 -> 3 -> 4 -> null,      
    Sample Output: 1 -> 2 -> 3 -> 4 -> null
    */
    /// </summary>

    internal class Deploy
    {
        public static SinglyLinkedListNode removeDuplicates(
                                                       SinglyLinkedListNode llist)
        {
            if (llist == null || llist.next == null)
            {
                return llist;
            }

            SinglyLinkedListNode current = llist;

            while (current != null)
            {
                while(current.next != null && current.data == current.next.data)
                {
                    current.next = current.next.next; // Bỏ qua nút trùng lặp
                }

                current = current.next;
            }

            return llist;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList SinLinkedList = new SinglyLinkedList();
            Console.Write("Please enter nNode = ");
            int nNode = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nNode; i++)
            {
                Console.Write($"Please enter Node value {i}: ");
                int NodeValue = Convert.ToInt32(Console.ReadLine());
                SinLinkedList.InsertNode(NodeValue);
            }

            var result = Deploy.removeDuplicates(SinLinkedList.head);
            SinglyLinkedList.PrintSinglyLinkedList(result, " -> ");

            Console.ReadLine();
        }
    }
}
#endif

#endregion

#region Data Structures Medium 1

#if false // Sparse Arrays
namespace matchingString
{
    /// <summary> Data Structers
    /*
    Cho 2 danh sách:
    - stringList là một danh sách chuỗi
    - queries là một danh sách các chuỗi cần tìm trong stringList
    Đếm số lần xuất hiện của một danh sách trong queries có trong stringList
    trả về danh sách kết quả, Ví dụ:
    stringList = ["aba", "baba", "aba", "xzxb"]
    queries = ["aba", "xzxb", "ab"]
    Chuỗi "aba" xuất hiện 2 lần trong stringList.
    Chuỗi "xzxb" xuất hiện 1 lần trong stringList.
    Chuỗi "ab" không xuất hiện trong stringList.
    kết quả sẽ là [2, 1, 0].
    Sample Input: n = 3 stringList = ["def", "de", "fgh"]
                  m = 3 queries = ["de", "lmn", "fgh"]
    Sample Output: 1, 0, 1
    */
    /// </summary>

    internal class Deploy
    {
        public static List<int> matchingString(List<string> stringList,
                                               List<string> queries)
        {
            List<int> result = new List<int>();

            foreach (string query in queries )
            {
                int count = stringList.Where(s => s == query).Count();
                result.Add(count);
            }

            return result;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();
            List<string> queries = new List<string>();

            Console.Write("Please enter n stringList: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter string element {i}: ");
                string elements = Console.ReadLine();
                stringList.Add(elements);
            }

            Console.Write("Please enter m string queries: ");
            int m = int.Parse(Console.ReadLine());
            for(int i = 0;i < m; i++)
            {
                Console.Write($"Please enter string element {i}: ");
                string elements = Console.ReadLine();
                queries.Add(elements);
            }

            List<int> result = Deploy.matchingString(stringList, queries);
            Console.WriteLine(string.Join(", ", result));

            Console.ReadLine();

        }
    }
}
#endif

#if false // Cycle Detection (Cycle LinkedList)
namespace cycleDetection
{
    /// <summary> Data Structers
    /*
    Cho một danh sách liên kết đơn (Singly Linked List) kiểm tra xem 
    (Singly Linked List) có chứa chu kỳ (cycle) hay không, Một chu kỳ trong
    Singly Linked List xảy ra khi một node nào đó trỏ ngược về một node đã xuất 
    hiện trước đó tạo ra một vòng lặp.

    Ví dụ:
    1 -> 2 -> 3 ---> trỏ về lại 2
    Trong trường hợp này, node cuối cùng trỏ ngược lại về node thứ 2
    tạo thành một chu kỳ. kiểm tra xem có tồn tại chu kỳ như vậy hay không.

    để làm dc dùng thuật toán hai con trỏ:
    Khởi tạo hai con trỏ, con trỏ "chậm" và con trỏ "nhanh", 
    cả hai đều bắt đầu tại node đầu tiên,
    Con trỏ "chậm" di chuyển một bước mỗi lần.
    Con trỏ "nhanh" di chuyển hai bước mỗi lần.
    Nếu tại bất kỳ thời điểm nào, con trỏ "nhanh" và con trỏ "chậm" gặp nhau, 
    thì chắc chắn có một chu kỳ trong danh sách.
    Nếu con trỏ "nhanh" đạt tới cuối danh sách (null), 
    điều đó có nghĩa là danh sách không có chu kỳ.

    Sample Input: 3 -> 2 -> 0 <-> -4 
    Sample Output:  true
    */
    /// </summary>

    internal class Deploy
    {
        public static bool hasCycle(SinglyLinkedListNode head)
        {
            // Nếu danh sách trống hoặc chỉ có 1 phần tử thì chắc chắn
            // không có chu kỳ
            if (head == null || head.next == null)
            {
                return false;
            }

            // Khởi tạo hai con trỏ: slow (chậm) và fast (nhanh)
            SinglyLinkedListNode slow = head;
            SinglyLinkedListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;

        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList linkedList = new SinglyLinkedList();
            Console.Write("Please enter nNode = ");
            int nNode = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nNode; i++)
            {
                Console.Write($"Please enter Node Value {i}: ");
                int NodeValue = Convert.ToInt32(Console.ReadLine());
                linkedList.InsertNode(NodeValue);
            }

            Console.Write("Enter index to form cycle (enter -1 for no cycle): ");
            int cycleindex = Convert.ToInt32(Console.ReadLine());
            SinglyLinkedList.CreateCycle(linkedList, cycleindex);


            bool result = Deploy.hasCycle(linkedList.head);
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
#endif

#endregion

#region Data Structures Hard 1

#if false // Array Manipulation
namespace arrayManipulation
{
    /// <summary> Data Structures
    /*
    cấu trúc dữ liệu này cần thực hiện nhiều thao tác cộng trên 1 mảng
    và sau đó trả về giá trị lớn nhất có thể có trong mảng sau khi thực
    hiện các thao tác đó.
    cho một mảng với kích thước n, ban đầu tất cả các phần tử đều = 0;
    dc cung cấp danh sách các thao tác queries, mỗi thao tác bao gồm 
    3 giá trị: a, b, k. Điều này có nghỉa là cần cộng thêm k vào tất 
    cả các phần tử của mảng từ vị trí a đến vị trí b.
    ví dụ: n = 5, queries = 3 => 1 2 100        a = 1, b = 2, k = 100
                                 2 5 100        a = 2, b = 5, k = 100
                                 3 4 100        a = 3, b = 4, k = 100
    Sau khi thực hiện các thao tác: Từ 1 đến 2, cộng 100.
                                    Từ 2 đến 5, cộng 100.
                                    Từ 3 đến 4, cộng 100.
    tạo 1 mảng để luu giá trị cộng dồn, sau đó tính tổng cộng dồn
    in ra tổng cộng dồn này.
    Sample Input: n = 5, queries = 4 => 1 5 50 
                                        4 8 100        
                                        6 9 150
                                        2 7 200
     Sample Output: 350
    */
    /// </summary>

    internal class Deploy
    {
        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            // Khởi tạo mảng arr với kích thước n+1
            // để áp dụng kỹ thuật cộng dồn
            long[] arr = new long[n + 1];

            // Thực hiện các thao tác theo kỹ thuật Difference Array
            foreach (var q in queries)
            {
                int a = q[0];
                int b = q[1];
                int k = q[2];

                arr[a - 1] += k;

                if (b < n)
                {
                    arr[b] -= k;
                }
            }

            // tính tổng cộng dồn
            long max = 0;
            long current = 0;

            for (int i = 0; i < n; i++)
            {
                current += arr[i];

                if (current > max)
                {
                    max = current;
                }
            }

            return max;

        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<List<int>> queries = new List<List<int>>();

            Console.Write("Please enter nRow = ");
            int nRow = int.Parse(Console.ReadLine());
            Console.Write("Please enter nColumns = ");
            int nColumn = int.Parse(Console.ReadLine());

            for (int i = 0; i < nRow; i++)
            {
                List<int> row = new List<int>();

                for (int j = 0; j < nColumn; j++)
                {
                    Console.Write($"Please enter row {i} column {j}: ");
                    int element = int.Parse(Console.ReadLine());
                    row.Add(element);
                }

                queries.Add(row);
            }

            Console.Write("Please enter n array: ");
            int n = int.Parse(Console.ReadLine());

            long result = Deploy.arrayManipulation(n, queries);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#endregion




#region Problem Solving Basic

#if false // String Anagram
namespace stringAnagram
{
    /// <summary> Problem Solving
    /*
    Đề Bài: Tìm Số Lượng Anagram

    Bạn được cung cấp hai danh sách:
    dictionary: Một danh sách chứa các từ trong từ điển.
    query: Một danh sách chứa các từ cần kiểm tra.

    Nhiệm vụ là xác định số lượng từ anagram 
    trong danh sách dictionary cho mỗi từ trong danh sách query.

    Định Nghĩa Anagram:
    Anagram là một từ hoặc cụm từ được tạo ra bằng cách sắp xếp lại các ký tự  của một từ khác.
    Ví dụ: Từ "listen" có thể được sắp xếp lại thành "silent".

    Yêu Cầu:
    Đối với mỗi từ trong danh sách query, bạn cần đếm số lượng từ trong dictionary là anagram 
    của từ đó.
    In ra một danh sách chứa số lượng anagram tương ứng cho mỗi từ trong query.

    Sameple Input: dictionary = ["eat", "tea", "tan", "ate", "nat", "bat"]
                   query = ["ate", "nat", "bat", "tan", "eat", "hello"]
    Sample Output: [3, 2, 1, 2, 3, 0]
    */
    /// </summary>

    internal class Deploy
    {
        public static List<int> stringAnagram(List<string> dictionary, 
                                                            List<string> query)
        {
            var anagramCount = new Dictionary<string, int>();

            // thêm từ trong dictionary vào từ điển
            foreach (var word in dictionary)
            {
                // Sắp xếp các ký tự của từ
                var sortedWord = String.Concat(word.OrderBy(c => c));

                if (anagramCount.ContainsKey(sortedWord))
                {
                    anagramCount[sortedWord]++;
                }
                else
                {
                    anagramCount[sortedWord] = 1;
                }
            }

            var result = new List<int>();

            foreach (var q in query)
            {
                var sortedQuery = String.Concat(q.OrderBy(c => c));

                result.Add(anagramCount.ContainsKey(sortedQuery) ? 
                                                anagramCount[sortedQuery] : 0);
            }

            return result;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<string> Dictionary = new List<string>();
            List<string> Query = new List<string>();

            Console.Write("Please enter nDictionary: ");
            int nDictionary = int.Parse(Console.ReadLine());

            for (int i  = 0; i < nDictionary; i++)
            {
                Console.Write($"Please enter Dictionary {i}: ");
                string element = Console.ReadLine();
                Dictionary.Add(element);
            }

            Console.Write("Please enter nQuery: ");
            int nQuery = int.Parse(Console.ReadLine());

            for (int i = 0; i < nQuery; i++)
            {
                Console.Write($"Please enter Query {i}: ");
                string element = Console.ReadLine();
                Query.Add(element);
            }

            List<int> result = Deploy.stringAnagram(Dictionary, Query);
            Console.WriteLine(string.Join(" ", result));

            Console.ReadLine();

        }
    }
}
#endif

#if false // Longgest Subarray
namespace longestSubarray
{
    /// <summary> Problem Solving
    /*
    Đề Bài: Tìm Dãy Con Dài Nhất

    Bạn được cung cấp một danh sách:
    arr: Một danh sách chứa các số nguyên.

    nhiệm vụ:
    Xác định độ dài của dãy con liên tiếp dài nhất trong danh sách arr, 
    mà dãy con đó có các phần tử có giá trị liên tiếp.
    Hai số được coi là liên tiếp nếu chúng chênh lệch nhau một đơn vị 
    (ví dụ: 1 và 2 hoặc 2 và 3).

    Yêu Cầu:
    Tìm độ dài của dãy con dài nhất mà các phần tử có giá trị liên tiếp với nhau 
    (có thể có số khác nhau một đơn vị).

    Sameple Input: arr = [1, 2, 2, 1, 3, 4, 5]
    Sample Output:  4

    */
    /// </summary>

    internal class Deploy
    {
        public static int longestSubarray(List<int> arr)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
           
            foreach (var num in arr)
            {
                if (freq.ContainsKey(num))
                {
                    freq[num]++;
                }
                else
                {
                    freq[num] = 1;
                }
            }

            int maxLength = 0;

            // Duyệt qua các khóa trong từ điển
            foreach (var key in freq.Keys)
            {
                // Kiểm tra xem phần tử liền kề (key + 1) có tồn tại không
                if (freq.ContainsKey(key + 1))
                {
                    int currentLength = freq[key] + freq[key + 1];
                    maxLength = Math.Max(maxLength, currentLength);
                }
            }

            // Nếu chỉ có một phần tử, độ dài sẽ là số lần xuất hiện của phần tử đó
            if (maxLength == 0 && freq.Count > 0)
            {
                maxLength = freq.Values.Max();
            }

            return maxLength;

        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int  i = 0; i < n; i++)
            {
                Console.Write($"Please enter arr[{i}]: ");
                int elemet = Convert.ToInt32(Console.ReadLine());
                arr.Add(elemet);
            }

            int result = Deploy.longestSubarray(arr);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#endregion

#region Problem Solving Intermediate

#if false // Nice Team
namespace niceTeam
{
    /// <summary> Problem Solving
    /*
    Đề Bài: Tìm Cặp Đội Tốt Nhất (Nice Team)

    Bạn được cung cấp một danh sách các mức độ kỹ năng của các thành viên
    trong nhóm và một giá trị chênh lệch kỹ năng tối thiểu.

    Nhiệm vụ của bạn là xác định số lượng cặp thành viên có chênh lệch kỹ năng
    đủ lớn để tạo thành một đội tốt.

    Yêu Cầu:
    - Với mỗi thành viên trong nhóm, bạn cần tìm một thành viên khác có mức độ 
    kỹ năng chênh lệch ít nhất bằng giá trị chênh lệch kỹ năng tối thiểu (minDiff).
    - Chỉ có thể tính một cặp một lần (không tính cặp trùng lặp).

    Input:
    - Một danh sách các mức độ kỹ năng skillLevel của các thành viên.
    - Một số nguyên minDiff đại diện cho chênh lệch kỹ năng tối thiểu.

    Output:
    Trả về số lượng cặp đội có thể tạo thành mà chênh lệch kỹ năng giữa hai
    thành viên trong mỗi cặp lớn hơn hoặc bằng minDiff.

    Sameple Input: skillLevel = [1, 2, 3, 4, 5, 6], minDiff = 2       
    Sample Output: 3
    */
    /// </summary>

    internal class Deploy
    {
        public static int maxPair(List<int> skillLevel, int minDiff)
        {
            skillLevel.Sort();
            int countpairs = 0;

            for (int i = 0; i < skillLevel.Count - 1; i++)
            {
                for (int j = i + 1; j < skillLevel.Count; j++)
                {
                    if (skillLevel[j] - skillLevel[i] >= minDiff)
                    {
                        countpairs++;
                        break;
                    }
                }
            }

            return countpairs;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> skillLevel = new List<int>();

            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;i < n ; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int element = Convert.ToInt32(Console.ReadLine());
                skillLevel.Add(element);
            }

            Console.Write("Please enter MinDiff: ");
            int minDiff = Convert.ToInt32(Console.ReadLine());

            int result = Deploy.maxPair(skillLevel, minDiff);
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
#endif

#if false // Equalizing Array Elements
namespace equalizingArrayElements
{
    /// <summary> Problem Solving
    /*
    Đề Bài: biến tất cả các phần tử trong một mảng thành các giá trị bằng nhau
    theo một số yêu cầu.

    Bạn được cung cấp một đầu vào:
    arr: Một danh sách chứa các số nguyên.
    threshold: Ngưỡng tối đa mà các phần tử trong mảng không được vượt quá.
    d: Giá trị mà bạn có thể cộng hoặc trừ cho mỗi phép toán.

    Các Quy Tắc Cụ Thể:
    - Phép Toán Cho Phép: Bạn có thể thực hiện các phép toán bằng cách tăng
    hoặc giảm một phần tử trong mảng với một giá trị cố định d. Điều này có
    nghĩa là nếu bạn có một phần tử x, bạn có thể chuyển nó thành x + d hoặc 
    x - d.
    - Ngưỡng Giới Hạn: Tất cả các phần tử cuối cùng của mảng phải không vượt
    quá một giá trị ngưỡng (threshold). Nếu giá trị nhỏ nhất trong mảng lớn hơn
    ngưỡng này, thì không thể thực hiện được việc điều chỉnh.
    - Mục Tiêu Cuối Cùng: Bạn muốn tìm ra số lượng phép toán tối thiểu cần thiết
    để đưa tất cả các phần tử trong mảng về cùng một giá trị. Giá trị mà tất cả 
    các phần tử sẽ hướng tới thường là giá trị nhỏ nhất trong mảng, miễn là nó 
    không vượt quá ngưỡng.

    Đầu ra: Trả về số lượng phép toán tối thiểu cần thiết để làm cho tất cả 
    các phần tử trong mảng bằng nhau mà không vượt quá threshold.

    Sameple Input: arr = [4, 8, 6], threshold = 6, d = 2
    Sample Output:  3

    */
    /// </summary>

    internal class Deploy
    {
        public static int minOperations(List<int> arr, int threshold, int d)
        {
            int minElement = arr.Min();

            // Nếu phần tử nhỏ nhất lớn hơn ngưỡng, không thể thực hiện
            if (minElement > threshold)
            {
                return -1; 
            }

            int totalOperations = 0;

            foreach (int num in arr)
            {
                int diff = Math.Abs(num - minElement);

                if (diff % d != 0) // kiểm tra diff có chia hết cho d hay k
                {
                    return -1; // nếu k chia hết thì k thực hiện.
                }

                // nếu chia hết thì tính toán số phép toán biến đổi
                totalOperations += diff / d;
            }

            return totalOperations;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter arr[{i}]: ");
                int element = Convert.ToInt32(Console.ReadLine());
                arr.Add(element);
            }

            Console.Write("Please enter threshold: ");
            int threshold = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter d: ");
            int d = Convert.ToInt32(Console.ReadLine());

            int result = Deploy.minOperations(arr, threshold, d);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#endregion





#region 1 Week Preparation Kit

#region Day 1

#if false // Plus Minus
namespace PlusMinus
{
    /// <summary> Algorithms Problem
    /*
    cho một List có n = 5 => [1, 1, 0 , -1, -1]
    có 2 số dương, 2 âm và 1 zero trong list
    ta có 2 dương: 2/5 = 0,400000 ratios
    ta có 2 âm:    2/5 = 0,400000 ratios
    ta có 1 zero:  1/5 = 0.200000 ratios
    in ra các tỉ lệ này: dương, âm, zero với 6 số sau dấu thập phân
    Sample Input: n = 6 => -4 3 -9 0 4 1
    Sample Output: 0.500000 0.333333 0.166667
    */
    /// </summary>

    internal class Deploy
    {
        public static void PlusMinus(int n, List<int> ar)
        {
            int positiveNumber = 0;
            int negativeNumber = 0;
            int zero = 0;

            foreach (int i in ar)
            {
                if (i > 0)
                {
                    positiveNumber++;
                }
                else if (i < 0)
                {
                    negativeNumber++;
                }
                else
                {
                    zero++;
                }
            }

            double positiveRatios = (double)positiveNumber / n;
            double negativeRatios = (double)negativeNumber / n;
            double zeroRatios = (double)zero / n;

            Console.WriteLine(positiveRatios.ToString("F6"));
            Console.WriteLine(negativeRatios.ToString("F6"));
            Console.WriteLine(zeroRatios.ToString("F6"));
        }
    }
    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> ar = new List<int>();
            Console.Write("Please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter elements {i}: ");
                int elements = int.Parse(Console.ReadLine());
                ar.Add(elements);
            }

            Deploy.PlusMinus(n, ar);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Mini-MaxSum
namespace MiniMaxSum
{
    /// <summary> Algorithms Problem
    /*
    Cho một danh sách số nguyên [1, 3, 5, 7, 9]
    tính tổng nhỏ nhất loại bỏ phần tử lớn nhất 1 + 3 + 5 + 7 = 16
    tính tổng lớn nhất loại bỏ phần tử bé nhất  3 + 5 + 7 + 9 = 24
    In ra tổng bé nhất và tổng lớn nhất: 16, 24
    Sample Input: n = 5 => 1 2 3 4 5
    Sample Output: 10 14
    */
    /// </summary>
    
    internal class Deploy
    {
        public static void MiniMaxSum(List<int> arr)
        {
            long sumElement = arr.Sum(x => (long) x);
            int minElement = arr.Min();
            int maxElement = arr.Max();

            long sumMax = sumElement - minElement;
            long sumMin = sumElement - maxElement;

            Console.WriteLine($"{sumMin} {sumMax}");
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();

            Console.Write("please enter n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter elements {i}: ");
                int elements = int.Parse(Console.ReadLine());
                arr.Add(elements);
            }

            Deploy.MiniMaxSum(arr);

            Console.ReadLine();
        }
    }

}
#endif

#if false // Time Conversion
namespace TimeConversion
{
    /// <summary> Algorithms Problem
    /*
    Cho một chuỗi s, biểu diễn thời gian hh:mm:ss:Period
    hh là từ 1h đến 12h
    mm là từ 00 đến 59
    ss là từ 00 đến 59
    Period là AM & PM
    cần chuyển đổi này sang định dạng 24h:
    nếu 12AM thì chuyển thành 00
    nếu 12PM thì giữ nguyên
    nếu là giờ AM nhưng k phải 12AM thì giữ nguyên giờ
    nếu là giờ PM nhưng k phải 12PM thì cộng thêm 12.
    in ra chuyển đổi định dạng từ 12h sang 24h đó?
    Sample Input: 07:05:45PM
    Sample Output: 19:05:45
    */
    /// </summary>
    
    internal class Deploy
    {
        public static string TimeConversion(string s)
        {
            string period = s.Substring(s.Length - 2);
            int hour = int.Parse(s.Substring(0, 2));
            string minutes = s.Substring(3, 2);
            string seconds = s.Substring(6, 2);

            if (period == "PM" && hour != 12)
            {
                hour += 12;
            }
            if (period == "AM" && hour == 12)
            {
                hour = 0;
            }

            return hour.ToString("D2") + ":" + minutes + ":" + seconds;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter time (hh:mm:ss AM/PM): ");
            string s = Console.ReadLine();

            string result = Deploy.TimeConversion(s);
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
#endif

#endregion

#region Day 2

#if false // Lonely Interger
namespace lonelyInterger
{
    /// <summary> Algorithms Problem
    /*
    Cho 1 danh sách các số nguyên trong đó, tất cả các số đều xuất hiện 2 lần
    chỉ có 1 số xuất hiện 1 lần duy nhất, tìm và in ra số đó

    Sanple Input: [1 2 3 4 3 2 1]
    sample Output: 4
    */
    /// 

    internal class Deploy
    {
        public static int lonelyInterger(List<int> a)
        {
            int result = 0;

            foreach (int num in a)
            {
                result ^= num; // XOR các phần tử
            }

            return result;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Console.Write("Please enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;i < n; i++)
            {
                Console.Write($"Please enter elements {i}: ");
                int element = Convert.ToInt32(Console.ReadLine());
                a.Add(element);
            }

            int result = Deploy.lonelyInterger(a);
            Console.WriteLine($"Lonely Interger: {result}");

            Console.ReadLine();
        }
    }
}
#endif

#if false // Diagonal Difference (List<List<int>>)
namespace DiagonalDifference
{
    /// <summary> Algorithms Problem
    /*
    cho một List 2 chiều n = 3 => 1 2 3
                                  4 5 6
                                  7 8 9
    tính tổng 2 đường chéo 1 + 5 + 9 = a và 3 + 5 + 7 = b
    in ra c = a - b
    Sample Input: n = 3 => 11 2 4
                           4  5 6
                           10 8 -12
    Sample Output: 15
    */
    /// </summary>
    
    internal class Deploy
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                primaryDiagonal += arr[i][i];
                secondaryDiagonal += arr[i][arr.Count - i - 1];
            }

            return Math.Abs(primaryDiagonal - secondaryDiagonal);
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();

            Console.Write("Please enter nRow = ");
            int nRows = int.Parse(Console.ReadLine());
            Console.Write("Please enter nColums = ");
            int nColumns = int.Parse(Console.ReadLine());

            for (int i = 0;i < nRows; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0;j < nColumns; j++)
                {
                    Console.Write($"Please enter elements rows {i}, Columns {j}: ");
                    int elements = int.Parse(Console.ReadLine());
                    row.Add(elements);
                }
                arr.Add(row);
            }

            int result = Deploy.DiagonalDifference(arr);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Counting Sort
namespace countingSort
{
    /// <summary> Algorithms Problem
    /*
    Cho 1 danh sách các số nguyên, trả về số lần xuất hiện của mổi số trong
    danh sách. Danh sách này chỉ chứa các số nguyên nằm trong khoảng từ 0 đến 99.

    Đầu ra Một danh sách (mảng) có 100 phần tử, trong đó mỗi phần tử tại chỉ số i
    sẽ là số lần mà số i xuất hiện trong danh sách đầu vào.

    Sameple Input: [1, 4, 1, 2, 7, 5, 2]
    Sampe Output: [2, 1, 2, 2, 1, 1, 2]
    */
    /// </summary>

    internal class Deploy
    {
        public static List<int> countingSort(List<int> arr)
        {
            
            List<int> count = new List<int>(new int[100]);
             
            foreach (int num in arr)
            {
                count[num]++;
            }

            return count;

        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            var arr = new List<int>();
            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n ; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int element = Convert.ToInt32(Console.ReadLine());
                arr.Add(element);
            }

            var result = Deploy.countingSort(arr);
            Console.WriteLine($"Sorted Array: {string.Join(" ", result)}");

            Console.ReadLine();
        }
    }

}
#endif

#endregion

#region Day 3

#if false // Zig Zag Sequence
namespace zigZagSequence
{
    /// <summary> Algorithms Problem
    /*
    Biến đổi một dãy số được sắp xếp thành một chuỗi có dạng ZigZag, tức là đầu tiên
    các số nhỏ dần sau đó các số lớn dần.

    Sanple Input: [1, 2, 3, 4, 5, 6, 7]
    sample Output: [1, 2, 3, 7, 6, 5, 4]
    */
    /// 

    internal class Deploy
    {
        public static int[] ZigZagSequence(int[] arr)
        { 
            Array.Sort(arr);

            int n = arr.Length;
            int mid = n / 2;

            // Tạo danh sách cho phần đầu và phần lớn
            List<int> result = new List<int>();

            // Thêm các phần tử nhỏ hơn hoặc bằng phần tử giữa
            for (int i = 0; i < mid; i++)
            {
                result.Add(arr[i]);
            }

            result.Add(arr[n - 1]);

            // Thêm các phần tử lớn hơn phần tử giữa nhưng ngược lại
            for (int i = n - 2; i >= mid; i--)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int element = Convert.ToInt32(Console.ReadLine());
                arr[i] = element;
            }

            int[] result = Deploy.ZigZagSequence(arr);
            Console.WriteLine(string.Join(" ", result));

            Console.ReadLine();
        }
    }
}
#endif

#if false // Tower Breakers
namespace towerBreakers
{
    /// <summary> Algorithms Problem
    /*
    Cho n tháp và mỗi tháp ban đầu có chiều cao m. nhận vào input n và m xác định
    Hai người chơi, Player 1 và Player 2, luân phiên nhau thực hiện các bước đi.
    Tại mỗi bước, người chơi chọn một tháp bất kỳ có chiều cao lớn hơn 1,
    và giảm chiều cao của nó xuống thành một số nhỏ hơn, 
    nhưng phải là ước của chiều cao hiện tại.
    ví dụ, nếu tháp có chiều cao 6, người chơi có thể giảm xuống 3 hoặc 2, 
    vì 6 chia hết cho 3 và 2).

    Người chơi không thể thực hiện nước đi nào nếu tất cả các tháp có chiều cao bằng 1.
    Người chơi không thể di chuyển sẽ thua cuộc.

    Quy tắc xác định người thắng:
    Nếu m = 1, Player 2 luôn thắng vì Player 1 không có nước đi nào.
    Nếu n là chẵn và m > 1, Player 2 thắng bằng chiến lược phản chiếu.
    Nếu n là lẻ và m > 1, Player 1 thắng vì Player 1 có thể dẫn dắt trò chơi 
    theo cách có lợi.

    Sanple Input: n = 2, m = 2
    sample Output: 2
    */
    /// 

    internal class Deploy
    {
        public static int towerBreakers(int n, int m)
        { 
            if (m == 1)
            {
                return 2;
            }

            if (n % 2 == 0)
            {
                return 2;
            }
            return 1;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter m = ");
            int m = Convert.ToInt32(Console.ReadLine());

            int result = Deploy.towerBreakers(n, m);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Caesar Cipher
namespace caesarCipher
{
    /// <summary> Algorithms Problem
    /*
    Thuật toán Caesar Cipher là một dạng mã hóa cổ điển trong mật mã học,
    được Julius Caesar sử dụng để bảo mật thông tin.
    Thuật toán này hoạt động bằng cách thay thế mỗi ký tự trong một chuỗi
    bằng ký tự khác nằm cách nó một khoảng xác định trong bảng chữ cái.

    Chuỗi s là đầu vào cần mã hóa.
    k là một số nguyên, đại diện cho số lần dịch chuyển ký tự trong bảng chữ cái.
    Nếu k > 26, ta lấy k % 26 vì bảng chữ cái chỉ có 26 ký tự.
    Các ký tự chữ cái sẽ được dịch chuyển theo số k vị trí trong bảng chữ cái.
    Các ký tự khác (số, ký hiệu) không thay đổi.

    Nếu ký tự là chữ cái viết thường (a-z):
    newChar = (currentChar - 'a' + k) % 26 + 'a'
    Nếu ký tự là chữ cái viết hoa (A-Z):
    newChar = (currentChar - 'A' + k) % 26 + 'A'


    Sanple Input: s = middle-Outz, k = 2
    sample Output: okffng-Qwvb
    */
    /// 

    internal class Deploy
    {
        public static string caesarCipher(string s, int k)
        {
            // Đảm bảo rằng k không lớn hơn 26 
            k = k % 26;

            StringBuilder result = new StringBuilder();

            foreach (char c in s)
            {
                if (char.IsLower(c))
                {
                    char newChar = (char)((c - 'a' + k) % 26 + 'a');
                    result.Append(newChar);
                }
                else if (char.IsUpper(c))
                {
                    char newChar = (char)((c - 'A' + k) % 26 + 'A'); 
                    result.Append(newChar);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter s = ");
            string s = Console.ReadLine();
            Console.Write("Please enter k = ");
            int k = Convert.ToInt32(Console.ReadLine());

            string result = Deploy.caesarCipher(s, k);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#endregion

#region Day 4

#if false // Grid Challenge (List<string>)
namespace gridChallenge
{
    /// <summary> Algorithms Problem
    /*
    Cho một lưới các ký tự, mỗi hàng trong lưới là một chuỗi ký tự.

    - Sắp xếp từng hàng của lưới theo thứ tự chữ cái tăng dần (sắp xếp từ 'a' đến 'z').
    - Sau khi sắp xếp từng hàng, kiểm tra mỗi cột của lưới xem có được sắp xếp theo
    thứ tự chữ cái tăng dần không.
    - Nếu tất cả các cột đều thỏa mãn điều kiện tăng dần, trả về "YES",
    Nếu có cột nào không thỏa mãn, trả về "NO".

    Sanple Input:  n = 5     ebacd
                             fghij
                             olmkn
                             trpqs
                             xywuv

    sample Output: YES
    */
    /// 

    internal class Deploy
    {
        public static string gridChallenge(List<string> grid)
        {
            // Sắp xếp từng hàng của lưới theo thứ tự chữ cái tăng dần
            for (int i = 0; i < grid.Count; i++)
            {
                char[] sortedRow = grid[i].ToCharArray();
                Array.Sort(sortedRow);
                grid[i] = new string(sortedRow);
            }

            // Kiểm tra từng cột xem có được sắp xếp theo thứ tự tăng dần hay không
            for (int col = 0; col < grid[0].Length; col++)
            {
                for (int row = 1; row < grid.Count; row++)
                {
                    if (grid[row][col] < grid[row - 1][col])
                    {
                        return "NO";
                    }
                }
            }

            return "YES";
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of rows (n) = ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter row {i} = ");
                grid.Add(Console.ReadLine());
            }

            string result = Deploy.gridChallenge(grid);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Recursive Digit Sum (đệ quy)
namespace recursiveDigitSum
{
    /// <summary> Algorithms Problem
    /*
    tính toán một "siêu chữ số" dựa trên một số lớn ban đầu.

    Cho một số nguyên dưới dạng chuỗi ký tự n và một số nguyên k.
    - Lặp lại chuỗi n thành một chuỗi mới với độ dài bằng n được lặp lại k lần.
    - Tính tổng các chữ số của chuỗi kết quả đó.
    - Nếu tổng các chữ số có nhiều hơn một chữ số, lặp lại quá trình tính tổng
    các chữ số cho đến khi chỉ còn một chữ số duy nhất.
    - Trả về chữ số cuối cùng này, gọi là "super digit".

    ví dụ: n = 148, k = 3 tức là ta sẽ lặp lại chuỗi "148" ba lần, 
    tạo thành chuỗi "148148148", Thay vì lặp lại chuỗi, 
    ta có thể tính tổng các chữ số của "148": 1 + 4 + 8 = 13.
    Sau đó, nhân tổng này với k: 13 * 3 = 39.
    Tính tổng các chữ số của 39: 3 + 9 = 12.
    Tính tiếp tổng các chữ số của 12: 1 + 2 = 3
    Vậy, "super digit" là 3.

    Sanple Input: n = 148, k = 3
    sample Output: 3
    */
    /// 

    internal class Deploy
    {
        public static int superDigit(string n, int k)
        {
            // Tính tổng các chữ số của chuỗi n
            long digitSum = n.ToCharArray().Select(c => (int)
                                                   char.GetNumericValue(c)).Sum();
            // Tổng cần tính là digitSum nhân với k
            long totalSum = digitSum * k;

            // Gọi hàm đệ quy để tính "super digit"
            return getSuperDigit(totalSum);
        }

        public static int getSuperDigit(long num)
        {
            // Nếu số chỉ còn 1 chữ số thì trả về chính nó
            if (num < 10)
            {
                return (int)num;
            }

            // Tính tổng các chữ số
            long newSum = num.ToString().ToCharArray().Select(c => (int)
                                                   char.GetNumericValue(c)).Sum();
            // Gọi lại hàm đệ quy với tổng mới
            return getSuperDigit(newSum);
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n = ");
            string n = Console.ReadLine();
            Console.Write("Please enter k = ");
            int k = Convert.ToInt32(Console.ReadLine());

            int result = Deploy.superDigit(n, k);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // New Year Chaos
namespace newYearChaos
{
    /// <summary> Algorithms Problem
    /*
    xác định số lượng "hối lộ" (bribes) mà một người phải trả để chuyển từ một hàng 
    đứng yên sang một hàng khác.

    - Có n người xếp hàng để nhận quà trong dịp Tết.
    - Mỗi người có một số thứ tự (1, 2, 3,..., n) mà họ nên đứng theo thứ tự này.
    - Một người chỉ có thể hối lộ tối đa 2 người đứng trước mình để có thể chuyển
    lên phía trước trong hàng.
    - Nếu một người đứng ở vị trí nào đó trong hàng mà họ đã hối lộ hơn 2 người,
    thì việc đó được coi là bất hợp pháp và cần báo cáo.

    Đầu vào: q: một danh sách các số nguyên, trong đó mỗi số nguyên đại diện cho thứ tự
    hiện tại của người đứng trong hàng.

    Đầu ra: - Nếu không có ai hối lộ quá hai người, in ra tổng số hối lộ mà mọi người đã 
    thực hiện.
    - Nếu có ai đó hối lộ quá hai người, in ra "Too chaotic".

    Sanple Input: q = [2, 1, 5, 3, 4]   
    sample Output: 3
    */
    /// 

    internal class Deploy
    {
        public static void minimumBribes(List<int> q)
        {
            int totalBrides = 0;
            bool chaotic = false;

            for (int i = 0; i < q.Count; i++)
            {
                // Kiểm tra nếu một người đã hối lộ quá 2 người
                if (q[i] - (i + 1) > 2)  // (i + 1) là vị trí thật của người thứ i
                {
                    chaotic = true;
                    break;
                }

                // Tính số hối lộ Chỉ kiểm tra các vị trí trước người hiện tại
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if (q[j] > q[i])
                    {
                        totalBrides++;
                    }
                }
            }

            if (chaotic)
            {
                Console.WriteLine("Too chaotic");
            }
            else
            {
                Console.WriteLine(totalBrides);
            }
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> q = new List<int>();

            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter element {i}: ");
                int element = Convert.ToInt32(Console.ReadLine());
                q.Add(element);
            }

            Deploy.minimumBribes(q);

            Console.ReadLine();
        }
    }
}
#endif



#endregion

#region Day 4

#if false // Merge Two Sorted Linked Lists
namespace mergeTwoSortedLists
{
    /// <summary> Data Structures
    /*
    hợp nhất hai singly linked lists  thành một singly linked lists mới,  với mục tiêu tạo ra
    một  singly linked lists đã được sắp xếp.
    Example: headA 1 -> 3 -> 7 -> null
             headB 1-> 2 -> null
             the new list: 1 -> 1 -> 2 -> 3 -> 7 -> null
    Sample Input: nNode1 = 3 => 1 -> 2 -> 3 -> null, nNode2 = 2 => 3 -> 4 -> null
    Sample Output: 1 -> 2 -> 3 -> 3 -> 4 -> null
    */
    /// </summary>

    internal class Deploy
    {
        public static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1,
                                                      SinglyLinkedListNode head2)
        {
            // tạo 1 Node tạm thời ngay đầu LinkedList mới
            SinglyLinkedListNode dummyNode = new SinglyLinkedListNode(0);
            SinglyLinkedListNode tail = dummyNode;

            while (head1 != null && head2 != null)
            {
                if (head1.data <= head2.data)
                {
                    tail.next = head1;
                    head1 = head1.next;
                }
                else
                {
                    tail.next = head2;
                    head2 = head2.next;
                }

                tail = tail.next;
            }

            if (head1 != null)
            {
                tail.next = head1;
            }
            if (head2 != null)
            {
                tail.next = head2;
            }

            return dummyNode.next;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            SinglyLinkedList linkedList1 = new SinglyLinkedList();
            SinglyLinkedList linkedList2 = new SinglyLinkedList();

            Console.Write("Please enter nnode1 = ");
            int nNode = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nNode; i++)
            {
                Console.Write($"Please enter value Node {i}: ");
                int nodeData = Convert.ToInt32(Console.ReadLine());
                linkedList1.InsertNode(nodeData);
            }

            Console.Write("Please enter nnode2 = ");
            int nNode2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nNode2; i++)
            {
                Console.Write($"Please enter value Node {i}: ");
                int nodeData = Convert.ToInt32(Console.ReadLine());
                linkedList2.InsertNode(nodeData);
            }

            SinglyLinkedListNode mergedList = Deploy.mergeLists(linkedList1.head, linkedList2.head);
            SinglyLinkedList.PrintSinglyLinkedList(mergedList, " -> ");

            Console.ReadLine();
        }
    }
}
#endif



#endregion

#endregion

#region Mock Test

#if false // Find Median
namespace findMedian
{
    /// <summary> Mock test
    /*
    Đề Bài: Tìm giá trị trung vị Median

    Định nghĩa:
    - Median (Trung vị) của một dãy số là giá trị mà chia dãy số thành hai phần 
    bằng nhau: một nửa các phần tử có giá trị nhỏ hơn trung vị, và nửa còn lại có
    giá trị lớn hơn trung vị.
    - Nếu dãy có số phần tử lẻ, thì median là phần tử đứng giữa sau khi dãy đã
    được sắp xếp.
    - Nếu dãy có số phần tử chẵn, median là trung bình của hai phần tử ở giữa sau
    khi dãy được sắp xếp.

    Sameple Input: 1 3 2 4 5    
    Sample Output: 3
    */
    /// </summary>

    internal class Deploy
    {
        public static int findMedian(List<int> arr)
        {
           arr.Sort();
           
           int n = arr.Count;
           int medianIndex = n / 2;

           return arr[medianIndex];
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            Console.Write("Please enter n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter arr[{i}]: ");
                int element = Convert.ToInt32(Console.ReadLine());
                arr.Add(element);
            }

            int result = Deploy.findMedian(arr);
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
#endif

#if false // Flipping the Matrix
namespace flippingTheMatrix
{
    /// <summary> Mock test
    /*
    Cho 1 ma trận hình vuông kích thước 2n x 2n; có nghĩa là số hàng và số cột
    của ma trận đều là 2n, ví dụ n = 2 ma trận sẽ có 4 hàng và 4 cột.

    có thể lật một phần tử của ma trận , lật ở đây là có thể chọn 1 phần tử và
    thay thế nó bằng 1 một 4 phần tử tương ứng nằm ở các góc của ma trận.

    cụ thể nếu chọn 1 phần tử tại vị trí (i, j) thì có thể lật sang:
    Phần tử ở trên bên trái: (i, j)
    Phần tử ở trên bên phải: (i, 2n - 1 - j)
    Phần tử ở dưới bên trái: (2n - 1 - i, j)
    Phần tử ở dưới bên phải: (2n - 1 - i, 2n - 1 - j)

    Mục tiêu cuối cùng là tìm tổng giá trị lớn nhất có thể của các phần tử
    trong nửa trên của ma trận sau khi bạn có thể lật các phần tử bất kỳ.

    chỉ cần xem xét nửa trên của ma trận, vì có thể chọn lật bất 
    kỳ phần tử nào từ nửa dưới sang nửa trên để tối đa hóa tổng.

    Sameple Input:    112 42 83 119
                      56  125 56 49
                      15  78 101 43
                      62  98 114 108

    lần lặp 1 (i = 0, j = 0): [112, 119, 62, 108] => 119
    lần lặp 2 (i = 0, j = 1): [42, 83, 98, 114] => 114
    lần lặp 3 (i = 1, j = 0): [56, 49, 15, 43] => 56
    lần lặp 4 (i = 1, j = 1): [125, 56, 78, 101] => 125
    119 + 114 + 56 + 125 = 414

    Sample Output: 414
    */
    /// </summary>

    internal class Deploy
    {
        public static int flippingMatrix(List<List<int>> maxtrix)
        {
            int n = maxtrix.Count / 2; // lấy nữa ma trận
            int totalMax = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int topLeft = maxtrix[i][j];
                    int topRight = maxtrix[i][2 * n - 1 - j];
                    int bottomLeft = maxtrix[2 * n - 1 - i][j];
                    int bottomRight = maxtrix[2 * n - 1 - i][2 * n - 1 - j];

                    int maxValue = Math.Max(topLeft, Math.Max(topRight, Math.
                                                   Max(bottomLeft, bottomRight)));
                    totalMax += maxValue;
                }
            }

            return totalMax;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            var matrix = new List<List<int>>();

            Console.Write("Please enter nRow = ");
            int nRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter nColumn = ");
            int nCol = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nRow; i++)
            {
                var row = new List<int>();

                for (int j = 0; j < nCol; j++)
                {
                    Console.Write($"Please enter value row{i} column{j}: ");
                    int element = Convert.ToInt32(Console.ReadLine());
                    row.Add(element);
                }

                matrix.Add(row);
            }

            int result = Deploy.flippingMatrix(matrix);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Palindrome Index
namespace palindromeIndex
{
    /// <summary> Mock test
    /*
    Bài toán yêu cầu tìm chỉ số của một ký tự trong chuỗi mà khi loại bỏ ký tự đó,
    chuỗi còn lại sẽ trở thành palindrome. Nếu chuỗi đã là palindrome,
    kết quả trả về là -1.

    Palindrome là chuỗi mà khi đảo ngược vẫn giống hệt chuỗi ban đầu.
    Ví dụ: "madam", "racecar", "121" là palindrome.
    Với chuỗi không phải palindrome, nếu loại bỏ một ký tự có thể biến chuỗi
    thành palindrome, ta phải tìm chỉ số của ký tự đó.

    in ra chỉ số của ký tự cần loại bỏ.

    Sameple Input: aaab 
    Sample Output: 3 vì aaa là palindrome nên loại bỏ b, b ở vị trí thứ 3.
    */
    /// </summary>

    internal class Deploy
    {
        public static int palindromeIndex(string s)
        {
            int n = s.Length;

            // Hàm kiểm tra xem một chuỗi có phải palindrome không
            bool IsPalindrome(string str, int start, int end)
            {
                while (start < end)
                {
                    if (str[start] != str[end])
                        return false;
                    start++;
                    end--;
                }

                return true;
            }

            // Duyệt từ đầu tới giữa chuỗi
            for (int i = 0; i < n / 2; i++)
            {
                if (s[i] != s[n - 1 - i])
                {
                    // Kiểm tra nếu bỏ ký tự tại vị trí i hoặc n-1-i
                    // có tạo ra palindrome không
                    if (IsPalindrome(s, i + 1, n - 1 - i))
                        return i;
                    if (IsPalindrome(s, i, n - 2 - i))
                        return n - 1 - i;
                }
            }

            return -1;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter string: ");
            string s = Console.ReadLine();

            int result = Deploy.palindromeIndex(s);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#if false // Truck Tour
namespace truckTour
{
    /// <summary> Mock test
    /*
    tìm ra điểm xuất phát của một chuyến hành trình mà tại đó một chiếc xe tải có 
    thể đi qua tất cả  các trạm xăng mà không hết xăng.

    cho một danh sách các trạm xăng, mỗi trạm có hai giá trị:
    - xăng (petrol): lượng xăng mà trạm cung cấp.
    - khoảng cách (distance): khoảng cách đến trạm xăng tiếp theo.

    tìm ra chỉ số của trạm xăng từ đó có thể bắt đầu hành trình, 
    và đi qua tất cả các trạm xăng mà không hết xăng.

    ví dụ: Trạm 0 cung cấp 4 lít xăng và cần 6 lít để đến trạm tiếp theo.
           Trạm 1 cung cấp 6 lít xăng và cần 5 lít để đến trạm tiếp theo.
           Trạm 2 cung cấp 7 lít xăng và cần 3 lít để đến trạm tiếp theo.
           Trạm 3 cung cấp 4 lít xăng và cần 5 lít để đến trạm tiếp theo.

           Tổng xăng: 4 + 6 + 7 + 4 = 21
           Tổng khoảng cách: 6 + 5 + 3 + 5 = 19

    Bắt đầu từ trạm 0: 
    Xăng còn lại: 4 - 6 = - 2 không thể bắt đầu từ trạm 0 startIndex thành 1
    Bắt đầu từ trạm 1:
    Xăng còn lại: 6 - 5 = 1 xăng còn lại có thể tiếp tục
    Từ trạm 1 đến trạm 2: 
    Xăng còn lại: 1 + 7 - 3 = 5 xăng còn lại có thể tiếp tục
    Từ trạm 2 đến trạm 3:
    Xăng còn lại: 5 + 4 - 5 = 4 xăng còn lại có thể tiếp tục
    Từ trạm 3 quay lại trạm 0:
    Xăng còn lại: 4 + 4 - 6 = 2 xăng còn lại có thể tiếp tục

    Tổng kết lại, có thể hoàn thành hành trình bắt đầu từ trạm 1

    Sample Input: 4 6
                  6 5
                  7 3
                  4 5

    Sample Output: 1
    */
    /// </summary>

    internal class Deploy
    {
        public static int truckTour(List<List<int>> petrolpumps)
        {
            int totalPetrol = 0;
            int totalDistance = 0;
            int currentPetrol = 0;
            int startindex = 0;

            for (int i = 0; i < petrolpumps.Count; i++)
            {
                int petrol = petrolpumps[i][0];
                int distance = petrolpumps[i][1];

                totalPetrol += petrol;
                totalDistance += distance;

                currentPetrol += petrol - distance;

                // Nếu xăng còn lại < 0, không thể đi tiếp từ trạm này
                if (currentPetrol < 0)
                {
                    startindex = i + 1; // Đặt lại điểm xuất phát
                    currentPetrol = 0; // Bắt đầu lại từ trạm tiếp theo
                }
            }

            // Nếu tổng xăng >= tổng khoảng cách, có đủ xăng từ trạm startindex
            return totalPetrol >= totalDistance ? startindex : -1;
        }
    }

    internal class Problem
    {
        static void Main(string[] args)
        {
            List<List<int>> petrolpumps = new List<List<int>>();

            Console.Write("Please enter nRow: ");
            int nRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nCol = 2 ");
            int nCol = 2;

            for (int i = 0;i < nRow; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0;j < nCol; j++)
                {
                    Console.Write($"Please enter element nRow {i} nCol {j}: ");
                    int element = Convert.ToInt32( Console.ReadLine());
                    row.Add(element);
                }

                petrolpumps.Add(row);
            }

            int result = Deploy.truckTour(petrolpumps);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
#endif

#endregion


