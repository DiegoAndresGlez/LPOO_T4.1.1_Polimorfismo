public class Procariota extends Celula{
    private boolean nucleo = false;

    public boolean getNucleo() {
        return nucleo;
    }

    public void setNucleo(boolean nucleo) {
        this.nucleo = nucleo;
    }

    public String toString(){
        return super.toString() + "Existe nucleo? "+nucleo+"\n";
    }    
}
