package types;

public class PuanContract {
	private int Id;
	private int BildirgeId;
	private int HakemId;
	private int Puan;
	
	public int getId() {
		return Id;
	}
	public void setId(int id) {
		Id = id;
	}
	public int getHakemId() {
		return HakemId;
	}
	public void setHakemId(int hakemId) {
		HakemId = hakemId;
	}
	public int getPuan() {
		return Puan;
	}
	public void setPuan(int puan) {
		Puan = puan;
	}
	public int getBildirgeId() {
		return BildirgeId;
	}
	public void setBildirgeId(int bildirgeId) {
		BildirgeId = bildirgeId;
	}
}
