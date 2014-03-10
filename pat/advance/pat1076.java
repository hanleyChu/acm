import java.util.*;

class Person
{
    public List<Person> followers = new LinkedList<Person>();
    public boolean visited = false;
    public int level = -1;
}

public class pat1076
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(pat1076.class.getClassLoader().getResourceAsStream("test"));

        int n = in.nextInt();
        int l = in.nextInt();

        Person[] persons = new Person[n+1];
        for(int i=1;i<=n;i++)
        {
            persons[i] = new Person();
        }

        // connected table init
        for(int i=1;i<=n;++i)
        {
            int k=in.nextInt();
            while(k>0)
            {
                int f = in.nextInt();
                persons[f].followers.add(persons[i]);
                k--;
            }
        }

        Stack<Person> stack = new Stack<Person>();
        int m = in.nextInt();
        int count=0;
        while(m>0)
        {
            //clear
            stack.clear();
            for(int i=1;i<=n;i++)
            {
                persons[i].visited= false;
                persons[i].level = -1;
            }
            count=0;

            int q = in.nextInt();

            // find the count
            persons[q].visited = true;//1 init root
            persons[q].level = 0;
            stack.push(persons[q]);
            while(!stack.isEmpty())
            {
                Person t = stack.pop();

                int nextLevel = t.level+1;
                if(nextLevel<=l)
                {
                    for(Person p:t.followers)
                    {
                        if(p.visited == false)
                        {
                            // visit it, set visited and level
                            count++;
                            p.visited = true;
                            p.level = nextLevel;

                            //push it
                            stack.push(p);
                        }
                    }
                }
            }

            System.out.println(count);

            m--;
        }

    }
}