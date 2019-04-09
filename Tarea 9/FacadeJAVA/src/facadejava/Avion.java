
package facadejava;


public class Avion {
    
    public void buscarVuelos(String fechaIda, String fechaVuelta, String origen, String destino)
    {
        System.out.println("Vuelos encotrados para " + destino + " desde " + origen);
        System.out.println("Fecha IDA: " + fechaIda + "Fecha Vuelta: " + fechaVuelta);
    }
    
}
