namespace бэмс_бэмс 
{
    internal class Program
    {
        static void Main()
        {
            int octave = 0;
            bool skipClearing = false;
            while (true)
            {
                int note = -1;
                if (!skipClearing)
                    Console.Clear();
                else
                    skipClearing = false;
                Console.WriteLine("Клавиша: ");
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.F1:
                        octave = 0;
                        break;
                    case ConsoleKey.F2:
                        octave = 1;
                        break;
                    case ConsoleKey.Q:
                        note = 0;
                        break;
                    case ConsoleKey.W:
                        note = 1;
                        break;
                    case ConsoleKey.E:
                        note = 2;
                        break;
                    case ConsoleKey.R:
                        note = 3;
                        break;
                    case ConsoleKey.T:
                        note = 4;
                        break;
                    case ConsoleKey.Y:
                        note = 5;
                        break;
                    case ConsoleKey.U:
                        note = 6;
                        break;
                    case ConsoleKey.I:
                        note = 7;
                        break;
                    case ConsoleKey.O:
                        note = 8;
                        break;
                    case ConsoleKey.P:
                        note = 9;
                        break;
                    case ConsoleKey.J:
                        note = 10;
                        break;
                    case ConsoleKey.K:
                        note = 11;
                        break;
                    case ConsoleKey.Backspace:
                        Console.Clear();
                        Console.WriteLine("See you!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("За ноты отвечают клавиши Q,W,E,R,T,Y,U,I,O,P,J,K\nПереключают октавы клавиши F1 и F2\nКлавиша BackSpace для выхода из программы");
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        break;
                }
                if (note != -1)
                    PlaySomeMusic(octave, note);
                else
                {
                    Console.WriteLine($"Выбрана {octave + 1}-ая октава");
                    skipClearing = true;
                }
            }
        }
        static void PlaySomeMusic(int octave, int note)
        {
            int[] firstOctave = new int[] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
            int[] secondOctave = new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
            switch (octave)
            {
                case 0:
                    Console.Beep(firstOctave[note], 100);
                    break;
                case 1:
                    Console.Beep(secondOctave[note], 100);
                    break;
            }

        }
    }
}