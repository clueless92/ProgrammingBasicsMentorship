/**
 * Created by Todor Ilchev on 2017-01-26.
 */
public class StringEquals {

    public static void main(String[] args) {
        String a = null;
        boolean asd = "asd".equals(a);
        System.out.println(asd);
        asd = a.equals("asd");
        System.out.println(asd);
    }
}
