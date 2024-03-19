/// 1. Класи Піаніно, Клавіша, Педаль. Методи: налаштувати, грати на піаніно, натискати клавішу. 
/// При виклику будь-якого методу класу, виводити на екран текстове повідомлення. 
/// Оверрайднути базові методи Equals, GetHashCode, ToString.
/// 2. 




namespace Lab2_4
{
    public class Piano_key
    {
        private int hash;
        public Piano_key()
        {
            hash = GenerateHashCode();
        }
        public void press()
        {
            Console.WriteLine("Key pressed");
        }
        public override bool Equals(object obj)
        {
            if (obj.GetHashCode() != GetHashCode())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GenerateHashCode()
        {
            Random rnd = new Random();
            return(rnd.Next(1, 89));
        }
        public override int GetHashCode()
        {
            return hash;
        }

        public override string ToString()
        {
            string str = "It's a piano key, its number is " + GetHashCode();
            return str;
        }
    }

    public class Piano_pedal
    {
        private int hash;
        public Piano_pedal()
        {
            hash = GenerateHashCode();
        }
        public void push()
        {
            Console.WriteLine("Pedal pushed");
        }
        public override bool Equals(object obj)
        {
            if (obj.GetHashCode() != GetHashCode())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GenerateHashCode()
        {
            Random rnd = new Random();
            return (rnd.Next(1, 4));
        }
        public override int GetHashCode()
        {
            return hash;
        }

        public override string ToString()
        {
            string str = "It's a piano pedal, its number is " + GetHashCode();
            return str;
        }
    }

    public class Piano
    {
        private Piano_key key;
        private Piano_pedal pedal;
        private int hash;

        public Piano()
        {
            key = new Piano_key();
            pedal = new Piano_pedal();
            hash = GenerateHashCode();
        }

        public void Setup()
        {
            Console.WriteLine("Piano setuped");
        }

        public void Play()
        {
            Console.WriteLine("Playing melody.");
            push_the_pedal(); 
            press_the_key(); 
            press_the_key();
        }

        public void press_the_key()
        {
            key.press();
        }

        public void push_the_pedal()
        {
            pedal.push();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetHashCode() != GetHashCode())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GenerateHashCode()
        {
            Random rnd = new Random();
            return (rnd.Next(1000000, 9999999));
        }
        public override int GetHashCode()
        {
            return hash;
        }

        public override string ToString()
        {
            string str = "It's a piano, its number is " + GetHashCode();
            return str;
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
                        Piano piano1 = new Piano();
                        Piano piano2 = new Piano();

                        Piano_key key1 = new Piano_key();
                        Piano_key key2 = new Piano_key();

                        Piano_pedal pedal1 = new Piano_pedal();
                        Piano_pedal pedal2 = new Piano_pedal();

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