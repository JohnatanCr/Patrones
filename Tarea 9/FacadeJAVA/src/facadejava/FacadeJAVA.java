
package facadejava;


public class FacadeJAVA {

    
    public static void main(String[] args) {
        
        CheckFacade cliente1 = new CheckFacade();
        cliente1.buscar("30/03/2019", "06/04/2019", "Villahermosa", "Merida");
        
        CheckFacade cliente2 = new CheckFacade();
        cliente2.buscar("30/03/2019", "06/04/2019", "Villahermosa", "Alcoholismo");
    }
    
}
