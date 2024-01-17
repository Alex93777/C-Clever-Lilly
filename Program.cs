int age = int.Parse(Console.ReadLine());
double loudryPrice = double.Parse(Console.ReadLine());
int priceToy = int.Parse(Console.ReadLine());

int toys = 0;
int money = 0;
int addMoney = 10;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 1)
    {
        toys += 1;
    }
    else if (i % 2 == 0)
    {
        money += addMoney;
        addMoney += 10;
        money -= 1;
    }
}

int moneyFromToys = toys * priceToy;
double totalMoneySaved = money + moneyFromToys;

if (totalMoneySaved >= loudryPrice)
{
    Console.WriteLine($"Yes! {totalMoneySaved - loudryPrice:F2}");
}
else
{
    Console.WriteLine($"No! {loudryPrice - totalMoneySaved:F2}");
}






