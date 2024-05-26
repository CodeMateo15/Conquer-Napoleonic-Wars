using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Control : MonoBehaviour
{
    private bool franc;
    private bool spai;
    private bool portuga;
    private bool UK;
    private bool CR;
    private bool morocc;
    private bool algeri;
    private bool tuni;
    private bool sard;
    private bool sici;
    private bool napl;
    private bool lucc;
    private bool ital;
    private bool helv;
    private bool austria;
    private bool otto;
    private bool mont;
    private bool pruss;
    private bool warsaw;
    private bool russia;
    private bool swed;
    private bool nor;

    public float controller;

    public float attackPower;
    public float defensePower;
    public float barracksLevel = 1f;
    public float barracksMultiplier = 1.1f;
    public float defenseLevel = 1f;
    public float defenseMultiplier = 1.1f;
    public float populationMultiply;
    public float cavalry;
    public float infantry;
    public float artillery;

    [HideInInspector] public bool accounted0;
    [HideInInspector] public bool accounted1;
    [HideInInspector] public bool accounted2;
    [HideInInspector] public bool accounted3;
    [HideInInspector] public bool accounted4;
    [HideInInspector] public bool accounted5;

    public GameObject accountGame0;
    public GameObject accountGame1;
    public GameObject accountGame2;
    public GameObject accountGame3;
    public GameObject accountGame4;
    public GameObject accountGame5;

    public float goldWorth;
    public float populationWorth;
    public float materialWorth;

    public List <GameObject> borderSpawn;
    public Vector2 borderPosition0;
    public Vector2 borderPosition1;
    public Vector2 borderPosition2;
    public Vector2 borderPosition3;
    public Vector2 borderPosition4;
    public Vector2 borderPosition5;
    [HideInInspector] public float countBorder;

    public TextMeshPro soldierCount;
    public float espionage;

    void Start()
    {
        if (controller == 0)
        {
            AddFrance();
        }
        if (controller == 1)
        {
            AddSpain();
        }
        if (controller == 2)
        {
            AddPortugal();
        }
        if (controller == 3)
        {
            AddUK();
        }
        if (controller == 4)
        {
            AddCR();
        }
        if (controller == 5)
        {
            AddMorocco();
        }
        if (controller == 6)
        {
            AddAlgeria();
        }
        if (controller == 7)
        {
            AddTunis();
        }
        if (controller == 8)
        {
            AddSard();
        }
        if (controller == 9)
        {
            AddSicily();
        }
        if (controller == 10)
        {
            AddNaples();
        }
        if (controller == 11)
        {
            AddLucca();
        }
        if (controller == 12)
        {
            AddItaly();
        }
        if (controller == 13)
        {
            AddHelvetia();
        }
        if (controller == 14)
        {
            AddAustrian();
        }
        if (controller == 15)
        {
            AddOttoman();
        }
        if (controller == 16)
        {
            AddMonte();
        }
        if (controller == 17)
        {
            AddPrussia();
        }
        if (controller == 18)
        {
            AddWarsaw();
        }
        if (controller == 19)
        {
            AddRussian();
        }
        if (controller == 20)
        {
            AddSweden();
        }
        if (controller == 21)
        {
            AddNorway();
        }
    }

    void Update()
    {
        attackPower = (cavalry * 3f) + (artillery * 2f) + (infantry * 1f);
        defensePower = (cavalry * 3f * defenseMultiplier) + (artillery * 2f * defenseMultiplier) + (infantry * 1f * defenseMultiplier);
        defensePower = Mathf.Round(defensePower);
        populationWorth = populationMultiply * barracksMultiplier;
        populationWorth = Mathf.Round(populationWorth);

        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.GetComponent<Country_AI>().CountryType == GameObject.Find("information").GetComponent<countries>().playerCountry)
            {
                if (targetAI.GetComponent<Country_AI>().borderingEnemies.Contains(this.gameObject))
                {
                    OnSoldiers();
                }
                else
                {
                    OffSoldiers();
                }
                if (targetAI.GetComponent<Country_AI>().CountryType == controller)
                {
                    AlwaysSoldiers();
                }
            }
        }
    }

    void AlwaysSoldiers()
    {
        soldierCount.gameObject.SetActive(true);
        soldierCount.SetText("Soldiers\r\n" + attackPower);
    }

    public void OnSoldiers()
    {
        soldierCount.gameObject.SetActive(true);
        
        if (espionage < 11)
        {
            soldierCount.SetText("Soldiers\r\n" + "Spies Failed");
        }
        if (espionage > 10 && espionage < 31)
        {
            soldierCount.SetText("Soldiers\r\n" + attackPower);
        }
        if (espionage > 30 && espionage < 101)
        {
            soldierCount.SetText("Soldiers\r\n" + defensePower);
        }
    }

    void OffSoldiers()
    {
        soldierCount.gameObject.SetActive(false);
    }

    public void ControlChange()
    {
        if (controller == 0)
        {
            Remove();
            AddFrance();
        }
        if (controller == 1)
        {
            Remove();
            AddSpain();
        }
        if (controller == 2)
        {
            Remove();
            AddPortugal();
        }
        if (controller == 3)
        {
            Remove();
            AddUK();
        }
        if (controller == 4)
        {
            Remove();
            AddCR();
        }
        if (controller == 5)
        {
            Remove();
            AddMorocco();
        }
        if (controller == 6)
        {
            Remove();
            AddAlgeria();
        }
        if (controller == 7)
        {
            Remove();
            AddTunis();
        }
        if (controller == 8)
        {
            Remove();
            AddSard();
        }
        if (controller == 9)
        {
            Remove();
            AddSicily();
        }
        if (controller == 10)
        {
            Remove();
            AddNaples();
        }
        if (controller == 11)
        {
            Remove();
            AddLucca();
        }
        if (controller == 12)
        {
            Remove();
            AddItaly();
        }
        if (controller == 13)
        {
            Remove();
            AddHelvetia();
        }
        if (controller == 14)
        {
            Remove();
            AddAustrian();
        }
        if (controller == 15)
        {
            Remove();
            AddOttoman();
        }
        if (controller == 16)
        {
            Remove();
            AddMonte();
        }
        if (controller == 17)
        {
            Remove();
            AddPrussia();
        }
        if (controller == 18)
        {
            Remove();
            AddWarsaw();
        }
        if (controller == 19)
        {
            Remove();
            AddRussian();
        }
        if (controller == 20)
        {
            Remove();
            AddSweden();
        }
        if (controller == 21)
        {
            Remove();
            AddNorway();
        }
    }

    void Remove()
    {
        if (franc == true)
        {
            RemoveFrance();
        }
        if (spai == true)
        {
            RemoveSpain();
        }
        if (portuga == true)
        {
            RemovePortugal();
        }
        if (UK == true)
        {
            RemoveUK();
        }
        if (CR == true)
        {
            RemoveCR();
        }
        if (morocc == true)
        {
            RemoveMorocco();
        }
        if (algeri == true)
        {
            RemoveAlgeria();
        }
        if (tuni == true)
        {
            RemoveTunis();
        }
        if (sard == true)
        {
            RemoveSard();
        }
        if (sici == true)
        {
            RemoveSicily();
        }
        if (napl == true)
        {
            RemoveNaples();
        }
        if (lucc == true)
        {
            RemoveLucca();
        }
        if (ital == true)
        {
            RemoveItaly();
        }
        if (helv == true)
        {
            RemoveHelvetia();
        }
        if (austria == true)
        {
            RemoveAustrian();
        }
        if (otto == true)
        {
            RemoveOttoman();
        }
        if (mont == true)
        {
            RemoveMonte();
        }
        if (pruss == true)
        {
            RemovePrussia();
        }
        if (warsaw == true)
        {
            RemoveWarsaw();
        }
        if (russia == true)
        {
            RemoveRussian();
        }
        if (swed == true)
        {
            RemoveSweden();
        }
        if (nor == true)
        {
            RemoveNorway();
        }
    }

    public void SpawnBorder()
    {
        countBorder = borderSpawn.Count;
        if (countBorder >= 1)
        {
            Instantiate(borderSpawn[0], borderPosition0, Quaternion.identity, transform);
        }
        if (countBorder >= 2)
        {
            Instantiate(borderSpawn[1], borderPosition1, Quaternion.identity, transform);
        }
        if (countBorder >= 3)
        {
            Instantiate(borderSpawn[2], borderPosition2, Quaternion.identity, transform);
        }
        if (countBorder >= 4)
        {
            Instantiate(borderSpawn[3], borderPosition3, Quaternion.identity, transform);
        }
        if (countBorder >= 5)
        {
            Instantiate(borderSpawn[4], borderPosition4, Quaternion.identity, transform);
        }
        if (countBorder >= 6)
        {
            Instantiate(borderSpawn[5], borderPosition5, Quaternion.identity, transform);
        }
    }

    void AddFrance()
    {
        GameObject.Find("information").GetComponent<countries>().franceGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().francePopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().franceMaterialWorth += materialWorth;
        franc = true;
    }
    void RemoveFrance()
    {
        GameObject.Find("information").GetComponent<countries>().franceGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().francePopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().franceMaterialWorth -= materialWorth;
        franc = false;
    }

    void AddSpain()
    {
        GameObject.Find("information").GetComponent<countries>().spainGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().spainPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().spainMaterialWorth += materialWorth;
        spai = true;
    }
    void RemoveSpain()
    {
        GameObject.Find("information").GetComponent<countries>().spainGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().spainPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().spainMaterialWorth -= materialWorth;
        spai = false;
    }

    void AddPortugal()
    {
        GameObject.Find("information").GetComponent<countries>().portugalGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().portugalPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().portugalMaterialWorth += materialWorth;
        portuga = true;
    }
    void RemovePortugal()
    {
        GameObject.Find("information").GetComponent<countries>().portugalGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().portugalPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().portugalMaterialWorth -= materialWorth;
        portuga = false;
    }

    void AddUK()
    {
        GameObject.Find("information").GetComponent<countries>().UKGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().UKPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().UKMaterialWorth += materialWorth;
        UK = true;
    }
    void RemoveUK()
    {
        GameObject.Find("information").GetComponent<countries>().UKGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().UKPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().UKMaterialWorth -= materialWorth;
        UK = false;
    }

    void AddCR()
    {
        GameObject.Find("information").GetComponent<countries>().CRGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().CRPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().CRMaterialWorth += materialWorth;
        CR = true;
    }
    void RemoveCR()
    {
        GameObject.Find("information").GetComponent<countries>().CRGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().CRPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().CRMaterialWorth -= materialWorth;
        CR = false;
    }

    void AddMorocco()
    {
        GameObject.Find("information").GetComponent<countries>().moroccoGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().moroccoPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().moroccoMaterialWorth += materialWorth;
        morocc = true;
    }
    void RemoveMorocco()
    {
        GameObject.Find("information").GetComponent<countries>().moroccoGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().moroccoPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().moroccoMaterialWorth -= materialWorth;
        morocc = false;
    }

    void AddAlgeria()
    {
        GameObject.Find("information").GetComponent<countries>().algeriaGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().algeriaPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().algeriaMaterialWorth += materialWorth;
        algeri = true;
    }
    void RemoveAlgeria()
    {
        GameObject.Find("information").GetComponent<countries>().algeriaGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().algeriaPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().algeriaMaterialWorth -= materialWorth;
        algeri = false;
    }

    void AddTunis()
    {
        GameObject.Find("information").GetComponent<countries>().tunisGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().tunisPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().tunisMaterialWorth += materialWorth;
        tuni = true;
    }
    void RemoveTunis()
    {
        GameObject.Find("information").GetComponent<countries>().tunisGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().tunisPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().tunisMaterialWorth -= materialWorth;
        tuni = false;
    }

    void AddSard()
    {
        GameObject.Find("information").GetComponent<countries>().sardGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().sardPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().sardMaterialWorth += materialWorth;
        sard = true;
    }
    void RemoveSard()
    {
        GameObject.Find("information").GetComponent<countries>().sardGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().sardPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().sardMaterialWorth -= materialWorth;
        sard = false;
    }

    void AddSicily()
    {
        GameObject.Find("information").GetComponent<countries>().sicilyGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().sicilyPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().sicilyMaterialWorth += materialWorth;
        sici = true;
    }
    void RemoveSicily()
    {
        GameObject.Find("information").GetComponent<countries>().sicilyGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().sicilyPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().sicilyMaterialWorth -= materialWorth;
        sici = false;
    }

    void AddNaples()
    {
        GameObject.Find("information").GetComponent<countries>().naplesGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().naplesPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().naplesMaterialWorth += materialWorth;
        napl = true;
    }
    void RemoveNaples()
    {
        GameObject.Find("information").GetComponent<countries>().naplesGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().naplesPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().naplesMaterialWorth -= materialWorth;
        napl = false;
    }

    void AddLucca()
    {
        GameObject.Find("information").GetComponent<countries>().luccaGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().luccaPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().luccaMaterialWorth += materialWorth;
        lucc = true;
    }
    void RemoveLucca()
    {
        GameObject.Find("information").GetComponent<countries>().luccaGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().luccaPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().luccaMaterialWorth -= materialWorth;
        lucc = false;
    }

    void AddItaly()
    {
        GameObject.Find("information").GetComponent<countries>().italyGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().italyPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().italyMaterialWorth += materialWorth;
        ital = true;
    }
    void RemoveItaly()
    {
        GameObject.Find("information").GetComponent<countries>().italyGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().italyPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().italyMaterialWorth -= materialWorth;
        ital = false;
    }

    void AddHelvetia()
    {
        GameObject.Find("information").GetComponent<countries>().helvetiaGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().helvetiaPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().helvetiaMaterialWorth += materialWorth;
        helv = true;
    }
    void RemoveHelvetia()
    {
        GameObject.Find("information").GetComponent<countries>().helvetiaGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().helvetiaPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().helvetiaMaterialWorth -= materialWorth;
        helv = false;
    }

    void AddAustrian()
    {
        GameObject.Find("information").GetComponent<countries>().austrianGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().austrianPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().austrianMaterialWorth += materialWorth;
        austria = true;
    }
    void RemoveAustrian()
    {
        GameObject.Find("information").GetComponent<countries>().austrianGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().austrianPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().austrianMaterialWorth -= materialWorth;
        austria = false;
    }

    void AddOttoman()
    {
        GameObject.Find("information").GetComponent<countries>().ottomanGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().ottomanPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().ottomanMaterialWorth += materialWorth;
        otto = true;
    }
    void RemoveOttoman()
    {
        GameObject.Find("information").GetComponent<countries>().ottomanGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().ottomanPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().ottomanMaterialWorth -= materialWorth;
        otto = false;
    }

    void AddMonte()
    {
        GameObject.Find("information").GetComponent<countries>().monteGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().montePopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().monteMaterialWorth += materialWorth;
        mont = true;
    }
    void RemoveMonte()
    {
        GameObject.Find("information").GetComponent<countries>().monteGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().montePopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().monteMaterialWorth -= materialWorth;
        mont = false;
    }

    void AddPrussia()
    {
        GameObject.Find("information").GetComponent<countries>().prussiaGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().prussiaPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().prussiaMaterialWorth += materialWorth;
        pruss = true;
    }
    void RemovePrussia()
    {
        GameObject.Find("information").GetComponent<countries>().prussiaGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().prussiaPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().prussiaMaterialWorth -= materialWorth;
        pruss = false;
    }

    void AddWarsaw()
    {
        GameObject.Find("information").GetComponent<countries>().warsawGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().warsawPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().warsawMaterialWorth += materialWorth;
        warsaw = true;
    }
    void RemoveWarsaw()
    {
        GameObject.Find("information").GetComponent<countries>().warsawGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().warsawPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().warsawMaterialWorth -= materialWorth;
        warsaw = false;
    }

    void AddRussian()
    {
        GameObject.Find("information").GetComponent<countries>().russianGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().russianPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().russianMaterialWorth += materialWorth;
        russia = true;
    }
    void RemoveRussian()
    {
        GameObject.Find("information").GetComponent<countries>().russianGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().russianPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().russianMaterialWorth -= materialWorth;
        russia = false;
    }

    void AddSweden()
    {
        GameObject.Find("information").GetComponent<countries>().swedenGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().swedenPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().swedenMaterialWorth += materialWorth;
        swed = true;
    }
    void RemoveSweden()
    {
        GameObject.Find("information").GetComponent<countries>().swedenGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().swedenPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().swedenMaterialWorth -= materialWorth;
        swed = false;
    }

    void AddNorway()
    {
        GameObject.Find("information").GetComponent<countries>().norwayGoldWorth += goldWorth;
        GameObject.Find("information").GetComponent<countries>().norwayPopulationWorth += populationWorth;
        GameObject.Find("information").GetComponent<countries>().norwayMaterialWorth += materialWorth;
        nor = true;
    }
    void RemoveNorway()
    {
        GameObject.Find("information").GetComponent<countries>().norwayGoldWorth -= goldWorth;
        GameObject.Find("information").GetComponent<countries>().norwayPopulationWorth -= populationWorth;
        GameObject.Find("information").GetComponent<countries>().norwayMaterialWorth -= materialWorth;
        nor = false;
    }
}