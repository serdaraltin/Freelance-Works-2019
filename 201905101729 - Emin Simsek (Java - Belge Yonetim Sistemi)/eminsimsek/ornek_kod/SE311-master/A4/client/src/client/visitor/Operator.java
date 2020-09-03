package client.visitor;
import client.Visitor;

public class Operator extends Operation{
	
	public Operator(){}
	
	public Operator(String value) {
		super(value);
	}

	@Override
	public void accept(Visitor v) {
		v.visitOperator(this);
	}
	
	public void setValue(String operand){
		this.value = operand;
	}
}
