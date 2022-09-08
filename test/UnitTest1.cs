namespace Store_Class;

public class UnitTest1
{
   
     [Fact]
     public void Test_exchange(){
         double[] numtest = Money.money(1234.50);
         double[] myNum = { 1, 0, 2, 0, 1, 1, 0, 2, 0, 1, 0 };
         Assert.Equal(numtest,myNum);
        }
   
}