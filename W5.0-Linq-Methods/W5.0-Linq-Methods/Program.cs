
using W5._0_Linq_Methods;

// Contact Linq Methods Example
ConcatExamplePets.ConcatExample();

Console.WriteLine("----------------------------------");

// Discint Linq Methods Example
DiscintExampleAges discintEx = new DiscintExampleAges();
discintEx.GetDistinctExample();

Console.WriteLine("----------------------------------");

// Skip Linq Methods Example
SkipExampleCity skipEx = new SkipExampleCity();
skipEx.GetSkipExample();

Console.WriteLine("----------------------------------");

// Take Linq Methods Example
TakeExampleGrades takeEx = new TakeExampleGrades();
takeEx.GetTakeExample();

