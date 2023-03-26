
namespace DiamondForTheAdvanced
{
    public class TUI
    {
        public static short GetInputFromUser(string i_prompt)
        {
            string rawInput = string.Empty;
            short proccessedInput = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                System.Console.Write(i_prompt);
                rawInput = System.Console.ReadLine(); 
                isValidInput = short.TryParse(rawInput,out proccessedInput);         
                if (!isValidInput)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Invalid input");
                }
            }
            System.Console.Clear();
            return proccessedInput;
        }
    }
}

