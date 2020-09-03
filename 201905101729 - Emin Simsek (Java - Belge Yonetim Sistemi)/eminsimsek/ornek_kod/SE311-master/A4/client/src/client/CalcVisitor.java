package client;
import client.visitor.Operation;

public class CalcVisitor implements Visitor{

	@Override
	public void visitOperator(Operation operation) {
		operation.accept(this); //accept the operation visitors
	}

	@Override
	public void visitOperand(Operation operation) {
		operation.accept(this); //accept the operation visitors
	}

}
