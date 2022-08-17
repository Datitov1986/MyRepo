using System;

int count = 0;
double distance = 10000;
double firstFriendSpeed = 1;
double secondFriendSpeed = 2;
double dogSpeed = 5;
int friend= 2;

while(distance > 10)
{
    if(friend == 1)
    {
        double time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        count++;
    }
    else
    {
        double time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        count++;
    }
    
}
Console.Write("Собака пробежала ");
Console.Write(count);
Console.WriteLine(" раз ");