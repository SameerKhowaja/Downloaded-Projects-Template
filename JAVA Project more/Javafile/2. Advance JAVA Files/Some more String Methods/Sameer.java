public class Sameer {
    public static void main(String[] args) {
        
        String a = "sameer ";
        String b = "khowaja";
        
        String s = "sameerkhowajasameerkhowaja";
        
        System.out.println(s.indexOf('k'));
        
        System.out.println(s.indexOf('k', 11));
        
        //concat
        System.out.println(a.concat(b));
        
        //replace
        System.out.println(a.replace('s', 'A'));
        
        //toUpperCase
        System.out.println(a.toUpperCase());
        
        //toLowerCase
        System.out.println(a.toLowerCase());
        
        
        String d = "     khowaja     ";
        
        //trim
        System.out.println(d.trim());
    }
    
}
