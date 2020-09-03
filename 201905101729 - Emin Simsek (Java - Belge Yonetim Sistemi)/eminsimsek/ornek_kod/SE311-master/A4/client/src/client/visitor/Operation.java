package client.visitor;
import client.Visitor;
import java.util.*;

public abstract class Operation {
	
	protected ArrayList<Operation> operation = new ArrayList<Operation>();
	String value = "";
	
	
	public Operation() {}
	
	public void accept(Visitor v){}
	
	public Operation(String value){
		this.value = value;
	}
	
	
	public Operation getOperation() {
		return this;
	}
	
	public void add(Operation operate){
		this.operation.add(operate);
	}
	
	public String getValue() {
		return this.value;
	}
	
	public void setValue(String value){ this.value = value;}
	
}

