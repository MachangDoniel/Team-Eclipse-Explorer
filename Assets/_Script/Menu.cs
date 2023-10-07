using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PreLevelLesson()
    {
        SceneManager.LoadScene("PreLevelLesson");
    }
    public void Level01()
    {
        SceneManager.LoadScene("Level01");
    }
    public void SimulationLobby()
    {
        Screen.orientation = ScreenOrientation.Portrait;

        SceneManager.LoadScene("SimulationLobby");
    }
    public void MultipleChoiseQuestion()
    {
        SceneManager.LoadScene("MultipleChoiceQuestion");
    }
    public void Lobby()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        SceneManager.LoadScene("Lobby");

    }
    public void Ar()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        SceneManager.LoadScene("AR");
    }
    public void _3D()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        SceneManager.LoadScene("3D");
    }

    public void _video()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        SceneManager.LoadScene("Video");
    }
    public void Rotate()
    {
        SceneManager.LoadScene("Rotate");
    }
    public void FindLoc()
    {
        SceneManager.LoadScene("FindLoc");
    }
    public void Slider()
    {
        SceneManager.LoadScene("Slider");
    }
    public void Level03()
    {
        SceneManager.LoadScene("EnterRocket");
    }

    public void News()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        SceneManager.LoadScene("News");
    }
}
