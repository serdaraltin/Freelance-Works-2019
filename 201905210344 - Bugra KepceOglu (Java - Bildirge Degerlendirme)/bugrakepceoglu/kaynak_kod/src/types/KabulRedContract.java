package types;

public class KabulRedContract {
	private int Id;
	private int BildirgeId;
	private String Durum;
	
	public int getId() {
		return Id;
	}
	public void setId(int id) {
		Id = id;
	}
	public int getBildirgeId() {
		return BildirgeId;
	}
	public void setBildirgeId(int bildirgeId) {
		BildirgeId = bildirgeId;
	}
	public String getDurum() {
		return Durum;
	}
	public void setDurum(String durum) {
		Durum = durum;
	}

}
