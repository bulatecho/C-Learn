class WhereSample
{
     static void Main()
     int[] numbers = {5, 4, 1, 3, 9, 8, 1};

     //Simple query with one predicate in where clause
     var queryLowNums = 
        from num in numbers
        where num < 5 
        select num;
}
