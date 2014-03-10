import java.util.*;
import java.io.*;

public Pat306
{
    public static void main(String[] args)
    {
        // if (, push into stack
        // if ), pop stack and output it until(
        // if opnd, output it
        // if optr > top of stack, push into stack
        // if optr <= top of stack, pop and output it until optr > top or stack is empty
        // note: any optr > (
        // if optr == '+' or '-'  and the last input is (, then optr is the symbol of next opnd

        Scanner in = new Scanner(new BufferedInputStream(Pat306.class.getClassLoader().getResourceAsStream()));

        StringBuilder sb = new StringBuilder();

        String exp = in.next();

        char last = ' ';
        int currentPos = 0;

        Stack<Char> stack = new Stack<Char>();
        int len = exp.length();
        while(currentPos<len)
        {
            char c = exp.charAt(currentPos);

            // if opnd , output it
            if(c<='9' && c>='0')
            {
                String str =  getOpnd(exp, currentPos);
                sb.append(str).appned(" ");
            }
            else
            {
                char o;
                switch(c)
                {
                    case '(': 
                        stack.push(c);
                        break;
                    case ')':
                        while(true)
                        {
                            o = stack.pop();
                            if(o!='(')
                                sb.append(o).append(" ");
                            else
                                break;
                        }
                        break;
                    case '-':
                    case '+':
                        // the symbol of an opnd
                        if(last == ' ' || last == '(')
                        {
                            if(c=='-')
                                sb.append('-');

                            sb.append(getOpnd(exp, currentPos+1)).append(" ");
                        }
                    default:
                        // if optr > top element in stack, push it, else pop stack until empty or top < optr
                        if(stack.empty() || compareOptr(stack.peek(), c)<0)
                            stack.push(c);
                        else
                        {
                            char t = stack.pop();
                            while(compareOptr(t, c)>=0 && !stack.empty())
                            {
                                sb.append(t).append(" ");
                                t = stack.pop();
                            }
                            stack.push(c);
                        }
                        break;
                }
            }

            last = c;
            currentPos++;
        }

        System.out.print(sb);
        
    }

    public static boolean compareOptr(char a, char b)
    {
        switch(a)
        {
            case '-':
            case '+':
                switch(b)
                {
                    case '-':
                    case '+':
                        return 0;
                    case '(':
                        return 1;
                    case '*':
                    case '/':
                        return -1;
                    default:
                        throw new IllegalArgumentException();
                }
             case '(':
                return -1;
            case '*':
            case '/':
                switch(b)
                {
                    case '+':
                    case '-':
                        return 1;
                    case '(':
                        return 1;
                    case '*':
                    case '/':
                        return 0;
                    default:
                        throw new IllegalArgumentException();
                }
            default:
                throw new IllegalArgumentException();
        }
    }


    public static String getOpnd(String exp, int pos)
    {
        int len = exp.length();
        int firstNumberPos = pos;
        while(pos<len && exp.charAt(pos)<='9' && exp.charAt(pos)>='0')
        {
            ++pos;
        }

        return exp.substring(firstNumberPos, pos);
    }   
}