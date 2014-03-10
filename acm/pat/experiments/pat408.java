import java.util.*;
import java.io.*;

/*
define strut FileNode
{
    String name;
    boolean isFile;
}

we use Map<FileNode,Map> as a directory tree
FileNode is the metadata of current directory or file
Map is its content including files and dirs, if current is a file, Map is a simple fake object

content = root directory content map
for each input string
    string[] parts = split string using '\'
    for i = 0->length-2
        node = new FileNode(name = parts[i], isFile = false)
        if content contains node:
            content = content.get(node)
        else
            content.put(node, new Map())
            content = the new Map
    if the last string parts[length-1] is not empty
        node = new FileNode(name = parts[length-1], isFile = true)
        if content not contains node:
            content.put(node, new Object())
            
DFS print tree

stack = new Stack()
stack.push(root Entry)
while(!stack.empty())
{
    e = stack.pop
    if e is dir
        push all sub content into stack
    
    print indent + e.name
} 
*/
class FileNode
{
    public boolean isFile;
    public String name;
    public int layer;

    public FileNode(String name, boolean isFile, int layer)
    {
        this.name = name;
        this.isFile = isFile;
        this.layer = layer;
    } 

    @Override
    public int hashCode() 
    {
        return name.hashCode()+(isFile?1:0)+layer;
    }

    @Override
    public boolean equals(Object obj)
    {
        if(!(obj instanceof FileNode))
            return false;
        
        if(this == obj)
            return true;

        if(this.hashCode()!=obj.hashCode())
            return false;
        
        FileNode node = (FileNode)obj;

        if(this.isFile == node.isFile && this.name.equals(node.name) && this.layer == node.layer)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class pat408
{
    public static void printIndent(int len)
    {
        for(int i=0;i<len;++i)
            System.out.print("  ");
    }
    public static void main(String[] args)
    {
        Scanner in = new Scanner(new BufferedInputStream(pat408.class.getClassLoader().getResourceAsStream("test")));

        int n = in.nextInt();
        String line = null;

        Comparator<FileNode> cmp = new Comparator<FileNode>()
        {
            @Override
            public int compare(FileNode n1,FileNode n2)
            {
                int r = (n1.isFile?1:0) - (n2.isFile?1:0);
                if(r!=0)
                    return -r;

                return -n1.name.compareTo(n2.name);
            }
        };
        TreeMap<FileNode,Object> tree = new TreeMap<FileNode,Object>(cmp);
        TreeMap<FileNode,Object> rootContent = new TreeMap<FileNode,Object>(cmp);
        tree.put(new FileNode("root", false, 0), rootContent);

        while(n>0)
        {
            line = in.next();
            String[] parts = line.split("\\\\",-1);

            TreeMap<FileNode,Object> cur = rootContent;
            
            int len = parts.length;

            for(int i = 0;i<len-1;++i)
            {
                FileNode tmp = new FileNode(parts[i], false, i+1);
                if(cur.containsKey(tmp))
                    cur = (TreeMap<FileNode,Object>)cur.get(tmp);
                else
                {
                    TreeMap<FileNode,Object> curContent = new TreeMap<FileNode,Object>(cmp);
                    cur.put(tmp, curContent);
                    cur = curContent;
                }
            }

            if(!parts[len-1].isEmpty())
            {
                FileNode tmp = new FileNode(parts[len-1], true, len);
                if(!cur.containsKey(tmp))
                    cur.put(tmp,new Object());
            }


            n--;
        }

        //print root,dfs or pre order tranverse
        Stack<Map.Entry<FileNode,Object>> stack = new Stack<Map.Entry<FileNode,Object>>();
        stack.push(tree.entrySet().iterator().next());

        while(!stack.empty())
        {
            Map.Entry<FileNode,Object> entry = stack.pop();
            FileNode node = entry.getKey();
            //push its sub files into stack for dfs print
            if(node.isFile == false)
            {
                TreeMap<FileNode,Object> content = (TreeMap<FileNode,Object>)entry.getValue();
                if(!content.isEmpty())
                {
                    for(Map.Entry<FileNode,Object> e : content.entrySet())
                    {
                        stack.push(e);
                    }
                }
            }
            
            printIndent(node.layer);
            System.out.print(node.name);
            if(!stack.empty())
                System.out.println();
        }

    }
}