package core;

public class CoreFields {
	
	private String UserName = "root";
	private String Password = "";
	private String Url = "jdbc:mysql://localhost/bildirgepuanlama";
	
	public String getUserName() {
		return UserName;
	}
	public void setUserName(String userName) {
		UserName = userName;
	}
	public String getPassword() {
		return Password;
	}
	public void setPassword(String password) {
		Password = password;
	}
	public String getUrl() {
		return Url;
	}
	public void setUrl(String url) {
		Url = url;
	}
	
}
