using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hermetyzacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


    }
    //public class SecretAgent
    //{
    //    //private string realName;
    //    //private string alias;
    //    //private string password;

    //    public void AgentGreeting() //parametr password
    //    {

    //    }
    //    SecretAgent ciaAgent = new SecretAgent();
    //}
    //public class EnemyAgent
    //{
    //    public string Borscht;
    //    public string Vodka;

    //    public void ContactComrades()
    //    {

    //    }
    //    public void OverthrowCapitalists()
    //    {

    //    }
    //    EnemyAgent kgbAgent = new EnemyAgent();
    //}
    //public class SuperChef
    //{
    //    public string cookieRecipe;
    //    //private string secretIngredient;
    //    private const int loyalCustomerOrderAmount = 60;
    //    public int Temperature;
    //    //private string ingredientSupplier;

    //    public string GetRecipe(int orderAmount)
    //    {
    //        if (orderAmount >= loyalCustomerOrderAmount)
    //        {
    //            return cookieRecipe + " " + secretIngredient;
    //        }
    //        else
    //        {
    //            return cookieRecipe;
    //        }
    //    }
    //}
    //1. string ovenTemp = mySuperChef.Temperature;
    //2. string supplier = mySuperChef.ingredientSupplier;
    //3. int loyalCustomerOrderAmount = 54;
    //4. mySuperChef.secretIngredient = "kardamon";
    //5. mySuperChef.cookieRecipe = "Weź 3 jajka, 2,5 szklanki mąki, 1 łyżeczkę soli, 1 łyżeczkę wanilii i 1,5 szklanki cukru.  Wszystko wymieszaj. Piecz przez 10 minut w temperaturze 200 stopni. Smacznego!";
    //6. string recipe = mySuperChef.GetRecipe(56);
    
    class Farmer
    {
        public int BagsOfFeed;
        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }

        public const int FeedMultiplier = 30;
        public int GetNumberOfCows()
        {
            return numberOfCows;
        }
        public void SetNumberOfCows(int newNumberOfCows)
        {
            numberOfCows = newNumberOfCows;
            BagsOfFeed = numberOfCows * FeedMultiplier;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Farmer myFarmer = new Farmer();
            myFarmer.NumberOfCows = 10;

            int howManyBags = myFarmer.BagsOfFeed;

            myFarmer.NumberOfCows = 20;
            howManyBags = myFarmer.BagsOfFeed;
        }


    }
    
}

