package client.visitor;

import client.Visitor;

public class Operand extends Operation{

	public Operand(){}
	
	public Operand(String value) {
		super(value);
	}

	@Override
	public void accept(Visitor v) {
		v.visitOperand(this);
	}
	
	public void setValue(String operand){
		this.value = operand;
	}
	
}
