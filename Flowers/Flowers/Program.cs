using Flowers.Models;

namespace Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Flower recordu olur və onun Name, Color, Price propları olur.
            Bucket classında isə Flower, FlowerCount, DiscountPercent propları
            GetTotalPrice() və AddFlower() methodları olur.

            AddFlower methodu Flower tipindən obyekt qəbul edir və əgər göndərilən flower Bucket obyektindəki
            Flower-ə bərabərdirsə onda Count propertysi 1 vahid artır.
            Bərabər deyilsə əlavə olunmur.
            Daha sonra Bucket obyektinin TotalPrice methodu isə
            çağırılan zaman yekun məbləği istifadəçiyə qaytarsın.
            (Əgər TotalPrice çağırılan zaman obyektdə Flower var idisə onda
            Endirim nəzərə alınmış qiymət və true qaytarsin(tuple).
            Əks halda (Flower əlavə olunmayıbsa) 0 və false qaytarsın)*/

            Flower flower1 = new Flower("Rose","White",10);
            Flower flower2 = new Flower("Lily","White",5);
            Flower flower3 = new Flower("Tulip","Red",8);
            Flower flower4 = new Flower("Iris","Purple",15);
            Flower flower5 = new Flower("Gardenia","Blue",5);
            Flower flower6 = new Flower("Columbine","White-Black",50);

            Basket basket1 = new Basket(30);
            Basket basket2 = new Basket(10);

            basket1.AddFlower(flower1);
            basket1.AddFlower(flower1);
            basket1.AddFlower(flower1);
            basket1.AddFlower(flower2);
            Console.WriteLine(basket1.FlowerCount);
            Console.WriteLine(basket1.TotalPrice());
        }
    }
}