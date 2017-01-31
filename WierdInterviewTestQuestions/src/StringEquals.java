public class StringEquals {

    public static void main(String[] args) {
        String a = "asd"; // what happens if this is null?
        boolean asd = "asd".equals(a); // here?
        System.out.println(asd);
        asd = a.equals("asd"); // and here?
        System.out.println(asd);
    }
}
