

var passwordGenerator = new W4._2_PWGenerator.PasswordGenerator();

Console.WriteLine("Lütfen şifreniz için istediğiniz karakter sayısını giriniz.");

var passwordLength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Şifreniz sayıları içersin mi?");

var includeNumbers = Console.ReadLine() == "E";

Console.WriteLine("Şifreniz küçük karakterleri içersin mi?");

var includeLowerCase = Console.ReadLine() == "E";

Console.WriteLine("Şifreniz büyük karakterleri içersin mi?");

var includeUpperCase = Console.ReadLine() == "E";

Console.WriteLine("Şifreniz özel karakterleri içersin mi?");

var includeSpecialChars = Console.ReadLine() == "E";

var password = passwordGenerator.Generate(passwordLength, includeNumbers, includeLowerCase, includeUpperCase, includeSpecialChars);

Console.WriteLine($"Şifreniz:{password}");

Console.ReadLine();
