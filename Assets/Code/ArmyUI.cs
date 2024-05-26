using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ArmyUI : MonoBehaviour
{
    public GameObject attackButton;
    public GameObject buyButton;
    public GameObject pauseui;
    public GameObject choiceui;
    public GameObject newsui;
    public GameObject UIui;
    public GameObject countryui;
    public GameObject buyui;
    public GameObject moveui;
    public GameObject gameOverui;
    public GameObject controlsui;

    public LayerMask worldLayer;

    public string news;
    public string round;

    public GameObject touchCountry1;
    [HideInInspector] public GameObject touchCountryAI1;

    public GameObject touchCountry2;
    [HideInInspector] public GameObject touchCountryAI2;

    public bool touched;
    public bool ready;
    public bool pauseUI;
    public bool choiceUI;
    public bool newsUI;
    public bool buyUI;
    public bool moveUI;
    public bool gameOverUI;
    public bool controlsUI;

    public bool exitGameOver;

    public float scoreNumber;
    TextMeshProUGUI scoreText;
    public GameObject score_Text;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            //if (EventSystem.current.IsPointerOverGameObject()) return;
            if (hit.collider != null && newsUI == false && pauseUI == false && choiceUI == false && buyUI == false && gameOverUI == false && controlsUI == false)
            {
                if (hit.collider.gameObject.tag == "country" && moveUI == false)
                {
                    if (touched == false && hit.collider.gameObject.GetComponent<Control>().controller == GameObject.Find("information").GetComponent<countries>().playerCountry)
                    {
                        if (GameObject.Find("information").GetComponent<countries>().countryTurn == GameObject.Find("information").GetComponent<countries>().playerCountry)
                        {
                            if (touchCountry1 != GameObject.Find("information"))
                            {
                                touchCountry1.GetComponent<ColorC>().attackFlash = false;
                                touchCountry1.GetComponent<ColorC>().wait = false;
                            }
                            touchCountry1 = hit.collider.gameObject;
                            touchCountry1.GetComponent<ColorC>().attackFlash = true;
                            touchCountry1.GetComponent<ColorC>().wait = true;
                        }
                        foreach (GameObject countryAI1 in GameObject.FindGameObjectsWithTag("AI"))
                        {
                            if (touchCountry1.GetComponent<Control>().controller == countryAI1.GetComponent<Country_AI>().CountryType)
                            {
                                touchCountryAI1 = countryAI1;
                            }
                        }
                        EnableButton();
                    }
                    if (touched == true && hit.collider.gameObject.GetComponent<Control>().controller != GameObject.Find("information").GetComponent<countries>().playerCountry && ready == false)
                    {
                        if (GameObject.Find("information").GetComponent<countries>().countryTurn == GameObject.Find("information").GetComponent<countries>().playerCountry)
                        {
                            if (touchCountry1.GetComponent<Control>().accountGame0 == hit.collider.gameObject || touchCountry1.GetComponent<Control>().accountGame1 == hit.collider.gameObject || touchCountry1.GetComponent<Control>().accountGame2 == hit.collider.gameObject || touchCountry1.GetComponent<Control>().accountGame3 == hit.collider.gameObject || touchCountry1.GetComponent<Control>().accountGame4 == hit.collider.gameObject)
                            {
                                if (touchCountryAI1.GetComponent<Country_AI>().FranceWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 0f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().FranceWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 0f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().SpainWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 1f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().SpainWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 1f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().PortugalWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 2f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().PortugalWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 2f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().UKWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 3f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().UKWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 3f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().CRWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 4f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().CRWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 4f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().MoroccoWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 5f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().MoroccoWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 5f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().AlgeriaWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 6f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().AlgeriaWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 6f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().TunisWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 7f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().TunisWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 7f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().SardWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 8f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().SardWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 8f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().SicilyWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 9f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().SicilyWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 9f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().NaplesWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 10f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().NaplesWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 10f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().LuccaWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 11f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().LuccaWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 11f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().ItalyWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 12f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().ItalyWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 12f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().HelvetiaWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 13f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().HelvetiaWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 13f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().AustrianWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 14f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().AustrianWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 14f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().OttomanWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 15f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().OttomanWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 15f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().MonteWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 16f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().MonteWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 16f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().PrussiaWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 17f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().PrussiaWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 17f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().WarsawWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 18f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().WarsawWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 18f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().RussianWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 19f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().RussianWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 19f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().SwedenWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 20f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().SwedenWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 20f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }

                                if (touchCountryAI1.GetComponent<Country_AI>().NorwayWar == true && hit.collider.gameObject.GetComponent<Control>().controller == 21f)
                                {
                                    touchCountry2 = hit.collider.gameObject;
                                    ready = true;
                                }
                                if (touchCountryAI1.GetComponent<Country_AI>().NorwayWar == false && hit.collider.gameObject.GetComponent<Control>().controller == 21f)
                                {
                                    touchCountry2 = GameObject.Find("information");
                                    Debug.Log("Choose country at war");
                                }
                            }
                        }
                        DisableButton();
                    }
                }
                if (hit.collider.gameObject.tag == "country" && moveUI == true)
                {
                    if (touched == false && hit.collider.gameObject.GetComponent<Control>().controller == GameObject.Find("information").GetComponent<countries>().playerCountry)
                    {
                        if (touchCountry2 != GameObject.Find("information") && touchCountry1 != GameObject.Find("information"))
                        {
                            touchCountry1.GetComponent<ColorC>().attackFlash = false;
                            touchCountry1.GetComponent<ColorC>().wait = false;
                            touchCountry2.GetComponent<ColorC>().attackFlash = false;
                            touchCountry2.GetComponent<ColorC>().wait = false;
                        }
                        touchCountry1 = hit.collider.gameObject;
                        touchCountry1.GetComponent<ColorC>().attackFlash = true;
                        touchCountry1.GetComponent<ColorC>().wait = true;
                        touched = true;
                    }
                    if (touched == true && hit.collider.gameObject.GetComponent<Control>().controller == GameObject.Find("information").GetComponent<countries>().playerCountry)
                    {
                        if (touchCountry1 != hit.collider.gameObject)
                        {
                            touchCountry2 = hit.collider.gameObject;
                            touchCountry2.GetComponent<ColorC>().attackFlash = true;
                            touchCountry2.GetComponent<ColorC>().wait = true;
                            touched = false;
                        }
                    }
                }
            }
        }

        if (Input.GetKeyDown("p"))
        {
            if (GameObject.Find("information").GetComponent<countries>().countryTurn == GameObject.Find("information").GetComponent<countries>().playerCountry)
            {
                moveUI = false;
                choiceUI = false;
                buyUI = false;
                newsUI = false;
                controlsUI = false;
                EnablePause();
            }
        }
        if (Input.GetKeyDown("l"))
        {
            if (GameObject.Find("information").GetComponent<countries>().countryTurn == GameObject.Find("information").GetComponent<countries>().playerCountry)
            {
                moveUI = false;
                pauseUI = false;
                buyUI = false;
                newsUI = false;
                gameOverUI = false;
                controlsUI = false;
                EnableChoice();
            }
        }
        if (Input.GetKeyDown("n"))
        {
            moveUI = false;
            choiceUI = false;
            buyUI = false;
            pauseUI = false;
            gameOverUI = false;
            controlsUI = false;
            EnableNews();
        }
        if (Input.GetKeyDown("m"))
        {
            if (moveUI == false)
            {
                newsUI = false;
                choiceUI = false;
                buyUI = false;
                pauseUI = false;
                gameOverUI = false;
                controlsUI = false;
                EnableMove();
            }
        }
    }

    public void EnablePause()
    {
        pauseui.SetActive(true);
        moveui.SetActive(false);
        buyui.SetActive(false);
        choiceui.SetActive(false);
        newsui.SetActive(false);
        UIui.SetActive(false);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        countryui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = true;
        pauseUI = true;
    }
    public void DisablePause()
    {
        pauseui.SetActive(false);
        moveui.SetActive(false);
        buyui.SetActive(false);
        choiceui.SetActive(false);
        newsui.SetActive(false);
        UIui.SetActive(true);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        countryui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = false;
        pauseUI = false;
    }

    public void EnableChoice()
    {
        choiceui.SetActive(true);
        moveui.SetActive(false);
        buyui.SetActive(false);
        newsui.SetActive(false);
        pauseui.SetActive(false);
        UIui.SetActive(false);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        countryui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = true;
        choiceUI = true;
    }
    public void DisableChoice()
    {
        pauseui.SetActive(false);
        moveui.SetActive(false);
        buyui.SetActive(false);
        choiceui.SetActive(false);
        newsui.SetActive(false);
        UIui.SetActive(true);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        countryui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = false;
        choiceUI = false;
    }

    public void EnableNews()
    {
        newsui.SetActive(true);
        buyui.SetActive(false);
        moveui.SetActive(false);
        choiceui.SetActive(false);
        pauseui.SetActive(false);
        UIui.SetActive(false);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        countryui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = true;
        newsUI = true;
    }
    public void DisableNews()
    {
        pauseui.SetActive(false);
        moveui.SetActive(false);
        buyui.SetActive(false);
        choiceui.SetActive(false);
        newsui.SetActive(false);
        UIui.SetActive(true);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        countryui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = false;
        newsUI = false;
    }

    public void EnableBuy()
    {
        newsui.SetActive(false);
        moveui.SetActive(false);
        choiceui.SetActive(false);
        pauseui.SetActive(false);
        buyui.SetActive(true);
        UIui.SetActive(false);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        countryui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = true;
        buyUI = true;
    }
    public void DisableBuy()
    {
        pauseui.SetActive(false);
        buyui.SetActive(false);
        choiceui.SetActive(false);
        moveui.SetActive(false);
        newsui.SetActive(false);
        UIui.SetActive(true);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        countryui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = false;
        buyUI = false;
    }

    public void EnableGameOver()
    {
        newsui.SetActive(false);
        moveui.SetActive(false);
        choiceui.SetActive(false);
        pauseui.SetActive(false);
        buyui.SetActive(false);
        UIui.SetActive(false);
        gameOverui.SetActive(true);
        countryui.SetActive(false);
        controlsui.SetActive(false);
        scoreText = score_Text.GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + scoreNumber.ToString();
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = true;
        gameOverUI = true;
    }
    public void DisableGameOver()
    {
        newsui.SetActive(false);
        moveui.SetActive(false);
        choiceui.SetActive(false);
        pauseui.SetActive(false);
        buyui.SetActive(false);
        UIui.SetActive(true);
        gameOverui.SetActive(false);
        countryui.SetActive(false);
        controlsui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = false;
        exitGameOver = true;
        gameOverUI = true;
    }

    public void EnableControls()
    {
        newsui.SetActive(false);
        moveui.SetActive(false);
        choiceui.SetActive(false);
        pauseui.SetActive(false);
        buyui.SetActive(false);
        UIui.SetActive(false);
        gameOverui.SetActive(false);
        controlsui.SetActive(true);
        countryui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = true;
        controlsUI = true;
    }

    public void DisableControls()
    {
        newsui.SetActive(false);
        moveui.SetActive(false);
        choiceui.SetActive(false);
        pauseui.SetActive(false);
        buyui.SetActive(false);
        UIui.SetActive(true);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        countryui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = false;
        controlsUI = false;
    }

    public void EnableMove()
    {
        moveui.SetActive(true);
        newsui.SetActive(false);
        choiceui.SetActive(false);
        pauseui.SetActive(false);
        buyui.SetActive(false);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        UIui.SetActive(false);
        countryui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = true;
        moveUI = true;
        touchCountry1.GetComponent<ColorC>().attackFlash = false;
        touchCountry1.GetComponent<ColorC>().wait = false;
        touchCountry1 = GameObject.Find("information");
        touchCountry2.GetComponent<ColorC>().attackFlash = false;
        touchCountry2.GetComponent<ColorC>().wait = false;
        touchCountry2 = GameObject.Find("information");
    }
    public void DisableMove()
    {
        moveui.SetActive(false);
        pauseui.SetActive(false);
        buyui.SetActive(false);
        choiceui.SetActive(false);
        newsui.SetActive(false);
        UIui.SetActive(true);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        touched = false;
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = false;
        moveUI = false;
        touchCountry1.GetComponent<ColorC>().attackFlash = false;
        touchCountry1.GetComponent<ColorC>().wait = false;
        touchCountry2.GetComponent<ColorC>().attackFlash = false;
        touchCountry2.GetComponent<ColorC>().wait = false;
    }
    public void DoMove()
    {
        moveui.SetActive(false);
        pauseui.SetActive(false);
        buyui.SetActive(false);
        choiceui.SetActive(false);
        newsui.SetActive(false);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        UIui.SetActive(true);
        countryui.SetActive(false);
        touched = false;
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = false;
        moveUI = false;
        touchCountry1.GetComponent<ColorC>().attackFlash = false;
        touchCountry1.GetComponent<ColorC>().wait = false;
        touchCountry2.GetComponent<ColorC>().attackFlash = false;
        touchCountry2.GetComponent<ColorC>().wait = false;
        touchCountry2.GetComponent<Control>().cavalry += touchCountry1.GetComponent<Control>().cavalry / 2;
        touchCountry1.GetComponent<Control>().cavalry = touchCountry1.GetComponent<Control>().cavalry / 2;
        touchCountry2.GetComponent<Control>().cavalry = Mathf.Round(touchCountry2.GetComponent<Control>().cavalry);
        touchCountry1.GetComponent<Control>().cavalry = Mathf.Round(touchCountry1.GetComponent<Control>().cavalry);
        touchCountry2.GetComponent<Control>().infantry += touchCountry1.GetComponent<Control>().infantry / 2;
        touchCountry1.GetComponent<Control>().infantry = touchCountry1.GetComponent<Control>().infantry / 2;
        touchCountry2.GetComponent<Control>().infantry = Mathf.Round(touchCountry2.GetComponent<Control>().infantry);
        touchCountry1.GetComponent<Control>().infantry = Mathf.Round(touchCountry1.GetComponent<Control>().infantry);
        touchCountry2.GetComponent<Control>().artillery += touchCountry1.GetComponent<Control>().artillery / 2;
        touchCountry1.GetComponent<Control>().artillery = touchCountry1.GetComponent<Control>().artillery / 2;
        touchCountry2.GetComponent<Control>().artillery = Mathf.Round(touchCountry2.GetComponent<Control>().artillery);
        touchCountry1.GetComponent<Control>().artillery = Mathf.Round(touchCountry1.GetComponent<Control>().artillery);
    }

    public void DisableCountryList()
    {
        moveui.SetActive(false);
        pauseui.SetActive(false);
        buyui.SetActive(false);
        choiceui.SetActive(false);
        newsui.SetActive(false);
        UIui.SetActive(true);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        countryui.SetActive(false);
        touched = false;
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = false;
    }

    public void DisableButton()
    {
        attackButton.SetActive(false);
        buyButton.SetActive(false);
        moveui.SetActive(false);
        pauseui.SetActive(false);
        buyui.SetActive(false);
        choiceui.SetActive(false);
        newsui.SetActive(false);
        gameOverui.SetActive(false);
        controlsui.SetActive(false);
        countryui.SetActive(false);
    }

    void EnableButton()
    {
        attackButton.SetActive(true);
        buyButton.SetActive(true);
    }
}