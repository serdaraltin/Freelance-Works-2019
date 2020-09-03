package edu.bp208;

public class Motorsiklet extends Arac implements CiftTekerli{

    public void hareketEt(){
        System.out.println("Motorsiklet eglenceli ulasim icin guzeldir!");
    }
    
    //Burada hareketEt fonksiyonu overload(asiri yukleme) yapilmistir.
    //Overload fonksiyon olabilmesi icin bir onceki fonksiyondan farkli bir parametre alabilmelidir.
    public void hareketEt(int hizLimit){
        StringBuffer sb = new StringBuffer();
        sb.append("Motorsiklet ile hiz limiti ").append(hizLimit).append("km/saat\'tir");
        
        System.out.println(sb.toString());
    }
    
    //Burada method override yapilmistir.
    //Bir ust siniftan method alinmistir.
    @Override
    public void tekTekerGit() {
        System.out.println("Motorsiklet ile akrobasi gosterisi yapilabilir!");
    }
    
}








