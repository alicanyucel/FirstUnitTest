
using UniitTest.App;
using Xunit;

namespace UnitTest.Test;

public class CalculatorTest
{
    [Fact] // test edilecek metotlara attribute verdik.
    public void AddTest()
    {
        //  Arrange ilk değerlerin verildiği yer hazırlık evresi class olusumu
        int a =5;
        int b = 20;
        var calculator = new Calculator();
        //Act testin davranısı test edilen metot burada calısır
        var total = calculator.Add(a, b);
        //asert doğrulama evresi
        Assert.Equal<int>(25,total); // generic değer alıyor beklenen değer
        // fonksiyondan gelen değer
    }
}
