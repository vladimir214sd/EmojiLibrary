using EmojiLibrary;
using System.ComponentModel;
namespace TestEmoji;

[TestClass]
public class TestEmoji
{
    [TestMethod]
    public void TestMethod1()
    {
        //Arrange
        Pokemon expected = new Pokemon(52, 232, 44);
        //Act
        Pokemon actual = new Pokemon(52, 232, 44);
        //Assert
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void TestMethod2()
    {
        //Arrange
        Pokemon expected = new Pokemon();
        //Act
        Pokemon actual = new Pokemon(0, 0, 0);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod3()
    {
        //Arrange
        Pokemon expected = new Pokemon(5555, 55555, 5555);
        //Act
        Pokemon actual = new Pokemon(414, 396, 496);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod4()
    {
        //Arrange
        Pokemon expected = new Pokemon(50, 50, 50);
        expected.IncreaseStats(1, 2, 4);
        //Act
        Pokemon actual = new Pokemon(51, 52, 54);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod5()
    {
        //Arrange
        Pokemon expected = new Pokemon(50, 50, 50);
        Pokemon.IncreaseStats(expected, 1, 2, 4);
        //Act
        Pokemon actual = new Pokemon(51, 52, 54);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod6()
    {
        //Arrange
        Pokemon expected = new Pokemon(100, 100, 100);
        --expected;
        //Act
        Pokemon actual = new Pokemon(100, 100, 99);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod7()
    {
        Pokemon expected = new Pokemon(95, 100, 105);
        expected = ~expected;

        Assert.AreEqual(expected.CombatPower, 973.46);
    }
    [TestMethod]
    public void TestMethod8()
    {
        //Arrange
        Pokemon expected = new Pokemon(50, 60, 70);
        expected = expected >> 2;
        //Act
        Pokemon actual = new Pokemon(50, 60, 72);
        //Assert
        Assert.AreEqual(expected.Stamina, actual.Stamina);
    }
    [TestMethod]
    public void TestMethod9()
    {
        //Arrange
        Emoji expected = new Emoji();
        //Act
        Emoji actual = new Emoji("NoName", "<NoTag>", 1);
        //Assert                      
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod10()
    {
        //Arrange
        Emoji expected = new Emoji("NoName", "<NoTag>", 1);
        //Act
        Emoji actual = (Emoji)expected.ShallowCopy();
        //Assert                      
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod11()
    {
        //Arrange
        Emoji expected = new Emoji("NoName", "<NoTag>", 1);
        //Act
        Emoji actual = (Emoji)expected.Clone();
        //Assert                      
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod12()
    {
        //Arrange
        Emoji expected = new Emoji("NoName", "<NoTag>", -100);
        //Act
        Emoji actual = new Emoji("NoName", "<NoTag>", 0);
        //Assert                      
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod13()
    {
        //Arrange
        Emoji expected = new Emoji("NoName", "<NoTag>", 1);
        //Act
        Emoji actual = new Emoji("NoName", "<NoTag>", 1);
        //Assert                      
        bool result = expected.Equals(actual);
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void TestMethod14()
    {
        //Arrange
        Emoji expected = new Emoji("NoName", "<NoTag>", 1);
        //Act
        Emoji actual = new Emoji("Happy", "<Tag>", 2);
        //Assert                      
        bool result = expected.Equals(actual);
        Assert.IsFalse(result);
    }
    [TestMethod]
    public void TestMethod15()
    {
        //Arrange
        Emoji expected = new Emoji("NoName", "<NoTag>", 1);
        //Act
        Emoji actual = new Emoji("NoName", "<NoTag>", 1);
        //Assert                      
        int result = expected.CompareTo(actual);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestMethod16()
    {
        //Arrange
        Emoji expected = new Emoji("NoName", "<NoTag>", 1);
        //Act
        Emoji actual = new Emoji("Name", "<NoTag>", 1);
        //Assert                      
        int result = expected.CompareTo(actual);
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void TestMethod17()
    {
        //Arrange
        Emoji expected = new Emoji("Name", "<NoTag>", 1);
        //Act
        Emoji actual = new Emoji("NoName", "<NoTag>", 1);
        //Assert                      
        int result = expected.CompareTo(actual);
        Assert.AreEqual(-1, result);
    }
    [TestMethod]
    public void TestMethod18()
    {
        // Arrange
        Animal expected = new Animal();
        // Act
        Animal actual = new Animal("NoName", "<NoTag>", 1, "NoPart");
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod19()
    {
        // Arrange
        Animal expected = new Animal("NoName", "<NoTag>", 1, "NoPart");
        // Act
        Animal actual = (Animal)expected.ShallowCopy();
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod20()
    {
        // Arrange
        Animal expected = new Animal("NoName", "<NoTag>", 1, "NoPart");
        // Act
        Animal actual = (Animal)expected.Clone();
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod21()
    {
        // Arrange
        Animal expected = new Animal("NoName", "<NoTag>", -100, "NoPart");
        // Act
        Animal actual = new Animal("NoName", "<NoTag>", 0, "NoPart");
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod22()
    {
        // Arrange
        Animal expected = new Animal("NoName", "<NoTag>", 1, "NoPart");
        // Act
        Animal actual = new Animal("NoName", "<NoTag>", 1, "NoPart");
        // Assert
        bool result = expected.Equals(actual);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod23()
    {
        // Arrange
        Animal expected = new Animal("NoName", "<NoTag>", 1, "NoPart");
        // Act
        Animal actual = new Animal("Happy", "<Tag>", 2, "NoPart");
        // Assert
        bool result = expected.Equals(actual);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod24()
    {
        // Arrange
        Animal expected = new Animal("NoName", "<NoTag>", 1, "NoPart");
        // Act
        Animal actual = new Animal("NoName", "<NoTag>", 1, "NoPart");
        // Assert
        int result = expected.CompareTo(actual);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestMethod25()
    {
        // Arrange
        Animal expected = new Animal("NoName", "<NoTag>", 1, "NoPart");
        // Act
        Animal actual = new Animal("Name", "<NoTag>", 1, "NoPart");
        // Assert
        int result = expected.CompareTo(actual);
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void TestMethod26()
    {
        // Arrange
        Animal expected = new Animal("Name", "<NoTag>", 1, "NoPart");
        // Act
        Animal actual = new Animal("NoName", "<NoTag>", 1, "NoPart");
        // Assert
        int result = expected.CompareTo(actual);
        Assert.AreEqual(-1, result);
    }
    [TestMethod]
    public void TestMethod27()
    {
        // Arrange
        Face expected = new Face();
        // Act
        Face actual = new Face("NoName", "<NoTag>", 1, 0, ":)");
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod28()
    {
        // Arrange
        Face expected = new Face("NoName", "<NoTag>", 1, 0, ":)");
        // Act
        Face actual = (Face)expected.ShallowCopy();
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod29()
    {
        // Arrange
        Face expected = new Face("NoName", "<NoTag>", 1, 0, ":)");
        // Act
        Face actual = (Face)expected.Clone();
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod30()
    {
        // Arrange
        Face expected = new Face("NoName", "<NoTag>", -100, 0, ":)");
        // Act
        Face actual = new Face("NoName", "<NoTag>", 0, 0, ":)");
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod31()
    {
        // Arrange
        Face expected = new Face("NoName", "<NoTag>", 1, 5, ":)");
        // Act
        Face actual = new Face("NoName", "<NoTag>", 1, 5, ":)");
        // Assert
        bool result = expected.Equals(actual);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod32()
    {
        // Arrange
        Face expected = new Face("NoName", "<NoTag>", 1, 5, ":)");
        // Act
        Face actual = new Face("Happy", "<Tag>", 2, 8, ":D");
        // Assert
        bool result = expected.Equals(actual);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod33()
    {
        // Arrange
        Face expected = new Face("NoName", "<NoTag>", 1, 5, ":)");
        // Act
        Face actual = new Face("NoName", "<NoTag>", 1, 5, ":)");
        // Assert
        int result = expected.CompareTo(actual);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestMethod34()
    {
        // Arrange
        Face expected = new Face("NoName", "<NoTag>", 1, 5, ":)");
        // Act
        Face actual = new Face("Smile", "<NoTag>", 1, 7, ":)");
        // Assert
        int result = expected.CompareTo(actual);
        Assert.AreEqual(-1, result);
    }

    [TestMethod]
    public void TestMethod35()
    {
        // Arrange
        Face expected = new Face("Smile", "<NoTag>", 1, 7, ":)");
        // Act
        Face actual = new Face("NoName", "<NoTag>", 1, 5, ":)");
        // Assert
        int result = expected.CompareTo(actual);
        Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void TestMethod36()
    {
        // Arrange
        Smiling expected = new Smiling();
        // Act
        Smiling actual = new Smiling("NoName", "<NoTag>", 1, 0, ":)", "NoReason");
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod37()
    {
        // Arrange
        Smiling expected = new Smiling("NoName", "<NoTag>", 1, 0, ":)", "noreason");
        // Act
        Smiling actual = (Smiling)expected.ShallowCopy();
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod38()
    {
        // Arrange
        Smiling expected = new Smiling("NoName", "<NoTag>", 1, 0, ":)", "noreason");
        // Act
        Smiling actual = (Smiling)expected.Clone();
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod40()
    {
        // Arrange
        Smiling expected = new Smiling("NoName", "<NoTag>", 1, 5, ":)", "noreason");
        // Act
        Smiling actual = new Smiling("NoName", "<NoTag>", 1, 5, ":)", "noreason");
        // Assert
        bool result = expected.Equals(actual);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod41()
    {
        // Arrange
        Smiling expected = new Smiling("NoName", "<NoTag>", 1, 5, ":)", "noreason");
        // Act
        Smiling actual = new Smiling("Happy", "<Tag>", 2, 8, ":D", "noreason");
        // Assert
        bool result = expected.Equals(actual);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod42()
    {
        // Arrange
        Smiling expected = new Smiling("NoName", "<NoTag>", 1, 5, ":)", "noreason");
        // Act
        Smiling actual = new Smiling("NoName", "<NoTag>", 1, 5, ":)", "noreason");
        // Assert
        int result = expected.CompareTo(actual);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestMethod43()
    {
        // Arrange
        Smiling expected = new Smiling("NoName", "<NoTag>", 1, 5, ":)", "noreason");
        // Act
        Smiling actual = new Smiling("Smile", "<NoTag>", 1, 7, ":)", "noreason");
        // Assert
        int result = expected.CompareTo(actual);
        Assert.AreEqual(-1, result);
    }

    [TestMethod]
    public void TestMethod44()
    {
        // Arrange
        Smiling expected = new Smiling("Smile", "<NoTag>", 1, 7, ":)", "noreason");
        // Act
        Smiling actual = new Smiling("NoName", "<NoTag>", 1, 5, ":)", "noreason");
        // Assert
        int result = expected.CompareTo(actual);
        Assert.AreEqual(1, result);
    }
}