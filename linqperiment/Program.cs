IList<int> listOfIntegers = new List<int>() { 1, 2, 3, 4, -1, -2, 8 }; // obtain the data source

IEnumerable<int> positiveIntegers = 
                        from integer in listOfIntegers
                        where integer > 0
                        select integer;  // build the query

foreach(int integer in positiveIntegers) // query execution
{
    Console.WriteLine(integer);
}