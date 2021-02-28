import java.util.*;

public class Sameer {
    public static void main(String[] args) {
        
        
        String[] things = {"google", "youtube", "facebook", "whatsapp"};
        List<String> list = Arrays.asList(things);
        
        System.out.printf("%s ", list);
        System.out.println();
        
        Set<String> set = new HashSet<String>(list);
        System.out.printf("%s ", set);
    }
    
}
