//TAMAMLANDI

import java.awt.*;
import java.awt.event.*;
import java.sql.Struct;
import java.util.*;
import javax.swing.*;
import javax.swing.border.*;

public class Game extends JPanel implements MouseListener, MouseMotionListener, Runnable {

	public static final int sy = 425;
	public static final int sx = 850;

	Vector<Ball> balls;
	Vector<Ball> jinqiuBalls;

	int beyazidx = -1;

	Menu mymenu;
	Reaction yinqing;

	public boolean rd;
	public boolean skrch = false;
	public boolean mvBai = true;
	public JLabel oyuncu1Label;
	public JLabel oyuncu2Label;

	public int oyuncu1puan = 0;
	public int oyuncu2puan = 0;
	public int secilioyuncu = 0;

	int mubiaoqiu = -1;
	boolean sorgu = false;
	HashMap<String, Integer> ql;

	public Game(Menu mymenu) {
		
		super();
		setDoubleBuffered(true);
		setBackground(new Color(0, 127, 0));
		setBorder(BorderFactory.createBevelBorder(BevelBorder.RAISED));
		addMouseListener(this);
		addMouseMotionListener(this);
		this.mymenu = mymenu;
		balls = new Vector<Ball>();
		yinqing = new Reaction(this);

		cBalls();
		yinqing.balls = balls;


		(new Thread(yinqing)).start();
		(new Thread(this)).start();

		rd = true;
		

		oyuncu1Label = new JLabel("Oyuncu 1 : ");
		//add(oyuncu1Label);
		
		oyuncu2Label = new JLabel("Oyuncu 2 : ");
		//add(oyuncu2Label);
		
		
	}

	public void newGame() {
		cBalls();
		yinqing.balls = balls;
		mvBai = true;
	}

	public void rdBall() {
		boolean beyaz = false;
		for (Ball c : balls) {
			if (c.isim.equals("beyaz"))
				beyaz = true;
		}

		if (!beyaz) {
			double cx = 800 + Reaction.tbx;
			double cy = sy / 2 + Reaction.tby;

			Ball b = new Ball(0, "beyaz", Color.WHITE, cx, cy, 0, 0, 30);
			balls.add(b);
			beyazidx = fbaiidx(balls);
		}
	}

	public int fbaiidx(Vector<Ball> balls) {
		Ball b;
		int idx = -1;
		for (int i = 0; i < balls.size(); i++) {
			b = (Ball) balls.elementAt(i);
			if (b.isim.equals("beyaz"))
				idx = i;
		}
		if (idx == -1) {
			System.out.println("Beyaz top yok");
			System.exit(0);
		}
		return idx;
	}


	public void cBalls() {
		balls = new Vector<Ball>();
		jinqiuBalls = new Vector<Ball>();

		double my = sy / 2 + Reaction.tby - 15;
		double fr = 150 + Reaction.tbx;

		balls.add(new Ball(0, "beyaz", Color.WHITE, (sx * .75) + Reaction.tbx, my, 0, 0, 30));
		balls.add(new Ball(1, "1", new Color(255, 255, 100), fr, my - 62, 0, 0, 30));
		
		balls.add(new Ball(2, "2", new Color(255, 0, 0), fr, my + 62, 0, 0, 30));
		

		beyazidx = fbaiidx(balls);


	}


	private void pball(Graphics g, Ball b) {
		if (b == null)
			return;
		int dx = (int) b.x + 8;
		int dy = (int) b.y + 8;
		int cl = 12;
		int r2=30;
		g.setColor(Color.WHITE);
		g.fillOval((int) b.x - 1, (int) b.y - 1, r2, r2);
		g.setColor(b.renk);

		if (b.sayi > 0 && b.sayi < 3) {
			g.fillOval((int) b.x - 1, (int) b.y - 1, r2, r2);
			if(b.sayi == 1)
				g.setColor(Color.RED);
			if(b.sayi == 2)
				g.setColor(Color.YELLOW);
			
			g.fillOval(dx, dy, cl, cl);
			
			g.setColor(Color.BLACK);
		
		} else if (b.sayi >= 9) {
			g.fillRect((int) b.x + 11, (int) b.y, 8, r2);

			g.setColor(Color.WHITE);
			g.fillOval(dx, dy, cl, cl);

			g.setColor(Color.BLACK);
			
		}
	}

