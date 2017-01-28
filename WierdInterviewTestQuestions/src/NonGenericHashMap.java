import java.util.HashMap;

/**
 * Created by Todor Ilchev on 2017-01-19.
 */
public class NonGenericHashMap {

    public static void main(String[] args) {
        HashMap map = new HashMap<String, String>();
        map.put("asd", "asd");
        map.put(1, "dsa");
        map.put("sad", 1);
        System.out.println(map.get("asd"));
        System.out.println(map.get(1));
        System.out.println(map.get("sad"));
    }
}
