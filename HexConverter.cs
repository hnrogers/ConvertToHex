using System.Linq;

class Hex
{
    public void HexConvert (string a)
    {

        char[] tempArray = a.ToLower().ToCharArray();

        foreach (char temp in tempArray)
        {
            
            Console.Write("{0:X} ", Convert.ToInt32(temp));
                   
        }
    }
}