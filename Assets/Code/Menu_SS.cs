using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Menu_SS : MonoBehaviour
{
    public GameObject startChoices;
    public GameObject controls;
    public GameObject credits;
    public GameObject whole;

    public int currentSceneIndex;
    public float transitionTime = 1f;
    private LevelLoader level;
    public Canvas canvas;
    public GameObject levelGameObject;

    public float highScore;
    public bool startingMenu;
    TextMeshProUGUI StartscoreText;
    public GameObject Startscore_Text;

    void Awake()
    {
        level = levelGameObject.GetComponent<LevelLoader>();
        canvas.sortingOrder = -1;
        if (startingMenu == true)
        {
            highScore = PlayerPrefs.GetFloat("Score");
            StartscoreText = Startscore_Text.GetComponent<TextMeshProUGUI>();
            StartscoreText.text = "High Score:\n" + highScore.ToString();
        }
    }
    public void LoadGame()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));
    }
    public void StartGame()
    {
        StartCoroutine(StartLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void NeutralGame()
    {
        StartCoroutine(NeutralLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        canvas.sortingOrder = 1;
        GameObject.Find("Loading Manager").GetComponent<LoadingManager>().load = true;
        level.transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        level.sliderTransition.SetTrigger("LoadStart");

        yield return new WaitForSeconds(0.5f);

        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        yield return new WaitForSeconds(transitionTime);

        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);

        level.loadingScreen.SetActive(true);

        while (operation.isDone == false)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            level.slider.value = progress;
            level.progressText.text = progress * 100f + "%";

            yield return null;
            level.sliderTransition.SetTrigger("LoadEnd");
        }
    }

    IEnumerator StartLevel(int levelIndex)
    {
        canvas.sortingOrder = 1;
        GameObject.Find("Loading Manager").GetComponent<LoadingManager>().load = false;
        level.transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        level.sliderTransition.SetTrigger("LoadStart");

        yield return new WaitForSeconds(0.5f);

        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        yield return new WaitForSeconds(transitionTime);

        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);

        level.loadingScreen.SetActive(true);

        while (operation.isDone == false)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            level.slider.value = progress;
            level.progressText.text = progress * 100f + "%";

            yield return null;
            level.sliderTransition.SetTrigger("LoadEnd");
        }
    }

    IEnumerator NeutralLevel(int levelIndex)
    {
        canvas.sortingOrder = 2;
        level.transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        level.sliderTransition.SetTrigger("LoadStart");

        yield return new WaitForSeconds(0.5f);

        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        yield return new WaitForSeconds(transitionTime);

        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);

        level.loadingScreen.SetActive(true);

        while (operation.isDone == false)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            level.slider.value = progress;
            level.progressText.text = progress * 100f + "%";

            yield return null;
            level.sliderTransition.SetTrigger("LoadEnd");
        }
    }

    public void RestartGame()
    {
        levelGameObject.SetActive(true);
        StartCoroutine(NeutralLevel(SceneManager.GetActiveScene().buildIndex - 1));
    }
    public void ExitGame()
    {
        levelGameObject.SetActive(true);
        StartCoroutine(NeutralLevel(SceneManager.GetActiveScene().buildIndex - 2));
    }
    public void EnterControlGame()
    {
        controls.SetActive(true);
        startChoices.SetActive(false);
    }
    public void ExitControlGame()
    {
        controls.SetActive(false);
        startChoices.SetActive(true);
    }
    public void EnterCreditsGame()
    {
        credits.SetActive(true);
        whole.SetActive(false);
    }
    public void ExitCreditsGame()
    {
        credits.SetActive(false);
        whole.SetActive(true);
    }
}