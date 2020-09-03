package client;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import client.states.*;
import client.visitor.*;
import java.util.*;
import java.net.*;
import java.io.*;


public class CalcContext implements ActionListener{

	/*context variables*/
	private State currentState = new Start(this);
	private CalculatorView view;

	/*use two arrays one to keep track of current operation 
	 * another to store total expression*/
	private ArrayList<Operation> current = new ArrayList<Operation>();
	private ArrayList<Operation> operation = new ArrayList<Operation>();
	
	/*operands and operators*/
	private Operation firstoperand = new Operand();
	private Operation secoperand = new Operand();
	private Operation operator = new Operator();
	
	
	public void setCalculator(CalculatorView calc) { view = calc;}

	
	public void setState(State state){
		this.currentState = state;
	}
	
	public State getState(){
		return this.currentState;
	}
	
	
	/*Getter and Setters for changing within the states*/
	public String getFirst(){ return this.firstoperand.getValue(); }
	public String getSecond() {return this.secoperand.getValue(); }
	public void setFirst(String first){ this.firstoperand.setValue(first); }
	public void setSecond(String second) { this.secoperand.setValue(second);}
	
	
	public CalculatorView getView(){
		return this.view;
	}
	
	
	public void actionPerformed(ActionEvent e)
	 {
		//get the action command when a button is pressed
		  String value = e.getActionCommand();
		  
		  /*condition to evaluate if second command eg 2 + 2 / 1*/
		  if(("*+-/".contains(value)) && isNotNull(firstoperand, secoperand, operator)){
			  
			if(operation.isEmpty()){
			
				//add all expressions to the array
			operation.add(new Operand(firstoperand.getValue()));
			operation.add(new Operator(operator.getValue()));
			operation.add(new Operand(secoperand.getValue()));
			current.addAll(Arrays.asList(firstoperand, operator, secoperand));
			  
			 }
			  else {
				  //only add the new + 5 no need to store first operand again
				  operation.add(new Operator(operator.getValue()));
				  operation.add(new Operand(secoperand.getValue()));				  
				  
				  current.add(1,operator);
				  current.add(2, secoperand);
				  
				  
			  }
			  /*update the view*/
			  update();
			  firstoperand.setValue(secoperand.getValue());
			  secoperand.setValue("");
		
		  }
		  
		  /*get the next state of the current view 
		   * and compare for certain states*/
		  this.currentState.nextState(e);
		  
		  if(this.currentState instanceof NextOperand){
			  this.operator.setValue(value);
			  
		  }		  
		  else if(currentState instanceof Calculate){
			  
			  /*condition to check if need to add the full operation or only the
			   * operator and second operand*/
			  if(!operation.isEmpty()){
				  
				  operation.addAll(Arrays.asList(operator, secoperand));
				  current.addAll(Arrays.asList(operator, secoperand));

			  }
			  else {
				  operation.addAll(Arrays.asList(firstoperand,operator,secoperand));
				  current.addAll(Arrays.asList(firstoperand, operator, secoperand));
			  }
			  
			 
			  //get the calculated value
			  String calculated = update();
			  
			  Operation equals = new Operator("=");
			  Operation total = new Operand(calculated);
			   
			  operation.addAll(Arrays.asList(equals, total));
			  
			  //send the operation to the server
			  try {
			  sendtoServer();
			  }
			  catch(Exception error){ System.out.println("ERROR: " + error);}
			  
			  //reset the current view
			  operation.removeAll(operation);
			  current.removeAll(current);
			  firstoperand.setValue("");
			  secoperand.setValue("");
			  operator.setValue(null);
		  }
		  
		  
	 }
	
	private boolean isNotNull(Operation firstoperand, Operation second, Operation operand){
		if((firstoperand.getValue() != "" && second.getValue() != "" ) && operand.getValue() != null)
			return true;
		else
			return false;
	}
	
	public String update(){
		/*to update the current operation compares what is stored in current and computes
		 * value*/
		double total=0;
		
			double firstdigit = Double.parseDouble(current.get(0).getValue());
			double seconddigit = Double.parseDouble(current.get(2).getValue());
			String operator = current.get(1).getValue();
			
			switch(operator){
				case "+":
					total = firstdigit + seconddigit;
					break;
				case "-":
					total = firstdigit - seconddigit;
					break;
				case "*":
					total = firstdigit * seconddigit;
					break;
				case "/":
					total = firstdigit / seconddigit;
				default:
					break;
			}
			
			/*remove the old operation in current and replace with new total value*/
			Operation updated = new Operand(Double.toString(total));
			current.set(0, updated);
			current.remove(1);
			current.remove(1);
			
			/*if integer remove the .0 and return the string*/
			if(total % 1 == 0) {
				int formatted = (int) total;
				view.updateResult(Integer.toString(formatted));
				return Integer.toString(formatted);
			}
			
		//update the view and return string if needed
		view.updateResult(Double.toString(total));
		return Double.toString(total);
	}
	
	
	public void sendtoServer() throws UnknownHostException, IOException{
		
		//converting the list of operations to string for easier handling with server
		ArrayList<String> stringOperations = new ArrayList<String>();
		Socket socket = new Socket("localhost", 8080);
		OutputStream os = socket.getOutputStream();
		ObjectOutputStream oos = new ObjectOutputStream(os);
		
		for(Operation op: operation) {
			stringOperations.add(op.getValue());
			System.out.println(op.getValue());
		}
		
		//write the arraylist close the string
		oos.writeObject(stringOperations);
		os.close();
		oos.close();
		socket.close();
		
	}
	
}