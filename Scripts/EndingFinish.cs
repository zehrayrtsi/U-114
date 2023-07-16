using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingFinish : MonoBehaviour
{

    private bool levelCompleted = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            levelCompleted = true;
            int totalElmas = PlayerPrefs.GetInt("NextLevelDiamond9");

            if (totalElmas > 120)
            {
                SceneManager.LoadScene("Good Ending Screen");
                Time.timeScale = 1f;

            }
            else
            {
                SceneManager.LoadScene("Bad Ending Screen");
                Time.timeScale = 1f;

            }
        }
    }
}
