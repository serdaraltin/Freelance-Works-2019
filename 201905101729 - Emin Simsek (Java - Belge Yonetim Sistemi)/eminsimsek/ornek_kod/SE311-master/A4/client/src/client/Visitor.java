package client;
import client.visitor.Operation;


public interface Visitor {
	public void visitOperator(Operation operation);
	public void visitOperand(Operation operation);
}
