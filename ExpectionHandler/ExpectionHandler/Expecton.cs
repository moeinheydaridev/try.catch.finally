using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace ExpectionHandler
{ public class Expecton
    {
        int[] array = { 1, 34, 21, 45, 43 };
        public static bool WrongAnswer = false;
        public int GetNumber(int index)
        {
            int output = -1;
            try
            {
                output = array[index];
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
}
            finally
            {
                if (output == -1)
                {
                    WrongAnswer = true;
                }
                else
                {
                    WrongAnswer = false;

                }
            }
            return output;
        }
    }
}

