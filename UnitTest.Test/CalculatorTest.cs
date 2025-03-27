
using System.Runtime.CompilerServices;
using UniitTest.App;
using Xunit;

namespace UnitTest.Test;

public class CalculatorTest
{
    public Calculator Calculator { get; set; }
    public CalculatorTest()
    {
        this.Calculator = new Calculator();
    }
    [Fact] // parametre almadıgı için fact, test edilecek metotlara attribute verdik.
    public void AddTest()
    {
        //  Arrange ilk değerlerin verildiği yer hazırlık evresi class olusumu
        //int a =5;
        //int b = 20;
        //var calculator = new Calculator();
        ////Act testin davranısı test edilen metot burada calısır
        ////var total = calculator.Add(a, b);
        ////asert doğrulama evresi
        ////Assert.Equal<int>(25,total); // generic değer alıyor beklenen değer
        ////// fonksiyondan gelen değer
        /////
        ////aranan //gercek deger
        ////Assert.Contains("Ali", "Ali Can Yücel"); //gerçek değer içerisnde aranan değer varsa true döner
        ////// gerçek değer içerisinde yoksa true döner
        ////Assert.DoesNotContain("enre","ali can yücel");
        //var names = new List<string>() { "ali", "can", "yücel" };
        //Assert.Contains(names, x => x == "ali");
        // boolean olarak kıyalama yapar
        //Assert.True(5 > 2)/*;*/
        //Assert.False(5 > 33);//BAŞARILI DÖNECEK
        //// İKİ TİP AYNI OLDUGU İÇİN BAŞARILI DONECEK
        //Assert.True("".GetType() == typeof(string));
        //var regex = "^dog";
        ////içinde değer varsa başarılı
        //Assert.Matches(regex, "dog tarcın");
        // içinde regex yoksa başarısızsa yine true doner
        //Assert.DoesNotMatch(regex, "tarcın");
        //startwith ilk kelime bakar endwith son kelimeye bakar
        // aranan sey            gerçek sey
        //Assert.StartsWith("bir","bir masal");
        //Assert.EndsWith("masal","bir masal");
        //Assert.EndsWith("masal","bir masal olsun"); //false doner
        //empty bos olup olmadıgını kontrol eder notemptiy ise dolu olma durumu
        //Assert.Empty(new List<string>());// true dizi boş
        // ınrange ve notınrange elen değerin belli bir aralıkta olup olmadıgını kontrol eder
        //Assert.InRange(5, 1, 10); 5 1 ile 10 arasında başarılı
        //Assert.NotInRange(3, 5, 10); //başarılı çalısır
        //// single  tek elemanlıysa true döner
        //Assert.Single(new List<string>() { "fatih" });
        //Assert.Single<int>(new List<int> { 1 });
        // ISTYPE ISNOTTYPE içerisine alacağı parametrenin tipini kontrol eder
        //Assert.IsType<string>("alican"); // true döner
        //Assert.IsNotType<string>(1); // false döner
        //// ısAsginableFrom bir tipin bir itpe referans verebiliyorsa true aksi takdirde başarısız döner
        //Assert.IsAssignableFrom<IEnumerable<string>>(new List<string>()); başarılı döner
        //Assert.IsAssignableFrom<Object>("ALİCAN"); //TRUE /*DÖNER*/
        // Bütün veri tiplerinin en ustu objectdir
        // null notnull
        //string deger = null;
        //Assert.Null(deger); // geriye true döner
        //string deger = null;
        //Assert.NotNull(deger); // test basarısız olur 
        //Assert.Equal<int>(2, 2); // gerçek değer 2 si sğadaki gerçek değer soldaki bizimkisi true
        //Assert.NotEqual<int>(2, 2); // test basarısız olıur
        // test metodarın parametre alma durumu
        // fact parametresiz
        //[Fact]
        //    [Theory]
        //    [InlineData](1,2,4)


    }
    //[Theory]
    //[InlineData(1,2,3)]
    //public void AddTest2(int a, int b, int c)
    //{
    //    var calculator=new Calculator();
    //    var actualTotal = calculator.Add(a, b);
    //    Assert.Equal(c,actualTotal);
    //}
    [Theory]
    [InlineData(0, 5, 0)]
    [InlineData(10, 0, 1)]
    public void Add_ZeroValues_ReturnZeroValue(int a,in int b,int c)
    {
        var actualTotal = Calculator.Add(a,b);
        Assert.Equal(0, actualTotal);
    }
}
