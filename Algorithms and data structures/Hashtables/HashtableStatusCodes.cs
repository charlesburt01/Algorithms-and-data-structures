#region status codes
using System.Collections;
Hashtable hashtable = new Hashtable()
{
    { 200, "Okay" },
    { 301, "Moved Permanently" },
    { 401, "Unauthorised" },
    { 404, "Not found" },
    { 500, "Internal Server Error" }
};

string GetStatusMeaning(int number)
{
    return (string)hashtable[number];
}

Console.WriteLine(GetStatusMeaning(401));

#endregion
