public class Procariota : Celula{
    private Boolean nucleo = false;

    public Boolean getNucleo() {
        return nucleo;
    }

    public void setNucleo(Boolean nucleo) {
        this.nucleo = nucleo;
    }

    public new String toString(){
        return base.toString() + "Existe nucleo? "+nucleo+"\n";
    }    
}