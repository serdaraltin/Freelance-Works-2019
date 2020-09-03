package zhuoqiu;

import java.awt.*;
import java.awt.event.*;
import java.awt.geom.*;
import javax.swing.*;
import java.util.*;

public class Ball {
	public String mingzi = "";
	public Color yanse;
	public int daxiao,bianhao;
	public Point zhongxin;
	public double x,y, dx,dy,ddx,ddy;
	public boolean yidong = false, mouseDrag = false;

	public Ball(int qiubianhao, String mingzi, Color color, double x, double y, int speed, double direction, int daxia) {
		this.bianhao = qiubianhao;
		this.mingzi = mingzi;
		this.yanse = color;
		this.daxiao = daxia;
		this.zhongxin = new Point();
		this.zhongxin.setLocation(x, y);
		this.x = x;
		this.y = y;

		System.out.println("生成了" + mingzi );
	}
}