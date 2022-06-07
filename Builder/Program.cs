//The intent of the Builder design pattern is to separate the construction of a complex object from its representation.
//https://en.wikipedia.org/wiki/Builder_pattern
//How can a class (the same construction process) create different representations of a complex object?

//    Creating and assembling the parts of a complex object directly within a class is inflexible.
//    It commits the class to creating a particular representation of the complex object and makes
//    it impossible to change the representation later independently from (without having to change) the class.
//    The Builder design pattern describes how to solve such problems:

//Encapsulate creating and assembling the parts of a complex object in a separate Builder object.
//A class delegates object creation to a Builder object instead of creating the objects directly.
//A class (the same construction process) can delegate to different Builder objects
//to create different representations of a complex object.

// create a type of object with different configurations while keeping immutability of class
// can be combined with e.g. Singleton?
namespace Builder;
class Program
{
    public static void Main()
    {
        Plant.PlantBuilder();
    }
}
