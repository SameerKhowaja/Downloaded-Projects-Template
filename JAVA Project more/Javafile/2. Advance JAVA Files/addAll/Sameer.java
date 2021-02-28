import java.util.*;

public class Sameer {
    public static void main(String[] args) {
        String[] stuff = {"apples", "lemons", "cheese", "bacon", "youtube"};
        List<String> list1 = Arrays.asList(stuff);
        
        ArrayList<String> list2 = new ArrayList<String>();
        list2.add("corn");
        list2.add("beaf");
        list2.add("butter");
        
        for(String x : list2)
            System.out.printf("%s ", x);
        
        Collections.addAll(list2, stuff);
        
        System.out.println();
        
        for(String x : list2)
            System.out.printf("%s ", x);
        
    }
    
}
