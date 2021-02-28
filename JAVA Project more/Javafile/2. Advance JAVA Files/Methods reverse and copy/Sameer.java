import java.util.*;

public class Sameer {
    public static void main(String[] args) {
        
        //create an array and convert to list
        Character[] ray = {'s', 'a', 'm', 'e', 'e', 'r'};
        List<Character> l = Arrays.asList(ray);
        System.out.println("List is : ");
        output(l);
        
        //reverse and print out the list
        Collections.reverse(l);
        System.out.println("After reverse : ");
        output(l);
        
        //create new array and a new list
        Character[] newRay = new Character[6];
        List<Character> listCopy = Arrays.asList(newRay);
        
        //copy content of the list into listCopy
        Collections.copy(listCopy , l);
        System.out.println("Copy of the list : ");
        output(listCopy);
        
        //fill collection with crap
        Collections.fill(l, 'X');
        System.out.println("After filling the list ; ");
        output(l);
    }
    
    //output method
    private static void output(List<Character> thelist){
        
        for(Character thing : thelist)
            System.out.printf("%s ", thing);
        System.out.println();
    }
    
}
