import java.io.*;
import java.util.*;


//  Definition for a point.
class Point {
  public int x;
  public int y;
  public Point() { x = 0; y = 0; }
  public Point(int a, int b) { x = a; y = b; }
}
 
public class Solution
{

    public static void main(String[] args)
    {
        // do test
    }

    public int maxPoints(Point[] points) 
    {
        int n = points.length;
        Point tmp;
        Set<Point> pointsSet;
        Map<Line,Set<Point>> map = new HashMap<Line, Set<Point>>(n*n);
        for(int 0;i<n-1;++i)
            for(int j=i+1;j<n;++j)
            {
                tmp = calLine(points[i],points[j]);
                pointsSet = map.get(tmp);

                if(pointsSet==null)
                {
                    pointsSet = new HashSet<Point>();
                    map.put(tmp, pointsSet);
                }

                pointsSet.add(points[i]);
                pointsSet.add(points[j]);
            }

        int max = 0;
        for(Set<Point> set: map.values())
        {
            if(set.size()>max)
                max = set.size();
        }

        return max;
    }

    public Line calLine(Point a, Point b)
    {
        float k = (a.y-b.y)/(a.x-b.x);
        float b = a.y-a.x*k;
        return new Line(k, b);
    }
}

class Line
{
    public float k;
    public float b;

    public Line(float k, float b)
    {
        this.k = k;
        this.b = b;
    }

    @Override
    public boolean equals(Line l)
    {
        return this.k == l.k && this.b == l.b;
    }

    @Override
    public int hashCode()
    {
        //to do
    }
}