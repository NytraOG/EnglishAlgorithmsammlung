namespace ReverseString
{
    public class StringTwister
    {
        public string TwistString(string inputString)
        {
            string outputString = "";

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                outputString += inputString.Substring(i, 1);
            }

            return outputString;
        }
    }
}
