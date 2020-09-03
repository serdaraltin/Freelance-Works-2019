package lab;

import java.util.Scanner;

public class Lab {

	public static void main(String[] args) {

		Scanner keyboard = new Scanner(System.in);
		
		int n;
		System.out.print("Test: printTopLeftTriangle(n): Please enter n: ");
		n = keyboard.nextInt();
		printTopLeftTriangle(n);
		
		/* Output: for n=5
		 * *****
		 * ****
		 * ***
		 * **
		 * *
		 */
		
		System.out.print("Test: printDownLeftTriangle(n): Please enter n: ");
		n = keyboard.nextInt();
		printDownLeftTriangle(n);
		
		/* Output: for n=5
		 * *
		 * **
		 * ***
		 * ****
		 * *****
		 */

		System.out.print("Test: printTopRightTriangle(n): Please enter n: ");
		n = keyboard.nextInt();
		printTopRightTriangle(n);

		/* Output: for n=5
		 * *****
		 *  ****
		 *   ***
		 *    **
		 *     *
		 */

		System.out.print("Test: findNthPrime(n): Please enter n: ");
		n = keyboard.nextInt();
		findNthPrime(n);
		
		/*
		Test: findNthPrime(n): Please enter n: 10
		(1) 1
		(2) 2
		(3) 3
		(4) 5
		(5) 7
		(6) 11
		(7) 13
		(8) 17
		(9) 19
		(10) 23
		 */
		
		Student[] students = new Student[5];
		students[0] = new Student("Zeki", "Kerimoglu", 456);
		students[1] = new Student("Ali", "Kalyoncu");
		students[2] = new Student("Zeki", "Kerimoglu", 456);
		students[3] = new Student("Ayse", "Seloglu", 132);
		for (Student s : students) {
			if (s!=null) {
				if (s.equals(students[0]))
						System.out.print("(*) ");
				s.writeOut();
			}
		}

		/* Output:
		 
		(*) Zeki Kerimoglu (456)
		Ali Kalyoncu (0)
		(*) Zeki Kerimoglu (456)
		Ayse Seloglu (132)		 

		 */
		
		System.out.println(reformat("Erdogan", '.'));
		System.out.println(reformat("Dogdu", '_'));
		System.out.println(reformat("JavaJavaJavaJavaJavaJava", '*'));

		/* Output:
		
		E.r.d.o.g.a.n
		D_o_g_d_u
		J*a*v*a*J*a*v*a*J*a*v*a*J*a*v*a*J*a*v*a*J*a*v*a

		 */

		/* Verilen bir tamsayı dizisindeki sayılardan kaç tanesinin
		   verilen tamsayı n'e tam bölünebildiğini bulan bolunenSayisi metodunu yazın
		 */
		
		int[] dizi = {1,5,6,4,12,999,2,27};
		System.out.println("3'e bölünen sayıların sayısı: " + bolunenSayisi(dizi,3));
		
		/* Output:

		   3'e bölünen sayıların sayısı: 4
		   
		 */
		
		keyboard.close();
	}
	
}
