namespace Game.UI
{
    internal class MyConsole
    {
        public static int AskForNoAndReturnIndex(int row, string question)
        {
            Console.CursorLeft = 1;
            Console.CursorTop = row;
            Console.Write(question);
            var numberStr = Console.ReadLine();
            return Convert.ToInt32(numberStr) - 1;
        }

        public static void Write(int row, int col, string text)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(text);
        }

        public static void WriteCentered(int row, int col, int width, string text)
        {
            var whiteSpaceCount = (width - text.Length) / 2;
            Console.SetCursorPosition(col, row);
            Console.Write("".PadLeft(whiteSpaceCount, ' '));
            Console.Write(text);
        }
    }
}
