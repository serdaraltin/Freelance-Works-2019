package zhuoqiu;

import java.awt.*;
import java.awt.event.*;
import java.util.*;
import javax.swing.*;
import javax.swing.border.*;

public class Game extends JPanel implements MouseListener, MouseMotionListener, Runnable {

	public static final int sy = 425;
	public static final int sx = 850;

	Vector<Ball> balls;
	Vector<Ball> jinqiuBalls;

	int baiqiuidx = -1;

	Menu mymenu;
	Yinqing yinqing;

	public boolean rd;
	public boolean skrch = false;
	public boolean mvBai = true;

	Vector<Qiudai> qiudais;

	int mubiaoqiu = -1;
	boolean zhixiangqiu = false;
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
		yinqing = new Yinqing(this);

		cBalls();
		yinqing.balls = balls;

		createQiudais();

		(new Thread(yinqing)).start();
		(new Thread(this)).start();

		rd = true;
	}

	public void newGame() {
		cBalls();
		yinqing.balls = balls;
		mvBai = true;
	}

	public void rdBall() {
		boolean baiqiu = false;
		for (Ball c : balls) {
			if (c.mingzi.equals("baiqiu"))
				baiqiu = true;
		}

		if (!baiqiu) {
			double cx = 800 + Yinqing.tbx;
			double cy = sy / 2 + Yinqing.tby;

			Ball b = new Ball(0, "baiqiu", Color.WHITE, cx, cy, 0, 0, 30);
			balls.add(b);
			baiqiuidx = fbaiidx(balls);
		}
	}

	public int fbaiidx(Vector<Ball> balls) {
		Ball b;
		int idx = -1;
		for (int i = 0; i < balls.size(); i++) {
			b = (Ball) balls.elementAt(i);
			if (b.mingzi.equals("baiqiu"))
				idx = i;
		}
		if (idx == -1) {
			System.out.println("没有白球!!!!");
			System.exit(0);
		}
		return idx;
	}

	public void createQiudais() {
		qiudais = new Vector<Qiudai>();
		qiudais.add(new Qiudai(100, 80));
		qiudais.add(new Qiudai(500, 80));
		qiudais.add(new Qiudai(900, 80));
		qiudais.add(new Qiudai(100, 500));
		qiudais.add(new Qiudai(500, 500));
		qiudais.add(new Qiudai(900, 500));

	}

	public void cBalls() {
		balls = new Vector<Ball>();
		jinqiuBalls = new Vector<Ball>();

		double my = sy / 2 + Yinqing.tby - 15;
		double fr = 150 + Yinqing.tbx;

		balls.add(new Ball(0, "baiqiu", Color.WHITE, (sx * .75) + Yinqing.tbx, my, 0, 0, 30));
		balls.add(new Ball(1, "1", new Color(255, 255, 100), fr, my - 62, 0, 0, 30));
		balls.add(new Ball(2, "2", new Color(50, 50, 255), fr, my - 31, 0, 0, 30));
		balls.add(new Ball(3, "3", new Color(200, 0, 50), fr, my, 0, 0, 30));
		balls.add(new Ball(4, "4", new Color(255, 0, 150), fr, my + 31, 0, 0, 30));
		balls.add(new Ball(5, "5", new Color(255, 100, 0), fr, my + 62, 0, 0, 30));
		balls.add(new Ball(6, "6", new Color(50, 255, 0), fr + 31, my - 47, 0, 0, 30));
		balls.add(new Ball(7, "7", new Color(100, 0, 0), fr + 31, my - 16, 0, 0, 30));
		balls.add(new Ball(8, "8", Color.BLACK, fr + 31, my + 16, 0, 0, 30));
		balls.add(new Ball(9, "9", new Color(200, 200, 0), fr + 31, my + 47, 0, 0, 30));
		balls.add(new Ball(10, "10", new Color(150, 0, 255), fr + 62, my - 31, 0, 0, 30));
		balls.add(new Ball(11, "11", new Color(150, 0, 0), fr + 62, my, 0, 0, 30));
		balls.add(new Ball(12, "12", new Color(255, 0, 150), fr + 62, my + 31, 0, 0, 30));
		balls.add(new Ball(13, "13", new Color(150, 255, 150), fr + 93, my - 16, 0, 0, 30));
		balls.add(new Ball(14, "14", new Color(0, 0, 150), fr + 93, my + 16, 0, 0, 30));
		balls.add(new Ball(15, "15", new Color(0, 0, 255), fr + 124, my, 0, 0, 30));

		baiqiuidx = fbaiidx(balls);


	}


	private void pball(Graphics g, Ball b) {
		if (b == null)
			return;
		int dx = (int) b.x + 8;
		int dy = (int) b.y + 8;
		int cl = 12;
		int r2=30;
		char[] n = (b.bianhao+"").toCharArray();
		g.setColor(Color.WHITE);
		g.fillOval((int) b.x - 1, (int) b.y - 1, r2, r2);
		g.setColor(b.yanse);

		if (b.bianhao > 0 && b.bianhao < 9) {
			g.fillOval((int) b.x - 1, (int) b.y - 1, r2, r2);
			
			g.setColor(Color.WHITE);
			g.fillOval(dx, dy, cl, cl);
			
			g.setColor(Color.BLACK);
			g.drawChars(n, 0, 1, (int) (b.x + 12), (int)(b.y + 17));
		} else if (b.bianhao >= 9) {
			g.fillRect((int) b.x + 11, (int) b.y, 8, r2);

			g.setColor(Color.WHITE);
			g.fillOval(dx, dy, cl, cl);

			g.setColor(Color.BLACK);
			g.drawChars(n, 0, n.length, (int) (b.x + 8), (int) (b.y + 17));
		}
	}

	public void adFall(Ball c) {
		System.out.println("掉落，" + c.mingzi);
		jinqiuBalls.add(c);
		int fallenCount = jinqiuBalls.size();
		c.x = 270 + (fallenCount * 31);
		c.y = 600;
	}

	@Override
	public void paint(Graphics g) {
		super.paint(g);

		g.setColor(Color.black);
		g.drawRect(Yinqing.tbx - 30, Yinqing.tby - 30, sx + 60, sy + 60);
		g.drawRect(Yinqing.tbx, Yinqing.tby, sx, sy);

		if (qiudais == null)
			createQiudais();
		for (Qiudai p : qiudais){
			if (p == null)
				return;
			g.setColor(Color.black);
			g.fillOval(p.x, p.y, p.size, p.size);
			}

		for (Ball f : jinqiuBalls)
			pball(g, f);

		for (Ball c : balls)
			pball(g, c);
		
		if (zhixiangqiu){
			g.setColor(Color.LIGHT_GRAY);
			if (ql == null)
				return;
			g.drawLine(((Integer) ql.get("x1")).intValue(), ((Integer) ql.get("y1")).intValue(),
					((Integer) ql.get("x2")).intValue(), ((Integer) ql.get("y2")).intValue());
		}
	}

	public void mouseClicked(MouseEvent e) {
	}

	public void mousePressed(MouseEvent e) {
		if (!rd) {
			return;
		}

		System.out.println("鼠标点击" + e.getPoint());

		Ball k;
		for (int ball = 0; ball < balls.size(); ball++) {
			k = (Ball) balls.elementAt(ball);
			int r = (int) (k.daxiao / 2);

			if (Math.abs((int) k.x - e.getPoint().x + 15) <= r && Math.abs((int) (k.y) - e.getPoint().y + 15) <= r) {
				if (ball == baiqiuidx && !mvBai)
					zhixiangqiu = true;
				mubiaoqiu = ball;
				k.mouseDrag = true;
			}
		}
	}

	public void mouseDragged(MouseEvent e) {
		if (!rd) {
			return;
		}

		Ball bq = (Ball) balls.elementAt(baiqiuidx);

		int middleX = e.getX();
		int middleY = e.getY();
		if (zhixiangqiu) {
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

		Ball bq = (Ball) balls.elementAt(baiqiuidx);

		System.out.println("鼠标释放" + e.getX() + "," + e.getY());
		ql = null;

		if (zhixiangqiu) {
			rd = false;

			bq.dx = (bq.x + 15 - e.getX()) / 50;
			bq.dy = (bq.y + 15 - e.getY()) / 50;
			
			System.out.println("球速" + bq.dx + ", " + bq.dy);

			yinqing.cF(bq);

			zhixiangqiu = false;
			Sound.CLASH.sound();
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
			Ball b = (Ball) balls.elementAt(baiqiuidx);

			double nx = e.getX(), ny = e.getY();

			double xr = sx + Yinqing.tbx - 15;
			double xl = (sx * 0.75) + Yinqing.tbx;

			double yb = sy + Yinqing.tby - 15;
			double yt = Yinqing.tby + 15;

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
}