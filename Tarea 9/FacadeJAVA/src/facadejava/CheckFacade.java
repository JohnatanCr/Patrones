
package facadejava;


public class CheckFacade {
    
    private final Avion avion;
    private final Hotel hotel;
    
    public CheckFacade()
    {
        avion = new Avion();
        hotel = new Hotel();        
    }
    
    public void buscar(String fechaIda, String fechaVuelta, String origen, String destino)
    {
        avion.buscarVuelos(fechaIda, fechaVuelta, origen, destino);
        hotel.buscarHoteles(fechaIda, fechaVuelta, origen, destino);
    }
}
