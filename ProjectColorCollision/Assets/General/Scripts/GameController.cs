using System.Collections.Generic;

public class GameController {
    private List<FinishableComponent> suscribedGameComponents;
    private static GameController instance;
    private bool gameOver;

    private GameController() {
        suscribedGameComponents = new List<FinishableComponent>();
    }

    public static GameController getInstance() {
        if(instance == null) {
            instance = new GameController();
        }
        return instance;
    }

    public void suscribeToGame(FinishableComponent item) {
        suscribedGameComponents.Add(item);
    }
	
    public void finishGame() {
        this.gameOver = true;

        foreach(FinishableComponent component in suscribedGameComponents) {
            component.finish();
        }
    }

    public bool isGameOver() {
        return this.gameOver;
    }

}
