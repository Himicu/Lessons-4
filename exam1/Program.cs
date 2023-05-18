//методы и функции

// void SayLang(string name){
//     Console.WriteLine($"привет, {name}");
// }
// SayLang("python");
// SayLang("c#");
// string lang = "c++";
// SayLang(lang);

int SayMax(int num1, int num2){
    if(num1 > num2) return num1;
    else return num2;
}
//один из вариантов вывода
Console.WriteLine(SayMax(3, 5));
//второй вариант вывода
int num = SayMax(4, 7);
Console.WriteLine(num);
//и еще один вариант
int x = 9, y = 6, num1 = SayMax(x, y);
Console.WriteLine(num1);