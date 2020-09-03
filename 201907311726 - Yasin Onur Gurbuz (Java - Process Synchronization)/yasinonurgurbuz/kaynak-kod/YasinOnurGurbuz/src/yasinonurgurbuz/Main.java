package yasinonurgurbuz;

import java.util.concurrent.Semaphore;

/**
 *
 * @author Yasin Oguz Gurbuz
 */
public class Main {
    /*
    Semaphore sinifindan semaphore adinda bir nesne uretme ve 
    yapici fonksiyona parametre olarak 1 degerini gonderme
     */
    static Semaphore semaphore = new Semaphore(1);

    /*
    barrier adinda bir class(sinif) olusturup Thread class(sinif)indan miras oldugunu
    belirtme
     */
    static class barrier extends Thread {
        
        /*
         name adinda String tipinde bir degisken tanimlama
         boylece o anki islemin ismi tutulabilecek
         */
        String name = "";

        /*
        barrier sinifi icin yapici bir fonksiyon olusturup parametre olarak
        String tipinde bir adet parametre alacagini bildirme
        */
        public barrier(String name) {
            /*
            dana onceden olusturulan name degiskeni icerisine fonksiyondan parametre olarak
            gelen degeri atama
            */
            this.name = name;

        }

        /*
        geriye herhangi bir deger dondurmeyen void(tipsiz) bir
        fonksiyon olusturma
        bu fonksiyonun isminin "run" olmasi sinifin Thread sinifindan genisletilmesinden kaynaklidir
        cunku bu isimdeki fonksiyon goruldugu yerdeki islemler ilk calistirilacaktir
        */
        public void run() {

            /*
            islemler sirasinda hata olusmasi durumuna karsi try-cath bloklari tanimlama
            */
            try {
                /*
                cikti olarak ekrana o anki islem ismini yazdirarak bariyer icin izin alindigini belirtme
                */
                System.out.println(name + " : bariyer(kilit) aliniyor...");
                /*
                o anki islemin iznini yazdirma 
                "1" izin var "0 veya bos" izin yok
                */
                System.out.println(name + " : semaphore izni : " + semaphore.availablePermits());
                /*
                semaphore den o anki islem icin izin alma
                boylece diger islemler su anki islemi bekleyecek
                */
                semaphore.acquire();
                /*
                izinin alindigini belirtme
                */
                System.out.println(name + " : izin alindi!");

                /*
                islemler sirasinda hata olusmasi durumuna karsi try-finally bloklari tanimlama
                */
                try {
                    /*
                    bir for dongusu olusturulup daha onceden belirlenmis tum islemler icin 
                    saglanmasini belirtme
                    */
                    for (int i = 1; i <= 3; i++) {
                        /*
                        hangi islemin yapildigini belirtme ve izin durumunu belirtme
                        */
                        System.out.println(name + " : islem yapiliyor " + i + ", semaphore izni : " + semaphore.availablePermits());
                        /*
                        her islem icin 1000 milisaniye(1 saniye) beklemesini belirtme
                        */
                        Thread.sleep(1000);
                    }
                /*
                son olarak islem icin yapilmasi istenilenler
                */
                } finally {
                    /*
                    beriyerin kaldirildigini yazdirma
                    */
                    System.out.println(name + " : bariyer(kilit) birakiliyor...");
                    /*
                    bariyeri(kilit) kaldirma
                    */
                    semaphore.release();
                    /*
                    semaphor iznini goruntuleme , bariyer kaldirildigi icin izin degisti
                    */
                    System.out.println(name + " : semaphore izni : ");
                }

            } catch (Exception e) {
                /*
                herhangi bir hata olusmasi durumunda olusan hata mesajini yazdirma
                */
                e.printStackTrace();

            }
        }
    }

    /*
    main fonksiyonu programin baslayacagi yeri belirtir
    */
    public static void main(String[] args) {
        /*
        baslangicta ki semaphore iznini yazdirma
        */
        System.out.println("Toplam semaphore izni : " + semaphore.availablePermits());
        /*
        berrier adinda tanimlanan siniftan yeni bir nesne uretme ve bu nesnenin yapici fonksiyonuna parametre olarak
        islem icin belirlenen ismi iletme
        */
        barrier P1 = new barrier("P1");
        /*
        P1 adinda tanimlanan barrier nesnesi Thread sinifindan miras oldugu icin
        start fonksiyonunu cagirarak calismaya baslatma
        */
        P1.start();
        
        /*
        P2 adinda islem nesnesi tanimlama ve calistirma
        */
        barrier P2 = new barrier("P2");
        P2.start();

        /*
        P3 adinda islem nesnesi tanimlama ve calistirma
        */
        barrier P3 = new barrier("P3");
        P3.start();

    }

}
