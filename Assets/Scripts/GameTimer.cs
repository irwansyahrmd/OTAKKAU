
public class GameTimer
{
    private static GameTimer _instance = new GameTimer();
    public float currentTime {set; get;}

    public global::GameTimer GameTimer1
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
        }
    }
    
    private GameTimer()
    {
        
    }

    public static GameTimer getInstance()
    {
        return _instance;
    }

    public void addTime(int additionTime)
    {
        currentTime += additionTime;
    }
}
