using System;
using System.Collections.Generic;

namespace CS133MIDTERMPROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant myRestaurant = new Restaurant();


            myRestaurant.ClientsToArrive("First Client ");
            myRestaurant.ClientsToArrive("Second Client ");
            myRestaurant.ClientsToArrive("Third Client ");
            myRestaurant.ClientsToArrive("Fourth Client ");
            myRestaurant.ClientsToArrive("Fifth Client ");

            myRestaurant.ShowMeHowManyClientsAreWaiting();
            myRestaurant.ClientsCanBeSitted();
            myRestaurant.ShowMeHowManyClientsAreWaiting();

            myRestaurant.ClientsLeave();

            myRestaurant.PorterCleansDishes();

            myRestaurant.HowManyDirtyDishesDoIHave();

            
        }
    }
}
public class Restaurant
{
    public User CurrentUser { get; set; }

    Queue<string> myQueue = new Queue<string>();
    Stack<string> dirtyDishesStack = new Stack<string>();
    Stack<string> cleanDishesStack = new Stack<string>();

    public void ClientsToArrive(string theClient)
    {
        myQueue.Enqueue(theClient);
    }

    public void ShowMeHowManyClientsAreWaiting()
    {
        Console.WriteLine(" We have " +
                          myQueue.Count +
                          " Clients Waiting ");
    }

    public void ClientsCanBeSitted()
    {

        {
            
            string theClien = myQueue.Dequeue();
            Console.WriteLine("Clients:" + theClien + "has been sitted");
        }
    }

    public bool ClientsLeave(User Leave)
    {
        return ((Leave.IsClient) || (Leave.ClanInfo.ClanName != CurrentUser.ClanInfo.ClanName));
        dirtyDishesStack.Push("Dish 1");

        Console.WriteLine("Client paid and Leave");
    }

    public bool PorterCleansDishes(User Clean)
    {
       
        {
            return ((Clean.IsClient) || (Clean.ClanInfo.ClanName != CurrentUser.ClanInfo.ClanName));
            string theDish = dirtyDishesStack.Pop();
            cleanDishesStack.Push(theDish);

            Console.WriteLine("POrter has cleaned a dish");
        }
    }
    public bool HowManyDirtyDishesDoIHave(User dirt)
    {
        return ((dirt.IsClient) || (dirt.ClanInfo.ClanName != CurrentUser.ClanInfo.ClanName));

        Console.WriteLine("The restaurant has these many dirty dishes left:  " + dirtyDishesStack.Count);
    }

    
}

public class User
{
    public string UserName { get; set; }
    public bool IsClient { get; set; }
    public Clan ClanInfo { get; set; }

}

public class Clan
{
    public string ClanName { get; set; }
}