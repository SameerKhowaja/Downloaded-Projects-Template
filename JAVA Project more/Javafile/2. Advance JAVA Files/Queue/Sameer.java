import java.util.*;

public class Sameer {
    public static void main(String[] args) {
        
        PriorityQueue<String> q = new PriorityQueue<String>();
        
        q.offer("first");
        q.offer("second");
        q.offer("third");
        
        System.out.printf("%s ", q);
        System.out.println();
        
        //first member
        System.out.printf("%s ", q.peek());
        System.out.println();
        
        //rest of members than first member
        q.poll();
        System.out.printf("%s ", q);
    }
    
}
