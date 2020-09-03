package ast;

public class DoWhileNode extends StmtNode{
    protected StmtNode body;
    protected ExprNode cond;

    public DoWhileNode(StmtNode body, ExprNode cond){
        super();
        this.body = body;
        this.cond = cond;
    }

    public StmtNode body(){
        return body;
    }

    public ExprNode cond(){
        return cond;
    }

    @Override
    public <S, E> S accept(ASTVisitor<S, E> visitor) {
        return visitor.visit(this);
    }
}
