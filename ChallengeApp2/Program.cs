string name = "Ewa";
int age = 33;
string gender = "woman";

if (name == "Ewa" && age < 33)
{

    Console.WriteLine("Kobieta poniżej 30 lat");

}
else if (gender != "woman" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (name == "Ewa" && age == 33)

{
    Console.WriteLine("Ewa,lat 33");
}