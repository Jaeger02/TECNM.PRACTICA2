using TecNM.Practica2.Core.Services;
using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Enums;

namespace TecNM.Practica2.Tests;

public class ISRServiceShould
{
    //Unit Test 1
    [Fact]
    public void ProcessISR_WhenSalaryMoreThan0_01_And_LessThan7735()
    {
        //arrange
        var expectedResult = ISRType.Range1;
        var person = new Person{salary = 3250.20f};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);

        //assert
        Assert.Equal(expectedResult, result.ISRType);
    }
    
    //Unit Test 2
    [Fact]
    public void ProcessISR_WhenSalaryMoreThan7735_01_And_LessThan65651_07()
    {
        //arrange
        var expectedResult = ISRType.Range2;
        var person = new Person{salary = 13500f};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);

        //assert
        Assert.Equal(expectedResult, result.ISRType);
    }
    
    //Unit Test 3
    [Fact]
    public void ProcessISR_WhenSalaryMoreThan65651_08_And_LessThan115375_90()
    {
        //arrange
        var expectedResult = ISRType.Range3;
        var person = new Person{salary = 70312.02f};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);

        //assert
        Assert.Equal(expectedResult, result.ISRType);
    }
    
    //Unit Test 4
    [Fact]
    public void ProcessISR_WhenSalaryMoreThan115375_91_And_LessThan134119_41()
    {
        //arrange
        var expectedResult = ISRType.Range4;
        var person = new Person{salary = 134119.41f};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);

        //assert
        Assert.Equal(expectedResult, result.ISRType);
    }
    
    //Unit Test 5
    [Fact]
    public void ProcessISR_WhenSalaryMoreThan134119_42_And_LessThan160577_65()
    {
        //arrange
        var expectedResult = ISRType.Range5;
        var person = new Person{salary = 150600.39f};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);

        //assert
        Assert.Equal(expectedResult, result.ISRType);
    }
    
    //Unit Test 6
    [Fact]
    public void ProcessISR_WhenSalaryMoreThan160577_66_And_LessThan323862_00()
    {
        //arrange
        var expectedResult = ISRType.Range6;
        var person = new Person{salary = 228456.39f};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);

        //assert
        Assert.Equal(expectedResult, result.ISRType);
    }
    
    //Unit Test 7
    [Fact]
    public void ProcessISR_WhenSalaryMoreThan323862_01_And_LessThan510451_00()
    {
        //arrange
        var expectedResult = ISRType.Range7;
        var person = new Person{salary = 499679.00f};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);

        //assert
        Assert.Equal(expectedResult, result.ISRType);
    }
    
    //Unit Test 8
    [Fact]
    public void ProcessISR_WhenSalaryMoreThan510451_01_And_LessThan974535_03()
    {
        //arrange
        var expectedResult = ISRType.Range8;
        var person = new Person{salary = 510452.01f};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);

        //assert
        Assert.Equal(expectedResult, result.ISRType);
    }
    
    //Unit Test 9
    [Fact]
    public void ProcessISR_WhenSalaryMoreThan974535_04_And_LessThan1299380_04()
    {
        //arrange
        var expectedResult = ISRType.Range9;
        var person = new Person{salary = 1123200.99f};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);

        //assert
        Assert.Equal(expectedResult, result.ISRType);
    }
    
    //Unit Test 10
    [Fact]
    public void ProcessISR_WhenSalaryMoreThan1299380_05_And_LessThan3898140_12()
    {
        //arrange
        var expectedResult = ISRType.Range10;
        var person = new Person{salary = 1299390.05f};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);

        //assert
        Assert.Equal(expectedResult, result.ISRType);
    }
    
    //Unit Test 11
    [Fact] 
    public void ProcessISR_WhenSalaryMoreThan3898140_13()
    {
        //arrange
        var expectedResult = ISRType.Range11;
        var person = new Person{salary = 5300189.07f};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);

        //assert
        Assert.Equal(expectedResult, result.ISRType);
    }
}