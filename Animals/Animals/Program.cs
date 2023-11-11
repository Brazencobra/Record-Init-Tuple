using Animals.Models;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Animal yaradirsiz:
            Gender, BirthYear property-leri olur. Gender dəyərini constructordan gələn dəyərdən götürməlidir. BirthYear ise constructor işə düşdükdə dinamik olaraq hal-hazırdakı ili götürməlidir(sadəcə 2022 yazmaq düz deyil) və təyin  olunduqdan sonra dəyişdirilə bilməz.

            Dog yaradırsız: 
            Name, Breed (yəni sortu  misal: Golden Retriever) property-ləri olur. Animal-dan inheritence alır. Name və Breed constructordan gəlir.
            Breed təyin olunduqdan sonra dəyişdirilə bilməməlidir  */

            //Animal animal1 = new Animal("Male");
            //Animal animal2 = new Animal("Female");

            Dog dog1 = new Dog("Male","Max","Husky");
            Dog dog2 = new Dog("Female","Skye","Golden Retriever");

        }
    }
}