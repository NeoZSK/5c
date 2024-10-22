Group g1 = new Group("5c", 20, "First Teacher", new string[10]);
Group g2 = new Group("5b", 20, "Second Teacher", new string[10]);



Console.WriteLine(GameChoices.SCISSORS + 1);
enum GameChoices
{
    PAPER, ROCK, SCISSORS
}

class Group(string name, int count, string mainTeacher, Array students)
{
    public string Name { get; private set; } = name;
    public int Count { get; private set; } = count;
    public string MainTeacher { get; private set; } = mainTeacher;
    public Array Students { get; private set; } = students;


    public Group Fight(Group target)
    {
        GameChoices choice1 = this.Choose();
        GameChoices choice2 = target.Choose();
        Console.WriteLine(choice1);
        Console.WriteLine(choice2);

        if (choice1 == choice2)
            return target;


        if ((((int)choice1 + 1) % 3) == (int)choice2)
            return this;
        else
            return target;
    }

    private GameChoices Choose()
    {
        Random r = new Random();
        int maxValue = Enum.GetValues(typeof(GameChoices)).Length;
        return (GameChoices)r.Next(maxValue);
    }
}






