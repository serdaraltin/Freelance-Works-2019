//interface Pipe
interface Pipe{
    public boolean put(Object obj);
    public Object get() throws InterruptedException;
    public boolean isEmpty();
    public int getSize();
}