/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.bp208;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

/**
 *
 * @author MAIN
 */
public class MotorsikletTest {
    
    public MotorsikletTest() {
    }
    
    @BeforeAll
    public static void setUpClass() {
    }
    
    @AfterAll
    public static void tearDownClass() {
    }
    
    @BeforeEach
    public void setUp() {
    }
    
    @AfterEach
    public void tearDown() {
    }

    /**
     * Test of hareketEt method, of class Motorsiklet.
     */
    @Test
    public void testHareketEt_0args() {
        System.out.println("hareketEt");
        Motorsiklet instance = new Motorsiklet();
        instance.hareketEt();
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of hareketEt method, of class Motorsiklet.
     */
    @Test
    public void testHareketEt_int() {
        System.out.println("hareketEt");
        int hizLimit = 0;
        Motorsiklet instance = new Motorsiklet();
        instance.hareketEt(hizLimit);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of tekTekerGit method, of class Motorsiklet.
     */
    @Test
    public void testTekTekerGit() {
        System.out.println("tekTekerGit");
        Motorsiklet instance = new Motorsiklet();
        instance.tekTekerGit();
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }
    
}

