public class Eucariota : Celula{
    private Boolean nucleo = true;

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