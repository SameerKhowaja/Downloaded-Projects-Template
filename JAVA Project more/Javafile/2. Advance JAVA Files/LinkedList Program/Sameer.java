import java.util.*;

public class Sameer {
    public static void main(String[] args) {
        
        String[] things = {"apples", "bananas", "grapes", "watermelon"};
        List<String> list1 = new LinkedList<String>();
        for(String x : things)
            list1.add(x);
        
        String[] things2 = {"Apples", "Tomatoes", "jucies", "bacon"};
        List<String> list2 = new LinkedList<String>();
        for(String y : things2)
            list2.add(y);
        
        list1.addAll(list2);
        list2 = null;
        
        printMe(list1);
        removeStuff(list1, 2, 5);
        printMe(list1);
        reverseMe(list1);
    }
    
    //printMe Method
    private static void printMe(List<String> l){
        for(String b : l)
            System.out.printf("%s ", b);
         System.out.println();
    }
    
    //removeStuff Method
    private static void removeStuff(List<String> l, int from, int to){
        l.subList(from, to).clear();
    }
    
    //reverseMe Method
    private static void reverseMe(List<String> l){
        ListIterator<String> bobby = l.listIterator(l.size());
        while(bobby.hasPrevious())
            System.out.printf("%s ", bobby.previous());
    }
    
}
