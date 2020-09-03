import java.util.*;
 
public class PipeImpl implements Pipe{
 
    private List buffer = new ArrayList();
 
    public synchronized boolean put(Object obj){
        boolean bAdded = buffer.add(obj);
        notify();
        return bAdded;
    }
 
    public synchronized Object get() throws InterruptedException{
        while(buffer.isEmpty()) wait(); //pipe empty - wait
        Object obj = buffer.remove(0);
        return obj;
    }


    public synchronized boolean isEmpty(){
        try{buffer.get(0);}
        catch(Exception e){return true;}
        return false;
    }



    public synchronized int getSize(){
        return buffer.size();
    }


}