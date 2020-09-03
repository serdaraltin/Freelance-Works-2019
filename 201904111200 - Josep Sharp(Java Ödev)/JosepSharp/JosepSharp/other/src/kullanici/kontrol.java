package kullanici;


import javax.swing.JOptionPane;


public class kontrol {
 static String kul_yet="";

    public static String getKul_yet() {
        return kul_yet;
    }

    public static void setKul_yet(String kul_yet) {
        kontrol.kul_yet = kul_yet;
    }

   
    public boolean kontrol(int buttonID) {
        try {
             char[] yetki=kul_yet.toCharArray();
     
        if ( yetki[buttonID]=='1') {
        return true;
        } else {
          
            JOptionPane.showMessageDialog(null, "yetki alanı dışında.");
        }
    
        } catch (Exception e) {
            System.out.println("kontrol hatası:"+kul_yet);
        }
        
        
       
     return false; }
    
}
