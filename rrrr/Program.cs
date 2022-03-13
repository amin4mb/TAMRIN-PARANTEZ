
var INPUT = "5(*X(5)(((*6+(54)660))6+2()))";

List<char> l = INPUT.ToList();


for (int i = 0; i < l.Count(); i++)
{
    if (l[i] == ')')
    {
        Console.WriteLine("IS NOT VALID ");

        break;
    }
    if (l[i] == '(')
    {

        if (l.Contains(')'))

        {
            for (int j = i + 1; j < l.Count(); j++)
            {
                if (l[j] == ')')
                {
                    l.RemoveAt(j);
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("IS NOT VALID ");
            break;


        }
       
    }

    if (i == (l.Count()) - 1)
    {
        Console.WriteLine("***VALID***");
    }
}




