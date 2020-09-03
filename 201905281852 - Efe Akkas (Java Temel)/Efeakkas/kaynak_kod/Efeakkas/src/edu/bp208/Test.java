package edu.bp208;

class Arac {// Sinif tanimlamasi.
    
    public void hareketEt(){
        //Burada konsola yazdirma islemi yapilmistir.
        System.out.println("Arac ulasim icin guzeldir!");
    }
}

//Burada Motorsiklet sinifi Arac sinifindan extend(genisletilmis) yani 
//Inheritance(kalitim) yapilmistir ve 
//CiftTekerli interface sinden methodlar alinmistir yapmistir.
 class Motorsiklet extends Arac implements CiftTekerli{

    public void hareketEt(){
        System.out.println("Motorsiklet eglenceli ulasim icin guzeldir!");
    }
    
    //Burada hareketEt fonksiyonu overload(asiri yukleme) yapilmistir.
    //Overload fonksiyon olabilmesi icin bir onceki fonksiyondan farkli bir parametre alabilmelidir.
    public void hareketEt(int hizLimit){
        StringBuffer sb = new StringBuffer(); // Bir StringBuffer olusturulmustur.
        sb.append("Motorsiklet ile hiz limiti ").append(hizLimit).append("km/saat\'tir"); //Append ile olusturulan sb ismindeki nesneye veri eklenmistir.
        
        System.out.println(sb.toString());//sb nesnesinin toString fonskiyonu kullanilarak String turunde icerisindeki veri dondurulmus ve konsola yazdirilmistir.
    }
    
    //Burada method override yapilmistir.
    //Bir ust siniftan method alinmistir.
    @Override //Netbeans ide si Override edilen methodu otomatik olarak etiketlemistir.
    public void tekTekerGit() {
        System.out.println("Motorsiklet ile akrobasi gosterisi yapilabilir!");
    }
    
}

//Burada inheritence olacak alan tanimlanmistir.
interface CiftTekerli {
    void tekTekerGit(); //void(tipsiz) method tanimlanmistir.
}

//Burada polymorphism yapilmistir
//Polimorfizm, nesneye yönelik programlamanın önemli kavramlarından biridir ve 
//sözlük anlamı olarak "bir çok şekil" anlamına gelmektedir. 
//Polimorfizm ile kalıtım konusu iç içedir. 
public class Test {
    public static void main(String[] args) {
        
        Arac arac2 = new Arac(); //Arac sinifindan uretilen yeni bir nesne tanimlanmistir.
        Arac arac1 = new Motorsiklet();
        Motorsiklet motorS1 = (Motorsiklet)arac1;
        
        arac2.hareketEt(); //Arac2 nesnesinin hareketEt fonksiyonu cagirilmistir.
        arac1.hareketEt(); //Arac1 nesnesinin hareketEt fonksiyonu cagirilmistir.
        motorS1.hareketEt(60); //Overload edilmis olan fonskiyon oldugu icin icerisine bir parametre verildiginde fonskiyonun parametreli olani cagirilmistir.
        motorS1.tekTekerGit(); // motorS1 nesnesinin tekTekerGit fonksiyonu cagirilmistir.
    }
}
































