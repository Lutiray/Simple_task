Console.WriteLine("Enter your number: ");
int a = Convert.ToInt32(Console.ReadLine());
int num = 1;

while (a >= num){
    if (num % 2 == 0){
        Console.WriteLine(num);
    }
    num++;
}
