using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructors;

public class PropsBefore
{
    public string FirstName { get; }
    public string LastName { get; set; }

public PropsBefore(string firstName, string lastName)
{
    FirstName = firstName;
    LastName = lastName;
}
}

public class PropsAfter(string firstName, string lastName)
{
    // instanciaztion
    public string FirstName { get;  } = firstName;
    public string LastName { get; set; } = lastName;
    public void Test()
    {
       Console.WriteLine($"FirstName: {FirstName}, LastName: {LastName}");
    }

}