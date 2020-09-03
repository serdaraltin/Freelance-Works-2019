package atakancoskuner;

import java.util.concurrent.Semaphore;

/**
 *
 * @author atakancoskuner
 */
public class Main {

    static Semaphore semaphore = new Semaphore(1);

    public static int[] A = new int[3];
    public static int[] B = new int[3];

    /*
    calc1 fonksiyonunun tanimlanmasi
    geri dondurecegi deger aldigi parametredir
    */
    private static int calc1(int i) {
        return i;
    }
    /*
    calc2 fonksiyonunun tanimlanmasi
    geri dondurecegi deger 1
    */
    private static int calc2(int i, int[] A) {
        return 1;
    }
    /*
    barrier adinda bir sinif tanimlanip bu sinifin
    Thread sinifindan genisletildigi(miras) oldugu
    */
    static class barrier extends Thread {
        /*
        process adinda int veri tipinde bir degisken olusturma
        bu degisken o anki islem numarasini tutacak
        */
        int process;
        /*
        yapici fonksiyon ile parametre olarak gelen veriyi
        process degiskenine atama
        */
        public barrier(int process) {
            this.process = process;
        }
        /*
        sinif Thread sinifindan genisletildigi icin run fonksiyonunu gordugu yerde islem yapagindan
        run fonksiyonu tanimlanip herhangi bir deger dondurmeyecegi void(tipsiz) oldugu bildirilmesi
        */
        public void run() {
            try {
                /*
                islemin calistirilmasi durumunda
                yapilan islemler
                */
                System.out.println("olustur P" + process);
                A[process] = calc1(process);
                semaphore.acquire();
                System.out.println("izin alindi P" + process);
                B[process] = calc2(process, A);
                try {
                    /*
                    Thread sinifinin sleep fonksiyonunu cagirarak 1000 milisaniye yani 1 saniye degerinin verilmesi
                    boylece 1 saniye bekleyecek
                    */
                    Thread.sleep(1000);
                } finally {
                    /*
                    islem gerceklestirildikten sonra kilit aciliyor ve diger islem icin izin olusuyor
                    */
                    System.out.println("izin P" + process + " : " + semaphore.availablePermits());
                    semaphore.release();
                    System.out.println("kapat P" + process);
                }

            } catch (Exception e) {
                e.printStackTrace();
            }
            for (int i = 0; i < B.length; i++) {
                /*
                her islem asamasinda B dizisi ekrana bastiriliyor
                */
                System.out.println("P" + i + " : " + B[i]);
            }
        }
    }

    public static void main(String[] args) {
        /*
        mevcut semaphore izni ekrana bastirma
        */
        System.out.println("Mevcut semaphore izni : " + semaphore.availablePermits());
        /*
        barrier_init fonksiyonuna 3 degerini parametre olarak gonderme
        */
        barrier_init(3);

    }

    private static void barrier_init(int process_max) {
        /*
        bir dongu olusturup 0 dan baslayarak parametre olarak gelen degere dek dondurme
        */
        for (int i = 0; i < process_max; i++) {
            /*
            dongunun o anki degeri ile bir bariyer nesnesi olusturup baslatma
            */
            barrier p_barrier = new barrier(i);
            p_barrier.start();
        }

    }

}
