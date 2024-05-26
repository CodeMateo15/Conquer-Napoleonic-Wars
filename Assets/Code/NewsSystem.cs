using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewsSystem : MonoBehaviour
{
    public GameObject newsTexts;
    public GameObject roundTexts;

    void Awake()
    {
        transform.SetAsFirstSibling();
        newsTexts = this.gameObject.transform.GetChild(0).gameObject;
        roundTexts = this.gameObject.transform.GetChild(1).gameObject;
        newsTexts.GetComponent<TextMeshProUGUI>().text = GameObject.Find("Main Camera").GetComponent<ArmyUI>().news;
        roundTexts.GetComponent<TextMeshProUGUI>().text = GameObject.Find("Main Camera").GetComponent<ArmyUI>().round;
    }
}