public class Organism {

	private int longevidad;
	private String ecosistema = "";

	public int getLongevidad(){
		return longevidad;
	}

	public void setLongevidad(int longevidad) {
		this.longevidad = longevidad;
	}

	public String getEcosistema() {
		return ecosistema;
	}

	public void setEcosistema(String ecosistema) {
		this.ecosistema = ecosistema;
	}

	public string toString() {
		string s = "";
		s += "Longevidad: "+longevidad+" anios\n";
		s += "Ecosistema: "+ecosistema+"\n";
		return s;
	}
}