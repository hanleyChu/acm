public class A
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(new BufferedInputStream(System.in));

        String[]  parts = in.next().trim().split("\\s");

        String a = parts[0];
        char da = parts[1].charAt(0);
        String b = parts[2];
        char db = parts[3].charAt(1);

        int la = a.length();
        int lb = b.length();

        int ca = 0,cb = 0;
        for(int j =0;j<la;++j)
        {
            if(a.charAt(j)==da)
                ca = ca*10+1;
        }

        for(int j =0;j<lb;++j)
        {
            if(b.charAt(j)==db)
                cb = cb*10+1;
        }

        ca = ca*((int)a-48);
        cb = cb*((int)b-48);

        System.out.println(ca+cb);


    }
}