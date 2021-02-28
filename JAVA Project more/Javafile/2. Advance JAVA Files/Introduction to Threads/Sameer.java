public class Sameer {
    public static void main(String[] args) {
       
        Thread t1 = new Thread(new Apples("one"));
        Thread t2 = new Thread(new Apples("two"));
        Thread t3 = new Thread(new Apples("three"));
       
        t1.start();
        t2.start();
        t3.start();
    }
}