string name = "Agata";
int age = 33;
string gender = "woman";
     
if (name == "Agata" && age >= 33) 
{

    Console.WriteLine("Kobieta poniżej 30 lat");

}
else if (gender != "woman" && age <= 33)
{
    Console.WriteLine( "Ewa, lat 33" );
}
else if (name == "Agata" && age < 33)

{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
