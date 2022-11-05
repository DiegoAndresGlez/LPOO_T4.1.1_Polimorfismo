public class Main {
    public static void main(String[] args) {
        Dog dog = new Dog();
        Procariota proc = new Procariota();
        Eucariota euca = new Eucariota();
        Feline cat = new Cat(); //<- Polimorfismo
        dog.setEcosistema("Terrestre");
        dog.setEspecie("Canino");
        dog.setRaza("Beagle");
        dog.setColor("Cafe y blanco");
        dog.setLongevidad(15);
        dog.setTamano(50);
        dog.setPeso(45);
        proc.setName("Procariota");
        euca.setName("Eucariota");
        cat.setEcosistema("Terrestre");
        cat.setEspecie("Felino");
        cat.setRaza("Persa");
        cat.setColor("Café");
        cat.setLongevidad(14);
        cat.setTamano(50);
        cat.setPeso(25);
        System.out.println(dog.toString()+proc.toString()+euca.toString());
        System.out.println(cat.toString());
        cat.doAction();
        cat.super.doAction();
    }
}
