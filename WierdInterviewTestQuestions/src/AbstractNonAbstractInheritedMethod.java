public class AbstractNonAbstractInheritedMethod {

    // is this allowed in Java?

    class A {
        void asd() {

        }
    }

    abstract class B extends A {

        @Override
        abstract void asd();
    }
}
