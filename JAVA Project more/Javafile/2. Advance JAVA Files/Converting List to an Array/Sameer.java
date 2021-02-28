import java.util.*;

public class Sameer {
    public static void main(String[] args) {
       
        String[] stuff = {"Choclates", "Milk", "Icecream", "fudge"};
        LinkedList<String> thelist = new LinkedList<String>(Arrays.asList(stuff));
        
        thelist.add("moreitems");
        thelist.addFirst("firstthing");
        
        //Convert back to an array
        stuff = thelist.toArray(new String[thelist.size()]);
        
        for(String x : stuff)
            System.out.printf("%s ", x);
    }
    
}
