// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void NatDegree(int A, int B)
{
    int deg = 1;
    for (int i=0; i<B; i++)
    {
        deg*=A;
    }
    Console.WriteLine("{0} ^ {1} = {2}", A, B, deg);
}

NatDegree(3, 5);
NatDegree(2, 4);
