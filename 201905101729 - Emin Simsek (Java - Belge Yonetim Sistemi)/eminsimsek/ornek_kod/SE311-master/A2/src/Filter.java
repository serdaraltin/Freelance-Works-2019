public abstract class Filter implements Runnable {

	
	protected Pipe input_;
	protected Pipe output_;
	protected boolean is_started_;
	
	public Filter(Pipe input_, Pipe output_) {
		this.input_ = input_;
		this.output_ = output_;
		is_started_ = false;
	}


	@Override
	public void run() {
		transform();

	}
	
	public void start(){
	    if(!is_started_){
	        is_started_ = true;
	        Thread thread = new Thread(this);
	        thread.start();
	      }
	}
	
	public void stop(){
		is_started_ = false;
		
	}
	
	protected abstract void transform();
}