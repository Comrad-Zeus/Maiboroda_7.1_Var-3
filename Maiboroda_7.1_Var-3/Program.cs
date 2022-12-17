// Майборода А.А. - Вар 3 - Высокий
var userString = Console.ReadLine().ToUpper().ToCharArray();

var isPalindrome = true;
for (var index = 0; index < userString.Length / 2; index++)
{
    if (userString[index] != userString[userString.Length - 1 - index])
        isPalindrome = false;
}

Console.WriteLine(isPalindrome);