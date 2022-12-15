// известно число жителей, проживающих в каждом доме улицы. Нумерация домов проведена подряд. Две стороны чет и нечет. На какой стороне больше живет людей

int[] House = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

House[1] = 1;
House[2] = 1;
House[3] = 1;
House[4] = 1;
House[5] = 1;
House[5] = 1;
House[6] = 1;
House[7] = 1;
House[8] = 1;
House[9] = 1;
House[10] = 1;

int HouseL = House[1] + House[3] + House[5] + House[7] + House[9];
int HouseR = House[2] + House[4] + House[6] + House[8] + House[10];

if (HouseL > HouseR)
{
    Console.WriteLine($"Нечетных Больше = {HouseL}");
}
else if (HouseR > HouseL)
{
    Console.WriteLine($"Четных Больше = {HouseR}");
}
else HouseL = HouseR;
{
    Console.WriteLine($"Жителей по ровну по обе стороны");
}