public class StaticClassCreation {

    public static class InnerClass {

    }
}

class Test {

    // how would you instantiate an object of the static class InnerClass
    // from outside of class StaticClassCreation?

    public static void main(String[] args) {
//        StaticClassCreation.InnerClass a = new StaticClassCreation.InnerClass(); // a)
//        StaticClassCreation.InnerClass b = new InnerClass();                     // b)
//        StaticClassCreation c1 = new StaticClassCreation();                      // c)
//        StaticClassCreation.InnerClass c2 = new c.InnerClass();
//        InnerClass d = new StaticClassCreation.InnerClass();                     // d)
    }
}
