WebApplication app = WebApplication.Create();
app.Urls.Add("https://localhost:3000");
app.Urls.Add("http://*:3000");

List<Ingredients> menu = new();

menu.Add(new() {Name="Hamburger", fullness=10, IngAmount=7, rotten=true});
menu.Add(new() {Name="Sandwich", fullness=3, IngAmount=3});
menu.Add(new() {Name="Pancakes", fullness=7, IngAmount=5});
Meals meal = new Meals();
meal.rotten=true;
meal.rotcheck();

app.MapGet("/", Answer);

app.MapGet("/menu/",() => 
{
    return menu;
    
});



app.Run();


static string Answer()
{
    return "Welcome to the resturant, add /menu to the link to see the menu";
}