	public void adFall(Ball c) {
		System.out.println("sal，" + c.isim);
		jinqiuBalls.add(c);
		int fallenCount = jinqiuBalls.size();
		c.x = 270 + (fallenCount * 31);
		c.y = 600;
	}

	@Override
	public void paint(Graphics g) {
	
		super.paint(g);

		g.setColor(Color.BLACK);
		g.drawRect(Reaction.tbx - 30, Reaction.tby - 30, sx + 60, sy + 60);
		g.drawRect(Reaction.tbx, Reaction.tby, sx, sy);


		for (Ball f : jinqiuBalls)
			pball(g, f);

		for (Ball c : balls)
			pball(g, c);
		
		if (sorgu){
	
			
			g.setColor(Color.LIGHT_GRAY);
			if (ql == null)
				return;
			g.drawLine(
			((Integer) ql.get("x1")).intValue(), 
			((Integer) ql.get("y1")).intValue(),
			((Integer) ql.get("x2")).intValue(), 
			((Integer) ql.get("y2")).intValue());
			
			
		}
		oyuncu1Label.setLocation(10, 600);
		oyuncu2Label.setLocation(10, 620);
	}

	public void mouseClicked(MouseEvent e) {
	}

	public void mousePressed(MouseEvent e) {
		if (!rd) {
			return;
		}

		System.out.println("tiklama " + e.getPoint());

		Ball k;
		for (int ball = 0; ball < balls.size(); ball++) {
			k = (Ball) balls.elementAt(ball);
			int r = (int) (k.boyut / 2);

			if (Math.abs((int) k.x - e.getPoint().x + 15) <= r && Math.abs((int) (k.y) - e.getPoint().y + 15) <= r) {
				if (ball == beyazidx && !mvBai)
					sorgu = true;
				mubiaoqiu = ball;
				k.faresurukle = true;
			}
		}
	}

	public void faresurukleged(MouseEvent e) {
		if (!rd) {
			return;
		}

		Ball bq = (Ball) balls.elementAt(beyazidx);

		int middleX = e.getX();
		int middleY = e.getY();
		if (sorgu) {
			ql = new HashMap<String, Integer>();
			ql.put("x1", (int) (middleX));
			ql.put("y1", (int) (middleY));
			
			int l = yinqing.miaozhun ? 10000 : 300;
			double dx = (bq.x) + 15 - middleX;
			double dy = (bq.y) + 15 - middleY;
			double i = l / (Math.sqrt(dx * dx + dy * dy));

			ql.put("x2", (int) ((dx * i) + middleX));
			ql.put("y2", (int) ((dy * i) + middleY));

		} else if (mvBai) {
			bq.x = middleX;
			bq.y = middleY;
		}
	}

	public void mouseReleased(MouseEvent e) {
		if (!rd) {
			return;
		}

		Ball bq = (Ball) balls.elementAt(beyazidx);

		System.out.println("surukleme " + e.getX() + "," + e.getY());
		ql = null;

		if (sorgu) {
			rd = false;

			bq.dx = (bq.x + 15 - e.getX()) / 50;
			bq.dy = (bq.y + 15 - e.getY()) / 50;
			
			System.out.println("top hizi " + bq.dx + ", " + bq.dy);

			yinqing.cF(bq);

			sorgu = false;
		
		} else if (mvBai) {
			mvBai = false;
		}
	}

	public void mouseEntered(MouseEvent e) {
	}

	public void mouseExited(MouseEvent e) {
	}

	public void mouseMoved(MouseEvent e) {
		if (mvBai) {
			Ball b = (Ball) balls.elementAt(beyazidx);

			double nx = e.getX(), ny = e.getY();

			double xr = sx + Reaction.tbx - 15;
			double xl = (sx * 0.75) + Reaction.tbx;

			double yb = sy + Reaction.tby - 15;
			double yt = Reaction.tby + 15;

			if (nx > xr)
				nx = xr;
			else if (nx < xl)
				nx = xl;

			if (ny > yb)
				ny = yb;
			else if (ny < yt)
				ny = yt;

			b.x = nx - 15;
			b.y = ny - 15;
		}
	}

	public void run() {
		while (true) {
			repaint();
			try {
				Thread.sleep(9, 1);
			} catch (InterruptedException ex) {
				System.out.println(ex.getMessage());
			}
		}
	}

	@Override
	public void mouseDragged(MouseEvent arg0) {
		
		
	}
}