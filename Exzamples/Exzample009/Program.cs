int [] array = { 1, 12, 23, 4, 15, 56, 77, 18, 29};

int n = array.Length;
int find = 23;
int index = 0;
while(index < n)
{
    if(array[index]==find)
    Console.WriteLine(index);
    index++;
}