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
        
        System.out.println();
        
        //for frequency: find from the list
        System.out.println(Collections.frequency(list2, "corn"));
        
        //for disjoint: common in both the list
        boolean tof = Collections.disjoint(list1, list2);
        System.out.println(tof);
        
        if(tof)
            System.out.println("These list do not have anything in common");
        else
            System.out.println("These list must have something in common");
    }
    
}