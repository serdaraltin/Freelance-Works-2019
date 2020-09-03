package client;
import java.io.*;

public class MainCalc {

	public static void main(String[] args) throws IOException {
		
		//create new view and contrller objects
		CalcContext context = new CalcContext();
		CalculatorView view = new CalculatorView();
		
		//attach view and listners
		context.setCalculator(view);	
		view.attachListener(context);	
	}

	
}
