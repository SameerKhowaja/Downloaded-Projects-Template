public class Forloop {

    public static void main(String args[]){
   
        //Odd
        System.out.println("FOR ODD");
        for (int i=1; i<=1; i++){
            for (int j=1; j<=550; j++){
                if (j%2 !=0)
                System.out.print(j + ", " );
        }
        System.out.println();
        
        System.out.println();
        
        //Even
        System.out.println("FOR EVEN");
        for (int f=1; f<=1; f++){
            for (int k=0; k<=550; k++){
                if (k%2 !=1)
                System.out.print(k + ", " );
        }
        System.out.println();
    }
}
    
}
}