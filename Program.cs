Attack fireball = new Attack("Fireball", 20);
Attack punch = new Attack("Punch", 10);
Attack throwAttack = new Attack("Throw", 15);

Enemy bandit = new Enemy("Bandit");
bandit.AttackList.Add(punch);
bandit.AttackList.Add(throwAttack);

Enemy boss = new Enemy("Boss");
boss.AttackList.Add(fireball);
boss.AttackList.Add(throwAttack);

bandit.RandomAttack();
boss.RandomAttack();