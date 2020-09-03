package types;

public class BildirgeContract {
	private int Id;
	private String Baslik;
	private String Metin;
	private String Anahtar;
	
	public int getId() {
		return Id;
	}
	public void setId(int id) {
		Id = id;
	}
	public String getBaslik() {
		return Baslik;
	}
	public void setBaslik(String baslik) {
		Baslik = baslik;
	}
	public String getMetin() {
		return Metin;
	}
	public void setMetin(String metin) {
		Metin = metin;
	}
	public String getAnahtar() {
		return Anahtar;
	}
	public void setAnahtar(String anahtar) {
		Anahtar = anahtar;
	}
	
	public Object[] Listele() {
		Object[] veriler = {Id,Baslik,Metin,Anahtar};
		return veriler;
	}

}
