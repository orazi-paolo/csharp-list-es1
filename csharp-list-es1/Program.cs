// istanzio una lista di interi
List<int> numeri = new List<int> { 5, 7, 2, 8, 3 };
// inizializzo le variabili max e min con il primo elemento della lista
int max = numeri[0];
int min = numeri[0];
// ciclo la lista e confronto ogni elemento con max e min
foreach (int num in numeri)
{
    if (max <= num)
    {
        max = num;
    }
    else if (min >= num)
    {
        min = num;
    }
}
// stampo i risultati
Console.WriteLine($"Il numero più grande è: {max}");
Console.WriteLine($"Il numero più piccolo è: {min}");