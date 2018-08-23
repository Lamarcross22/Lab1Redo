using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GC_Lab_1
{
    class Program
    {
        private const bool V = true;

        static bool MainTask(int[] nums1, int[] nums2)
        {
            bool repeat = true;
            while (repeat)

            {

                if (nums1 != null)
                {
                    if (nums2 == null)
                    {
                        throw new ArgumentNullException(nameof(nums2));
                    }

                    bool answer = true;
                    List<int> sumList = nums2.Select((t, i) => nums1[i] + t).ToList();
                    int reference = sumList[0];
                    for (int i = 0; i < nums1.Length; i++)
                    {
                        if ((sumList[i] == reference) && answer)
                        {
                        }
                        else
                        {
                            answer = false;
                        }
                    }

                    return answer;
                }

                throw new ArgumentNullException(nameof(nums1));
            

            static string Input1(bool first)
            {
                bool whileBreak = false;
                if (first)
                {
                    WriteLine("Hello, please enter a whole number. ");
                }

                if (!first)
                {
                    WriteLine("Please enter a whole number.");
                }

                string output = ReadLine();
                while (whileBreak == false)
                {
                    bool tryAgain = false;
                    try
                    {
                        int i = Convert.ToInt32(output);
                    }
                    catch (FormatException)
                    {
                        WriteLine("Input string is not a sequence of digits.");
                        WriteLine("Please try again.");
                        output = ReadLine();
                        tryAgain = NewMethod();
                    }
                    catch (OverflowException)
                    {
                        WriteLine("The number cannot fit in an Int32.");
                        WriteLine("Redo");
                        output = ReadLine();
                        tryAgain = NewMethod();
                    }
                    finally
                    {
                        if (tryAgain != true)
                        {
                            whileBreak = true;
                        }
                    }
                }

                return output;
            }

            private static bool NewMethod()
            {
                return true;
            }

            static string Input2()
            {
                bool whileBreak = false;
                WriteLine("Please enter another whole number of the same length. ");
                string output = ReadLine();
                while (whileBreak == false)
                {
                    bool tryAgain = false;
                    try
                    {
                    }
                    catch (FormatException)
                    {
                        WriteLine("Input string is not a sequence of digits.");
                        WriteLine("Please try again.");
                        output = ReadLine();
                        tryAgain = true;
                    }
                    catch (OverflowException)
                    {
                        WriteLine("The number cannot fit in an Int32.");
                        WriteLine("Please try again.");
                        output = ReadLine();
                        tryAgain = true;
                    }
                    finally
                    {
                        if (tryAgain != V)
                        {
                            whileBreak = true;
                        }
                    }
                }

                return output;
            }

            // Check length
            bool LengthCheck(string in1, string in2)
            {
                bool check = false;
                var charArray1 = in1.ToCharArray();
                var charArray2 = in2.ToCharArray();
                check = (charArray1.Length == charArray2.Length);
                return check;
            }

            void Main(string[] args)
            {
                //These are the inputs
                var input1 = Input1(first: true);
                var input2 = Input2();
                bool whileBreak = false;
                //Entry loop
                while (!whileBreak)
                {
                    whileBreak = LengthCheck(in1: input1, in2: input2);
                    if (LengthCheck(input1, in2: input2)) continue;
                    WriteLine(value: "Entered numbers are not the same length, go ahead and retry this.");
                    input1 = Input1(first: false);
                    input2 = Input2();
                }

                var charArray1 = input1.ToCharArray();
                var charArray2 = input2.ToCharArray();
                var numArray1 = Array.ConvertAll(array: charArray1, converter: c => (int) char.GetNumericValue(c: c));
                var numArray2 = Array.ConvertAll(array: charArray2, converter: c => (int) char.GetNumericValue(c: c));
                WriteLine(value: MainTask(nums1: numArray1, nums2: numArray2));
                ReadKey();
            }
                
        }
    }
}


