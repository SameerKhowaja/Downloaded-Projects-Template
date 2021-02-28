public class Ship
{
	public static void main(String[] args) {
		int l2=0,i1=26;
int aa=0;
		while( aa<=(i1+1)){
			System.out.print(" ");
			aa++;
		}
		System.out.println("*");
		for(int i=0;i<=6;i++){
			for(int j=0;j<i1;j++){
			System.out.print(" ");
			}
			for(int k=0;k<1;k++){
				System.out.print("*");
			} 
			for(int l=0;l<=l2;l+=2){
				System.out.print(" ");
			}
			for(int m=0;m<1;m++){
				System.out.println("*");
			}
			i1--;
			l2+=4;
		}		
		for(int x=0;x<20;x++){
			System.out.print("*");
		}
		for(int y=0;y<15;y++){
			System.out.print(" ");
		}
		for(int z=0;z<19;z++){
			System.out.print("*");
		}
		for(int a=0;a<1;a++){
			System.out.println("*");		
		}		
		int u=50;		
		for(int w=0;w<=6;w++){
			for(int p=0;p<=w;p++){
				System.out.print(" ");
			}
			for(int b=0;b<1;b++){
				System.out.print("*");
			    
			}		
			for(int c=0;c<=u;c++){
				System.out.print(" ");			
			} 
			for(int d=0;d<1;d++){
				System.out.println("*");
			}
			u-=2;		
		}
		for(int t=0;t<=7;t++){
			System.out.print(" ");
		}
		for(int v=0;v<=38;v++){
			System.out.print("*");
		}

	}
}