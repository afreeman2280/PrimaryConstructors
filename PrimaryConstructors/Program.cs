// See https://aka.ms/new-console-template for more information
using PrimaryConstructors;
using static System.Console;
WriteLine("Hello, World!");
int[] ages = { 1, 2, 3, 4, 5 };
int[] ages2 = new int[] { 1, 2, 3, 4, 5 };
int[] ages3 = new[] { 1, 2, 3, 4, 5 };
List<int> ageValues = new List<int>() { 98, 4, 22, 45 };
// Using collection expression syntax to initialize collections
int[] ages4 = [ 1, 2, 3, 4, 5 ];
List<int> ageValues2 = [ 98, 4, 22, 45];


CollectionExpression collectionExpression = new CollectionExpression(); 
collectionExpression.PrintAges(ages);
collectionExpression.PrintAges(ageValues);
collectionExpression.PrintAges(ages4);
collectionExpression.PrintAges(ageValues2);

