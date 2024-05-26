using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WarList : MonoBehaviour
{
    public bool war;
    public bool alliance;

    void Update()
    {
        if (war == true)
        {
            this.gameObject.GetComponent<TextMeshProUGUI>().text = "At War With: ";
            foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI")) //Add each war to the text ADD COUNTRY_AI
            {
                if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == GameObject.Find("information").GetComponent<countries>().playerCountry)
                {
                    foreach (string warline in targetAI.gameObject.GetComponent<Country_AI>().warList)
                    {
                        this.gameObject.GetComponent<TextMeshProUGUI>().text += warline + ", ";
                    }
                }
            }
        }
        
        if (alliance == true)
        {
            this.gameObject.GetComponent<TextMeshProUGUI>().text = "Alliance With: ";
            foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI")) //Add each alliance to the text
            {
                if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == GameObject.Find("information").GetComponent<countries>().playerCountry)
                {
                    foreach (string allianceline in targetAI.gameObject.GetComponent<Country_AI>().allianceList)
                    {
                        this.gameObject.GetComponent<TextMeshProUGUI>().text += allianceline + ", ";
                    }
                }
            }
        }
    }
}
