using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrimaryConstructors;


public class SimpleBefore
{
    private string _fname;
    private string _lName;
    public SimpleBefore()
    {
        _fname = "Antoine";
        _lName = "Freeman";
    }
    public SimpleBefore(string fname, string lname)
    {
        _fname = fname;
        _lName = lname;
    }
    public string GetName()
    {
        return _fname +" " + _lName;
    }

}
// fname and lname are parameters of the constructor
// available for the entire class and Become mutable

public class SimpleAfter(string fname,string lname)
{
    // to make private
    // will use privete field not the parameter passed in the constructor
    private string fname = fname;
    public string getFullName()
    {
        return $"{fname}  {lname}";
    }
    //empty constructor 
    // always have to call simpleAfter constructor
    public SimpleAfter(): this("Antoine", "Freeman")
    {
    }
}
