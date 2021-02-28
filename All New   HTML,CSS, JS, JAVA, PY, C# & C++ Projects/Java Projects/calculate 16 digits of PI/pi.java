

import java.math.*;

public class PI_15_decimal_place
{
    // calculate PI using Chudnovsky series
    private static long fact(long n)
    {
        if(n<=1) return 1;
        return n*fact(n-1);
    }
     
   public static void main(String[] args)
   { int y=3;//no of iretations
        int z=100;

        int k=0;
        BigDecimal bk = new BigDecimal("0"); 
        BigDecimal one = new BigDecimal("1"); 
         BigDecimal tlv = new BigDecimal("12"); 
        BigDecimal bigSum = new BigDecimal("0"); 
        BigDecimal bigProduct = new BigDecimal("0");
        BigDecimal bi1 = new BigDecimal("-1"); 
        BigDecimal bi2 = new BigDecimal("545140134");
        BigDecimal bi3 = new BigDecimal("13591409"); 
        BigDecimal bi4 = new BigDecimal("262537412640768000"); 
        BigDecimal bi5 = new BigDecimal("512384047.99600074981255466992792"); 
        BigDecimal t1,t3,t6; 
        while (k<y){
            BigDecimal t2,t4,t5,d,n;  
              t1=bi1.pow(k);
              t2=new BigDecimal(fact(6*k));
              t3=(bi2.multiply(bk)).add(bi3);
              
              t4= new BigDecimal(fact(3*k));
              t5= new BigDecimal(fact(k));
              t5=t5.pow(3);
              t6=bi4.pow(k).multiply(bi5);
              
              n=t1.multiply(t2).multiply(t3);
              d=t4.multiply(t5).multiply(t6);
              
              bigSum=bigSum.add(n.divide(d,z,RoundingMode.CEILING));
            

                  bigProduct=bigSum.multiply(tlv);
                  bigProduct=one.divide(bigProduct,z,RoundingMode.CEILING);
                    System.out.println("throw no" + k +"\t PI is: " +   bigProduct);
                    k++;
                  bk=bk.add(one);
                }
                z=48;
               bigProduct=bigSum.multiply(tlv);
                  bigProduct=one.divide(bigProduct,z,2);
                  BigDecimal actualPI = new BigDecimal(Math.PI);
                 BigDecimal Difference = bigProduct.subtract(actualPI);
               
                System.out.println("\n\n PI is now: " + bigProduct);
                System.out.println(" PI is actually : " + actualPI);
                System.out.println("Difference = " + Difference);
    }
}
