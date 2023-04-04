class Enemy
{
    public string Name { get; }
    public int Health { get; set; }
    public List<Attack> AttackList { get; }

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public void RandomAttack()
    {
        Random rnd = new Random();
        int index = rnd.Next(AttackList.Count);
        Attack attack = AttackList[index];
        Console.WriteLine(Name + " performs " + attack.Name + " and deals " + attack.DamageAmount + " damage!");
    }
}