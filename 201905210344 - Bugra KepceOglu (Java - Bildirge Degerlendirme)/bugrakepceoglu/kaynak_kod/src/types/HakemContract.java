package types;

public class HakemContract {
	private int Id;
	private String KullaniciAd;
	private String Parola;
	private String Anahtar;
	

	public String getAnahtar() {
		return Anahtar;
	}
	public void setAnahtar(String anahtar) {
		Anahtar = anahtar;
	}
	
	public int getId() {
		return Id;
	}
	public void setId(int id) {
		Id = id;
	}
	public String getKullaniciAd() {
		return KullaniciAd;
	}
	public void setKullaniciAd(String kullaniciAd) {
		KullaniciAd = kullaniciAd;
	}
	public String getParola() {
		return Parola;
	}
	public void setParola(String parola) {
		Parola = parola;
	}
	
	public Object[] Listele() {
		Object[] veriler = {Id,KullaniciAd,Parola,Anahtar};
		return veriler;
	}

}
