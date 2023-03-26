int time;        
int distance = 10000, FirstFriendSpeed = 1, 
   SecondFriendSpeed = 2, DogSpeed = 5, friend = 2, count = 0;
while (distance > 10)
{
    if (friend == 1)
    {
    int time, distance;
    int time = (distance / (FirstFriendSpeed + DogSpeed)) ;
    Console.WriteLine(time);
    friend = 2;
    } 
    else
    {
    int time, distance;
    int time = (distance / (SecondFriendSpeed + DogSpeed));
    Console.WriteLine(time);
    friend =1;
    }
  int distance = (distance - (FirstFriendSpeed + SecondFriendSpeed) * time);
  Console.WriteLine(distance);
  count++;
}
Console.WriteLine(count);
 