import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.net.MalformedURLException;
import java.applet.AudioClip;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.net.MalformedURLException;
import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JLabel;
import java.applet.Applet;
import java.applet.AudioClip;
import java.awt.event.KeyEvent;
import java.awt.event.MouseEvent;
import java.io.File;
import java.net.MalformedURLException;
import javax.swing.ImageIcon;
import javax.swing.*;
import javax.swing.JLabel;
class table extends JFrame{
AudioClip a;
Thread th;
JFrame frm;
JLabel L1,L2,L3,L4,L5,L6,L7,L8,L9,L10,L11,L12,L13,L14,L15,L16,L17,L18,L19,L20,L21,L22,L23,L24,L25,L26,L27,L28,L29,L30,L31,L32,L33,L34,L35,L36,L37,L38,L39,L40,L41,L42,L43,L44,L45,L46,L47,L48,L49,L50,L51,L52,L53,L54,L55,L56,L57,L58,L59,L60,L61,L62,L63,L64,L65,L66,L67,L68,L69,L70,L71,L72,L73,L74,L75,L76,L77,L78,L79,L80,L81,L82,L83,L84,L85,L86,L87,L88,L89,L90,L91,L92,L93,L94,L95,L96,L97,L98,L99,L100,L101;
table()throws MalformedURLException, InterruptedException{

frm=new JFrame();
frm.setBounds(30,50,1100,700);
frm.setLayout(null);
frm.setDefaultCloseOperation(3);
frm.setVisible(true);

frm.setResizable(false);

File A = new File("Sleep Away.wav");
this.a = Applet.newAudioClip(A.toURL());
this.a.loop();

L1=new JLabel();
L1.setIcon(new ImageIcon("yellow.png"));
L1.setBounds(200, 40, 22, 19);
frm.add(L1);
for(int a=1; a<=899; a++){
try{

L1.setBounds(1100-a, 40, 22, 19);
Thread.sleep(1);
}catch(Exception e){}
}

L2=new JLabel();
L2.setIcon(new ImageIcon("yellow.png"));
L2.setBounds(180, 40, 22, 19);
frm.add(L2);
for(int b=1; b<=920; b++){
try{

L2.setBounds(1100-b, 40, 22, 19);
Thread.sleep(1);
}catch(Exception e){}
}

L3=new JLabel();
L3.setIcon(new ImageIcon("yellow.png"));
L3.setBounds(160, 50, 22, 19);
frm.add(L3);
for(int c=1; c<=940; c++){
try{
L3.setBounds(1100-c, 50, 22, 19);
Thread.sleep(1);
}catch(Exception e){}

}
L4=new JLabel();
L4.setIcon(new ImageIcon("yellow.png"));
L4.setBounds(170, 70, 22, 19);
frm.add(L4);
for(int c=1; c<=930; c++){
try{

L4.setBounds(1100-c, 70, 22, 19);
Thread.sleep(1);
}catch(Exception e){}
}

L5=new JLabel();
L5.setIcon(new ImageIcon("yellow.png"));
L5.setBounds(190, 80, 22, 19);
frm.add(L5);
for(int d=1; d<=912; d++){
try{

L5.setBounds(1100-d, 80, 22, 19);
Thread.sleep(1);
}catch(Exception e){}
}
L6=new JLabel();
L6.setIcon(new ImageIcon("yellow.png"));
L6.setBounds(205, 95, 22, 19);
frm.add(L6);
for(int e=1; e<=889; e++){
try{

L6.setBounds(1100-e, 95, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
L7=new JLabel();
L7.setIcon(new ImageIcon("yellow.png"));
L7.setBounds(220, 110, 22, 19);
frm.add(L7);
for(int f=1; f<=880; f++){
try{

L7.setBounds(1100-f, 111, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
L8=new JLabel();
L8.setIcon(new ImageIcon("yellow.png"));
L8.setBounds(210, 130, 22, 19);
frm.add(L8);
for(int g=1; g<=887; g++){
try{

L8.setBounds(1100-g, 130, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
L9=new JLabel();
L9.setIcon(new ImageIcon("yellow.png"));
L9.setBounds(190, 130, 22, 19);
frm.add(L9);
for(int h=1; h<=910; h++){
try{

L9.setBounds(1100-h, 130, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}

L10=new JLabel();
L10.setIcon(new ImageIcon("yellow.png"));
L10.setBounds(170, 120, 22, 19);
frm.add(L10);
for(int i=1; i<=930; i++){
try{

L10.setBounds(1100-i, 120, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}

}
/////////////////////////////////////////////////
L11=new JLabel();
L11.setIcon(new ImageIcon("green.png"));
L11.setBounds(300, 40, 22, 19);
frm.add(L11);

for(int h=1; h<=760; h++){
try{

L11.setBounds(300, 800-h, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
L12=new JLabel();
L12.setIcon(new ImageIcon("green.png"));
L12.setBounds(300, 60, 22, 19);
frm.add(L12);
for(int j=1; j<=740; j++){
try{

L12.setBounds(300, 800-j, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
L13=new JLabel();
L13.setIcon(new ImageIcon("green.png"));
L13.setBounds(300, 80, 22, 19);
frm.add(L13);
for(int j=1; j<=720; j++){
try{

L13.setBounds(300, 800-j, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
L14=new JLabel();
L14.setIcon(new ImageIcon("green.png"));
L14.setBounds(300, 100, 22, 19);
frm.add(L14);
for(int k=1; k<=700; k++){
try{

L14.setBounds(300, 800-k, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
L15=new JLabel();
L15.setIcon(new ImageIcon("green.png"));
L15.setBounds(300, 120, 22, 19);
frm.add(L15);
for(int kk=1; kk<=680; kk++){
try{

L15.setBounds(300, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
L16=new JLabel();
L16.setIcon(new ImageIcon("green.png"));
L16.setBounds(380, 40, 22, 19);
frm.add(L16);
for(int kk=1; kk<=720; kk++){
try{

L16.setBounds(1100-kk, 40, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
L17=new JLabel();
L17.setIcon(new ImageIcon("green.png"));
L17.setBounds(380, 60, 22, 19);
frm.add(L17);
for(int kk=1; kk<=740; kk++){
try{

L17.setBounds(380, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}

L18=new JLabel();
L18.setIcon(new ImageIcon("green.png"));
L18.setBounds(380, 80, 22, 19);
frm.add(L18);
for(int kk=1; kk<=380; kk++){
try{

L18.setBounds(kk, 80, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}

L19=new JLabel();
L19.setIcon(new ImageIcon("green.png"));
L19.setBounds(380, 100, 22, 19);
frm.add(L19);
for(int kk=1; kk<=700; kk++){
try{

L19.setBounds(380, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}

L20=new JLabel();
L20.setIcon(new ImageIcon("green.png"));
L20.setBounds(380, 120, 22, 19);
frm.add(L20);
for(int kk=1; kk<=720; kk++){
try{

L20.setBounds(1100-kk, 120, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
L21=new JLabel();
L21.setIcon(new ImageIcon("green.png"));
L21.setBounds(320, 80, 22, 19);
frm.add(L21);

L22=new JLabel();
L22.setIcon(new ImageIcon("green.png"));
L22.setBounds(340, 80, 22, 19);
frm.add(L22);


L23=new JLabel();
L23.setIcon(new ImageIcon("green.png"));
L23.setBounds(360, 80, 22, 19);
frm.add(L23);
for(int kk=1; kk<=720; kk++){
try{

L21.setBounds(320, 800-kk, 22, 19);
L22.setBounds(340, 800-kk, 22, 19);
L23.setBounds(360, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}

///////////////////////////////aaaaaaaa









L24=new JLabel();
L24.setIcon(new ImageIcon("whi.png"));
L24.setBounds(500, 40, 22, 19);
frm.add(L24);

for(int kk=1; kk<=760; kk++){
try{

L24.setBounds(500, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}

//2444444444444444444444444444

L25=new JLabel();
L25.setIcon(new ImageIcon("whi.png"));
L25.setBounds(520, 40, 22, 19);
frm.add(L25);
for(int kk=1; kk<=580; kk++){
try{

L25.setBounds(1100-kk, 40, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
//255555555555555555555555
L26=new JLabel();
L26.setIcon(new ImageIcon("whi.png"));
L26.setBounds(480, 40, 22, 19);
frm.add(L26);
for(int kk=1; kk<=760; kk++){
try{

L26.setBounds(480, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
//26666666666666666

L27=new JLabel();
L27.setIcon(new ImageIcon("whi.png"));
L27.setBounds(480, 60, 22, 19);
frm.add(L27);

for(int kk=1; kk<=480; kk++){
try{

L27.setBounds(kk, 60, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
//27////////////////
L28=new JLabel();
L28.setIcon(new ImageIcon("whi.png"));
L28.setBounds(480, 80, 22, 19);
frm.add(L28);
for(int kk=1; kk<=620; kk++){
try{

L28.setBounds(1100-kk, 80, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}

//288888888888888
L29=new JLabel();
L29.setIcon(new ImageIcon("whi.png"));
L29.setBounds(480, 100, 22, 19);
frm.add(L29);
for(int kk=1; kk<=700; kk++){
try{

L29.setBounds(480, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
//29999999999
L30=new JLabel();
L30.setIcon(new ImageIcon("whi.png"));
L30.setBounds(480, 120, 22, 19);
frm.add(L30);

for(int kk=1; kk<=480; kk++){
try{

L30.setBounds(kk, 120, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
//30000000000000
L31=new JLabel();
L31.setIcon(new ImageIcon("whi.png"));
L31.setBounds(540, 40, 22, 19);
frm.add(L31);
for(int kk=1; kk<=560; kk++){
try{

L31.setBounds(1100-kk, 40, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}


L32=new JLabel();
L32.setIcon(new ImageIcon("whi.png"));
L32.setBounds(560, 60, 22, 19);
frm.add(L32);
for(int kk=1; kk<=740; kk++){
try{

L32.setBounds(560, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
L33=new JLabel();
L33.setIcon(new ImageIcon("whi.png"));
L33.setBounds(560, 80, 22, 19);
frm.add(L33);
for(int kk=1; kk<=540; kk++){
try{

L33.setBounds(1100-kk, 80, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}


L39=new JLabel();
L39.setIcon(new ImageIcon("whi.png"));
L39.setBounds(560, 40, 22, 19);
frm.add(L39);

for(int kk=1; kk<=540; kk++){
try{

L39.setBounds(1100-kk, 40, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}



L34=new JLabel();
L34.setIcon(new ImageIcon("whi.png"));
L34.setBounds(560, 100, 22, 19);
frm.add(L34);
for(int kk=1; kk<=560; kk++){
try{

L34.setBounds(kk, 100, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
L35=new JLabel();
L35.setIcon(new ImageIcon("whi.png"));
L35.setBounds(560, 120, 22, 19);
frm.add(L35);
for(int kk=1; kk<=680; kk++){
try{

L35.setBounds(560, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}
L36=new JLabel();
L36.setIcon(new ImageIcon("whi.png"));
L36.setBounds(500, 80, 22, 19);
frm.add(L36);

L37=new JLabel();
L37.setIcon(new ImageIcon("whi.png"));
L37.setBounds(520, 80, 22, 19);
frm.add(L37);

L38=new JLabel();
L38.setIcon(new ImageIcon("whi.png"));
L38.setBounds(540, 80, 22, 19);
frm.add(L38);
for(int kk=1; kk<=720; kk++){
try{

L36.setBounds(500, 800-kk, 22, 19);
L37.setBounds(520, 800-kk, 22, 19);
L38.setBounds(540, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}

///////////////vvvvvvvvvvvvvvvvvvvvvvvvvvv

L40=new JLabel();
L40.setIcon(new ImageIcon("vv.png"));
L40.setBounds(650, 40, 22, 19);
frm.add(L40);

L41=new JLabel();
L41.setIcon(new ImageIcon("vv.png"));
L41.setBounds(650, 60, 22, 19);
frm.add(L41);

	L42=new JLabel();
L42.setIcon(new ImageIcon("vv.png"));
L42.setBounds(650, 80, 22, 19);
frm.add(L42);


L43=new JLabel();
L43.setIcon(new ImageIcon("vv.png"));
L43.setBounds(650, 100, 22, 19);
frm.add(L43);

L44=new JLabel();
L44.setIcon(new ImageIcon("vv.png"));
L44.setBounds(650, 120, 22, 19);
frm.add(L44);
for(int kk=1; kk<=650; kk++){
try{

L40.setBounds(kk, 40, 22, 19);
L41.setBounds(kk, 60, 22, 19);
L42.setBounds(kk, 80, 22, 19);
L43.setBounds(kk, 100, 22, 19);
L44.setBounds(kk, 120, 22, 19);
Thread.sleep(1);
}catch(Exception ed){}
}

L45=new JLabel();
L45.setIcon(new ImageIcon("vv.png"));
L45.setBounds(630, 40, 22, 19);
frm.add(L45);

for(int kk=1; kk<=760; kk++){
try{

L45.setBounds(630, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception ed){}
}

L46=new JLabel();
L46.setIcon(new ImageIcon("vv.png"));
L46.setBounds(670, 40, 22, 19);
frm.add(L46);
for(int kk=1; kk<=430; kk++){
try{

L46.setBounds(1100-kk, 40, 22, 19);

Thread.sleep(1);
}catch(Exception ed){}
}

L47=new JLabel();
L47.setIcon(new ImageIcon("vv.png"));
L47.setBounds(690, 40, 22, 19);
frm.add(L47);
for(int kk=1; kk<=760; kk++){
try{

L47.setBounds(690, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception ed){}
}
L48=new JLabel();
L48.setIcon(new ImageIcon("vv.png"));
L48.setBounds(710, 50, 22, 19);
frm.add(L48);
for(int kk=1; kk<=710; kk++){
try{

L48.setBounds(kk, 50, 22, 19);

Thread.sleep(1);
}catch(Exception ed){}
}
L49=new JLabel();
L49.setIcon(new ImageIcon("vv.png"));
L49.setBounds(720, 70, 22, 19);
frm.add(L49);
for(int kk=1; kk<=730; kk++){
try{

L49.setBounds(720, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception ed){}
}
L50=new JLabel();
L50.setIcon(new ImageIcon("vv.png"));
L50.setBounds(720, 90, 22, 19);
frm.add(L50);
for(int kk=1; kk<=380; kk++){
try{

L50.setBounds(1100-kk, 90, 22, 19);

Thread.sleep(1);
}catch(Exception ed){}
}

L51=new JLabel();
L51.setIcon(new ImageIcon("vv.png"));
L51.setBounds(720, 110, 22, 19);
frm.add(L51);

for(int kk=1; kk<=690; kk++){
try{

L51.setBounds(720, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception ed){}
}

L52=new JLabel();
L52.setIcon(new ImageIcon("vv.png"));
L52.setBounds(710, 130, 22, 19);
frm.add(L52);

for(int kk=1; kk<=710; kk++){
try{

L52.setBounds(kk, 130, 22, 19);

Thread.sleep(1);
}catch(Exception ed){}
}
L53=new JLabel();
L53.setIcon(new ImageIcon("vv.png"));
L53.setBounds(690, 130, 22, 19);
frm.add(L53);
for(int kk=1; kk<=670; kk++){
try{

L53.setBounds(690, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception ed){}
}
L54=new JLabel();
L54.setIcon(new ImageIcon("vv.png"));
L54.setBounds(670, 130, 22, 19);
frm.add(L54);

for(int kk=1; kk<=670; kk++){
try{

L54.setBounds(kk, 130, 22, 19);

Thread.sleep(1);
}catch(Exception ed){}
}





L56=new JLabel();
L56.setIcon(new ImageIcon("vv.png"));
L56.setBounds(625, 130, 22, 19);
frm.add(L56);
for(int kk=1; kk<=470; kk++){
try{

L56.setBounds(1100-kk, 130, 22, 19);

Thread.sleep(1);
}catch(Exception ed){}

}
L57=new JLabel();
L57.setIcon(new ImageIcon("vv.png"));
L57.setBounds(648, 130, 22, 19);
frm.add(L57);

for(int kk=1; kk<=747; kk++){
try{

L57.setBounds(648, 880-kk, 22, 19);

Thread.sleep(1);
}catch(Exception ed){}

}


//a22222222222222222222222222222222222222222222


















L58=new JLabel();
L58.setIcon(new ImageIcon("g.png"));
L58.setBounds(860, 40, 22, 19);
frm.add(L58);
for(int kk=1; kk<=860; kk++){
try{
L58.setBounds(kk, 40, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}

L59=new JLabel();
L59.setIcon(new ImageIcon("g.png"));
L59.setBounds(840, 40, 22, 19);
frm.add(L59);
for(int kk=1; kk<=760; kk++){
try{
L59.setBounds(840, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}
L60=new JLabel();
L60.setIcon(new ImageIcon("g.png"));
L60.setBounds(820, 40, 22, 19);
frm.add(L60);


for(int kk=1; kk<=280; kk++){
try{
L60.setBounds(1100-kk, 40, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}
L61=new JLabel();
L61.setIcon(new ImageIcon("g.png"));
L61.setBounds(880, 40, 22, 19);
frm.add(L61);
for(int kk=1; kk<=880; kk++){
try{
L61.setBounds(kk, 40, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}

L62=new JLabel();
L62.setIcon(new ImageIcon("g.png"));
L62.setBounds(880, 60, 22, 19);
frm.add(L62);
for(int kk=1; kk<=740; kk++){
try{
L62.setBounds(880, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}
L63=new JLabel();
L63.setIcon(new ImageIcon("g.png"));
L63.setBounds(880, 80, 22, 19);
frm.add(L63);
for(int kk=1; kk<=220; kk++){
try{
L63.setBounds(1100-kk, 80, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}
L64=new JLabel();
L64.setIcon(new ImageIcon("g.png"));
L64.setBounds(880, 100, 22, 19);
frm.add(L64);

for(int kk=1; kk<=700; kk++){
try{
L64.setBounds(880, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}
L65=new JLabel();
L65.setIcon(new ImageIcon("g.png"));
L65.setBounds(880, 120, 22, 19);
frm.add(L65);

for(int kk=1; kk<=880; kk++){
try{
L65.setBounds(kk, 120, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}


L66=new JLabel();
L66.setIcon(new ImageIcon("g.png"));
L66.setBounds(800, 40, 22, 19);
frm.add(L66);
for(int kk=1; kk<=760; kk++){
try{
L66.setBounds(800, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}
L67=new JLabel();
L67.setIcon(new ImageIcon("g.png"));
L67.setBounds(800, 60, 22, 19);
frm.add(L67);
for(int kk=1; kk<=300; kk++){
try{
L67.setBounds(1100-kk, 60, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}



L69=new JLabel();
L69.setIcon(new ImageIcon("g.png"));
L69.setBounds(800, 100, 22, 19);
frm.add(L69);
for(int kk=1; kk<=700; kk++){
try{
L69.setBounds(800, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}
L70=new JLabel();
L70.setIcon(new ImageIcon("g.png"));
L70.setBounds(800, 120, 22, 19);
frm.add(L70);
for(int kk=1; kk<=800; kk++){
try{
L70.setBounds(kk, 120, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}
L71=new JLabel();
L71.setIcon(new ImageIcon("g.png"));
L71.setBounds(800, 80, 22, 19);
frm.add(L71);
for(int kk=1; kk<=300; kk++){
try{
L71.setBounds(1100-kk, 80, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}


L72=new JLabel();
L72.setIcon(new ImageIcon("g.png"));
L72.setBounds(820, 80, 22, 19);
frm.add(L72);

for(int kk=1; kk<=720; kk++){
try{
L72.setBounds(820, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}

L73=new JLabel();
L73.setIcon(new ImageIcon("g.png"));
L73.setBounds(840, 80, 22, 19);
frm.add(L73);
for(int kk=1; kk<=840; kk++){
try{
L73.setBounds(kk, 80, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}

L74=new JLabel();
L74.setIcon(new ImageIcon("g.png"));
L74.setBounds(860, 80, 22, 19);
frm.add(L74);

for(int kk=1; kk<=720; kk++){
try{
L74.setBounds(860, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}

L75=new JLabel();
L75.setIcon(new ImageIcon("f.png"));
L75.setBounds(970, 40, 22, 19);
frm.add(L75);

L76=new JLabel();
L76.setIcon(new ImageIcon("f.png"));
L76.setBounds(970, 60, 22, 19);
frm.add(L76);
for(int kk=1; kk<=760; kk++){
try{
L75.setBounds(970, 800-kk, 22, 19);
L76.setBounds(210+kk, 60, 22, 19);
Thread.sleep(1);
}catch(Exception e){}

}
L77=new JLabel();
L77.setIcon(new ImageIcon("f.png"));
L77.setBounds(970, 80, 22, 19);
frm.add(L77);

for(int kk=1; kk<=970; kk++){
try{
L77.setBounds(kk, 80, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}

L78=new JLabel();
L78.setIcon(new ImageIcon("f.png"));
L78.setBounds(970, 100, 22, 19);
frm.add(L78);
for(int kk=1; kk<=700; kk++){
try{
L78.setBounds(970, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}

L79=new JLabel();
L79.setIcon(new ImageIcon("f.png"));
L79.setBounds(970, 120, 22, 19);
frm.add(L79);


L80=new JLabel();
L80.setIcon(new ImageIcon("f.png"));
L80.setBounds(990, 33, 22, 19);
frm.add(L80);

for(int kk=1; kk<=765; kk++){
try{
L79.setBounds(210+kk, 120, 22, 19);
L80.setBounds(990, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception e){}

}
L81=new JLabel();
L81.setIcon(new ImageIcon("f.png"));
L81.setBounds(1010, 35, 22, 19);
frm.add(L81);
for(int kk=1; kk<=770; kk++){
try{
L81.setBounds(1010, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}

L82=new JLabel();
L82.setIcon(new ImageIcon("f.png"));
L82.setBounds(1030, 40, 22, 19);
frm.add(L82);

for(int kk=1; kk<=760; kk++){
try{
L82.setBounds(1030, 800-kk, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}
L83=new JLabel();
L83.setIcon(new ImageIcon("f.png"));
L83.setBounds(1030, 60, 22, 19);
frm.add(L83);


for(int kk=1; kk<=1030; kk++){
try{
L83.setBounds(kk, 60, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}

L84=new JLabel();
L84.setIcon(new ImageIcon("f.png"));
L84.setBounds(1020, 80, 22, 19);
frm.add(L84);



L85=new JLabel();
L85.setIcon(new ImageIcon("f.png"));
L85.setBounds(1000, 80, 22, 19);
frm.add(L85);
for(int kk=1; kk<=720; kk++){
try{
L84.setBounds(300+kk, 80, 22, 19);
L85.setBounds(1000, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception e){}

}

L86=new JLabel();
L86.setIcon(new ImageIcon("f.png"));
L86.setBounds(980, 80, 22, 19);
frm.add(L86);

L87=new JLabel();
L87.setIcon(new ImageIcon("f.png"));
L87.setBounds(1030, 90, 22, 19);
frm.add(L87);
for(int kk=1; kk<=985; kk++){
try{
L86.setBounds(kk, 80, 22, 19);
L87.setBounds(50+kk, 90, 22, 19);
Thread.sleep(1);
}catch(Exception e){}

}
L88=new JLabel();
L88.setIcon(new ImageIcon("f.png"));
L88.setBounds(1035, 110, 22, 19);
frm.add(L88);
for(int kk=1; kk<=1030; kk++){
try{
L88.setBounds(kk, 110, 22, 19);

Thread.sleep(1);
}catch(Exception e){}

}

L89=new JLabel();
L89.setIcon(new ImageIcon("f.png"));
L89.setBounds(1030, 130, 22, 19);
frm.add(L89);
for(int kk=1; kk<=680; kk++){
try{

L89.setBounds(1030, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception e){}

}

L90=new JLabel();
L90.setIcon(new ImageIcon("f.png"));
L90.setBounds(1010, 130, 22, 19);
frm.add(L90);


L91=new JLabel();
L91.setIcon(new ImageIcon("f.png"));
L91.setBounds(985, 130, 22, 19);
frm.add(L91);


for(int kk=1; kk<=670; kk++){
try{

L90.setBounds(340+kk, 130, 22, 19);
L91.setBounds(985, 800-kk, 22, 19);
Thread.sleep(1);
}catch(Exception e){}

}
this.a.stop();
JOptionPane.showMessageDialog(null,"Made By Shadab Ali Khowaja");
System.exit(0);
}

public static void main(String args[])throws MalformedURLException, InterruptedException{



table tb=new table();

}
}