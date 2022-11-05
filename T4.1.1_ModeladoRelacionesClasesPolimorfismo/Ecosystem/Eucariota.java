public class Eucariota extends Celula{
    private boolean nucleo = true;

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
