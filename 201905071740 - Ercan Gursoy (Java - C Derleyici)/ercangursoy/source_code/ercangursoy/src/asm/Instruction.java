package asm;

import ast.StringLiteralNode;

public class Instruction extends Assembly{
    protected String mnemonic;
    protected String suffix;
    protected Operand[] operands;

    public Instruction(String mnemonic){
        this(mnemonic, "", new Operand[0]);
    }

    public Instruction(String mnemonic, String suffix,
                       Operand a1){
        this(mnemonic, suffix, new Operand[]{a1});
    }

    public Instruction(String mnemonic, String suffix,
                       Operand[] operands){
        this.mnemonic = mnemonic;
        this.suffix = suffix;
        this.operands = operands;
    }

    public Instruction build(String mnemonic, Operand a1, Operand a2){
        return new Instruction(mnemonic, this.suffix,
                new Operand[]{a1, a2});
    }

    public Instruction(String mnemonic, String suffix, Operand a1, Operand a2){
        this(mnemonic, suffix,
                new Operand[]{a1, a2});
    }

    public boolean isInstruction(){
        return true;
    }

    public String mnemonic(){
        return this.mnemonic;
    }

    public boolean isJumpInstruction(){
        return mnemonic.equals("jmp")
                || mnemonic.equals("jz")
                || mnemonic.equals("jne")
                || mnemonic.equals("je")
                || mnemonic.equals("jne");
    }

    public int numOperands(){
        return this.operands.length;
    }

    public Operand operand1(){
        return this.operands[0];
    }

    public Operand operand2(){
        return this.operands[1];
    }

    public Symbol jmpDestination(){
        DirectMemoryReference ref = (DirectMemoryReference)operands[0];
        return (Symbol)ref.value();
    }

    public String toSource(SymbolTable table){
        StringBuffer buf = new StringBuffer();
        buf.append("\t");
        buf.append(mnemonic + suffix);
        String sep = "\t";
        for(int i = 0; i < operands.length; i++){
            buf.append(sep);
            sep = ", ";
            buf.append(operands[i].toSource(table));
        }
        return buf.toString();
    }

    public String toString(){
        return "#<Insn " + mnemonic + ">";
    }
}
