using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 
public class TimeControl : MonoBehaviour
{
    public Text timerText;
    public float timeLeftSeconds = 120F;
    public static bool TimesUp = false;
    public string GameName;

    void Start()
    {
        TimesUp = false;
    }


    void Update()
    {
        float t = timeLeftSeconds -= Time.deltaTime;
        string minutes = ((int)t / 60).ToString("00");
        string seconds = (t % 60).ToString("00");
       // string milliseconds = ((int)(t * 100f) % 100).ToString("00");

        timerText.text = "Timer: " + minutes + ":" + seconds;

        if (timeLeftSeconds <= 0)
        {
            timeLeftSeconds = 0;
            timerText.text = minutes + ":" + seconds;
            TimesUp = true;
        }

        if (TimesUp == true && Input.GetKeyDown("p"))
            SceneManager.LoadScene(GameName, LoadSceneMode.Single);

    }
    private void OnGUI()
    {
        if (TimesUp == true)
            GUI.Box(new Rect(0, 50, 250, 25), "GAME OVER. Press 'p' to play again");
    }
}
