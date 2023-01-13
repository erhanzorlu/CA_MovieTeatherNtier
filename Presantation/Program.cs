using Bll.Repository.Concrete;
using Dal.Entity;

CategoryRepository cr = new CategoryRepository();


//Category c = new Category() { CategoryName="Korku" };
//Console.WriteLine(cr.Create(c));

Category category = new Category() {ID=1, CategoryName="Komedi"};
string resault = cr.Update(category);
Console.WriteLine(resault);

string resaultDel = cr.Delete(2);
Console.WriteLine(resaultDel);


foreach (var item in cr.GetAll())
{
    Console.WriteLine(item.ID +" "+ item.CategoryName);

}

Console.Read();


