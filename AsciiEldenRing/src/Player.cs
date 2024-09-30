class Player
{
    private short _level;
    private int _health;

    private short _estusCount;

    public Player()
    {
        _health = GameRules.PLAYER_HEALTH_START;
        _level = GameRules.PLAYER_LEVEL_START;
        _estusCount = GameRules.PLAYER_ESTUS_START;
    }

}