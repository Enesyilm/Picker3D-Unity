public static class GameState
{
   public enum GameStates {
       Failed,
       Continues,
       NotStarted,
       LevelFinished,
   }
   public static bool PlayerHaveBoost=false;
   public static int CurrentGemAmount=0;
   public static int CurrentLevel=0;
   public static int MaxLevelNumber=3;
   public static int LastJumpBlockIndex=0;
   public static float CurrentBoostDuration=1;
  public static GameStates currentGameState=GameStates.NotStarted;
}
