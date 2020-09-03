package atakancoskuner;

import java.util.concurrent.Semaphore;


public class Main2 {

    static Semaphore semaphore = new Semaphore(1);

    static class barrier extends Thread {
        String name = "";

        public barrier(String name) {
            this.name = name;
        }
        public void run() {
            try {
                System.out.println(name + " : bariyer(kilit) aliniyor...");
                System.out.println(name + " : semaphore izni : " + semaphore.availablePermits());
                semaphore.acquire();
                System.out.println(name + " : izin alindi!");

                try {
                    for (int i = 1; i <= 3; i++) {
                        System.out.println(name + " : islem yapiliyor " + i + ", semaphore izni : " + semaphore.availablePermits());
                        Thread.sleep(1000);
                    }
                } finally {
                    System.out.println(name + " : bariyer(kilit) birakiliyor...");
                    semaphore.release();
                    System.out.println(name + " : semaphore izni : ");
                }

            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    public static void main(String[] args) {
        System.out.println("Toplam semaphore izni : " + semaphore.availablePermits());
        barrier P1 = new barrier("P1");
        P1.start();
        
        barrier P2 = new barrier("P2");
        P2.start();
        
        barrier P3 = new barrier("P3");
        P3.start();

    }

}
