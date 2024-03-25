/// 1. Класи Піаніно, Клавіша, Педаль. Методи: налаштувати, грати на піаніно, натискати клавішу. 
/// При виклику будь-якого методу класу, виводити на екран текстове повідомлення. 
/// Оверрайднути базові методи Equals, GetHashCode, ToString.
/// 2. Створити таксопарк. Вартість автопарку, сортування по витраті палива. Знайти автомобіль з заданою швидкістю.





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
            Console.WriteLine("Playing the melody.");
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

    public class Car
    {
        public string Model {get; set;}
        public double Consumption {get; set;}
        public decimal Price {get; set;}
        public int MaxSpeed {get; set;}

        public Car(string m, double c, decimal p, int mS)
        {
            Model = m;
            Consumption = c;
            Price = p;
            MaxSpeed = mS;
        }

        public void Info()
        {
            Console.WriteLine($"Model: {Model}, " +
                $"\nFuel Consumption: {Consumption} L/100km, " +
                $"\nPrice: {Price}$, " +
                $"\nMax Speed: {MaxSpeed} km/h\n");
        }
    }
    
    public class Car_Park
    {
        private List<Car> park;

        public Car_Park()
        {
            park = new List<Car>();
        }
        public void AddCar(Car car)
        {
            park.Add(car);
        }
        public void RemoveCar(Car car)
        {
            park.Remove(car);
        }
        public decimal TotalPrice()
        {
            return park.Sum(c => c.Price);
        }
        public void SortConsumption()
        {
            park.Sort((car1, car2) => car1.Consumption.CompareTo(car2.Consumption));
        }
        public Car FindSpeed(int maxSpeed)
        {
            Car possible_car = park.FirstOrDefault(c => c.MaxSpeed == maxSpeed);
            return possible_car;
        }
        public void DisplayCars()
        {
            foreach (var car in park)
            {
                car.Info();
            }
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

                        piano1.Play();
                        piano2.Setup();
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
                        Car_Park park = new Car_Park();
                        park.AddCar(new Car("Ferrari", 15.5, 300000, 340));
                        park.AddCar(new Car("Mercedes", 9.5, 100000, 270));
                        park.AddCar(new Car("Porsche", 11.8, 120000, 310));

                        park.DisplayCars();

                        park.SortConsumption();
                        park.DisplayCars();

                        Car foundCar = park.FindSpeed(310);
                        if (foundCar != null)
                        {
                            Console.WriteLine($"\nCar found with max speed 310:");
                            foundCar.Info();
                        }
                        else
                        {
                            Console.WriteLine($"\nCar with max speed 310 not found");
                        }

                        Console.WriteLine("Total Price: " + park.TotalPrice());
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