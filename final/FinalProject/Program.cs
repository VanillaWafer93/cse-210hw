class Program
{
    static void Main()
    {
        // Create players
        Hacker hacker = new Hacker("Hacker", "150", "Tech expert", "Player");
        Hitman hitman = new Hitman("Hitman", "150", "Silent killer", "Player");

        // Create enemies
        List<Enemy> enemies = new List<Enemy>
        {
            new Robot("Robot", "200", "Steel machine", "Enemy"),
            new Psychopath("Psychopath", "200", "Unhinged killer", "Enemy")
        };

        // Main game loop
        while (enemies.Any(e => e.DisplayHealth() > 0))
        {
            // Player chooses character each turn
            Player player = ChoosePlayer(hacker, hitman);
            Actions playerActions = new Actions(player);

            // Player chooses action
            int damage = playerActions.SelectAction();
            bool isAttack = damage > 0 && !playerActions.CurrentActionIsHeal();

            // Choose enemy to attack
            if (isAttack)
            {
                Console.WriteLine("\nEnemies:");
                for (int i = 0; i < enemies.Count; i++)
                    Console.WriteLine($"{i + 1}. {enemies[i]._name} (HP: {enemies[i].DisplayHealth()})");

                Console.WriteLine("\nChoose enemy to attack:");
                int enemyChoice = int.Parse(Console.ReadLine()) - 1;
                while (enemyChoice < 0 || enemyChoice >= enemies.Count || enemies[enemyChoice].DisplayHealth() <= 0)
                {
                    Console.WriteLine("Invalid choice, choose again:");
                    enemyChoice = int.Parse(Console.ReadLine()) - 1;
                }

                enemies[enemyChoice].TakeDamage(damage, player);
                enemies = enemies.Where(e => e.DisplayHealth() > 0).ToList();
            }

            // Enemy turn
            Console.WriteLine("\nEnemies' turn:");
            foreach (var enemy in enemies)
            {
                int enemyDmg = enemy.ActionRandomiser();
                player.TakeDamage(enemyDmg);
                if (player.DisplayHealth() <= 0)
                {
                    Console.WriteLine($"{player._name} has been defeated! Game Over.");
                    return;
                }
            }
        }

        Console.WriteLine("\nAll enemies defeated! You win!");
    }

    // Choosing character to play each turn
    static Player ChoosePlayer(Hacker hacker, Hitman hitman)
    {
        Console.WriteLine("\nChoose Player:\n1. Hacker\n2. Hitman");
        int choice = int.Parse(Console.ReadLine());
        return choice == 1 ? (Player)hacker : (Player)hitman;
    }
}