namespace ConvertToHex
{
    class Primary
    {
        public static void Main()
        {
            string regularWords = "hello world";
            Hex hex = new Hex();

            hex.HexConvert(regularWords);
        }
    }
}
