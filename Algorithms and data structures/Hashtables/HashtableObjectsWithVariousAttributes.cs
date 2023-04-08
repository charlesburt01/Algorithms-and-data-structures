#region objects with various attributes
using System.Collections;
Hashtable dogHashTable = new Hashtable()
{
    {
        "Fido", new Hashtable()
        {
            { "Name", "Fido" },
            { "Breed", "Pug" },
            { "Age", 3 }
        }
    },
    {
        "Rufus", new Hashtable()
        {
            { "Name", "Rufus" },
            { "Breed", "Sausage" },
            { "Age", 1 }
        }
    },
    {
        "Pizza", new List<string>() // as a hastable returns type of object, its not type safe, (system.collections.generics are type safe, i.e. List<string> is a generic collection, which enforces the type <string> and belongs to System.Collections.Generics, however Hashtable belongs to System.Collections which are not type safe, so they allow any types, which all derive from object, this means that the complier doesn't know what type is being returned, so you have to cast it back to the type explicitly as you will see below
        {
            "Mighty Meaty",
            "Sizzler"
        }
    }
};
//Below you have to cast the returned type to what it is, so the complier knows... you can see we have used (Hashtable) on the first result of dogHashTable, so we can access the value contained inside the second hashtable, as this is a hashtable of 2 hashtables and 1 List<string> generic collection
if (dogHashTable["Fido"] is Hashtable)
{
    Console.WriteLine(((Hashtable)dogHashTable["Fido"])["Name"]); // Output: Fido
    Console.WriteLine(((Hashtable)dogHashTable["Fido"])["Breed"]); // Output: Pug
    Console.WriteLine(((Hashtable)dogHashTable["Fido"])["Age"]); // Output: 3
}
if (dogHashTable["Rufus"] is Hashtable)
{
    Console.WriteLine(((Hashtable)dogHashTable["Rufus"])["Name"]); // Output: Rufus
    Console.WriteLine(((Hashtable)dogHashTable["Rufus"])["Breed"]); // Output: Sausage
    Console.WriteLine(((Hashtable)dogHashTable["Rufus"])["Age"]); // Output: 1
}
//whats really interesting is that when using a hashtable, as its not type safe, you have to make sure the collection's type is of the type you are looking for, above, we have done this above and below to check to see if the dogHashTable["Pizza"] is in fact the type we want. The likely reason we do this is that there are other types of collections inside the hashtable collection (2 hashtables and a list<string> ) and perhaps the types inside the dogHashTable will change over time, so we need to be type safe about it.
if (dogHashTable["Pizza"] is List<string> pizzaList)
{
    foreach (string pizza in pizzaList)
    {
        Console.WriteLine(pizza);
    }
}
else
{
    Console.WriteLine("Pizza key not found or is not a list of strings.");
}



#endregion#region status codes
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
