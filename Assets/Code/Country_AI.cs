using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public class Country_AI : MonoBehaviour
{
    [HideInInspector] public bool GameOver;
    public float CountryType;
    public List<GameObject> allLand;
    public List<GameObject> borderingEnemies;
    public List<GameObject> alliances;

    public GameObject attackCountryAI1;
    public GameObject attackCountryAI2;

    [HideInInspector] public bool aggressive;
    [HideInInspector] public bool defensive;

    public float AIGold;
    public float AIPopulation;
    public float AIMaterial;
    public float buyGold;
    public float buyPopulation;
    public float buyMaterial;

    public GameObject newsPrefab;
    public GameObject container;

    public float FranceOpinion;
    public bool FranceWar;

    public float SpainOpinion;
    public bool SpainWar;

    public float PortugalOpinion;
    public bool PortugalWar;

    public float UKOpinion;
    public bool UKWar;

    public float CROpinion;
    public bool CRWar;

    public float MoroccoOpinion;
    public bool MoroccoWar;

    public float AlgeriaOpinion;
    public bool AlgeriaWar;

    public float TunisOpinion;
    public bool TunisWar;

    public float SardOpinion;
    public bool SardWar;

    public float SicilyOpinion;
    public bool SicilyWar;

    public float NaplesOpinion;
    public bool NaplesWar;

    public float LuccaOpinion;
    public bool LuccaWar;

    public float ItalyOpinion;
    public bool ItalyWar;

    public float HelvetiaOpinion;
    public bool HelvetiaWar;

    public float AustrianOpinion;
    public bool AustrianWar;

    public float OttomanOpinion;
    public bool OttomanWar;

    public float MonteOpinion;
    public bool MonteWar;

    public float PrussiaOpinion;
    public bool PrussiaWar;

    public float WarsawOpinion;
    public bool WarsawWar;

    public float RussianOpinion;
    public bool RussianWar;

    public float SwedenOpinion;
    public bool SwedenWar;

    public float NorwayOpinion;
    public bool NorwayWar;

    public List<string> warList;
    public List<string> allianceList;

    public float score;
    public float beforeScore;

    void Start()
    {
        FindLand();
        ConstantPeace();
    }

    void Update()
    {
        if (GameObject.Find("information").GetComponent<countries>().countryTurn == CountryType)
        {
            if (GameObject.Find("information").GetComponent<countries>().playerCountry != CountryType)
            {
                if (allLand.Count == 0)
                {
                    GameObject.Find("information").GetComponent<countries>().NewTurn();
                }
                if (allLand.Count != 0)
                {
                    DoTurn();
                }
            }
            else
            {
                if (allLand.Count == 0)
                {
                    if (GameOver == false)
                    {
                        Score();
                        beforeScore = PlayerPrefs.GetFloat("Score");
                        if (score >= beforeScore)
                        {
                            PlayerPrefs.SetFloat("Score", score);
                        }
                        Debug.Log("Game Lost!");
                        GameObject.Find("information").GetComponent<countries>().countryTurn = 1000f;
                        GameObject.Find("MusicManager").GetComponent<MusicManager>().EnterLost();
                        GameOver = true;
                        //GameObject.Find("information").GetComponent<countries>().countryTurn += 1f; for testing AI
                        GameObject.Find("Main Camera").GetComponent<ArmyUI>().scoreNumber = score;
                        GameObject.Find("Main Camera").GetComponent<ArmyUI>().EnableGameOver();
                    }
                }
            }
        }
        if (allLand.Count >= 58) //set to 58
        {
            if (GameOver == false)
            {
                Score();
                beforeScore = PlayerPrefs.GetFloat("Score");
                if (score >= beforeScore)
                {
                    PlayerPrefs.SetFloat("Score", score);
                }
                Debug.Log("Game Won!");
                GameObject.Find("information").GetComponent<countries>().countryTurn = 1000f;
                GameObject.Find("Main Camera").GetComponent<Movement>().slider = true;
                GameOver = true;
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().scoreNumber = score;
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().EnableGameOver();
            }
        }
        FindLand();
        ConstantPeace();
    }

    void Diplomacy()
    {
        FindGold();
        FranceOpinion = 50f;
        SpainOpinion = 50f;
        PortugalOpinion = 50f;
        UKOpinion = 50f;
        CROpinion = 50f;
        MoroccoOpinion = 50f;
        AlgeriaOpinion = 50f;
        TunisOpinion = 50f;
        SardOpinion = 50f;
        SicilyOpinion = 50f;
        NaplesOpinion = 50f;
        LuccaOpinion = 50f;
        ItalyOpinion = 50f;
        HelvetiaOpinion = 50f;
        AustrianOpinion = 50f;
        OttomanOpinion = 50f;
        MonteOpinion = 50f;
        PrussiaOpinion = 50f;
        WarsawOpinion = 50f;
        RussianOpinion = 50f;
        SwedenOpinion = 50f;
        NorwayOpinion = 50f;


        foreach (GameObject allies in alliances)
        {
            if (allies.GetComponent<Country_AI>().CountryType == 0)
            {
                FranceWar = false;
                FranceOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 1)
            {
                SpainWar = false;
                SpainOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 2)
            {
                PortugalWar = false;
                PortugalOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 3)
            {
                UKWar = false;
                UKOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 4)
            {
                CRWar = false;
                CROpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 5)
            {
                MoroccoWar = false;
                MoroccoOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 6)
            {
                AlgeriaWar = false;
                AlgeriaOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 7)
            {
                TunisWar = false;
                TunisOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 8)
            {
                SardWar = false;
                SardOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 9)
            {
                SicilyWar = false;
                SicilyOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 10)
            {
                NaplesWar = false;
                NaplesOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 11)
            {
                LuccaWar = false;
                LuccaOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 12)
            {
                ItalyWar = false;
                ItalyOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 13)
            {
                HelvetiaWar = false;
                HelvetiaOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 14)
            {
                AustrianWar = false;
                AustrianOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 15)
            {
                OttomanWar = false;
                OttomanOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 16)
            {
                MonteWar = false;
                MonteOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 17)
            {
                PrussiaWar = false;
                PrussiaOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 18)
            {
                WarsawWar = false;
                WarsawOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 19)
            {
                RussianWar = false;
                RussianOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 20)
            {
                SwedenWar = false;
                SwedenOpinion = 70f;
            }
            if (allies.GetComponent<Country_AI>().CountryType == 21)
            {
                NorwayWar = false;
                NorwayOpinion = 70f;
            }
        }

        foreach (GameObject borders in borderingEnemies)
        {
            if (borders.GetComponent<Control>().controller == 0)
            {
                FranceOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 1)
            {
                SpainOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 2)
            {
                PortugalOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 3)
            {
                UKOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 4)
            {
                CROpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 5)
            {
                MoroccoOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 6)
            {
                AlgeriaOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 7)
            {
                TunisOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 8)
            {
                SardOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 9)
            {
                SicilyOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 10)
            {
                NaplesOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 11)
            {
                LuccaOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 12)
            {
                ItalyOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 13)
            {
                HelvetiaOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 14)
            {
                AustrianOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 15)
            {
                OttomanOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 16)
            {
                MonteOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 17)
            {
                PrussiaOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 18)
            {
                WarsawOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 19)
            {
                RussianOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 20)
            {
                SwedenOpinion -= 10f;
            }
            if (borders.GetComponent<Control>().controller == 21)
            {
                NorwayOpinion -= 10f;
            }

            int declare = Random.Range(0, 100);
            if (declare >= 96)
            {
                if (borders.GetComponent<Control>().controller == 0)
                {
                    FranceOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 1)
                {
                    SpainOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 2)
                {
                    PortugalOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 3)
                {
                    UKOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 4)
                {
                    CROpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 5)
                {
                    MoroccoOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 6)
                {
                    AlgeriaOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 7)
                {
                    TunisOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 8)
                {
                    SardOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 9)
                {
                    SicilyOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 10)
                {
                    NaplesOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 11)
                {
                    LuccaOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 12)
                {
                    ItalyOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 13)
                {
                    HelvetiaOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 14)
                {
                    AustrianOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 15)
                {
                    OttomanOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 16)
                {
                    MonteOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 17)
                {
                    PrussiaOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 18)
                {
                    WarsawOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 19)
                {
                    RussianOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 20)
                {
                    SwedenOpinion -= 50f;
                }
                if (borders.GetComponent<Control>().controller == 21)
                {
                    NorwayOpinion -= 50f;
                }
            }

            int friends = Random.Range(0, 100);
            if (friends >= 98)
            {
                if (borders.GetComponent<Control>().controller == 0)
                {
                    FranceOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 1)
                {
                    SpainOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 2)
                {
                    PortugalOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 3)
                {
                    UKOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 4)
                {
                    CROpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 5)
                {
                    MoroccoOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 6)
                {
                    AlgeriaOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 7)
                {
                    TunisOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 8)
                {
                    SardOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 9)
                {
                    SicilyOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 10)
                {
                    NaplesOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 11)
                {
                    LuccaOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 12)
                {
                    ItalyOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 13)
                {
                    HelvetiaOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 14)
                {
                    AustrianOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 15)
                {
                    OttomanOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 16)
                {
                    MonteOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 17)
                {
                    PrussiaOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 18)
                {
                    WarsawOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 19)
                {
                    RussianOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 20)
                {
                    SwedenOpinion += 40f;
                }
                if (borders.GetComponent<Control>().controller == 21)
                {
                    NorwayOpinion += 40f;
                }
            }
        }

        if (FranceWar == true)
        {
            FranceOpinion = 0f;
            warList.Add("France");
        }
        if (SpainWar == true)
        {
            SpainOpinion = 0f;
            warList.Add("France");
        }
        if (PortugalWar == true)
        {
            PortugalOpinion = 0f;
            warList.Add("France");
        }
        if (UKWar == true)
        {
            UKOpinion = 0f;
            warList.Add("France");
        }
        if (CRWar == true)
        {
            CROpinion = 0f;
            warList.Add("France");
        }
        if (MoroccoWar == true)
        {
            MoroccoOpinion = 0f;
            warList.Add("France");
        }
        if (AlgeriaWar == true)
        {
            AlgeriaOpinion = 0f;
            warList.Add("France");
        }
        if (TunisWar == true)
        {
            TunisOpinion = 0f;
            warList.Add("France");
        }
        if (SardWar == true)
        {
            SardOpinion = 0f;
            warList.Add("France");
        }
        if (SicilyWar == true)
        {
            SicilyOpinion = 0f;
            warList.Add("France");
        }
        if (NaplesWar == true)
        {
            NaplesOpinion = 0f;
            warList.Add("France");
        }
        if (LuccaWar == true)
        {
            LuccaOpinion = 0f;
            warList.Add("France");
        }
        if (ItalyWar == true)
        {
            ItalyOpinion = 0f;
            warList.Add("France");
        }
        if (HelvetiaWar == true)
        {
            HelvetiaOpinion = 0f;
            warList.Add("France");
        }
        if (AustrianWar == true)
        {
            AustrianOpinion = 0f;
            warList.Add("France");
        }
        if (OttomanWar == true)
        {
            OttomanOpinion = 0f;
            warList.Add("France");
        }
        if (MonteWar == true)
        {
            MonteOpinion = 0f;
            warList.Add("France");
        }
        if (PrussiaWar == true)
        {
            PrussiaOpinion = 0f;
            warList.Add("France");
        }
        if (WarsawWar == true)
        {
            WarsawOpinion = 0f;
            warList.Add("France");
        }
        if (RussianWar == true)
        {
            RussianOpinion = 0f;
            warList.Add("France");
        }
        if (SwedenWar == true)
        {
            SwedenOpinion = 0f;
            warList.Add("France");
        }
        if (NorwayWar == true)
        {
            NorwayOpinion = 0f;
            warList.Add("France");
        }
        foreach (GameObject countries in GameObject.FindGameObjectsWithTag("country"))
        {
            foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
            {
                targetAI.GetComponent<Country_AI>().borderingEnemies.Clear();
            }
            countries.GetComponent<Control>().SpawnBorder();
        }
        StartAlliance();
    }

    void ConstantPeace()
    {
        if (CountryType == 0)
        {
            FranceWar = false;
            FranceOpinion = 100f;
        }
        if (CountryType == 1)
        {
            SpainWar = false;
            SpainOpinion = 100f;
        }
        if (CountryType == 2)
        {
            PortugalWar = false;
            PortugalOpinion = 100f;
        }
        if (CountryType == 3)
        {
            UKWar = false;
            UKOpinion = 100f;
        }
        if (CountryType == 4)
        {
            CRWar = false;
            CROpinion = 100f;
        }
        if (CountryType == 5)
        {
            MoroccoWar = false;
            MoroccoOpinion = 100f;
        }
        if (CountryType == 6)
        {
            AlgeriaWar = false;
            AlgeriaOpinion = 100f;
        }
        if (CountryType == 7)
        {
            TunisWar = false;
            TunisOpinion = 100f;
        }
        if (CountryType == 8)
        {
            SardWar = false;
            SardOpinion = 100f;
        }
        if (CountryType == 9)
        {
            SicilyWar = false;
            SicilyOpinion = 100f;
        }
        if (CountryType == 10)
        {
            NaplesWar = false;
            NaplesOpinion = 100f;
        }
        if (CountryType == 11)
        {
            LuccaWar = false;
            LuccaOpinion = 100f;
        }
        if (CountryType == 12)
        {
            ItalyWar = false;
            ItalyOpinion = 100f;
        }
        if (CountryType == 13)
        {
            HelvetiaWar = false;
            HelvetiaOpinion = 100f;
        }
        if (CountryType == 14)
        {
            AustrianWar = false;
            AustrianOpinion = 100f;
        }
        if (CountryType == 15)
        {
            OttomanWar = false;
            OttomanOpinion = 100f;
        }
        if (CountryType == 16)
        {
            MonteWar = false;
            MonteOpinion = 100f;
        }
        if (CountryType == 17)
        {
            PrussiaWar = false;
            PrussiaOpinion = 100f;
        }
        if (CountryType == 18)
        {
            WarsawWar = false;
            WarsawOpinion = 100f;
        }
        if (CountryType == 19)
        {
            RussianWar = false;
            RussianOpinion = 100f;
        }
        if (CountryType == 20)
        {
            SwedenWar = false;
            SwedenOpinion = 100f;
        }
        if (CountryType == 21)
        {
            NorwayWar = false;
            NorwayOpinion = 100f;
        }
    }

    public void FindGold()
    {
        if (CountryType == 0)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().franceGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().francePopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().franceMaterial;
        }
        if (CountryType == 1)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().spainGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().spainPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().spainMaterial;
        }
        if (CountryType == 2)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().portugalGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().portugalPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().portugalMaterial;
        }
        if (CountryType == 3)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().UKGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().UKPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().UKMaterial;
        }
        if (CountryType == 4)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().CRGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().CRPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().CRMaterial;
        }
        if (CountryType == 5)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().moroccoGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().moroccoPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().moroccoMaterial;
        }
        if (CountryType == 6)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().algeriaGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().algeriaPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().algeriaMaterial;
        }
        if (CountryType == 7)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().tunisGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().tunisPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().tunisMaterial;
        }
        if (CountryType == 8)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().sardGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().sardPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().sardMaterial;
        }
        if (CountryType == 9)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().sicilyGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().sicilyPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().sicilyMaterial;
        }
        if (CountryType == 10)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().naplesGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().naplesPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().naplesMaterial;
        }
        if (CountryType == 11)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().luccaGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().luccaPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().luccaMaterial;
        }
        if (CountryType == 12)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().italyGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().italyPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().italyMaterial;
        }
        if (CountryType == 13)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().helvetiaGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().helvetiaPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().helvetiaMaterial;
        }
        if (CountryType == 14)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().austrianGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().austrianPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().austrianMaterial;
        }
        if (CountryType == 15)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().ottomanGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().ottomanPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().ottomanMaterial;
        }
        if (CountryType == 16)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().monteGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().montePopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().monteMaterial;
        }
        if (CountryType == 17)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().prussiaGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().prussiaPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().prussiaMaterial;
        }
        if (CountryType == 18)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().warsawGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().warsawPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().warsawMaterial;
        }
        if (CountryType == 19)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().russianGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().russianPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().russianMaterial;
        }
        if (CountryType == 20)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().swedenGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().swedenPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().swedenMaterial;
        }
        if (CountryType == 21)
        {
            AIGold = GameObject.Find("information").GetComponent<countries>().norwayGold;
            AIPopulation = GameObject.Find("information").GetComponent<countries>().norwayPopulation;
            AIMaterial = GameObject.Find("information").GetComponent<countries>().norwayMaterial;
        }
    }

    void BuyMen()
    {
        if (CountryType == 0)
        {
            GameObject.Find("information").GetComponent<countries>().franceGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().francePopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().franceMaterial -= 20f;
        }
        if (CountryType == 1)
        {
            GameObject.Find("information").GetComponent<countries>().spainGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().spainPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().spainMaterial -= 20f;
        }
        if (CountryType == 2)
        {
            GameObject.Find("information").GetComponent<countries>().portugalGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().portugalPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().portugalMaterial -= 20f;
        }
        if (CountryType == 3)
        {
            GameObject.Find("information").GetComponent<countries>().UKGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().UKPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().UKMaterial -= 20f;
        }
        if (CountryType == 4)
        {
            GameObject.Find("information").GetComponent<countries>().CRGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().CRPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().CRMaterial -= 20f;
        }
        if (CountryType == 5)
        {
            GameObject.Find("information").GetComponent<countries>().moroccoGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().moroccoPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().moroccoMaterial -= 20f;
        }
        if (CountryType == 6)
        {
            GameObject.Find("information").GetComponent<countries>().algeriaGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().algeriaPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().algeriaMaterial -= 20f;
        }
        if (CountryType == 7)
        {
            GameObject.Find("information").GetComponent<countries>().tunisGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().tunisPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().tunisMaterial -= 20f;
        }
        if (CountryType == 8)
        {
            GameObject.Find("information").GetComponent<countries>().sardGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().sardPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().sardMaterial -= 20f;
        }
        if (CountryType == 9)
        {
            GameObject.Find("information").GetComponent<countries>().sicilyGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().sicilyPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().sicilyMaterial -= 20f;
        }
        if (CountryType == 10)
        {
            GameObject.Find("information").GetComponent<countries>().naplesGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().naplesPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().naplesMaterial -= 20f;
        }
        if (CountryType == 11)
        {
            GameObject.Find("information").GetComponent<countries>().luccaGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().luccaPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().luccaMaterial -= 20f;
        }
        if (CountryType == 12)
        {
            GameObject.Find("information").GetComponent<countries>().italyGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().italyPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().italyMaterial -= 20f;
        }
        if (CountryType == 13)
        {
            GameObject.Find("information").GetComponent<countries>().helvetiaGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().helvetiaPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().helvetiaMaterial -= 20f;
        }
        if (CountryType == 14)
        {
            GameObject.Find("information").GetComponent<countries>().austrianGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().austrianPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().austrianMaterial -= 20f;
        }
        if (CountryType == 15)
        {
            GameObject.Find("information").GetComponent<countries>().ottomanGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().ottomanPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().ottomanMaterial -= 20f;
        }
        if (CountryType == 16)
        {
            GameObject.Find("information").GetComponent<countries>().monteGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().montePopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().monteMaterial -= 20f;
        }
        if (CountryType == 17)
        {
            GameObject.Find("information").GetComponent<countries>().prussiaGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().prussiaPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().prussiaMaterial -= 20f;
        }
        if (CountryType == 18)
        {
            GameObject.Find("information").GetComponent<countries>().warsawGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().warsawPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().warsawMaterial -= 20f;
        }
        if (CountryType == 19)
        {
            GameObject.Find("information").GetComponent<countries>().russianGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().russianPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().russianMaterial -= 20f;
        }
        if (CountryType == 20)
        {
            GameObject.Find("information").GetComponent<countries>().swedenGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().swedenPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().swedenMaterial -= 20f;
        }
        if (CountryType == 21)
        {
            GameObject.Find("information").GetComponent<countries>().norwayGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().norwayPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().norwayMaterial -= 20f;
        }
        FindGold();
        DoBuy();
    }

    void BuyBuild()
    {
        if (CountryType == 0)
        {
            GameObject.Find("information").GetComponent<countries>().franceGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().francePopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().franceMaterial -= 20f;
        }
        if (CountryType == 1)
        {
            GameObject.Find("information").GetComponent<countries>().spainGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().spainPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().spainMaterial -= 20f;
        }
        if (CountryType == 2)
        {
            GameObject.Find("information").GetComponent<countries>().portugalGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().portugalPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().portugalMaterial -= 20f;
        }
        if (CountryType == 3)
        {
            GameObject.Find("information").GetComponent<countries>().UKGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().UKPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().UKMaterial -= 20f;
        }
        if (CountryType == 4)
        {
            GameObject.Find("information").GetComponent<countries>().CRGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().CRPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().CRMaterial -= 20f;
        }
        if (CountryType == 5)
        {
            GameObject.Find("information").GetComponent<countries>().moroccoGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().moroccoPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().moroccoMaterial -= 20f;
        }
        if (CountryType == 6)
        {
            GameObject.Find("information").GetComponent<countries>().algeriaGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().algeriaPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().algeriaMaterial -= 20f;
        }
        if (CountryType == 7)
        {
            GameObject.Find("information").GetComponent<countries>().tunisGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().tunisPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().tunisMaterial -= 20f;
        }
        if (CountryType == 8)
        {
            GameObject.Find("information").GetComponent<countries>().sardGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().sardPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().sardMaterial -= 20f;
        }
        if (CountryType == 9)
        {
            GameObject.Find("information").GetComponent<countries>().sicilyGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().sicilyPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().sicilyMaterial -= 20f;
        }
        if (CountryType == 10)
        {
            GameObject.Find("information").GetComponent<countries>().naplesGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().naplesPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().naplesMaterial -= 20f;
        }
        if (CountryType == 11)
        {
            GameObject.Find("information").GetComponent<countries>().luccaGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().luccaPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().luccaMaterial -= 20f;
        }
        if (CountryType == 12)
        {
            GameObject.Find("information").GetComponent<countries>().italyGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().italyPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().italyMaterial -= 20f;
        }
        if (CountryType == 13)
        {
            GameObject.Find("information").GetComponent<countries>().helvetiaGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().helvetiaPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().helvetiaMaterial -= 20f;
        }
        if (CountryType == 14)
        {
            GameObject.Find("information").GetComponent<countries>().austrianGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().austrianPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().austrianMaterial -= 20f;
        }
        if (CountryType == 15)
        {
            GameObject.Find("information").GetComponent<countries>().ottomanGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().ottomanPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().ottomanMaterial -= 20f;
        }
        if (CountryType == 16)
        {
            GameObject.Find("information").GetComponent<countries>().monteGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().montePopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().monteMaterial -= 20f;
        }
        if (CountryType == 17)
        {
            GameObject.Find("information").GetComponent<countries>().prussiaGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().prussiaPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().prussiaMaterial -= 20f;
        }
        if (CountryType == 18)
        {
            GameObject.Find("information").GetComponent<countries>().warsawGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().warsawPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().warsawMaterial -= 20f;
        }
        if (CountryType == 19)
        {
            GameObject.Find("information").GetComponent<countries>().russianGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().russianPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().russianMaterial -= 20f;
        }
        if (CountryType == 20)
        {
            GameObject.Find("information").GetComponent<countries>().swedenGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().swedenPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().swedenMaterial -= 20f;
        }
        if (CountryType == 21)
        {
            GameObject.Find("information").GetComponent<countries>().norwayGold -= 15f;
            GameObject.Find("information").GetComponent<countries>().norwayPopulation -= 10f;
            GameObject.Find("information").GetComponent<countries>().norwayMaterial -= 20f;
        }
        FindGold();
    }

    void FindLand()
    {
        foreach (GameObject friendlyObj in GameObject.FindGameObjectsWithTag("country"))
        {
            if (friendlyObj.gameObject.GetComponent<Control>().controller == CountryType)
            {
                if (!allLand.Contains(friendlyObj))
                {
                    allLand.Add(friendlyObj);
                }
            }
        }
        foreach (GameObject enemyObj in allLand.ToList())
        {
            if (enemyObj.gameObject.GetComponent<Control>().controller != CountryType)
            {
                this.gameObject.GetComponent<Country_AI>().allLand.Remove(enemyObj);
            }
        }
    }

    IEnumerator WaitTurn(float waitTurnTime) //not being used
    {
        yield return new WaitForSeconds(waitTurnTime);
        GameObject.Find("information").GetComponent<countries>().NewTurn();
    }

    void DoTurn()
    {
        Diplomacy();
        //StartCoroutine(WaitTurn(1f));
    }

    void DoAttack()
    {
        int IfAttack = Random.Range(0, 100);
        int randomCountry = Random.Range(0, allLand.Count);
        attackCountryAI1 = allLand[randomCountry];

        int randomAttack = Random.Range(0, attackCountryAI1.gameObject.GetComponent<Control>().borderSpawn.Count);

        if (IfAttack >= 10)
        {
            if (randomAttack == 0)
            {
                if (allLand[randomCountry].gameObject.GetComponent<Control>().borderSpawn.Count >= 1)
                {
                    attackCountryAI2 = allLand[randomCountry].gameObject.GetComponent<Control>().accountGame0;

                    if (attackCountryAI2.gameObject.GetComponent<Control>().controller == 0 && FranceWar == true || attackCountryAI2.gameObject.GetComponent<Control>().controller == 1 && SpainWar == true || attackCountryAI2.GetComponent<Control>().controller == 2 && PortugalWar == true || attackCountryAI2.GetComponent<Control>().controller == 3 && UKWar == true || attackCountryAI2.GetComponent<Control>().controller == 4 && CRWar == true || attackCountryAI2.GetComponent<Control>().controller == 5 && MoroccoWar == true || attackCountryAI2.GetComponent<Control>().controller == 6 && AlgeriaWar == true || attackCountryAI2.GetComponent<Control>().controller == 7 && TunisWar == true || attackCountryAI2.GetComponent<Control>().controller == 8 && SardWar == true || attackCountryAI2.GetComponent<Control>().controller == 9 && SicilyWar == true || attackCountryAI2.GetComponent<Control>().controller == 10 && NaplesWar == true || attackCountryAI2.GetComponent<Control>().controller == 11 && LuccaWar == true || attackCountryAI2.GetComponent<Control>().controller == 12 && ItalyWar == true || attackCountryAI2.GetComponent<Control>().controller == 13 && HelvetiaWar == true || attackCountryAI2.GetComponent<Control>().controller == 14 && AustrianWar == true || attackCountryAI2.GetComponent<Control>().controller == 15 && OttomanWar == true || attackCountryAI2.GetComponent<Control>().controller == 16 && MonteWar == true || attackCountryAI2.GetComponent<Control>().controller == 17 && PrussiaWar == true || attackCountryAI2.GetComponent<Control>().controller == 18 && WarsawWar == true || attackCountryAI2.GetComponent<Control>().controller == 19 && RussianWar == true || attackCountryAI2.GetComponent<Control>().controller == 20 && SwedenWar == true || attackCountryAI2.GetComponent<Control>().controller == 21 && NorwayWar == true)
                    {
                        if (!alliances.Contains(attackCountryAI2))
                        {
                            GameObject.Find("information").GetComponent<Occupation>().Attack();
                        }
                    }
                    else
                    {
                        randomAttack = Random.Range(0, attackCountryAI1.gameObject.GetComponent<Control>().borderSpawn.Count);
                    }
                }
                else
                {
                    randomAttack = Random.Range(0, attackCountryAI1.gameObject.GetComponent<Control>().borderSpawn.Count);
                }
            }
            if (randomAttack == 1)
            {
                if (allLand[randomCountry].gameObject.GetComponent<Control>().borderSpawn.Count >= 2)
                {
                    attackCountryAI2 = allLand[randomCountry].gameObject.GetComponent<Control>().accountGame1;

                    if (attackCountryAI2.gameObject.GetComponent<Control>().controller == 0 && FranceWar == true || attackCountryAI2.gameObject.GetComponent<Control>().controller == 1 && SpainWar == true || attackCountryAI2.GetComponent<Control>().controller == 2 && PortugalWar == true || attackCountryAI2.GetComponent<Control>().controller == 3 && UKWar == true || attackCountryAI2.GetComponent<Control>().controller == 4 && CRWar == true || attackCountryAI2.GetComponent<Control>().controller == 5 && MoroccoWar == true || attackCountryAI2.GetComponent<Control>().controller == 6 && AlgeriaWar == true || attackCountryAI2.GetComponent<Control>().controller == 7 && TunisWar == true || attackCountryAI2.GetComponent<Control>().controller == 8 && SardWar == true || attackCountryAI2.GetComponent<Control>().controller == 9 && SicilyWar == true || attackCountryAI2.GetComponent<Control>().controller == 10 && NaplesWar == true || attackCountryAI2.GetComponent<Control>().controller == 11 && LuccaWar == true || attackCountryAI2.GetComponent<Control>().controller == 12 && ItalyWar == true || attackCountryAI2.GetComponent<Control>().controller == 13 && HelvetiaWar == true || attackCountryAI2.GetComponent<Control>().controller == 14 && AustrianWar == true || attackCountryAI2.GetComponent<Control>().controller == 15 && OttomanWar == true || attackCountryAI2.GetComponent<Control>().controller == 16 && MonteWar == true || attackCountryAI2.GetComponent<Control>().controller == 17 && PrussiaWar == true || attackCountryAI2.GetComponent<Control>().controller == 18 && WarsawWar == true || attackCountryAI2.GetComponent<Control>().controller == 19 && RussianWar == true || attackCountryAI2.GetComponent<Control>().controller == 20 && SwedenWar == true || attackCountryAI2.GetComponent<Control>().controller == 21 && NorwayWar == true)
                    {
                        if (!alliances.Contains(attackCountryAI2))
                        {
                            GameObject.Find("information").GetComponent<Occupation>().Attack();
                        }
                    }
                    else
                    {
                        randomAttack = Random.Range(0, attackCountryAI1.gameObject.GetComponent<Control>().borderSpawn.Count);
                    }
                }
                else
                {
                    randomAttack = Random.Range(0, attackCountryAI1.gameObject.GetComponent<Control>().borderSpawn.Count);
                }
            }
            if (randomAttack == 2)
            {
                if (allLand[randomCountry].gameObject.GetComponent<Control>().borderSpawn.Count >= 3)
                {
                    attackCountryAI2 = allLand[randomCountry].gameObject.GetComponent<Control>().accountGame2;

                    if (attackCountryAI2.gameObject.GetComponent<Control>().controller == 0 && FranceWar == true || attackCountryAI2.gameObject.GetComponent<Control>().controller == 1 && SpainWar == true || attackCountryAI2.GetComponent<Control>().controller == 2 && PortugalWar == true || attackCountryAI2.GetComponent<Control>().controller == 3 && UKWar == true || attackCountryAI2.GetComponent<Control>().controller == 4 && CRWar == true || attackCountryAI2.GetComponent<Control>().controller == 5 && MoroccoWar == true || attackCountryAI2.GetComponent<Control>().controller == 6 && AlgeriaWar == true || attackCountryAI2.GetComponent<Control>().controller == 7 && TunisWar == true || attackCountryAI2.GetComponent<Control>().controller == 8 && SardWar == true || attackCountryAI2.GetComponent<Control>().controller == 9 && SicilyWar == true || attackCountryAI2.GetComponent<Control>().controller == 10 && NaplesWar == true || attackCountryAI2.GetComponent<Control>().controller == 11 && LuccaWar == true || attackCountryAI2.GetComponent<Control>().controller == 12 && ItalyWar == true || attackCountryAI2.GetComponent<Control>().controller == 13 && HelvetiaWar == true || attackCountryAI2.GetComponent<Control>().controller == 14 && AustrianWar == true || attackCountryAI2.GetComponent<Control>().controller == 15 && OttomanWar == true || attackCountryAI2.GetComponent<Control>().controller == 16 && MonteWar == true || attackCountryAI2.GetComponent<Control>().controller == 17 && PrussiaWar == true || attackCountryAI2.GetComponent<Control>().controller == 18 && WarsawWar == true || attackCountryAI2.GetComponent<Control>().controller == 19 && RussianWar == true || attackCountryAI2.GetComponent<Control>().controller == 20 && SwedenWar == true || attackCountryAI2.GetComponent<Control>().controller == 21 && NorwayWar == true)
                    {
                        if (!alliances.Contains(attackCountryAI2))
                        {
                            GameObject.Find("information").GetComponent<Occupation>().Attack();
                        }
                    }
                    else
                    {
                        randomAttack = Random.Range(0, attackCountryAI1.gameObject.GetComponent<Control>().borderSpawn.Count);
                    }
                }
                else
                {
                    randomAttack = Random.Range(0, attackCountryAI1.gameObject.GetComponent<Control>().borderSpawn.Count);
                }
            }
            if (randomAttack == 3)
            {
                if (allLand[randomCountry].gameObject.GetComponent<Control>().borderSpawn.Count >= 4)
                {
                    attackCountryAI2 = allLand[randomCountry].gameObject.GetComponent<Control>().accountGame3;

                    if (attackCountryAI2.gameObject.GetComponent<Control>().controller == 0 && FranceWar == true || attackCountryAI2.gameObject.GetComponent<Control>().controller == 1 && SpainWar == true || attackCountryAI2.GetComponent<Control>().controller == 2 && PortugalWar == true || attackCountryAI2.GetComponent<Control>().controller == 3 && UKWar == true || attackCountryAI2.GetComponent<Control>().controller == 4 && CRWar == true || attackCountryAI2.GetComponent<Control>().controller == 5 && MoroccoWar == true || attackCountryAI2.GetComponent<Control>().controller == 6 && AlgeriaWar == true || attackCountryAI2.GetComponent<Control>().controller == 7 && TunisWar == true || attackCountryAI2.GetComponent<Control>().controller == 8 && SardWar == true || attackCountryAI2.GetComponent<Control>().controller == 9 && SicilyWar == true || attackCountryAI2.GetComponent<Control>().controller == 10 && NaplesWar == true || attackCountryAI2.GetComponent<Control>().controller == 11 && LuccaWar == true || attackCountryAI2.GetComponent<Control>().controller == 12 && ItalyWar == true || attackCountryAI2.GetComponent<Control>().controller == 13 && HelvetiaWar == true || attackCountryAI2.GetComponent<Control>().controller == 14 && AustrianWar == true || attackCountryAI2.GetComponent<Control>().controller == 15 && OttomanWar == true || attackCountryAI2.GetComponent<Control>().controller == 16 && MonteWar == true || attackCountryAI2.GetComponent<Control>().controller == 17 && PrussiaWar == true || attackCountryAI2.GetComponent<Control>().controller == 18 && WarsawWar == true || attackCountryAI2.GetComponent<Control>().controller == 19 && RussianWar == true || attackCountryAI2.GetComponent<Control>().controller == 20 && SwedenWar == true || attackCountryAI2.GetComponent<Control>().controller == 21 && NorwayWar == true)
                    {
                        if (!alliances.Contains(attackCountryAI2))
                        {
                            GameObject.Find("information").GetComponent<Occupation>().Attack();
                        }
                    }
                    else
                    {
                        randomAttack = Random.Range(0, attackCountryAI1.gameObject.GetComponent<Control>().borderSpawn.Count);
                    }
                }
                else
                {
                    randomAttack = Random.Range(0, attackCountryAI1.gameObject.GetComponent<Control>().borderSpawn.Count);
                }
            }
            if (randomAttack == 4)
            {
                if (allLand[randomCountry].gameObject.GetComponent<Control>().borderSpawn.Count >= 5)
                {
                    attackCountryAI2 = allLand[randomCountry].gameObject.GetComponent<Control>().accountGame4;

                    if (attackCountryAI2.gameObject.GetComponent<Control>().controller == 0 && FranceWar == true || attackCountryAI2.gameObject.GetComponent<Control>().controller == 1 && SpainWar == true || attackCountryAI2.GetComponent<Control>().controller == 2 && PortugalWar == true || attackCountryAI2.GetComponent<Control>().controller == 3 && UKWar == true || attackCountryAI2.GetComponent<Control>().controller == 4 && CRWar == true || attackCountryAI2.GetComponent<Control>().controller == 5 && MoroccoWar == true || attackCountryAI2.GetComponent<Control>().controller == 6 && AlgeriaWar == true || attackCountryAI2.GetComponent<Control>().controller == 7 && TunisWar == true || attackCountryAI2.GetComponent<Control>().controller == 8 && SardWar == true || attackCountryAI2.GetComponent<Control>().controller == 9 && SicilyWar == true || attackCountryAI2.GetComponent<Control>().controller == 10 && NaplesWar == true || attackCountryAI2.GetComponent<Control>().controller == 11 && LuccaWar == true || attackCountryAI2.GetComponent<Control>().controller == 12 && ItalyWar == true || attackCountryAI2.GetComponent<Control>().controller == 13 && HelvetiaWar == true || attackCountryAI2.GetComponent<Control>().controller == 14 && AustrianWar == true || attackCountryAI2.GetComponent<Control>().controller == 15 && OttomanWar == true || attackCountryAI2.GetComponent<Control>().controller == 16 && MonteWar == true || attackCountryAI2.GetComponent<Control>().controller == 17 && PrussiaWar == true || attackCountryAI2.GetComponent<Control>().controller == 18 && WarsawWar == true || attackCountryAI2.GetComponent<Control>().controller == 19 && RussianWar == true || attackCountryAI2.GetComponent<Control>().controller == 20 && SwedenWar == true || attackCountryAI2.GetComponent<Control>().controller == 21 && NorwayWar == true)
                    {
                        if (!alliances.Contains(attackCountryAI2))
                        {
                            GameObject.Find("information").GetComponent<Occupation>().Attack();
                        }
                    }
                    else
                    {
                        randomAttack = Random.Range(0, attackCountryAI1.gameObject.GetComponent<Control>().borderSpawn.Count);
                    }
                }
                else
                {
                    randomAttack = Random.Range(0, attackCountryAI1.gameObject.GetComponent<Control>().borderSpawn.Count);
                }
            }
        }
        DoBuy();
    }

    void DoBuy()
    {
        int chooseBuy = Random.Range(0, 100);
        if (0 < chooseBuy && chooseBuy < 33)
        {
            if (AIGold > 16 && AIPopulation > 11 && AIMaterial > 21)
            {
                attackCountryAI1.GetComponent<Control>().cavalry += 1f;
                buyGold = 15f;
                buyPopulation = 10f;
                buyMaterial = 20f;
                BuyMen();
            }
            else
            {
                DoBuild();
            }
        }
        if (32 < chooseBuy && chooseBuy < 63)
        {
            if (AIGold > 16 && AIPopulation > 11 && AIMaterial > 21)
            {
                attackCountryAI1.GetComponent<Control>().infantry += 1f;
                buyGold = 15f;
                buyPopulation = 10f;
                buyMaterial = 20f;
                BuyMen();
            }
            else
            {
                DoBuild();
            }
        }
        if (62 < chooseBuy && chooseBuy < 93)
        {
            if (AIGold > 16 && AIPopulation > 11 && AIMaterial > 21)
            {
                attackCountryAI1.GetComponent<Control>().artillery += 1f;
                buyGold = 15f;
                buyPopulation = 10f;
                buyMaterial = 20f;
                BuyMen();
            }
            else
            {
                DoBuild();
            }
        }
        if (92 < chooseBuy && chooseBuy < 101)
        {
            DoBuild();
        }
    }

    void DoBuild()
    {
        int chooseBuild = Random.Range(0, 100);
        if (chooseBuild > 50)
        {
            if (attackCountryAI1.GetComponent<Control>().defenseLevel <= 4 && AIGold > 16 && AIPopulation > 11 && AIMaterial > 21)
            {
                buyGold = 15f;
                buyPopulation = 10f;
                buyMaterial = 20f;
                BuyBuild();
                attackCountryAI1.GetComponent<Control>().defenseMultiplier += 0.1f;
                attackCountryAI1.GetComponent<Control>().defenseLevel += 1f;
                GameObject.Find("information").GetComponent<countries>().NewTurn();
            }
            else
            {
                GameObject.Find("information").GetComponent<countries>().NewTurn();
            }
        }
        if (chooseBuild < 51)
        {
            if (attackCountryAI1.GetComponent<Control>().barracksLevel <= 4 && AIGold > 16 && AIPopulation > 11 && AIMaterial > 21)
            {
                buyGold = 15f;
                buyPopulation = 10f;
                buyMaterial = 20f;
                BuyBuild();
                attackCountryAI1.GetComponent<Control>().barracksMultiplier += 0.1f;
                attackCountryAI1.GetComponent<Control>().barracksLevel += 1f;
                GameObject.Find("information").GetComponent<countries>().NewTurn();
            }
            else
            {
                GameObject.Find("information").GetComponent<countries>().NewTurn();
            }
        }
        //StartCoroutine(WaitTurn(1f));
    }

    void StartAlliance()
    {
        #pragma warning disable 0642
        //all below start alliance
        if (FranceOpinion >= 60f && FranceWar == false && !alliances.Contains(GameObject.Find("France AI"))) //0
        {
            alliances.Add(GameObject.Find("France AI"));
            if (!GameObject.Find("France AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject));
            {
                GameObject.Find("France AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (SpainOpinion >= 60f && SpainWar == false && !alliances.Contains(GameObject.Find("Spain AI"))) //1
        {
            alliances.Add(GameObject.Find("Spain AI"));
            if (!GameObject.Find("Spain AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject));
            {
                GameObject.Find("Spain AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (PortugalOpinion >= 60f && PortugalWar == false && !alliances.Contains(GameObject.Find("Portugal AI"))) //2
        {
            alliances.Add(GameObject.Find("Portugal AI"));
            if (!GameObject.Find("Portugal AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject));
            {
                GameObject.Find("Portugal AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (UKOpinion >= 60f && UKWar == false && !alliances.Contains(GameObject.Find("UK AI"))) //3
        {
            alliances.Add(GameObject.Find("UK AI"));
            if (!GameObject.Find("UK AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject));
            {
                GameObject.Find("UK AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (CROpinion >= 60f && CRWar == false && !alliances.Contains(GameObject.Find("CR AI"))) //4
        {
            alliances.Add(GameObject.Find("CR AI"));
            if (!GameObject.Find("CR AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject));
            {
                GameObject.Find("CR AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (MoroccoOpinion >= 60f && MoroccoWar == false && !alliances.Contains(GameObject.Find("Morocco AI"))) //5
        {
            alliances.Add(GameObject.Find("Morocco AI"));
            if (!GameObject.Find("Morocco AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Morocco AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (AlgeriaOpinion >= 60f && AlgeriaWar == false && !alliances.Contains(GameObject.Find("Algeria AI"))) //6
        {
            alliances.Add(GameObject.Find("Algeria AI"));
            if (!GameObject.Find("Algeria AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Algeria AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (TunisOpinion >= 60f && TunisWar == false && !alliances.Contains(GameObject.Find("Tunis AI"))) //7
        {
            alliances.Add(GameObject.Find("Tunis AI"));
            if (!GameObject.Find("Tunis AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Tunis AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (SardOpinion >= 60f && SardWar == false && !alliances.Contains(GameObject.Find("Sardinia AI"))) //8
        {
            alliances.Add(GameObject.Find("Sardinia AI"));
            if (!GameObject.Find("Sardinia AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Sardinia AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (SicilyOpinion >= 60f && SicilyWar == false && !alliances.Contains(GameObject.Find("Sicily AI"))) //9
        {
            alliances.Add(GameObject.Find("Sicily AI"));
            if (!GameObject.Find("Sicily AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Sicily AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (NaplesOpinion >= 60f && NaplesWar == false && !alliances.Contains(GameObject.Find("Naples AI"))) //10
        {
            alliances.Add(GameObject.Find("Naples AI"));
            if (!GameObject.Find("Naples AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Naples AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (LuccaOpinion >= 60f && LuccaWar == false && !alliances.Contains(GameObject.Find("Lucca AI"))) //11
        {
            alliances.Add(GameObject.Find("Lucca AI"));
            if (!GameObject.Find("Lucca AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Lucca AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (ItalyOpinion >= 60f && ItalyWar == false && !alliances.Contains(GameObject.Find("Italy AI"))) //12
        {
            alliances.Add(GameObject.Find("Italy AI"));
            if (!GameObject.Find("Italy AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Italy AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (HelvetiaOpinion >= 60f && HelvetiaWar == false && !alliances.Contains(GameObject.Find("Helvetia AI"))) //13
        {
            alliances.Add(GameObject.Find("Helvetia AI"));
            if (!GameObject.Find("Helvetia AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Helvetia AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (AustrianOpinion >= 60f && AustrianWar == false && !alliances.Contains(GameObject.Find("Austria AI"))) //14
        {
            alliances.Add(GameObject.Find("Austria AI"));
            if (!GameObject.Find("Austria AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Austria AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (OttomanOpinion >= 60f && OttomanWar == false && !alliances.Contains(GameObject.Find("Ottoman AI"))) //15
        {
            alliances.Add(GameObject.Find("Ottoman AI"));
            if (!GameObject.Find("Ottoman AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Ottoman AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (MonteOpinion >= 60f && MonteWar == false && !alliances.Contains(GameObject.Find("Montenegro AI"))) //16
        {
            alliances.Add(GameObject.Find("Montenegro AI"));
            if (!GameObject.Find("Montenegro AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Montenegro AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (PrussiaOpinion >= 60f && PrussiaWar == false && !alliances.Contains(GameObject.Find("Prussia AI"))) //17
        {
            alliances.Add(GameObject.Find("Prussia AI"));
            if (!GameObject.Find("Prussia AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Prussia AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarsawOpinion >= 60f && WarsawWar == false && !alliances.Contains(GameObject.Find("Warsaw AI"))) //18
        {
            alliances.Add(GameObject.Find("Warsaw AI"));
            if (!GameObject.Find("Warsaw AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Warsaw AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (RussianOpinion >= 60f && RussianWar == false && !alliances.Contains(GameObject.Find("Russia AI"))) //19
        {
            alliances.Add(GameObject.Find("Russia AI"));
            if (!GameObject.Find("Russia AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Russia AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (SwedenOpinion >= 60f && SwedenWar == false && !alliances.Contains(GameObject.Find("Sweden AI"))) //20
        {
            alliances.Add(GameObject.Find("Sweden AI"));
            if (!GameObject.Find("Sweden AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Sweden AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (NorwayOpinion >= 60f && NorwayWar == false && !alliances.Contains(GameObject.Find("Norway AI"))) //21
        {
            alliances.Add(GameObject.Find("Norway AI"));
            if (!GameObject.Find("Norway AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject)) ;
            {
                GameObject.Find("Norway AI").GetComponent<Country_AI>().alliances.Add(this.gameObject);
            }
            Debug.Log("Alliance started between " + this.gameObject.name + " and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + this.gameObject.name + " and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        #pragma warning restore 0642
        StartWar();
    }

    void StartWar()
    {
        //all below start war
        if (FranceOpinion <= 20f && FranceWar == false && CountryType != 0) //0
        {
            if (GameObject.Find("France AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("France AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("France AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and France");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and France";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                FranceWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("France AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and France");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and France";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (SpainOpinion <= 20f && SpainWar == false && CountryType != 1) //1
        {
            if (GameObject.Find("Spain AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Spain AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Spain AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Spain");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Spain";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                SpainWar = true;
                if (CountryType == 0)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Spain AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Spain");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Spain";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PortugalOpinion <= 20f && PortugalWar == false && CountryType != 2) //2
        {
            if (GameObject.Find("Portugal AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Portugal AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Portugal AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Portugal");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Portugal";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PortugalWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Portugal AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Portugal");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Portugal";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (UKOpinion <= 20f && UKWar == false && CountryType != 3) //3
        {
            if (GameObject.Find("UK AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("UK AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("UK AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and UK");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and UK";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                UKWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("UK AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and UK");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and UK";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (CROpinion <= 20f && CRWar == false && CountryType != 4) //4
        {
            if (GameObject.Find("CR AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("CR AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("CR AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and CR");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and CR";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                CRWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("CR AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and CR");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and CR";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (MoroccoOpinion <= 20f && MoroccoWar == false && CountryType != 5) //5
        {
            if (GameObject.Find("Morocco AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Morocco AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Morocco AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Morocco");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Morocco";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                MoroccoWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Morocco AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Morocco");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Morocco";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (AlgeriaOpinion <= 20f && AlgeriaWar == false && CountryType != 6) //6
        {
            if (GameObject.Find("Algeria AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Algeria AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Algeria AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Algeria");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Algeria";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                AlgeriaWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Algeria AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Algeria");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Algeria";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (TunisOpinion <= 20f && TunisWar == false && CountryType != 7) //7
        {
            if (GameObject.Find("Tunis AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Tunis AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Tunis AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Tunis");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Tunis";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                TunisWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Tunis AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Tunis");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Tunis";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (SardOpinion <= 20f && SardWar == false && CountryType != 8) //8
        {
            if (GameObject.Find("Sardinia AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Sardinia AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Sardinia AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Sardinia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Sardinia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                SardWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Sardinia AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Sardinia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Sardinia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (SicilyOpinion <= 20f && SicilyWar == false && CountryType != 9) //7
        {
            if (GameObject.Find("Sicily AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Sicily AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Sicily AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Sicily");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Sicily";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                SicilyWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Sicily AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Sicily");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Sicily";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (NaplesOpinion <= 20f && NaplesWar == false && CountryType != 10) //7
        {
            if (GameObject.Find("Naples AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Naples AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Naples AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Naples");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Naples";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                NaplesWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Naples AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Naples");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Naples";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (LuccaOpinion <= 20f && LuccaWar == false && CountryType != 11) //7
        {
            if (GameObject.Find("Lucca AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Lucca AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Lucca AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Lucca");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Lucca";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                LuccaWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Lucca AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Lucca");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Lucca";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (ItalyOpinion <= 20f && ItalyWar == false && CountryType != 12) //7
        {
            if (GameObject.Find("Italy AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Italy AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Italy AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Italy");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Italy";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                ItalyWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Italy AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Italy");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Italy";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (HelvetiaOpinion <= 20f && HelvetiaWar == false && CountryType != 13) //7
        {
            if (GameObject.Find("Helvetia AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Helvetia AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Helvetia AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Helvetia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Helvetia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                HelvetiaWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Helvetia AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Helvetia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Helvetia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (AustrianOpinion <= 20f && AustrianWar == false && CountryType != 14) //7
        {
            if (GameObject.Find("Austria AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Austria AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Austria AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Austria");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Austria";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                AustrianWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Austria AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Austria");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Austria";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (OttomanOpinion <= 20f && OttomanWar == false && CountryType != 15) //7
        {
            if (GameObject.Find("Ottoman AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Ottoman AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Ottoman AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Ottoman");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Ottoman";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                OttomanWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Ottoman AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Ottoman");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Ottoman";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (MonteOpinion <= 20f && MonteWar == false && CountryType != 16) //7
        {
            if (GameObject.Find("Montenegro AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Montenegro AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Montenegro AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Montenegro");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Montenegro";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                MonteWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Montenegro AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Montenegro");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Montenegro";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PrussiaOpinion <= 20f && PrussiaWar == false && CountryType != 17) //7
        {
            if (GameObject.Find("Prussia AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Prussia AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Prussia AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Prussia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Prussia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PrussiaWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Prussia AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Prussia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Prussia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (WarsawOpinion <= 20f && WarsawWar == false && CountryType != 18) //7
        {
            if (GameObject.Find("Warsaw AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Warsaw AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Warsaw AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Warsaw");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Warsaw";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                WarsawWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Warsaw AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Warsaw");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Warsaw";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (RussianOpinion <= 20f && RussianWar == false && CountryType != 19) //7
        {
            if (GameObject.Find("Russia AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Russia AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Russia AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Russia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Russia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                RussianWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Russia AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Russia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Russia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (SwedenOpinion <= 20f && SwedenWar == false && CountryType != 20) //20
        {
            if (GameObject.Find("Sweden AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Sweden AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Sweden AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Sweden");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Sweden";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                SwedenWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (CountryType == 21)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Sweden AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Sweden");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Sweden";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (NorwayOpinion <= 20f && NorwayWar == false && CountryType != 21) //7
        {
            if (GameObject.Find("Norway AI").GetComponent<Country_AI>().alliances.Contains(this.gameObject))
            {
                GameObject.Find("Norway AI").GetComponent<Country_AI>().alliances.Remove(this.gameObject);
                this.gameObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Norway AI"));
                Debug.Log("Alliance broken between " + this.gameObject.name + " and Norway/Denmark");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance broken between " + this.gameObject.name + " and Norway/Denmark";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                NorwayWar = true;
                if (CountryType == 1)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (CountryType == 2)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (CountryType == 3)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (CountryType == 0)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (CountryType == 5)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (CountryType == 6)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (CountryType == 4)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (CountryType == 8)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (CountryType == 9)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (CountryType == 10)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (CountryType == 11)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (CountryType == 12)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (CountryType == 13)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (CountryType == 14)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (CountryType == 15)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (CountryType == 16)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (CountryType == 17)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (CountryType == 18)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (CountryType == 19)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (CountryType == 20)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (CountryType == 7)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().TunisWar = true;
                }
                GameObject.Find("information").GetComponent<countries>().warCountry1 = this.gameObject;
                GameObject.Find("information").GetComponent<countries>().warCountry2 = GameObject.Find("Norway AI");
                GameObject.Find("information").GetComponent<countries>().SpawnWar();
                Debug.Log("War started between " + this.gameObject.name + " and Norway/Denmark");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + this.gameObject.name + " and Norway/Denmark";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        DoAttack();
    }

    public void PlayerDiplomacy()
    {
        allianceList.Clear();
        warList.Clear();

        FranceOpinion = 50f;
        SpainOpinion = 50f;
        PortugalOpinion = 50f;
        UKOpinion = 50f;
        CROpinion = 50f;
        MoroccoOpinion = 50f;
        AlgeriaOpinion = 50f;
        TunisOpinion = 50f;
        SardOpinion = 50f;
        SicilyOpinion = 50f;
        NaplesOpinion = 50f;
        LuccaOpinion = 50f;
        ItalyOpinion = 50f;
        HelvetiaOpinion = 50f;
        AustrianOpinion = 50f;
        OttomanOpinion = 50f;
        MonteOpinion = 50f;
        PrussiaOpinion = 50f;
        WarsawOpinion = 50f;
        RussianOpinion = 50f;
        SwedenOpinion = 50f;
        NorwayOpinion = 50f;

        if (FranceWar == true)
        {
            FranceOpinion = 0f;
            warList.Add("France");
        }
        if (SpainWar == true)
        {
            SpainOpinion = 0f;
            warList.Add("Spain");
        }
        if (PortugalWar == true)
        {
            PortugalOpinion = 0f;
            warList.Add("Portugal");
        }
        if (UKWar == true)
        {
            UKOpinion = 0f;
            warList.Add("UK");
        }
        if (CRWar == true)
        {
            CROpinion = 0f;
            warList.Add("CR");
        }
        if (MoroccoWar == true)
        {
            MoroccoOpinion = 0f;
            warList.Add("Morocco");
        }
        if (AlgeriaWar == true)
        {
            AlgeriaOpinion = 0f;
            warList.Add("Algeria");
        }
        if (TunisWar == true)
        {
            TunisOpinion = 0f;
            warList.Add("Tunis");
        }
        if (SardWar == true)
        {
            SardOpinion = 0f;
            warList.Add("Sardinia");
        }
        if (SicilyWar == true)
        {
            SicilyOpinion = 0f;
            warList.Add("Sicily");
        }
        if (NaplesWar == true)
        {
            NaplesOpinion = 0f;
            warList.Add("Naples");
        }
        if (LuccaWar == true)
        {
            LuccaOpinion = 0f;
            warList.Add("Lucca");
        }
        if (ItalyWar == true)
        {
            ItalyOpinion = 0f;
            warList.Add("Italy");
        }
        if (HelvetiaWar == true)
        {
            HelvetiaOpinion = 0f;
            warList.Add("Helvetia");
        }
        if (AustrianWar == true)
        {
            AustrianOpinion = 0f;
            warList.Add("Austria");
        }
        if (OttomanWar == true)
        {
            OttomanOpinion = 0f;
            warList.Add("Ottoman");
        }
        if (MonteWar == true)
        {
            MonteOpinion = 0f;
            warList.Add("Montenegro");
        }
        if (PrussiaWar == true)
        {
            PrussiaOpinion = 0f;
            warList.Add("Prussia");
        }
        if (WarsawWar == true)
        {
            WarsawOpinion = 0f;
            warList.Add("Warsaw");
        }
        if (RussianWar == true)
        {
            RussianOpinion = 0f;
            warList.Add("Russia");
        }
        if (SwedenWar == true)
        {
            SwedenOpinion = 0f;
            warList.Add("Sweden");
        }
        if (NorwayWar == true)
        {
            NorwayOpinion = 0f;
            warList.Add("Norway/Denmark");
        }

        foreach (GameObject allies in alliances)
        {
            if (allies.GetComponent<Country_AI>().CountryType == 0)
            {
                FranceWar = false;
                FranceOpinion = 70f;
                allianceList.Add("France");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 1)
            {
                SpainWar = false;
                SpainOpinion = 70f;
                allianceList.Add("Spain");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 2)
            {
                PortugalWar = false;
                PortugalOpinion = 70f;
                allianceList.Add("Portugal");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 3)
            {
                UKWar = false;
                UKOpinion = 70f;
                allianceList.Add("UK");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 4)
            {
                CRWar = false;
                CROpinion = 70f;
                allianceList.Add("CR");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 5)
            {
                MoroccoWar = false;
                MoroccoOpinion = 70f;
                allianceList.Add("Morocco");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 6)
            {
                AlgeriaWar = false;
                AlgeriaOpinion = 70f;
                allianceList.Add("Algeria");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 7)
            {
                TunisWar = false;
                TunisOpinion = 70f;
                allianceList.Add("Tunis");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 8)
            {
                SardWar = false;
                SardOpinion = 70f;
                allianceList.Add("Sardinia");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 9)
            {
                SicilyWar = false;
                SicilyOpinion = 70f;
                allianceList.Add("Sicily");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 10)
            {
                NaplesWar = false;
                NaplesOpinion = 70f;
                allianceList.Add("Naples");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 11)
            {
                LuccaWar = false;
                LuccaOpinion = 70f;
                allianceList.Add("Lucca");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 12)
            {
                ItalyWar = false;
                ItalyOpinion = 70f;
                allianceList.Add("Italy");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 13)
            {
                HelvetiaWar = false;
                HelvetiaOpinion = 70f;
                allianceList.Add("Helvetia");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 14)
            {
                AustrianWar = false;
                AustrianOpinion = 70f;
                allianceList.Add("Austria");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 15)
            {
                OttomanWar = false;
                OttomanOpinion = 70f;
                allianceList.Add("Ottoman");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 16)
            {
                MonteWar = false;
                MonteOpinion = 70f;
                allianceList.Add("Montenegro");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 17)
            {
                PrussiaWar = false;
                PrussiaOpinion = 70f;
                allianceList.Add("Prussia");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 18)
            {
                WarsawWar = false;
                WarsawOpinion = 70f;
                allianceList.Add("Warsaw");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 19)
            {
                RussianWar = false;
                RussianOpinion = 70f;
                allianceList.Add("Russia");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 20)
            {
                SwedenWar = false;
                SwedenOpinion = 70f;
                allianceList.Add("Sweden");
            }
            if (allies.GetComponent<Country_AI>().CountryType == 21)
            {
                NorwayWar = false;
                NorwayOpinion = 70f;
                allianceList.Add("Norway/Denmark");
            }
        }
    }

    public void Score()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.GetComponent<Country_AI>().CountryType == GameObject.Find("information").GetComponent<countries>().playerCountry)
            {
                foreach (GameObject land in targetAI.GetComponent<Country_AI>().allLand)
                {
                    score += 1f;
                    score += land.GetComponent<Control>().defensePower;
                }
            }
        }
        score = score * 1000f;
    }
}