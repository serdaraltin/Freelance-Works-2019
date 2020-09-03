package client.states;
import java.awt.event.ActionEvent;


import client.CalcContext;
import client.State;

public class Error extends State{

	public Error(CalcContext context) {
		super(context);
	}

	@Override
	public void nextState(ActionEvent e) {

		String value = e.getActionCommand();
		switch(value) {
		
		case "C":
			this.context.setFirst("");
			this.context.setSecond("");
			this.context.getView().updateResult("");
			this.context.setState(new Start(this.context));
			break;
			
		default:
			this.context.setState(new Error(this.context));
			this.context.getView().updateResult("ERR");
			break;
		
		}
		
	}

}
