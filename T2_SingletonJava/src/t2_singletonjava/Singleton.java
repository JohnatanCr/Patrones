/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package t2_singletonjava;

import javax.swing.JPanel;




public final class Singleton {


    protected  JPanel instance;

    protected Singleton() {}
    protected javax.swing.JPanel GetIntance()
            {
                if (instance==null)
                {
                    return instance=new JPanel();
                }

                    return instance;
                
            }
}
