void printProperties(IList users) 
{
  for (int i = 0; i < users.size(); i++)
  {
    string result = "";
    result += users.get(i).getName();
    result += " ";
    result += users.get(i).getAge();
    Console.WriteLine(result);

    // ...
  }
}