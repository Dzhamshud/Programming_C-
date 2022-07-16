//Защита от дурака
string s;
int n;
bool f;
do
{
    s=Console.ReadLine();
    f=int.TryParse(s,out n);
    if (f==false) System.Console.WriteLine("Wrong input!");
}
while(f==false);
System.Console.WriteLine(n);
