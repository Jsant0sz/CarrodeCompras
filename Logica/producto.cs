namespace carritoligica
{
    public class Producto
    {
        // Propiedades auto-implementadas
        public int Stock { get; set; }
        public double Precio { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        // Constructor
        public Producto(int intstock, double precio, string nombre, string codigo)
        {
            this.Stock = stock;
            this.Precio = precio;
            this.Nombre = nombre;
            this.Codigo = codigo;
        }

        // Método para verificar stock suficiente
        public bool VerificarStock(int cantidad)
        {
            return cantidad > 0 && this.Stock >= cantidad;
        }

    // verifca los datos, si es mayor a cero, lo verefica en la cantidad

// -1 es amoyr a cero, no, pero para la maquina es fall, y verdadero es true, , ambos debes de ser verdaderos, para 

    public void mostrar prodcuto () {
        console.writeline ($¨{stcor}{srrnombre}¨);)
    }
    }
}