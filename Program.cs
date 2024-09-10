using System;

namespace Colorless
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Colorless";
            Console.WindowHeight = 45;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            // Title Screen

            Console.WriteLine("Adrian Ignacio Presents");
            Console.ReadLine();
            Console.WriteLine("Colorless");
            Console.ReadLine();
            Console.WriteLine("Press 'Enter' to start");

            Console.ReadLine();

            // Kroton (Green Faction) "Enthusiastic, Hilarious, Hopeful Poet"

            // Name Q/A

            Console.WriteLine("??: Why hello there!");
            Console.ReadLine();
            Console.WriteLine("??: What do they call such a fine specimen?");
            Console.ReadLine();
            Console.WriteLine("Please enter your name.");

            string userName = Console.ReadLine();

            Console.WriteLine("??: " + userName + " huh? What a peculiar name...");
            Console.ReadLine();
            Console.WriteLine("??: I'm Codiaeum Variegatum Evergreen!");
            Console.ReadLine();
            Console.WriteLine("Codiaeum Variegatum Evergreen: But only the most admirable, benevolent, courteous, diligent, empathetic, \nformidable, generous, hopeful, irreplaceable, judicious, kind-hearted, luminous, motivational, noteworthy, optimistic, \nprestegious, qualified, responsible, sincere, tenacious, unrivalled, valiant, wise, xenodochial, young-at-heart, \nand zealous may call me by that name.");
            Console.ReadLine();
            Console.WriteLine("Otherwise, you can call me Kroton.");
            Console.ReadLine();

            // Color Q/A

            Console.WriteLine("Kroton: Now...");
            Console.ReadLine();
            Console.WriteLine("Kroton: This may be a bit personal but...");
            Console.ReadLine();
            Console.WriteLine("Kroton: Which color do you prefer?");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Kroton: Red?");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Kroton: or");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Kroton: Blue?");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Please choose a color.");

            string color = Console.ReadLine();

            // red
            // blue
            // green
            // yellow/gold
            // purple
            // orange/peach/apricot
            // white/ivory
            // black
            // grey/silver
            // brown/bronze/tan
            // pink
            // rainbow

            switch (color)
            {

                // Red

                case "red" or "Red" or "RED" or "crimson" or "Crimson" or "CRIMSON" or "scarlet" or "Scarlet" or "SCARLET" or "ruby" or "Ruby" or "RUBY" or "burgundy" or "Burgundy" or "BURGUNDY" or "rose" or "Rose" or "ROSE" or "blood" or "Blood" or "BLOOD" or "garnet" or "Garnet" or "GARNET" or "light red" or "Light red" or "light Red" or "Light Red" or "LIGHT RED" or "lightred" or "LIGHTRED" or "dark red" or "Dark red" or "dark Red" or "Dark Red" or "DARK RED" or "darkred" or "DARKRED":
                    Console.WriteLine("Kroton: What an exciting choice!");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Kroton: Red symbolizes passion, energy, and strength.");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Kroton: I expected no less from you, " + userName + ".");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: Now, based on my reaction, I'm sure you can guess which color I prefer.");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: Yes!");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: Precisely!");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: It's..!");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: Drum roll please!!");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("....");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".....");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("......");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".......");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("........");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".........");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("..........");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...........");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("............");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".............");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("..............");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...............");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("..................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("....................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".....................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("......................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".......................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("........................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".........................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("..........................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...........................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("............................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".............................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("..............................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...............................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("..................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("....................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".....................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("......................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".......................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("........................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".........................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("....................................................................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Kroton: Green");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Kroton: Oh. What I meant to say was...");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Kroton: GREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEN");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Kroton: YES! THAT'S RIGHT! GREEN MEANS ABSOLUTELY EVERYTHING TO ME!!!");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: HA");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: HA HA");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: HA HA HA");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: HA HA HA HA");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: Just kidding. I won't put you through that again.");
                    Console.ReadLine();
                    break;

                // Blue

                case "blue" or "Blue" or "BLUE" or "turqoise" or "Turqoise" or "TURQOISE" or "sky" or "Sky" or "SKY" or "navy" or "Navy" or "NAVY" or "cobalt" or "Cobalt" or "COBALT" or "lapis" or "Lapis" or "LAPIS" or "sapphire" or "Sapphire" or "SAPPHIRE" or "teal" or "Teal" or "TEAL" or "arctic" or "Arctic" or "ARCTIC" or "cyan" or "Cyan" or "CYAN" or "light blue" or "Light blue" or "light Blue" or "Light Blue" or "LIGHT BLUE" or "lightblue" or "LIGHTBLUE" or "dark blue" or "Dark blue" or "dark Blue" or "Dark Blue" or "DARK BLUE" or "darkblue" or "DARKBLUE":
                    Console.WriteLine("Kroton: What a relaxing choice!");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Kroton: Blue symbolizes trust, loyalty, and responsibility.");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Kroton: I expected no less from you, " + userName + ".");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: Now, based on my reaction, I'm sure you can guess which color I prefer.");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: Yes!");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: Precisely!");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: It's..!");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: Drum roll please!!");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("....");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".....");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("......");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".......");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("........");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".........");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("..........");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...........");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("............");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".............");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("..............");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...............");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("..................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("....................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".....................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("......................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".......................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("........................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".........................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("..........................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...........................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("............................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".............................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("..............................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...............................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("..................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("...................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("....................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".....................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("......................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".......................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("........................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(".........................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("....................................................................................");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Kroton: Green");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Kroton: Oh. What I meant to say was...");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Kroton: GREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEN");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Kroton: YES! THAT'S RIGHT! GREEN MEANS ABSOLUTELY EVERYTHING TO ME!!!");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: HA");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: HA HA");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: HA HA HA");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: HA HA HA HA");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: Just kidding. I won't put you through that again.");
                    Console.ReadLine();
                    break;

                // Green

                case "green" or "Green" or "GREEN" or "emerald" or "Emerald" or "EMERALD" or "olive" or "Olive" or "OLIVE" or "lime" or "Lime" or "LIME" or "sage" or "Sage" or "SAGE" or "mint" or "Mint" or "MINT" or "parakeet" or "Parakeet" or "PARAKEET" or "seafoam" or "Seafoam" or "SEAFOAM" or "pistachio" or "Pistachio" or "PISTACHIO" or "pear" or "Pear" or "PEAR" or "pine" or "Pine" or "PINE" or "light green" or "Light green" or "light Green" or "Light Green" or "LIGHT GREEN" or "lightgreen" or "LIGHTGREEN" or "dark green" or "Dark green" or "dark Green" or "Dark Green" or "DARK GREEN" or "darkgreen" or "DARKGREEN":
                    Console.WriteLine("Kroton: ...");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: That's not Red nor Blue.");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: However...");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: YOU PICKED THE PERFECT COLOR!!!");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: What a hopeful choice!");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Kroton: Green symbolizes harmony, health, and growth.");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Kroton: It is everything I stand for!");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: " + userName + ", you're astounding!");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Kroton: Green means more to me than you could ever know.");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                // Yellow

                case "yellow" or "Yellow" or "YELLOW" or "gold" or "Gold" or "GOLD" or "lemon" or "Lemon" or "LEMON" or "daffodil" or "Daffodil" or "DAFFODIL" or "blonde" or "Blonde" or "BLONDE" or "honey" or "Honey" or "HONEY" or "light yellow" or "Light yellow" or "light Yellow" or "Light Yellow" or "LIGHT YELLOW" or "lightyellow" or "LIGHTYELLOW" or "dark yellow" or "Dark yellow" or "dark Yellow" or "Dark Yellow" or "DARK YELLOW" or "darkyellow" or "DARKYELLOW":
                    Console.WriteLine("Kroton: ...");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: That's not Red nor Blue.");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: However, it is...");
                    Console.ReadLine();
                    Console.WriteLine("Kroton: Such a fun choice!");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Kroton: Yellow symbolizes happiness, optimism, and creativity.");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Kroton: I expected no less from you, " + userName + ".");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Kroton: I personally love the color GREEN!");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;




            }

            // Console.WriteLine("Kroton: I expected no less from you, " + userName + ".");
            // Console.ReadLine();

            // Green Poem

            Console.WriteLine("Kroton: But if I had to choose between Red and Blue...");
            Console.ReadLine();
            Console.WriteLine("Kroton: I prefer Blue, since combined with Yellow, they make Green!");
            Console.ReadLine();
            Console.WriteLine("Kroton: Now, allow me to explain why I believe Green is the perfect color.");
            Console.ReadLine();
            Console.WriteLine("Kroton: All around, I see it \nWatching the river flow with me \nThe big rocks where I'd sit \nWith grass, leaves, and trees so free");
            Console.ReadLine();
            Console.WriteLine("Left alone with my thoughts \nEvery so often, 6 strings \nAdmiring geese across \nAs I would play, dance, and sing");
            Console.ReadLine();
            Console.WriteLine("Journal and pencil in hand \nWriting my heart away \nBeneath a dazzling Blue sky so grand \nWhile mosquitoes had a buffet");
            Console.ReadLine();
            Console.WriteLine("This paradise became my light \nTruly, the most magical scene \nBelow a blazing Yellow sun so bright \nI too... turned Green");
            Console.ReadLine();
            Console.WriteLine("Kroton: So really, what I'm trying to say is, I prefer Green. :^)");

            Console.ReadLine();

            // Kosher (Green Faction)

            Console.WriteLine("??: Well I prefer Green too cuz I be smokin' it on the daily.");
            Console.ReadLine();
            Console.WriteLine("Kroton: Heyyyy, it's Kosher!");
            Console.ReadLine();
            Console.WriteLine("Kosher: Wassup dumbass.");
            Console.ReadLine();

            // The Average Guy (?? Faction)

            Console.WriteLine("??: SALUUUUUUTATIONNNNNNNNNNNSSSSSSSSSSSSSSSSSSSS!");
            Console.ReadLine();
            Console.WriteLine("??: It is I!");
            Console.ReadLine();
            Console.WriteLine("??: The Average Guy!!!");
            Console.ReadLine();
            Console.WriteLine("The Average Guy: Now give me 3 numbers so I can give you the average of them.");
            Console.ReadLine();

            double num01;
            double num02;
            double num03;

            Console.WriteLine("Please input a number.");
            num01 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input another number.");
            num02 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input a final number.");
            num03 = Convert.ToDouble(Console.ReadLine());

            double result = (num01 + num02 + num03) / 3;

            Console.WriteLine("The Average Guy: Aaaaaaaannnnnddd... The average is " + result + "!!!");
            Console.ReadLine();
            Console.WriteLine("The Average Guy: " + userName + ", you may now applaud.");




            Console.ReadKey();

        }

    }

}