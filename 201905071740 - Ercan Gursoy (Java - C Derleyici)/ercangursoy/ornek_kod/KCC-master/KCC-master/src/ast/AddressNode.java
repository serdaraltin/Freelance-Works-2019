package ast;

import type.Type;

public class AddressNode extends ExprNode{
    final ExprNode expr;
    Type type;

    public AddressNode(ExprNode expr){
        this.expr = expr;
    }

    public ExprNode expr(){
        return expr;
    }

    public Type type(){
        if(type == null){
            throw new Error("type is null");
        }else{
            return type;
        }
    }

    @Override
    public <S, E> E accept(ASTVisitor<S, E> visitor) {
        return visitor.visit(this);
    }

    public void setType(Type type){
        if(this.type != null){
            throw new Error("type set twice");
        }else{
            this.type = type;
        }

    }
}
