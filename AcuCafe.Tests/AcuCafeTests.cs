using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcuCafe.Decorators;
using AcuCafe.Enums;

namespace AcuCafe.Tests
{
    /// <summary>
    /// Class the test methods of AcuCafe.
    /// </summary>
    [TestClass]
    public class AcuCafeTests
    {
        /// <summary>
        /// Orders the drink returns ice tea without milk when has milk is true.
        /// </summary>
        [TestMethod]
        public void OrderDrink_ReturnsIceTeaWithoutMilk_WhenHasMilkIsTrue()
        {
            //Arrange
            DrinkAddOn addOn = new DrinkAddOn();
            addOn.HasMilk = true;

            //Act
            IDrink drink = DrinkFactory.OrderDrink(DrinkType.IceTea, addOn);

            //Assert
            Assert.IsTrue(drink is IceTea);
            Assert.AreEqual("We are preparing the following drink for you: Ice tea without sugar", drink.Description);
            Assert.AreEqual(1.5, drink.GetCost());
        }

        /// <summary>
        /// Orders the drink returns ice tea with sugar when has sugar is true.
        /// </summary>
        [TestMethod]
        public void OrderDrink_ReturnsIceTeaWithSugar_WhenHasSugarIsTrue()
        {
            //Arrange
            DrinkAddOn addOn = new DrinkAddOn();
            addOn.HasSugar = true;

            //Act
            IDrink drink = DrinkFactory.OrderDrink(DrinkType.IceTea, addOn);

            //Assert
            Assert.IsTrue(drink is SugarDecorator);
            Assert.AreEqual("We are preparing the following drink for you: Ice tea with sugar", drink.Description);
            Assert.AreEqual(2.0, drink.GetCost());
        }

        /// <summary>
        /// Orders the drink returns ice tea without sugar when has sugar is false.
        /// </summary>
        [TestMethod]
        public void OrderDrink_ReturnsIceTeaWithoutSugar_WhenHasSugarIsFalse()
        {
            //Arrange
            DrinkAddOn addOn = new DrinkAddOn();
     
            //Act
            IDrink drink = DrinkFactory.OrderDrink(DrinkType.IceTea, addOn);

            //Assert
            Assert.IsTrue(drink is IceTea);
            Assert.AreEqual("We are preparing the following drink for you: Ice tea without sugar", drink.Description);
            Assert.AreEqual(1.5, drink.GetCost());
        }

        /// <summary>
        /// Orders the drink returns tea with milk and sugar when has milk and has sugar are true.
        /// </summary>
        [TestMethod]
        public void OrderDrink_ReturnsTeaWithMilkAndSugar_WhenHasMilkAndHasSugarAreTrue()
        {
            //Arrange
            DrinkAddOn addOn = new DrinkAddOn();
            addOn.HasMilk = true;
            addOn.HasSugar = true;

            //Act
            IDrink drink = DrinkFactory.OrderDrink(DrinkType.Tea, addOn);

            //Assert
            Assert.IsTrue(drink is SugarDecorator);
            Assert.AreEqual("We are preparing the following drink for you: Hot tea with milk with sugar", drink.Description);
            Assert.AreEqual(2, drink.GetCost());
        }

        /// <summary>
        /// Orders the drink returns tea without milk and sugar when has milk and has sugar are false.
        /// </summary>
        [TestMethod]
        public void OrderDrink_ReturnsTeaWithoutMilkAndSugar_WhenHasMilkAndHasSugarAreFalse()
        {
            //Arrange
            DrinkAddOn addOn = new DrinkAddOn();

            //Act
            IDrink drink = DrinkFactory.OrderDrink(DrinkType.Tea, addOn);

            //Assert
            Assert.IsTrue(drink is Tea);
            Assert.AreEqual("We are preparing the following drink for you: Hot tea without milk without sugar", drink.Description);
            Assert.AreEqual(1, drink.GetCost());
        }

        /// <summary>
        /// Orders the drink returns tea with milk when has milk is true.
        /// </summary>
        [TestMethod]
        public void OrderDrink_ReturnsTeaWithMilk_WhenHasMilkIsTrue()
        {
            //Arrange
            DrinkAddOn addOn = new DrinkAddOn();
            addOn.HasMilk = true;
            //Act
            IDrink drink = DrinkFactory.OrderDrink(DrinkType.Tea, addOn);

            //Assert
            Assert.IsTrue(drink is MilkDecorator);
            Assert.AreEqual("We are preparing the following drink for you: Hot tea with milk without sugar", drink.Description);
            Assert.AreEqual(1.5, drink.GetCost());
        }

