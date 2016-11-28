package sample;

import javafx.application.Platform;
import javafx.event.ActionEvent;
import javafx.scene.Scene;

public class LoseController {

    public void onNo(ActionEvent actionEvent) {
        Platform.exit();
    }

    public void onYes(ActionEvent actionEvent) {

    }
}
