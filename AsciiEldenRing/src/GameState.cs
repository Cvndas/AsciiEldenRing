using System.Diagnostics;
enum GameModes
{
    START_SCREEN,
    OVERWORLD,
    COMBAT,
    DEATH,
    PAUSE,
    SHOP,
    GRACE
}

class GameState
{
    private static GameModes _gameMode;
    public static GameModes GameMode {
        get {
            return _gameMode;
        }
        set {
            Program.DD("Set GameMode to " + value);
            if (!Enum.IsDefined(typeof(GameModes), value)) {
                throw new ArgumentException("Invalid Gamemode set attempted");
            }
            _gameMode = value;
        }
    }

    public static Player? Player;

    public static void GameStateInit(){
        // TODO : Assert that this does indeed trigger GameState
        return;
    }

    static GameState()
    {
        Program.DD("Initializing the GameState");
        Player = new Player();
        Program.AA(Player != null);

        _gameMode = GameModes.START_SCREEN;
    }

    public static void GameLoop(){
        while (true){
            Thread.Sleep(1);
        }
    }
}