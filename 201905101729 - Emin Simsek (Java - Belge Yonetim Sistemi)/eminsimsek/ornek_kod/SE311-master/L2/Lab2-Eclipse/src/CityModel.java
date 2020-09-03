import java.awt.event.*;
import java.util.*;

/**
 * SE 311 Lab 2
 * <p>
 * Each object of this class represents a GUI enhanced model of a list of cities.
 * </p>
 * @version 1.0
 *
 */
public class CityModel extends CityList {

	/**
	 * List to keep track of who is registered to listen for events from the CityModel.
	 */
	private ArrayList<ActionListener> actionListenerList;
	
	/**
	 * @param country
	 */
	public CityModel(String country) {
		super(country);
	}

	/**
	 * @param city
	 */
	public void addToCitList(City city) {
		super.addToCityList(city);
		processEvent(new ActionEvent(this, ActionEvent.ACTION_PERFORMED, "add city"));
	}
	
	
	public void clearCityList() {
		super.clearCityList();
		processEvent(new ActionEvent(this, ActionEvent.ACTION_PERFORMED, "clear city list"));
	}
	
	/**
	 * Register an action event listener.
	 */
	public synchronized void addActionListener(ActionListener l) {
		if (actionListenerList == null)
			actionListenerList = new ArrayList<ActionListener>();
		actionListenerList.add(l);
	}
	
	/**
	 * Remove an action event listener.
	 */
	public synchronized void removeActionListener(ActionListener l) {
		if (actionListenerList != null && actionListenerList.contains(l))
			actionListenerList.remove(l);
	}
	
	/**
	 * Fire event.
	 */
	private void processEvent(ActionEvent e) {
		ArrayList<ActionListener> list;
		
		synchronized (this) {
			if (actionListenerList == null) return;
			list = (ArrayList<ActionListener>)actionListenerList.clone();
		}
		
		for (int i = 0; i < list.size(); i++) {
			ActionListener listener = list.get(i);
			listener.actionPerformed(e);
		}
	}
}