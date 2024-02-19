namespace LinqTutorial.Examples
{
    public static class All
    {
        public static void Run()
        {
            var numbers = new[] { 10, 1, 4, 17, 122 };

            var allGreaterThan0 = numbers.All(n => n > 0);
            allGreaterThan0.Dump("allGreaterThan0");

            var doAllHaveNonEmptyNames = Pets.All(p => !string.IsNullOrEmpty(p.Name));
            doAllHaveNonEmptyNames.Dump("doAllHaveNonEmptyNames");

            var doAllCats = Pets.All(p => p.PetType == PetType.Cat);
            doAllCats.Dump("doAllCats");

            var AllPetTypes = Enum.GetValues(typeof(PetType)).Cast<PetType>();

            var doAllHaveSamePetType = AllPetTypes.Any(pt => Pets.All(p => p.PetType == pt));
            doAllHaveSamePetType.Dump("doAllHaveSamePetType");
<<<<<<< HEAD
            var AreAllPetNameSameLength = Pets.All(p => p.Name.Length == Pets.First().Name.Length);
            AreAllPetNameSameLength.Dump("AreAllPetNameSameLength");
=======


            var AreAllPetNameSameLength = Pets.All(p => p.Name.Length == Pets.First().Name.Length);
            AreAllPetNameSameLength.Dump("AreAllPetNameSameLength");

>>>>>>> cfc42da (Add AreAllPetNameSameLength)
        }
    }
}
