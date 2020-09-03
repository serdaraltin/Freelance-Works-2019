package client;

import java.awt.event.ActionEvent;

/*used abstract class to hold view so states can update on own*/
public abstract class State {
	protected CalcContext context;
	
	public State(CalcContext context){
		this.context = context;
	}
	
	public void nextState(ActionEvent e) {}
	
}
