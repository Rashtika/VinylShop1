// See https://aka.ms/new-console-template for more information

using VinylShop.first;

Console.WriteLine($"Choose option:");

List<Vinyl> list = new List<Vinyl>();
LP ThePaleEmperor = new LP("The Pale Emperor", "Marilyn Manson", "Industrial metal", 2015, 10);
list.Add(ThePaleEmperor);

bool quit = false;
while (!quit)
{
    int option = Console.ReadLine();
    switch (int.Parse(option))
    {
        case 1:
            Console.WriteLine($"");

            break;
    }
    Console.WriteLine($"Choose option:" +
            $"1. Add vinyl to your cart" +
            $"2. Remove item from your cart" +
            $"3. Change character" +
            $"4. Attack opponent" +
            $"5. Remove charcter" +
            $"6. Quit" +
            $"7. Print options");
}

