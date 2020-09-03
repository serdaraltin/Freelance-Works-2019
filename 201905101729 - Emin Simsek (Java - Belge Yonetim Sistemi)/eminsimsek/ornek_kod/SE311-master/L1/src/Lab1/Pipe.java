package Lab1;

//interface Pipe
interface Pipe{
    public boolean put(Object obj);
    public Object get() throws InterruptedException;
}

