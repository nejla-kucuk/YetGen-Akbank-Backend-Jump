// See https://aka.ms/new-console-template for more information

using W10._0_DesingPattern;

// Uygulamada bir kez oluşturmak için kullanılır. Daha sonra yeniden çağırdığımızda eski instance gelir.

Console.WriteLine("Singleton");

ConfigurationService configurationService = ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance();

var db = configurationService.GetValue("ConnectionStrings:ExampleDb");

Console.WriteLine(db);




Console.WriteLine("\n**************************************************\n");

new MyClass();
new MyClass();
new MyClass();
new MyClass();


class MyClass
{
    // Sadece bir kez tetiklenir.
    static MyClass()
    {
        Console.WriteLine("Static Constructor!");
    }

    public MyClass()
    {
        Console.WriteLine("Instance Created!");
    }
}








