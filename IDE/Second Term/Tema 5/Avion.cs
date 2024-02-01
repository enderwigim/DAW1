public class avion
{
    private float altura;
    private float velocidad; 
    private float combustible; 
    private int orientacion;

    public avion(float altura, float velocidad, float combustible, int orientacion)
    {
        this.altura = altura; 
        this.velocidad = velocidad;
        this.combustible = combustible; 
        this.orientacion = orientacion;
    }

    public float Altura
    {
        get { return altura; }
    }

    public int Orientacion
    {
        get { return orientacion; }
    }

    public float Combustible
    { 
        get { return combustible; } 
    }

    //Metodo que sirve para virar el avion los grados indicados.
    public void Virar(int grados)
    {
        orientacion = (orientacion + grados) % 360;
        ConsumirCombustible(grados * 0.1);
    }

    //Metodo que sirve para ascender los metros indicados
    public void Ascender(float metros) 
    {
        altura = altura + metros; 
        ConsumirCombustible(metros * 0.3);
    }

    //Metodo que sirve para descender los metros indicados
    public void Descender(float metros)
    {
        altura = altura - metros;
        if (altura < 0)
            altura = 0;
    }

    //Metodo que sirve para consumir los litros indicados de combustible.
    private void ConsumirCombustible(float litros)
    {
        combustible = combustible - litros;
        if (combustible < 0)
            combustible = 0;
    }
}