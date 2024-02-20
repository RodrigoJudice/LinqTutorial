namespace LinqTutorial.Examples;
public static class Count
{
  public static void Run()
  {
    //Count returns the number of element that meet the specific criteria
    var countOfDogs = Pets.Count(pet => pet.PetType == PetType.Dog);
    Console.WriteLine($"countOfDogs: {countOfDogs}");

    //LongCount dos the same, but returns long instead of int
    //We should this method rather than Count
    //when we expect the result to be greater than int.MaxValue (2147483647)
    var countOfPetsNamedBruce = Pets.LongCount(pet => pet.Name == "Bruce");
    Console.WriteLine($"countOfPetsNamedBruce: {countOfPetsNamedBruce}");

    //we can, of course, define more complex predicate
    var countOfAllSmallDogs = Pets.Count(pet =>
        pet.PetType == PetType.Dog &&
        pet.Weight < 10);
    Console.WriteLine($"countOfAllSmallDogs: {countOfAllSmallDogs}");

    //count of all elements
    var countOfAllElements = Pets.Count();
    Console.WriteLine($"countOfAllElements: {countOfAllElements}");
  }
}