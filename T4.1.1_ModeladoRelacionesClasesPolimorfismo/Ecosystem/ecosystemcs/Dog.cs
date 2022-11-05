public class Dog : Organism, IAnimal{

	private String raza = "";
	private string color = "";
	private string especie = "";
	private float tamano = 0;
	private float peso = 0;

	public String getRaza() {
		return raza;
	}

	public void setRaza(String raza) {
		this.raza = raza;
	}

	public new String toString() {
		String s = "";
		s += "Raza: "+raza+"\n";
		s += "Color: "+color+"\n";
		s += "Especie: "+especie+"\n";
		s += "Tamano: "+tamano+"\n";
		s += "Peso: "+peso+"\n";
		return s + base.toString();
	}

    public string getColor()
    {
        return color;
    }

    public void setColor(string color)
    {
        this.color = color;
    }

    public string getEspecie()
    {
        return especie;
    }

    public void setEspecie(string especie)
    {
        this.especie = especie;
    }

    public float getTamano()
    {
        return tamano;
    }

    public void setTamano(float tamano)
    {
        this.tamano = tamano;
    }

    public float getPeso()
    {
        return peso;
    }

    public void setPeso(float peso)
    {
        this.peso = peso;
    }
}