/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package test;

import controller.futbolcuController;
import entity.futbolcu;


public class run {
    public static void main(String[] args) {
        futbolcuController fcon = new futbolcuController();
    
        futbolcu f =new futbolcu("ahmet","sever",20,"turk","fenerbahce",5,1,3);
        
        fcon.Ekle(f);
        
        for(futbolcu fl: fcon.listele()){
            System.out.println(fl);
        }
        
       
        System.out.println("\n\naranan\n\n");
        for(futbolcu fl: fcon.Bul("necmi")){
            System.out.println(fl);
        }
    }
}
