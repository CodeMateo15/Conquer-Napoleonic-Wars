using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Country_List : MonoBehaviour
{
    public float choice;
    public GameObject choiceTexts;

    void Start()
    {
        transform.SetAsFirstSibling();
        choiceTexts = this.gameObject.transform.GetChild(0).gameObject;
        if (choice == 0)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "France";
        }
        if (choice == 1)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Spain";
        }
        if (choice == 2)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Portugal";
        }
        if (choice == 3)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "UK";
        }
        if (choice == 4)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "CR";
        }
        if (choice == 5)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Morocco";
        }
        if (choice == 6)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Algeria";
        }
        if (choice == 7)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Tunis";
        }
        if (choice == 8)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Sardinia";
        }
        if (choice == 9)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Sicily";
        }
        if (choice == 10)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Naples";
        }
        if (choice == 11)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Lucca";
        }
        if (choice == 12)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Italy";
        }
        if (choice == 13)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Helvetia";
        }
        if (choice == 14)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Austria";
        }
        if (choice == 15)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Ottoman";
        }
        if (choice == 16)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Montenegro";
        }
        if (choice == 17)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Prussia";
        }
        if (choice == 18)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Warsaw";
        }
        if (choice == 19)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Russia";
        }
        if (choice == 20)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Sweden";
        }
        if (choice == 21)
        {
            choiceTexts.GetComponent<TextMeshProUGUI>().text = "Norway/Denmark";
        }
    }

    public void Choice()
    {
        if (GameObject.Find("information").GetComponent<countries>().allianceChoice == true)
        {
            foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
            {
                if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == GameObject.Find("information").GetComponent<countries>().playerCountry)
                {
                    if (targetAI.GetComponent<Country_AI>().AIGold > 101 && targetAI.GetComponent<Country_AI>().AIPopulation > 101 && targetAI.GetComponent<Country_AI>().AIMaterial > 101)
                    {
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 0)
                        {
                            GameObject.Find("information").GetComponent<countries>().franceGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().francePopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().franceMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 1)
                        {
                            GameObject.Find("information").GetComponent<countries>().spainGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().spainPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().spainMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 2)
                        {
                            GameObject.Find("information").GetComponent<countries>().portugalGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().portugalPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().portugalMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 3)
                        {
                            GameObject.Find("information").GetComponent<countries>().UKGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().UKPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().UKMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 4)
                        {
                            GameObject.Find("information").GetComponent<countries>().CRGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().CRPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().CRMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 5)
                        {
                            GameObject.Find("information").GetComponent<countries>().moroccoGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().moroccoPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().moroccoMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 6)
                        {
                            GameObject.Find("information").GetComponent<countries>().algeriaGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().algeriaPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().algeriaMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 7)
                        {
                            GameObject.Find("information").GetComponent<countries>().tunisGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().tunisPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().tunisMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 8)
                        {
                            GameObject.Find("information").GetComponent<countries>().sardGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().sardPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().sardMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 9)
                        {
                            GameObject.Find("information").GetComponent<countries>().sicilyGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().sicilyPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().sicilyMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 10)
                        {
                            GameObject.Find("information").GetComponent<countries>().naplesGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().naplesPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().naplesMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 11)
                        {
                            GameObject.Find("information").GetComponent<countries>().luccaGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().luccaPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().luccaMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 12)
                        {
                            GameObject.Find("information").GetComponent<countries>().italyGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().italyPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().italyMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 13)
                        {
                            GameObject.Find("information").GetComponent<countries>().helvetiaGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().helvetiaPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().helvetiaMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 14)
                        {
                            GameObject.Find("information").GetComponent<countries>().austrianGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().austrianPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().austrianMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 15)
                        {
                            GameObject.Find("information").GetComponent<countries>().ottomanGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().ottomanPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().ottomanMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 16)
                        {
                            GameObject.Find("information").GetComponent<countries>().monteGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().montePopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().monteMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 17)
                        {
                            GameObject.Find("information").GetComponent<countries>().prussiaGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().prussiaPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().prussiaMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 18)
                        {
                            GameObject.Find("information").GetComponent<countries>().warsawGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().warsawPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().warsawMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 19)
                        {
                            GameObject.Find("information").GetComponent<countries>().russianGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().russianPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().russianMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 20)
                        {
                            GameObject.Find("information").GetComponent<countries>().swedenGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().swedenPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().swedenMaterial -= 1000f;
                        }
                        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 21)
                        {
                            GameObject.Find("information").GetComponent<countries>().norwayGold -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().norwayPopulation -= 1000f;
                            GameObject.Find("information").GetComponent<countries>().norwayMaterial -= 1000f;
                        }
                        targetAI.GetComponent<Country_AI>().FindGold();
                        SentMoney();
                    }
                    else
                    {
                        Debug.Log("Can't afford it");
                        GameObject.Find("information").GetComponent<countries>().CountryAfford();
                        GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableCountryList();
                    }
                }
            }
        }
        if (GameObject.Find("information").GetComponent<countries>().warChoice == true)
        {
            GameObject.Find("information").GetComponent<countries>().PlayerChoice = choice;
            GameObject.Find("information").GetComponent<countries>().PlayerWar();
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().countryui.SetActive(false);
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().UIui.SetActive(true);
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().choiceUI = false;
            GameObject.Find("Main Camera").GetComponent<Movement>().slider = false;
            foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
            {
                if (GameObject.Find("information").GetComponent<countries>().countryTurn == GameObject.Find("information").GetComponent<countries>().playerCountry)
                {
                    targetAI.GetComponent<Country_AI>().PlayerDiplomacy();
                }
            }
        }
    }

    public void SentMoney()
    {
        GameObject.Find("information").GetComponent<countries>().PlayerChoice = choice;
        GameObject.Find("information").GetComponent<countries>().PlayerAlliance();
        GameObject.Find("Main Camera").GetComponent<ArmyUI>().countryui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<ArmyUI>().UIui.SetActive(true);
        GameObject.Find("Main Camera").GetComponent<ArmyUI>().choiceUI = false;
        GameObject.Find("Main Camera").GetComponent<Movement>().slider = false;
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (GameObject.Find("information").GetComponent<countries>().countryTurn == GameObject.Find("information").GetComponent<countries>().playerCountry)
            {
                targetAI.GetComponent<Country_AI>().PlayerDiplomacy();
            }
        }
    }
}