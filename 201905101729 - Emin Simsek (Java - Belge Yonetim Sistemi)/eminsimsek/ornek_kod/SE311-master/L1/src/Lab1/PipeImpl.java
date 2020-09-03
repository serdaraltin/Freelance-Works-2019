package Lab1;
//PipeImpl.java
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
}

