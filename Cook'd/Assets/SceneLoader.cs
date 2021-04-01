

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int nextSceneLoad;

    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void Advance()
    {
        if(SceneManager.GetActiveScene().buildIndex == 4)
        {
           Debug.Log("You Win!");
            SceneManager.LoadScene("credits");
        }
        else
        {
            SceneManager.LoadScene(nextSceneLoad);

            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }

        
    }

    public void ButtonPress()
    {
        soundmanager.PlaySound("Button Press");
    }

    public void credits()
    {
        SceneManager.LoadScene("credits");
    }

    public void DeletePrefs()
    {
        PlayerPrefs.DeleteAll();
    }


    public void levelselect()
    {
        SceneManager.LoadScene("Levelselect");
    }

    public void level1()
    {
        SceneManager.LoadScene("level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("level2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("level3");
    }

    public void Level4()
    {
        SceneManager.LoadScene("level4");
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("SUCKMABOLL");
    }

    public void BackToTitle()
    {
        SceneManager.LoadScene("Menu");
    }

  

  

    
   
}
