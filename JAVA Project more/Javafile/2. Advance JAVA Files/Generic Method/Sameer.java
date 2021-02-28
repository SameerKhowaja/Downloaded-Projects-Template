import java.util.*;

public class Sameer {
    public static void main(String[] args) {
        
        Integer[] iray = {1,2,3,4,5,6};
        Character[] cray = {'s', 'a', 'm', 'e', 'e', 'r'};
        
        printMe(iray);
        printMe(cray);
    }
    
    public static void printMe(Integer[] i){
        
        for(Integer x : i)
            System.out.printf("%s ", x);
        System.out.println();
    }
    
    public static void printMe(Character[] i){
        
        for(Character x : i)
            System.out.printf("%s ", x);
        System.out.println();
    }
    
}
