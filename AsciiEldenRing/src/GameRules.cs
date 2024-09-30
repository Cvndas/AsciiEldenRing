public class GameRules
{
    // Defining the space of the UI and the world that occupies it
    public const int SCREEN_BORDER_TOP = 0;
    public const int SCREEN_BORDER_BOTTOM = 30;
    public const int SCREEN_BORDER_LEFT = 0;
    public const int SCREEN_BORDER_RIGHT = 30;

    public const int CONTROLS_HINT_LANE = SCREEN_BORDER_TOP + 1;
    public const int CONTROLS_HINT_BORDER_TOP = SCREEN_BORDER_BOTTOM;
    public const int CONTROLS_HINT_BORDER_LEFT = SCREEN_BORDER_LEFT + 4;
    public const int CONTROLS_HINT_BORDER_RIGHT = SCREEN_BORDER_RIGHT - 4;
    public const int CONTROLS_HINT_BORDER_BOTTOM = CONTROLS_HINT_LANE + 1;

    public const int STATUS_BAR_BORDER_TOP = CONTROLS_HINT_BORDER_BOTTOM;
    public const int STATUS_BAR_LANE = STATUS_BAR_BORDER_TOP + 1;
    public const int STATUS_BAR_BORDER_LEFT = SCREEN_BORDER_LEFT;
    public const int STATUS_BAR_BORDER_RIGHT = SCREEN_BORDER_RIGHT;
    public const int STATUS_BAR_BORDER_BOTTOM = STATUS_BAR_LANE + 1;

    public const int EQUIPMENT_BAR_BORDER_TOP = STATUS_BAR_BORDER_BOTTOM;
    public const int EQUIPMENT_BAR_LANE = EQUIPMENT_BAR_BORDER_TOP + 1;
    public const int EQUIPMENT_BAR_BORDER_LEFT = SCREEN_BORDER_LEFT + 4;
    public const int EQUIPMENT_BAR_BORDER_RIGHT = SCREEN_BORDER_RIGHT - 4;
    public const int EQUIPMENT_BAR_BORDER_BOTTOM = EQUIPMENT_BAR_LANE + 1;

    public const int GAME_VIEW_BORDER_TOP = EQUIPMENT_BAR_BORDER_BOTTOM;
    public const int GAME_VIEW_BORDER_BOTTOM = SCREEN_BORDER_BOTTOM - 2;
    public const int GAME_VIEW_BORDER_LEFT = SCREEN_BORDER_LEFT;
    public const int GAME_VIEW_BORDER_RIGHT = SCREEN_BORDER_RIGHT;

    public const int RUNE_BAR_BORDER_TOP = GAME_VIEW_BORDER_BOTTOM;
    public const int RUNE_BAR_LANE = RUNE_BAR_BORDER_TOP + 1;
    public const int RUNE_BAR_BORDER_LEFT = SCREEN_BORDER_LEFT + 6;
    public const int RUNE_BAR_BORDER_RIGHT = SCREEN_BORDER_RIGHT - 6;
    public const int RUNE_BAR_BORDER_BOTTOM = SCREEN_BORDER_BOTTOM;




    // Player Stats
    public const int PLAYER_HEALTH_MAX = 1000;
    public const int PLAYER_HEALTH_MIN = 1;
    public const int PLAYER_HEALTH_START = 10; // TODO : Make classes where this is different
    public const int PLAYER_ESTUS_START = 3;
    public const int PLAYER_ESTUS_MAX = 10;
    public const int PLAYER_ESTUS_MIN = 0;
    public const int PLAYER_LEVEL_START = 1;
    public const int PLAYER_LEVEL_MIN = 1;
}