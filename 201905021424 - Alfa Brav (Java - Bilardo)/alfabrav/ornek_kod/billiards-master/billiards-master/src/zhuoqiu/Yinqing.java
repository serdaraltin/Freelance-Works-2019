package zhuoqiu;

import java.awt.*;
import java.util.*;

public class Yinqing implements Runnable {

    Game game;	
    Vector<Ball> balls;
	public static final int tbx = 100;
	public static final int tby = 100;

    boolean f = true, miaozhun  = true;

    int mv = 0, r = 1;

    public Yinqing( Game game ) {
        this.game = game;
    }

   	public static boolean cCol(Ball a, Ball b ) {
   		double dx = a.x - b.x;
   		double dy = a.y - b.y; 

   		double ds =  dx * dx + dy * dy;
   		
   		if (  Math.sqrt(ds) < 30 )  {
   			double kaa, kba, kab, kbb;
   			kba = (dx * a.dx + dy * a.dy) / ds; 
   			kaa = (dx * a.dy - dy * a.dx) / ds; 
   			kab = (dx * b.dx + dy * b.dy) / ds; 
   			kbb = (dx * b.dy - dy * b.dx) / ds; 

   			a.dy = kab * dy + kaa * dx;
   			a.dx = kab * dx - kaa * dy;

   			b.dy = kba * dy + kbb * dx;
   			b.dx = kba * dx - kbb * dy;

			Sound.HIT.sound();
   			return true;
   		}
   		return false;
   	}

	public void cF( Ball b) {
		double k = (b.dx * b.dx + b.dy * b.dy);

		k = Math.sqrt(k) * 120;

		if (k == 0) return;

		b.ddy = -b.dy / k;
		b.ddx = -b.dx / k;
    }

    private void dF( Ball c ) {
        c.dy += c.ddy;
        c.dx += c.ddx;
        if (c.dx > 0 == c.ddx > 0) {
            c.dx = 0;
            cRd();
        }
        if (c.dy > 0 == c.ddy > 0) {
            c.dy = 0;
            cRd();
        }
    }

	private boolean ifQiudai( Ball b ) {

		if ( game.mvBai ) return false;
		
		for ( Qiudai p : game.qiudais ) {

			double px = p.x+p.size/2;
			double py = p.y+p.size/2;

			double cx = b.x+b.daxiao/2;
			double cy = b.y+b.daxiao/2;

			double dx = cx-px;
			double dy = cy-py;
			double dist = Math.sqrt((dx*dx) + (dy*dy));
			if ( dist < p.size/2 ) {
				Sound.SINK.sound();
				cRd();
				return true;
			}
		}
		return false;
	}

	private void ifBounds( Ball b) {

		if (  b.x > Game.sx + tbx - 30 ) {
			b.dx  = -Math.abs( b.dx );
			b.ddx = Math.abs( b.ddx );
		}
		else if ( b.x < tbx ) {
			b.dx  = Math.abs( b.dx );
			b.ddx = -Math.abs( b.ddx );
		}

		if ( b.y < tby ) {
			b.dy  = Math.abs( b.dy );
			b.ddy = -Math.abs( b.ddy );
		}
		else if ( b.y > Game.sy + tby - 30 ) {
			b.dy  = -Math.abs( b.dy );
			b.ddy = Math.abs( b.ddy );
		}
	}

    public void cPos() {
            int ball, b;
            Ball i, j;

            for  ( ball = 0 ; ball < balls.size() ; ball++ ) {
                i = (Ball)balls.elementAt( ball );
                if (i.dy != 0 || i.dx != 0) {
                    i.y += i.dy;
                    i.x += i.dx;

                    if ( f ) dF(i);
                }

				if ( ifQiudai(i) ) {
					i.dx = 0;
					i.dy = 0;
					balls.remove(ball);
					if ( ball == game.baiqiuidx ) {
						game.skrch = true;
						game.baiqiuidx = -1;
					}
					else {
						if ( !game.skrch ) {
							game.baiqiuidx = game.fbaiidx( balls );
						}
						System.out.println(i.mingzi + "进球");
						game.adFall(i);
					}
				}
				else {
					ifBounds(i);

					for ( b = ball+1; b < balls.size() ; b++ ) {
						j = (Ball)balls.elementAt( b );
						if (cCol(i, j)) {
							cF(i);
							cF(j);
						}
					}
				}
            }

            cRd();
    }

	private void cRd() {
		for (Ball c : balls)
			if (c.dx != 0 || c.dy != 0)
				return;

		game.rd = true;
		if ( game.skrch ) {
			game.rdBall();
			game.mvBai = true;
			game.skrch = false;
		}
	}

	public void run() {
		long time;

		while (true) {
			time = System.currentTimeMillis();
			cPos();

			time = 5 - System.currentTimeMillis() + time;

			if (time < 0)
				time = 0;

			try {
				Thread.sleep(time, 1);
			} catch (InterruptedException e) {
				System.out.println(e.getMessage());
			}
		}
	}

}