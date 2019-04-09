
package adapaterjava;


public class AdapaterJAVA {

    
    public static void main(String[] args) {
        
        Adaptador conversor = new Adaptador();
        conversor.ingresarPesetas( 2000 );
        conversor.ingresarPesetas( 5000 );
        conversor.ingresarPesetas( 1000 );
        System.out.println( "Total euros: " + conversor.getTotalEuros() );
        
    }
    
}
