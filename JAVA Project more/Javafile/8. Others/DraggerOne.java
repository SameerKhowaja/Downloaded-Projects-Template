import java.awt.Frame;
import java.awt.Canvas;
import java.awt.Graphics;
import java.awt.AWTEvent;
import java.awt.Color;
import java.awt.Rectangle;
import java.awt.Image;
import java.awt.event.WindowEvent;
import java.awt.event.MouseListener;
import java.awt.event.MouseMotionListener;
import java.awt.event.MouseEvent;

public class DraggerOne extends Frame {
    public static void main(String arg[]) {
        new DraggerOne();
    }
    DraggerOne() {
        enableEvents(AWTEvent.WINDOW_EVENT_MASK);
        add(new DraggerOneCanvas());
        pack();
        show();
    }
    public void processWindowEvent(WindowEvent event) {
        if(event.getID() == WindowEvent.WINDOW_CLOSING)
            System.exit(0);
    }
}

class DraggerOneCanvas extends Canvas
        implements MouseListener, MouseMotionListener {
    final int SIDE = 20;
    boolean moving = false;
    int xsquare;
    int ysquare;
    int xoffset;
    int yoffset;
    Rectangle rect;
    Image image;
    DraggerOneCanvas() {
        setSize(200,200);
        rect = new Rectangle(201,201);
        addMouseListener(this);
        addMouseMotionListener(this);
    }
    public void mouseClicked(MouseEvent event) {
    }
    public void mouseEntered(MouseEvent event) {
    }
    public void mouseExited(MouseEvent event) {
    }
    public void mousePressed(MouseEvent event) {
        int x = event.getX();
        if((x < xsquare) || (x > (xsquare + SIDE)))
            return;
        int y = event.getY();
        if((y < ysquare) || (y > (ysquare + SIDE)))
            return;
        xoffset = x - xsquare;
        yoffset = y - ysquare;
        moving = true;
    }
    public void mouseReleased(MouseEvent event) {
        if(moving) {
            xsquare = event.getX() - xoffset;
            ysquare = event.getY() - yoffset;
            moving = false;
            repaint();
        }
    }
    public void mouseMoved(MouseEvent event) {
    }
    public void mouseDragged(MouseEvent event) {
        if(moving) {
            xsquare = event.getX() - xoffset;
            ysquare = event.getY() - yoffset;
            repaint();
        }
    }
    public void update(Graphics g) {
        if(!rect.equals(getBounds())) {
            rect = getBounds();
            image = createImage(rect.width,rect.height);
        }
        if(xsquare < 0)
            xsquare = 0;
        else if(xsquare > (rect.width - SIDE))
            xsquare = rect.width - SIDE;
        if(ysquare < 0)
            ysquare = 0;
        else if(ysquare > (rect.height - SIDE))
            ysquare = rect.height - SIDE;
        Graphics ig = image.getGraphics();
        paint(ig);
        g.drawImage(image,0,0,this);
    }
    public void paint(Graphics g) {
        g.setColor(Color.cyan);
        g.fillRect(0,0,rect.width,rect.height);
        if(moving)
            g.setColor(Color.orange);
        else
            g.setColor(Color.black);
        g.fillRect(xsquare,ysquare,SIDE,SIDE);
    }
}
