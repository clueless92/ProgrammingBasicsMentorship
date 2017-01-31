public class WierdCasting {

    public static void main(String[] args) {
        int a = 1;
        double d = 1.4d;
        a += d; // this is not the same as
//        a = a + d; // this

        // the first one does casts automatically
    }
}
