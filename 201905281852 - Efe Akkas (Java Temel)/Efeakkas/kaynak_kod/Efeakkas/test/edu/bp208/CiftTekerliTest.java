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
public class CiftTekerliTest {
    
    public CiftTekerliTest() {
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
     * Test of tekTekerGit method, of class CiftTekerli.
     */
    @Test
    public void testTekTekerGit() {
        System.out.println("tekTekerGit");
        CiftTekerli instance = new CiftTekerliImpl();
        instance.tekTekerGit();
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    public class CiftTekerliImpl implements CiftTekerli {

        public void tekTekerGit() {
        }
    }
    
}

