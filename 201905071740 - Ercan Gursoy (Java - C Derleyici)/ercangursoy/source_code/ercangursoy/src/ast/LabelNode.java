package ast;

public class LabelNode extends StmtNode{
    protected String name;
    protected StmtNode stmt;

    public LabelNode(String name, StmtNode stmt){
        super();
        this.name = name;
        this.stmt = stmt;
    }

    public String name(){
        return name;
    }

    public StmtNode stmt(){
        return stmt;
    }

    @Override
    public <S, E> S accept(ASTVisitor<S, E> visitor) {
        return visitor.visit(this);
    }
}
