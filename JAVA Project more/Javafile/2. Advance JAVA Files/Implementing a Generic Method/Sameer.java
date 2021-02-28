import java.util.*;

public class Sameer {
    public static void main(String[] args) {
        
        Integer[] iray = {1,2,3,4,5,6};
        Character[] cray = {'s', 'a', 'm', 'e', 'e', 'r'};
        
        printMe(iray);
        printMe(cray);
    }
    
    //Generic method
    public static <T> void printMe(T[] x){
        
        for(T b : x)
            System.out.printf("%s ", b);
        System.out.println();
    }
    
}
