using System.Security.Cryptography.X509Certificates;
using carritoligica;

namespace carrito.logica
    public class detalle{
    public Producto objproducto{get,set};
    public int intcantidad{get,set};
    // COnstructor
    public detalle(Producto objproducto, int intcantidad)
    {
        this.objproducto = objproducto;
        this.intcantidad = intcantidad;
    Public double calculador subtotal()2
    if (objproducto = null) #return 0.0;
    return objproducto. dblprecio * intcantidad,
    }

    public void mostrar detalle(){
        double dblsubtotal = calcular subtotal(),
        console.writeline(&¨{objproductostrnombre}{dblsubtotal}¨)
    }
}