using System;

public class Actions
{
    private Character _character;
    private List<Func<int>> _characterActions;
    private List<string> _actionNames;
    private int _lastActionIndex = -1;

    public Actions(Character character)
    {
        _character = character;

        _characterActions = new List<Func<int>>();
        _actionNames = new List<string>();

        // Basic Attack
        _characterActions.Add(() => _character.BasicAttack(20));
        _actionNames.Add("Basic Attack");

        // Special Attack
        _characterActions.Add(() => _character.SpecialAttack());
        _actionNames.Add("Special Attack");

        // Heal
        _characterActions.Add(() => _character.Heal());
        _actionNames.Add("Heal");
    }

    // Display and selection
    public int SelectAction()
    {
        Console.WriteLine("\nChoose an action:");
        for (int i = 0; i < _actionNames.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_actionNames[i]}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        while (choice < 0 || choice >= _actionNames.Count)
        {
            Console.WriteLine("Invalid choice, choose again:");
            choice = int.Parse(Console.ReadLine()) - 1;
        }

        // _lastActionIndex = choice;
        int result = _characterActions[choice]();

        return (_actionNames[choice] == "Heal") ? 0 : result; 
    }

    // Check if last action was Heal
    public bool CurrentActionIsHeal()
    {
        return _lastActionIndex == 2; 
    }

    public List<string> GetActionNames()
    {
        return _actionNames;
    }
}