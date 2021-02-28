public class Sameer {
    public static void main(String[] args) {
        
        String[] words = {"fudge", "chunk", "funk", "nuck", "lolo"};
        
        //Starts With
        for(String w : words){
            if(w.startsWith("fu"))
                System.out.println(w + " starts with fu");
        }
        
        //Ends With
        for(String w : words){
            if(w.endsWith("unk"))
                System.out.println(w + " ends with unk");
        }
    }
    
}
