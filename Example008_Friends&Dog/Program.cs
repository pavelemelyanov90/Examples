int distance = 10000;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;
int count = 0;
int time = 0;

while (distance > 10)
{
    int friend = new Random().Next(1, 2); // [0, 2) 0 1 
    if (friend == 0)
    {
        time = distance / (first_friend_speed + dog_speed);
        distance = distance - (first_friend_speed + second_friend_speed) * time;
        count++;
    }    
    if(friend == 1)
    {
        time = distance / (second_friend_speed + dog_speed);
        distance = distance - (first_friend_speed + second_friend_speed) * time;
        count++;
    }
}
Console.Write("Количество забегов собаки, ");        
Console.WriteLine(count);        
