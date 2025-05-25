using System;

namespace bossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string DamageHeroCommand = "бить";
            const string FireBallCommand ="огненный шар";
            const string BangCommand = "взрыв";
            const string RehabCommand = "лечение";

            int healthBoss = 100;
            int damageBoss1 = 20;
            int damageBoss2;
            int maxDamageBoss = 10;
            
            int healthHero = 100;
            int manaHero = 100;
            int healthHeroMax = healthHero;
            int manaHeroMax = manaHero;

            int damageHero = 10;
            int damageFireBall = 15;
            int damageBang = 20;
            int spendManaFireBall = 20;

            int factorHealth = 2;
            int limitRehab = 3;
            
            bool canUseBang = false;
            
            Console.WriteLine($" У вас {healthHero} здоровья и {manaHero} маны. \n У босса {healthBoss} здоровья. \n В вашем арсенале: атака с руки, 2 магических скилла и лечение. " +
                $"\n Чтобы применить определенное действие нужно написать команду." +
                $"\n 1. Обычная атака - '{DamageHeroCommand}'. Урон - {damageHero}  \n 2. Огненный шар - '{FireBallCommand}'. Урон - {damageFireBall}  Тратится мана при применении - {spendManaFireBall}" +
                $"\n 3. Взрыв - '{BangCommand}'. Урон - {damageBang}. Можно вызывать, только если был использован огненный шар. Для повторного применения надо повторно использовать огненный шар." +
                $"\n 4. Лечение - '{RehabCommand}'. Восстанавливает здоровье и ману, но не больше их максимального значения. Можно использовать {limitRehab} число раз." +
                $"\n\n Каждый ход босс наносит различный урон до {maxDamageBoss}. Если вы совершите ошибку при использовании своих скиллов, то босс наносит дополнительный урон - {damageBoss1}. " +
                $"\n Возможна ничья, если после хода не останется здоровья у вас и у врага.");

            while (healthHero >= 0 || healthBoss >=0)
            {
                Console.WriteLine($" \n\n Здоровье - {healthHero} \n Мана - {manaHero} \n \n Здоровье босса - {healthBoss}");

                int rehabHealth = (healthHeroMax - healthHero) / factorHealth;
                int rehabMana = (manaHeroMax - manaHero) / factorHealth;
                bool canBossAttack = false;

                Console.Write("\n\n Введите скилл: ");
                string commandHero = Console.ReadLine();
            
                switch (commandHero)
                {
                    case DamageHeroCommand:
                        healthBoss -= damageHero;

                        Console.WriteLine($"\n Вы нанесли урон {damageHero}");
                        break;

                    case FireBallCommand:
                        if (spendManaFireBall <= manaHero)
                        {
                            healthBoss -= damageFireBall;
                            manaHero -= spendManaFireBall;
                            canUseBang = true;

                            Console.WriteLine($"\n Огненным шаром нанесли урон - {damageFireBall}. Потрачено маны - {spendManaFireBall}");
                        }
                        else
                        {
                             canBossAttack = true;

                             Console.WriteLine($"\n У вас недостаточно маны для Огненного шара");
                        }
                        break;

                    case BangCommand:
                        if(canUseBang)
                        {
                            healthBoss -= damageBang;
                            canUseBang = false;

                            Console.WriteLine($"\n Взрывом нанесли урон - {damageBang}");
                        }
                        else
                        {
                            canBossAttack = true;

                            Console.WriteLine("\n Вы не можете использовать Взрыв, так как вы не использовали Огненный шар");
                        }
                        break;

                    case RehabCommand:
                        if (limitRehab > 0)
                        {
                            healthHero += rehabHealth;
                            manaHero += rehabMana;
                            limitRehab --;

                            Console.WriteLine($"\n Здоровье и мана восстановлены \n У вас {limitRehab} заряда для восстановаления. \n Вы получили {rehabHealth} здоровья и {rehabMana} маны");
                        }
                        else
                        {
                            Console.WriteLine("\n У вас нет возможности для восстановления здоровья и маны");
                        }
                        break;

                    default:
                        canBossAttack = true;
                        break;
                }

                if (canBossAttack)
                {
                    healthHero -= damageBoss1;
                    Console.WriteLine($"\n Из-за вашей неосторожности вам нанесли урон - {damageBoss1}");
                }

                Random random = new Random();
                damageBoss2 = random.Next(0, maxDamageBoss + 1);
                healthHero -= damageBoss2;

                Console.WriteLine($" Босс нанес вам урон - {damageBoss2}"); 
            }
            
            if (healthBoss <= 0 && healthHero <= 0)
            {
                Console.WriteLine("\n\n\n  Ничья");
            }
            else if (healthHero <= 0)
            {
                Console.WriteLine("\n\n\n  Босс победил");
            }
            else if (healthBoss <= 0)
            {
                Console.WriteLine("\n\n\n  Вы победили");
            }
        }
    }
}
