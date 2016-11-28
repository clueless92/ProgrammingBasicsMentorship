package sample;

import javafx.animation.PathTransition;
import javafx.animation.RotateTransition;
import javafx.animation.ScaleTransition;
import javafx.animation.Timeline;
import javafx.event.ActionEvent;
import javafx.scene.control.Button;
import javafx.scene.control.Labeled;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.*;
import javafx.util.Duration;

public class LevelOneController {
    public Rectangle obst1;
    public Rectangle obst2;
    public Arc obst3;
    public Circle obst4;
    public Button buttonStart;
    public Button buttonFinish;

    private PathTransition anim1 = new PathTransition();
    private PathTransition anim2 = new PathTransition();
    private RotateTransition anim3 = new RotateTransition();
    private ScaleTransition anim4 = new ScaleTransition();

    public void onStart(ActionEvent actionEvent) {
        startGame();
    }

    public void onFinish(ActionEvent actionEvent) {

    }

    public void onMouseExited(MouseEvent event) {
        double x = event.getX();
        double y = event.getY();

        if(contains(buttonStart, x, y)) {
            return;
        }
        
        stopGame();
    }

    private boolean contains(Labeled item, double x, double y) {
        double tolerance = 2.0;
        double left = item.getLayoutX() - tolerance;
        double right = left + item.getWidth() + 2 * tolerance;
        double up = item.getLayoutY() - tolerance;
        double down = up + item.getHeight() + 2 * tolerance;

        return left <= x && x <= right && up <= y && y <= down;
    }

    private void stopGame() {

        anim1.jumpTo(Duration.ZERO);
        anim1.stop();
        anim2.jumpTo(Duration.ZERO);
        anim2.stop();
        anim3.jumpTo(Duration.ZERO);
        anim3.stop();
        anim4.jumpTo(Duration.ZERO);
        anim4.stop();
    }

    private void startGame() {
        anim1.setNode(obst1);
        anim1.setDuration(Duration.seconds(2.0));
        Path p1 = new Path();
        p1.getElements().add(new MoveTo(obst1.getWidth() / 2, obst1.getHeight() / 2));
        p1.getElements().add(new HLineTo(-60d));
        anim1.setPath(p1);
        anim1.setCycleCount(Timeline.INDEFINITE);
        anim1.setAutoReverse(true);
        anim1.play();

        anim2.setNode(obst2);
        anim2.setDuration(Duration.seconds(2.0));
        Path p2 = new Path();
        p2.getElements().add(new MoveTo(obst2.getWidth() / 2, obst2.getHeight() / 2));
        p2.getElements().add(new HLineTo(160d));
        anim2.setPath(p2);
        anim2.setCycleCount(Timeline.INDEFINITE);
        anim2.setAutoReverse(true);
        anim2.play();

        anim3.setNode(obst3);
        anim3.setDuration(Duration.seconds(3.5));
        anim3.setToAngle(360);
        anim3.setCycleCount(Timeline.INDEFINITE);
        anim3.play();

        anim4.setNode(obst4);
        anim4.setDuration(Duration.seconds(2.0));
        anim4.setCycleCount(Timeline.INDEFINITE);
        anim4.setByX(9.5);
        anim4.setByY(9.5);
        anim4.play();
    }
}
