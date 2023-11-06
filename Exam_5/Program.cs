
using Exam_5;
using System.Linq;

// ---------------------------- LINQ 1 -----------------------------------//

List<Product> products = new List<Product>()
{
    new Product(){Id =  1, Name = "Olma", Narxi = 51000},
    new Product(){Id = 2,Name = "Shaftoli", Narxi = 30000},
    new Product(){Id = 3,Name = "Banan",Narxi = 60000},
    new Product(){Id = 4,Name = "Kiwi",Narxi = 25000},
    new Product(){Id = 5,Name = "Nok",Narxi = 10000}
};

//-----------------problem 1 ----------------------//
/*var result = from i in products
             where i.Narxi < 50000
             select i;
foreach (var product in result)
{
    Console.WriteLine($"Name - {product.Name}  ||  Narxi - {product.Narxi} ");
}*/

//-----------------problem 2 ----------------------//
/*var result = products.OrderByDescending(p => p.Narxi).FirstOrDefault();
Console.WriteLine($"Name - {result.Name} || narxi - { result.Narxi}");
*/
//-----------------problem 3 ----------------------//



// ---------------------------- LINQ 3 -----------------------------------//

//-----------------problem 1 ----------------------//
/*
int[] son = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var Juft = from i in son
           where i%2 == 0
           select i;
int sum =0;
foreach(var p in Juft)
{
    sum += p;
}
Console.WriteLine(sum);

*/

//-----------------problem 2 ----------------------//

List<User> users = new List<User>()
{ 
    new User{Id = 1,ismi = "Sarvar",familiyasi = "Gulomjonov",Address = "Andijon",buyurtmalar_soni = 2},
    new User{Id = 1,ismi = "Sardor",familiyasi = "Gulomjonov",Address = "Andijon",buyurtmalar_soni = 5},
    new User{Id = 1,ismi = "Abdulla",familiyasi = "Abdullaev",Address = "Andijon",buyurtmalar_soni = 3},
    new User{Id = 1,ismi = "Bahriddin",familiyasi = "Abdusalomov",Address = "Fargona",buyurtmalar_soni = 1},
    new User{Id = 1,ismi = "Boburbek",familiyasi = "Turginboev",Address = "Angren",buyurtmalar_soni = 4}
};

/* var result = users
            .GroupBy(u => new { u.ismi, u.familiyasi })
            .Select(g => g.First())
            .ToList();

foreach (var user in result)
{
    Console.WriteLine($"Ismi: {user.ismi}, Familiyasi: {user.familiyasi}");
}
*/

//-----------------problem 3 ----------------------//

List<Oquvchi> oquvchis = new List<Oquvchi>()
{
    new Oquvchi(){Id = 1,Name = "Sarvar",DarsName = "Adabiyot",age = 20},
    new Oquvchi(){Id = 2,Name = "Bahriddin",DarsName = "Kimyo",age=20},
    new Oquvchi(){Id = 3,Name = "Sardor",DarsName = "Ona-tili",age = 19}
};
/*
var result  = oquvchis.GroupBy(i => new { i.Name, i.DarsName })
                      .Select(n => n.First())
                      .ToList();
foreach (var item in result)
{
    Console.WriteLine($"ismi: {item.Name}, DarsNomi: {item.DarsName}");
}
*/
//-----------------problem 4 ----------------------//




// ---------------------------- LINQ 4 -----------------------------------//

//-----------------problem 1 ----------------------//
/*int[] son = { 15, 2, 33, 14, 0,25, 65, 7, 68, 9, 160 };

var result = from i in son
             orderby i ascending
             select i;
foreach(var s in result)
{
    Console.WriteLine(s);
}
*/
//-----------------problem 2 ----------------------//

/*var result  = from mijoz in users
              orderby mijoz.familiyasi ascending
              select mijoz;
foreach(var item in result)
{
    Console.WriteLine(item.familiyasi);
}

*/

//-----------------problem 3 ----------------------//

/*var result = from i in products
             orderby i.Narxi descending
             select i;
var group = result.GroupBy(i => new{i.Id,i.Name,i.Narxi})
                  .Select(n =>n.First())
                  .ToList();
foreach (var item in group)
{
    Console.WriteLine($"Id = {item.Id},Name = {item.Name},Narxi = {item.Narxi}");
}*/

//-----------------problem 4 ----------------------//

/*var result = from i in users
             orderby i.buyurtmalar_soni descending
             select i;
foreach(var i in result)
{
    Console.WriteLine($"id:{i.Id},ismi:{i.ismi},address:{i.Address},buyurtma_soni:{i.buyurtmalar_soni}");
}
*/


// ---------------------------- LINQ 5 -----------------------------------//


//-----------------problem 1 ----------------------//
object[] son = { 1, "sarvar", 2, "sardor", 4, 5, 6 };
/* 


var sonlar = son.OfType<int>().ToList();
var matnlar = son.OfType<string>().ToList();

Console.WriteLine("Sonlar:");
foreach (var s in sonlar)
{
    Console.WriteLine(s);
}

Console.WriteLine("Matnlar:");
foreach (var m in matnlar)
{
    Console.WriteLine(m);
}
*/

//-----------------problem 2 ----------------------//
/*
var sonlar = son.OfType<int>().ToList();
Console.WriteLine("Sonlar:");
foreach (var s in sonlar)
{
    Console.WriteLine(s);
}*/

//-----------------problem 3 ----------------------//
/*string txt = "Bu orqali orvati orom orziq oromdagilik so'zlarni topish orqa orol";

string[] str = txt.Split(' ');

var result = str
         .Where(word => word.StartsWith("or", StringComparison.OrdinalIgnoreCase))
         .ToList();
foreach (string soz in result)
{
    Console.WriteLine(soz);
}
*/


//-----------------problem 4 ----------------------//
/*
string Text = "Bugun C# imtihonda otiribmiz";

string[] nimadur = Text.Split(' ');

var sozlar = nimadur
    .Where(x => x.Contains("a", StringComparison.OrdinalIgnoreCase))
    .ToList();

foreach (var i in sozlar)
{
    Console.WriteLine(i);
}*/



// ---------------------------- LINQ 6 -----------------------------------//

//-----------------problem 1 ----------------------//
/*
int[] son1 = { 1, 2, 3, -1, 2, 4, -6, 7 };

var result = from i in son1 
             where i>0
             select i;
Console.WriteLine("musbat sonlar");
foreach (var s in result)
{
    Console.WriteLine(s);
}*/

//-----------------problem 2 ----------------------//
/*
string str = "Bugun C# imtihonda otiribmiz Ustoz yaxshi baho qoyarsiz";
string[] nima = str.Split(' ');

var soz5dankatta = nima
    .Where(c => c.Length > 5)
    .ToList();

var soz5dankichik = nima
    .Where(x => x.Length <= 5)
    .ToList();

Console.WriteLine("5dan katta so'zlar:");
foreach (var i in soz5dankatta)
{
    Console.WriteLine(i);
}

Console.WriteLine("5 dan kichik so'zlar:");
foreach (var v in soz5dankichik)
{
    Console.WriteLine(v);
}
 */

//-----------------problem 3 ----------------------//
/*
string nima = "Bugun C# imtihonda otiribmiz Ustoz yaxshi baho qoyarsiz";

string[] s = nima.Split(' ');

var Counts = s
    .Select(word => new
    {
        Word = word,
        Count = word.Count(c => c == 'o')
    })
    .OrderBy(item => item.Count)
    .ToList();

foreach (var item in Counts)
{
    Console.WriteLine($"So'z: '{item.Word}', 'o' harfi nechta marta: {item.Count}");
}
*/


