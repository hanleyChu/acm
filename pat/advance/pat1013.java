import java.util.*;

class City
{
	public int number;
    public Set<City> adjCities;
    public City(int num)
    {
    	this.adjCities = new HashSet<City>();
    	this.number = num;
    	}
}

class CityGraphic
{
    public int cityCount;
    private int count;
    private boolean[] visited;
    private int[] cc;
    public City[] cities;

    public CityGraphic(int cityCount)
    {
    	this.cityCount = cityCount;
        visited = new boolean[cityCount+1];
        cc = new int[cityCount+1];
        cities = new City[cityCount+1];

        for(int i=1;i<=cityCount;i++)
            cities[i] = new City(i);
    }

    public int getRepairCount(int testCity)
    {
        //init
        Arrays.fill(visited, false);
        count = 1;

        // split
        for(int i=1;i<=cityCount;++i)
        {
            if(i!=testCity && visited[i] == false)
            {
                dfs(cities[i],testCity);
                count++;
            }
        }

        //get components nubmer
        int number = 0;
        for(int i=1;i<=cityCount;i++)
        {
            if(i!=testCity && cc[i]>number)
                number = cc[i];
        }

        return number - 1;
    }

    private void dfs(City i,int testCity)
    {
        LinkedList<City> stack = new LinkedList<City>();
        stack.push(i);

        while(!stack.isEmpty())
        {
            City city = stack.pop();
            visited[city.number] = true;
            cc[city.number] = count;

            for(City c: city.adjCities)
            {
                if(c!=cities[testCity] && visited[c.number]==false)
                    stack.push(c);
            }

        }
    }
}

public class pat1013
{
    public static void main(String[] args)
    {
        /*
        build a graphic adjacent table based on input data
        for each city, we exclude it from graphic
            split graphic into connected components
            print connected components number - 1

        connected components:j
            int[] cc = all 0; // 0 means unprocessed
            boolean[] visited; // all false
            City[] cities; //City class has an adjacency table internally
            count = 1;

            for each v in unvisited vertex && v is not the test case:
                dfs(v)
                count++

        dfs(v):
            visited[v] = true
            cc[v] = count // mark it as part of the same component
            for each u around v && u is not the test case:
                if visited[u] == false:
                    dfs(u)
                    */

        Scanner in = new Scanner(pat1013.class.getClassLoader().getResourceAsStream("test"));

        int cityCount = in.nextInt();
        int wayCount = in.nextInt();
        int testCount = in.nextInt();

        CityGraphic cg = new CityGraphic(cityCount);

        int i = wayCount;
        while(i>0)
        {
            int x = in.nextInt();
            int y = in.nextInt();
            cg.cities[x].adjCities.add(cg.cities[y]);
            cg.cities[y].adjCities.add(cg.cities[x]);
            i--;
        }

        int testCity;
        while(testCount>0)
        {
        	testCity = in.nextInt();
            System.out.println(cg.getRepairCount(testCity));
            testCount--;
        }


    }
}