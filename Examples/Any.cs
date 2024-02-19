namespace LinqTutorial.Examples
{
    public static class Any
    {
        public static void Run()
        {
            var numbers = new[] { 10, 1, 4, 17, 122 };
            bool isAnyLargerThan10 = numbers.Any(n => n > 10);
            isAnyLargerThan10.Dump("isAnyLargerThan10");

            var isAnyPetNamedBruce = Pets.Any(p => p.Name == "Bruce");
            isAnyPetNamedBruce.Dump("isAnyPetNamedBruce");

            var isAnyFish = Pets.Any(p => p.PetType == PetType.Fish);
            isAnyFish.Dump("isAnyFish");

            var isThereASpecificPet = Pets.Any(pet => pet.Name.Length > 6 && pet.Id % 2 == 0);
            isThereASpecificPet.Dump("isThereASpecificPet");

            var isNotEmpty = Pets.Any();
            isNotEmpty.Dump("isNotEmpty");
        }
    }
}
