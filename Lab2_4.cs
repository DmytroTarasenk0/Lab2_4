/// 1. Класи Піаніно, Клавіша, Педаль. Методи: налаштувати, грати на піаніно, натискати клавішу. 
/// При виклику будь-якого методу класу, виводити на екран текстове повідомлення. 
/// Оверрайднути базові методи Equals, GetHashCode, ToString.
/// 2. 




namespace Lab2_4
{
    public class Piano_key
    {
        public void press()
        {
            Console.WriteLine("Key pressed");
        }
    }

    public class Piano_pedal
    {
        public void push()
        {
            Console.WriteLine("Pedal pushed");
        }
    }

    public class Piano
    {
        private Piano_key key;
        private Piano_pedal pedal;

        public Piano()
        {
            key = new Piano_key();
            pedal = new Piano_pedal();
        }

        public void Setup()
        {
            Console.WriteLine("Piano setuped");
        }

        public void Play()
        {
            Console.WriteLine("Playing melody");
        }

        public void press_the_key()
        {
            key.press();
        }

        public void push_the_pedal()
        {
            pedal.push();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("As always, 1, 2 - task. 'Exit' for exit");
            while (true)
            {
                string u_input;
                u_input = Console.ReadLine();

                if (u_input.ToLower() == "exit")
                {
                    break;
                }
                else if (u_input.ToLower() == "1")
                {
                    try
                    {

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error. " + e.Message);
                    }
                }
                else if (u_input.ToLower() == "2")
                {
                    try
                    {

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error. " + e.Message);
                    }
                }
            }
        }
    }
}