
using W3._1_Freelancer.Entities;
using W3._1_Freelancer.Service;

/*
Job job = new Job();
job.FirstName = "Nejla";
job.LastName = "YetGen";
*/

// File.WriteAllText("C:\\Users\\Asus\\source\\repos\\W3.1-Freelancer\\W3.1-Freelancer\\Database\\Deneme.txt", "deneme");


var customer1 = new Customer()
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTime.Now,
    FirstName = "Nejla",
    LastName = "YetGen",
    PhoneNumber = "1234567890"
};


NotepadService notepadService = new NotepadService();
//notepadService.SaveToNotepad(customer);

string customerData = notepadService.GetOnNotepad("C:\\Users\\Asus\\source\\repos\\W3.1-Freelancer\\W3.1-Freelancer\\Database\\Customer.txt");

string[] splittedLines = customerData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();

foreach (var line in splittedLines)
{
    Customer customer = new();
    customer.SetValuesCSV(line);
    customers.Add(customer);
}