using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public float sonController;

    public float borderNumber;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "country")
        {
            if (other.gameObject.GetComponent<Control>().controller == sonController)
            {
                //Debug.Log("ally" + other.gameObject);
                if (borderNumber == 0f)
                {
                    if (gameObject.GetComponentInParent<Control>().accounted0 == false)
                    {
                        gameObject.GetComponentInParent<Control>().accountGame0 = other.gameObject;
                        gameObject.GetComponentInParent<Control>().accounted0 = true;
                    }
                    if (gameObject.GetComponentInParent<Control>().accounted0 == true)
                    {
                        if (gameObject.GetComponentInParent<Control>().accountGame0 != other.gameObject)
                        {
                            gameObject.GetComponentInParent<Control>().accounted0 = false;
                        }
                    }
                }
                if (borderNumber == 1f)
                {
                    if (gameObject.GetComponentInParent<Control>().accounted1 == false)
                    {
                        gameObject.GetComponentInParent<Control>().accountGame1 = other.gameObject;
                        gameObject.GetComponentInParent<Control>().accounted1 = true;
                    }
                    if (gameObject.GetComponentInParent<Control>().accounted1 == true)
                    {
                        if (gameObject.GetComponentInParent<Control>().accountGame1 != other.gameObject)
                        {
                            gameObject.GetComponentInParent<Control>().accounted1 = false;
                        }
                    }
                }
                if (borderNumber == 2f)
                {
                    if (gameObject.GetComponentInParent<Control>().accounted2 == false)
                    {
                        gameObject.GetComponentInParent<Control>().accountGame2 = other.gameObject;
                        gameObject.GetComponentInParent<Control>().accounted2 = true;
                    }
                    if (gameObject.GetComponentInParent<Control>().accounted2 == true)
                    {
                        if (gameObject.GetComponentInParent<Control>().accountGame2 != other.gameObject)
                        {
                            gameObject.GetComponentInParent<Control>().accounted2 = false;
                        }
                    }
                }
                if (borderNumber == 3f)
                {
                    if (gameObject.GetComponentInParent<Control>().accounted3 == false)
                    {
                        gameObject.GetComponentInParent<Control>().accountGame3 = other.gameObject;
                        gameObject.GetComponentInParent<Control>().accounted3 = true;
                    }
                    if (gameObject.GetComponentInParent<Control>().accounted3 == true)
                    {
                        if (gameObject.GetComponentInParent<Control>().accountGame3 != other.gameObject)
                        {
                            gameObject.GetComponentInParent<Control>().accounted3 = false;
                        }
                    }
                }
                if (borderNumber == 4f)
                {
                    if (gameObject.GetComponentInParent<Control>().accounted4 == false)
                    {
                        gameObject.GetComponentInParent<Control>().accountGame4 = other.gameObject;
                        gameObject.GetComponentInParent<Control>().accounted4 = true;
                    }
                    if (gameObject.GetComponentInParent<Control>().accounted4 == true)
                    {
                        if (gameObject.GetComponentInParent<Control>().accountGame4 != other.gameObject)
                        {
                            gameObject.GetComponentInParent<Control>().accounted4 = false;
                        }
                    }
                }
                if (borderNumber == 5f)
                {
                    if (gameObject.GetComponentInParent<Control>().accounted5 == false)
                    {
                        gameObject.GetComponentInParent<Control>().accountGame5 = other.gameObject;
                        gameObject.GetComponentInParent<Control>().accounted5 = true;
                    }
                    if (gameObject.GetComponentInParent<Control>().accounted5 == true)
                    {
                        if (gameObject.GetComponentInParent<Control>().accountGame5 != other.gameObject)
                        {
                            gameObject.GetComponentInParent<Control>().accounted5 = false;
                        }
                    }
                }
                Destroy(gameObject);
            }
            if (other.gameObject.GetComponent<Control>().controller != sonController)
            {
                //Debug.Log("enemy" + other.gameObject);
                if (borderNumber == 0f)
                {
                    if (gameObject.GetComponentInParent<Control>().accounted0 == false)
                    {
                        gameObject.GetComponentInParent<Control>().accountGame0 = other.gameObject;
                        gameObject.GetComponentInParent<Control>().accounted0 = true;
                    }
                    if (gameObject.GetComponentInParent<Control>().accounted0 == true)
                    {
                        if (gameObject.GetComponentInParent<Control>().accountGame0 != other.gameObject)
                        {
                            gameObject.GetComponentInParent<Control>().accounted0 = false;
                        }
                    }
                }
                if (borderNumber == 1f)
                {
                    if (gameObject.GetComponentInParent<Control>().accounted1 == false)
                    {
                        gameObject.GetComponentInParent<Control>().accountGame1 = other.gameObject;
                        gameObject.GetComponentInParent<Control>().accounted1 = true;
                    }
                    if (gameObject.GetComponentInParent<Control>().accounted1 == true)
                    {
                        if (gameObject.GetComponentInParent<Control>().accountGame1 != other.gameObject)
                        {
                            gameObject.GetComponentInParent<Control>().accounted1 = false;
                        }
                    }
                }
                if (borderNumber == 2f)
                {
                    if (gameObject.GetComponentInParent<Control>().accounted2 == false)
                    {
                        gameObject.GetComponentInParent<Control>().accountGame2 = other.gameObject;
                        gameObject.GetComponentInParent<Control>().accounted2 = true;
                    }
                    if (gameObject.GetComponentInParent<Control>().accounted2 == true)
                    {
                        if (gameObject.GetComponentInParent<Control>().accountGame2 != other.gameObject)
                        {
                            gameObject.GetComponentInParent<Control>().accounted2 = false;
                        }
                    }
                }
                if (borderNumber == 3f)
                {
                    if (gameObject.GetComponentInParent<Control>().accounted3 == false)
                    {
                        gameObject.GetComponentInParent<Control>().accountGame3 = other.gameObject;
                        gameObject.GetComponentInParent<Control>().accounted3 = true;
                    }
                    if (gameObject.GetComponentInParent<Control>().accounted3 == true)
                    {
                        if (gameObject.GetComponentInParent<Control>().accountGame3 != other.gameObject)
                        {
                            gameObject.GetComponentInParent<Control>().accounted3 = false;
                        }
                    }
                }
                if (borderNumber == 4f)
                {
                    if (gameObject.GetComponentInParent<Control>().accounted4 == false)
                    {
                        gameObject.GetComponentInParent<Control>().accountGame4 = other.gameObject;
                        gameObject.GetComponentInParent<Control>().accounted4 = true;
                    }
                    if (gameObject.GetComponentInParent<Control>().accounted4 == true)
                    {
                        if (gameObject.GetComponentInParent<Control>().accountGame4 != other.gameObject)
                        {
                            gameObject.GetComponentInParent<Control>().accounted4 = false;
                        }
                    }
                }
                if (borderNumber == 5f)
                {
                    if (gameObject.GetComponentInParent<Control>().accounted5 == false)
                    {
                        gameObject.GetComponentInParent<Control>().accountGame5 = other.gameObject;
                        gameObject.GetComponentInParent<Control>().accounted5 = true;
                    }
                    if (gameObject.GetComponentInParent<Control>().accounted5 == true)
                    {
                        if (gameObject.GetComponentInParent<Control>().accountGame5 != other.gameObject)
                        {
                            gameObject.GetComponentInParent<Control>().accounted5 = false;
                        }
                    }
                }
                foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
                {
                    if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == sonController)
                    {
                        if (!targetAI.GetComponent<Country_AI>().borderingEnemies.Contains(other.gameObject))
                        {
                            targetAI.GetComponent<Country_AI>().borderingEnemies.Add(other.gameObject);
                        }
                    }
                }
                Destroy(gameObject);
            }
        }
    }

    void Start()
    {
        sonController = gameObject.GetComponentInParent<Control>().controller;
    }
}