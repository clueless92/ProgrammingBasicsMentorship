/**
 * Created by Todor Ilchev on 2017-01-19.
 */
public class AbstractNonAbstractInheritedMethod {

    class A {
        void asd() {

        }
    }

    abstract class B extends A {

        @Override
        abstract void asd();
    }
}