        /// <summary>
        /// Orders the drink returns tea with sugar when has sugar is true.
        /// </summary>
        [TestMethod]
        public void OrderDrink_ReturnsTeaWithSugar_WhenHasSugarIsTrue()
        {
            //Arrange
            DrinkAddOn addOn = new DrinkAddOn();
            addOn.HasSugar = true;
            //Act
            IDrink drink = DrinkFactory.OrderDrink(DrinkType.Tea, addOn);

            //Assert
            Assert.IsTrue(drink is SugarDecorator);
            Assert.AreEqual("We are preparing the following drink for you: Hot tea without milk with sugar", drink.Description);
            Assert.AreEqual(1.5, drink.GetCost());
        }

        /// <summary>
        /// Orders the drink returns expresso without milk and sugar when has milk and has sugar are false.
        /// </summary>
        [TestMethod]
        public void OrderDrink_ReturnsExpressoWithoutMilkAndSugar_WhenHasMilkAndHasSugarAreFalse()
        {
            //Arrange
            DrinkAddOn addOn = new DrinkAddOn();

            //Act
            IDrink drink = DrinkFactory.OrderDrink(DrinkType.Expresso, addOn);

            //Assert
            Assert.IsTrue(drink is Expresso);
            Assert.AreEqual("We are preparing the following drink for you: Expresso without milk without sugar", drink.Description);
            Assert.AreEqual(1.8, drink.GetCost());
        }

        /// <summary>
        /// Orders the drink returns expresso with milk and sugar when has milk and has sugar are true.
        /// </summary>
        [TestMethod]
        public void OrderDrink_ReturnsExpressoWithMilkAndSugar_WhenHasMilkAndHasSugarAreTrue()
        {
            //Arrange
            DrinkAddOn addOn = new DrinkAddOn();
            addOn.HasSugar = true;
            addOn.HasMilk = true;
            //Act
            IDrink drink = DrinkFactory.OrderDrink(DrinkType.Expresso, addOn);

            //Assert
            Assert.IsTrue(drink is SugarDecorator);
            Assert.AreEqual("We are preparing the following drink for you: Expresso with milk with sugar", drink.Description);
            Assert.AreEqual(2.8, drink.GetCost());
        }

        /// <summary>
        /// Orders the drink returns expresso with milk when has milk is true.
        /// </summary>
        [TestMethod]
        public void OrderDrink_ReturnsExpressoWithMilk_WhenHasMilkIsTrue()
        {
            //Arrange
            DrinkAddOn addOn = new DrinkAddOn();
            addOn.HasMilk = true;
            //Act
            IDrink drink = DrinkFactory.OrderDrink(DrinkType.Expresso, addOn);

            //Assert
            Assert.IsTrue(drink is MilkDecorator);
            Assert.AreEqual("We are preparing the following drink for you: Expresso with milk without sugar", drink.Description);
            Assert.AreEqual(2.3, drink.GetCost());
        }

        /// <summary>
        /// Orders the drink returns expresso with sugar when has sugar is true.
        /// </summary>
        [TestMethod]
        public void OrderDrink_ReturnsExpressoWithSugar_WhenHasSugarIsTrue()
        {
            //Arrange
            DrinkAddOn addOn = new DrinkAddOn();
            addOn.HasSugar = true;
            //Act
            IDrink drink = DrinkFactory.OrderDrink(DrinkType.Expresso, addOn);

            //Assert
            Assert.IsTrue(drink is SugarDecorator);
            Assert.AreEqual("We are preparing the following drink for you: Expresso without milk with sugar", drink.Description);
            Assert.AreEqual(2.3, drink.GetCost());
        }

        /// <summary>
        /// Orders the drink returns expresso with milk and sugar with chocolate when has milk and has sugar and has chocolate are true.
        /// </summary>
        [TestMethod]
        public void OrderDrink_ReturnsExpressoWithMilkAndSugarWithChocolate_WhenHasMilkAndHasSugarAndHasChocolateAreTrue()
        {
            //Arrange
            DrinkAddOn addOn = new DrinkAddOn();
            addOn.HasSugar = true;
            addOn.HasMilk = true;
            addOn.HasChocolate = true;
            //Act
            IDrink drink = DrinkFactory.OrderDrink(DrinkType.Expresso, addOn);

            //Assert
            Assert.IsTrue(drink is ChocolateDecorator);
            Assert.AreEqual("We are preparing the following drink for you: Expresso with milk with sugar with chocolate", drink.Description);
            Assert.AreEqual(3.3, drink.GetCost());
        }

    }
}
