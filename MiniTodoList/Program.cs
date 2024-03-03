using System.Numerics;

string userResponse ;
List<string> userTasks = new List<string>();

do
{
    cleanScreen();
    mainMenu();
    userResponse = Console.ReadLine().ToString();
    switch(userResponse)
    {
        case "S":
        case "s":
        case "1":
            showAllTasks();
            break;

        case "A":
        case "a":
        case "2":
            insertTaskToList();
            break;

        case "R":
        case "r":
        case "3":
            RemoveTaskFromListByTitle();
            break;

        case "D":
        case "d":
        case "4":
            DeleteAllTasks();
            break;

        case "e":
        case "E":
        case "5":
           
            break;

        default:
            Console.WriteLine("Wrong input press any key for try agian,");
            Console.ReadLine();
            break;

    }
} while (userResponse != "5" && userResponse != "e" && userResponse != "E");


//Menu
void mainMenu()
{
    Console.WriteLine("1.[S]how All Todo Task.");
    Console.WriteLine("2.[A]dd task to list.");
    Console.WriteLine("3.[R]emove task with title.");
       Console.WriteLine("4.[D]elete all tasks.");
    Console.WriteLine("5.[E]xit.");
    Console.WriteLine("--=---=---=-=--=-=-=-===---=-");
    Console.Write("Choose your destiny:");

}

//clear Screen
void cleanScreen()
{
    System.Console.Clear();
}


void showAllTasks()
{
    Console.WriteLine($"Your List have {userTasks.Count} Tasks.");
    Console.WriteLine($"---------------------------------------");

    foreach (string task in userTasks)
    {
        Console.WriteLine($"{task}");
    }
    Console.WriteLine($"---------------------------------------");
    Console.ReadLine();
}
//insert to list
void insertTaskToList()
{
    string utask;
    bool isTasknotValid = true;
    while (isTasknotValid)
    {
        Console.WriteLine("please Enter Your Task:");
        utask = Console.ReadLine();
        if (utask == "")
        {
            Console.WriteLine($"Task can not be empty please enter valid task.");
        }
        else if (userTasks.Contains(utask))
        {
            Console.WriteLine($"The {utask} has already been entered");
        }
        else
        {
            userTasks.Add(utask);
            Console.WriteLine($"{utask} -> Successfully Added.");
            isTasknotValid = false;
            Console.ReadLine();
        }
        
    }
}

// remove from list
void RemoveTaskFromListByTitle()
{
    string utask;
    showAllTasks();
    Console.WriteLine("please Enter Your Task title:");
    utask = Console.ReadLine();
    if (userTasks.Remove(utask))
    {
        Console.WriteLine($"{utask} -> Successfully Removed.");
    }
    else
    {
        Console.WriteLine($"{utask} -> not found.");
    }    
    
    Console.ReadLine();
}

void DeleteAllTasks()
{
    Console.WriteLine("Are you sure to delete All Tasks ? press Y");
    if (Console.ReadLine()=="y")
    {
        userTasks.Clear();
    }
    else
    {
        Console.WriteLine("nothing remove");
    }
    Console.ReadLine();
}