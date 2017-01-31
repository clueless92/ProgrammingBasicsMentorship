import java.util.HashMap;

public class NonGenericHashMap {

    public static void main(String[] args) {
        HashMap map = new HashMap<String, String>();
        map.put("a", "a");
        map.put(1, "b"); // 8
        map.put("c", 1); // 9
        System.out.println(map.get("a"));
        System.out.println(map.get(1)); // 11
        System.out.println(map.get("c")); // 12
    }

    // a) compile time error on line 8
    // b) runtime error on line 8
    // c) compile time error on line 9
    // d) runtime error on line 9
    // e) compile time error on line 11
    // f) runtime error on line 11
    // g) compile time error on line 12
    // h) runtime error on line 12
    // i) no errors - prints:
    //    a
    //    b
    //    1
}
