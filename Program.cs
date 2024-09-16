/* I just want to preface this by saying I have coded in C# before. I also searched StackExchange to find the best method of coding to use here.
I ended up Experimenting with Case/Return method to choose the results.
*/


    string enjoymentLevel = GetEnjoymentLevel();

    string stadium = GetStadiumRecommendation(enjoymentLevel);

    string game = GetGameRecommendation(stadium);

    DisplayStadiumDetails(stadium, game);
    

    // Asks the user for enjoyment level and gives them a result based upon that.
    static string GetEnjoymentLevel()
    {   Console.Clear();
        Console.WriteLine("Enter your chosen level of enjoyment (Boring, Average, Fun, Epic):");
        string enjoymentLevel = Console.ReadLine().Trim();

        // This next section I learned on StackExchange. I cannot take credit for this but it only accepts 1 of the 4 answers.
        while (enjoymentLevel.ToLower() != "boring" && enjoymentLevel.ToLower() != "average" &&
               enjoymentLevel.ToLower() != "fun" && enjoymentLevel.ToLower() != "epic")
        {
            Console.WriteLine("Invalid input. Please enter one of the following: Boring, Average, Fun, Epic.");
            enjoymentLevel = Console.ReadLine().Trim();
        }

        return enjoymentLevel.ToLower();
    }

    // Picks the best stadium based on the enjoyment level. Here is where I use the Case/Return.
    static string GetStadiumRecommendation(string enjoymentLevel)
    {
        switch (enjoymentLevel)
        {
            case "boring":
                return "Neyland Stadium";
            case "average":
                return "Jordan-Hare Stadium";
            case "fun":
                return "Tiger Stadium";
            case "epic":
                return "Saban Field at Bryant-Denny Stadium";
            default:
                return ""; // This case should never be hit, It is a just in case thing that I, once again, learned from Stackexchange many months ago.
        }
    }

    // This chooses the best game to attend based on the stadium
    static string GetGameRecommendation(string stadium)
    {
        switch (stadium)
        {
            case "Neyland Stadium":
                return "vs Kent State";
            case "Jordan-Hare Stadium":
                return "vs Kentucky";
            case "Tiger Stadium":
                return "vs Alabama";
            case "Saban Field at Bryant-Denny Stadium":
                return "vs Auburn";
            default:
                return ""; // This case should never be hit
        }
    }

    // Shows the user the stadium and game details
    static void DisplayStadiumDetails(string stadium, string game)
    {
        Console.WriteLine($"You should attend the game at {stadium}. The best game to attend is {game}.");
    }
