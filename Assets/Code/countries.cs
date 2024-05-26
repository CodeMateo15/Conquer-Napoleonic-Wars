using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class countries : MonoBehaviour
{
    private int currentSceneIndex;
    public float transitionTime = 1f;
    private LevelLoader level;
    public GameObject LoadingCanvas;

    [HideInInspector] public GameObject PlayerObject;
    [HideInInspector] public float PlayerChoice;
    [HideInInspector] public bool warChoice;
    [HideInInspector] public bool allianceChoice;

    public GameObject GoldLogAmount;
    TextMeshProUGUI GoldLogAmount_text;
    public GameObject PopulationLogAmount;
    TextMeshProUGUI PopulationLogAmount_text;
    public GameObject MaterialLogAmount;
    TextMeshProUGUI MaterialLogAmount_text;

    private LoadingManager GetLoading;

    public GameObject war;
    public List<GameObject> warList;
    public GameObject warCountry1;
    public GameObject warCountry2;

    public GameObject messageBoardImage;
    public GameObject messageBoard;

    public float playerCountry;
    public float goldMultiplier;
    public float populationMultiplier;
    public float materialMultiplier;

    public float turnNumber;
    public float countryTurn;

    public bool simpleColor;
    public GameObject simpleColorText;
    public bool easy;
    public bool normal;
    public bool hard;
    public GameObject newsPrefab;
    public GameObject choicePrefab;
    public GameObject container;
    public GameObject Warcontainer;
    public GameObject WarCanvas;
    public GameObject Alliancecontainer;
    public GameObject AlliancCanvas;
    [HideInInspector] public float maxCalvalry;
    [HideInInspector] public float maxInfantry;
    [HideInInspector] public float maxArtillery;

    public float franceGold;
    [HideInInspector] public float franceGoldWorth;
    public float spainGold;
    [HideInInspector] public float spainGoldWorth;
    public float portugalGold;
    [HideInInspector] public float portugalGoldWorth;
    public float UKGold;
    [HideInInspector] public float UKGoldWorth;
    public float CRGold;
    [HideInInspector] public float CRGoldWorth;
    public float moroccoGold;
    [HideInInspector] public float moroccoGoldWorth;
    public float algeriaGold;
    [HideInInspector] public float algeriaGoldWorth;
    public float tunisGold;
    [HideInInspector] public float tunisGoldWorth;
    public float sardGold;
    [HideInInspector] public float sardGoldWorth;
    public float sicilyGold;
    [HideInInspector] public float sicilyGoldWorth;
    public float naplesGold;
    [HideInInspector] public float naplesGoldWorth;
    public float luccaGold;
    [HideInInspector] public float luccaGoldWorth;
    public float italyGold;
    [HideInInspector] public float italyGoldWorth;
    public float helvetiaGold;
    [HideInInspector] public float helvetiaGoldWorth;
    public float austrianGold;
    [HideInInspector] public float austrianGoldWorth;
    public float ottomanGold;
    [HideInInspector] public float ottomanGoldWorth;
    public float monteGold;
    [HideInInspector] public float monteGoldWorth;
    public float prussiaGold;
    [HideInInspector] public float prussiaGoldWorth;
    public float warsawGold;
    [HideInInspector] public float warsawGoldWorth;
    public float russianGold;
    [HideInInspector] public float russianGoldWorth;
    public float swedenGold;
    [HideInInspector] public float swedenGoldWorth;
    public float norwayGold;
    [HideInInspector] public float norwayGoldWorth;

    public float francePopulation;
    [HideInInspector] public float francePopulationWorth;
    public float spainPopulation;
    [HideInInspector] public float spainPopulationWorth;
    public float portugalPopulation;
    [HideInInspector] public float portugalPopulationWorth;
    public float UKPopulation;
    [HideInInspector] public float UKPopulationWorth;
    public float CRPopulation;
    [HideInInspector] public float CRPopulationWorth;
    public float moroccoPopulation;
    [HideInInspector] public float moroccoPopulationWorth;
    public float algeriaPopulation;
    [HideInInspector] public float algeriaPopulationWorth;
    public float tunisPopulation;
    [HideInInspector] public float tunisPopulationWorth;
    public float sardPopulation;
    [HideInInspector] public float sardPopulationWorth;
    public float sicilyPopulation;
    [HideInInspector] public float sicilyPopulationWorth;
    public float naplesPopulation;
    [HideInInspector] public float naplesPopulationWorth;
    public float luccaPopulation;
    [HideInInspector] public float luccaPopulationWorth;
    public float italyPopulation;
    [HideInInspector] public float italyPopulationWorth;
    public float helvetiaPopulation;
    [HideInInspector] public float helvetiaPopulationWorth;
    public float austrianPopulation;
    [HideInInspector] public float austrianPopulationWorth;
    public float ottomanPopulation;
    [HideInInspector] public float ottomanPopulationWorth;
    public float montePopulation;
    [HideInInspector] public float montePopulationWorth;
    public float prussiaPopulation;
    [HideInInspector] public float prussiaPopulationWorth;
    public float warsawPopulation;
    [HideInInspector] public float warsawPopulationWorth;
    public float russianPopulation;
    [HideInInspector] public float russianPopulationWorth;
    public float swedenPopulation;
    [HideInInspector] public float swedenPopulationWorth;
    public float norwayPopulation;
    [HideInInspector] public float norwayPopulationWorth;

    public float franceMaterial;
    [HideInInspector] public float franceMaterialWorth;
    public float spainMaterial;
    [HideInInspector] public float spainMaterialWorth;
    public float portugalMaterial;
    [HideInInspector] public float portugalMaterialWorth;
    public float UKMaterial;
    [HideInInspector] public float UKMaterialWorth;
    public float CRMaterial;
    [HideInInspector] public float CRMaterialWorth;
    public float moroccoMaterial;
    [HideInInspector] public float moroccoMaterialWorth;
    public float algeriaMaterial;
    [HideInInspector] public float algeriaMaterialWorth;
    public float tunisMaterial;
    [HideInInspector] public float tunisMaterialWorth;
    public float sardMaterial;
    [HideInInspector] public float sardMaterialWorth;
    public float sicilyMaterial;
    [HideInInspector] public float sicilyMaterialWorth;
    public float naplesMaterial;
    [HideInInspector] public float naplesMaterialWorth;
    public float luccaMaterial;
    [HideInInspector] public float luccaMaterialWorth;
    public float italyMaterial;
    [HideInInspector] public float italyMaterialWorth;
    public float helvetiaMaterial;
    [HideInInspector] public float helvetiaMaterialWorth;
    public float austrianMaterial;
    [HideInInspector] public float austrianMaterialWorth;
    public float ottomanMaterial;
    [HideInInspector] public float ottomanMaterialWorth;
    public float monteMaterial;
    [HideInInspector] public float monteMaterialWorth;
    public float prussiaMaterial;
    [HideInInspector] public float prussiaMaterialWorth;
    public float warsawMaterial;
    [HideInInspector] public float warsawMaterialWorth;
    public float russianMaterial;
    [HideInInspector] public float russianMaterialWorth;
    public float swedenMaterial;
    [HideInInspector] public float swedenMaterialWorth;
    public float norwayMaterial;
    [HideInInspector] public float norwayMaterialWorth;

    public bool testing;

    void Start()
    {
        level = LoadingCanvas.GetComponent<LevelLoader>();
        if (testing == false) //use true if testing
        {
            GetLoading = GameObject.Find("Loading Manager").GetComponent<LoadingManager>();
            GetLoading.LoadAIData();
        }
        Destroy(GameObject.Find("Loading Manager"));

        playerCountry = PlayerPrefs.GetFloat("Player");

        easy = (PlayerPrefs.GetInt("easy") != 0);
        normal = (PlayerPrefs.GetInt("normal") != 0);
        hard = (PlayerPrefs.GetInt("hard") != 0);
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                PlayerObject = targetAI;
            }
        }

        countryTurn = playerCountry;

        GoldLogAmount_text = GoldLogAmount.GetComponent<TextMeshProUGUI>();
        PopulationLogAmount_text = PopulationLogAmount.GetComponent<TextMeshProUGUI>();
        MaterialLogAmount_text = MaterialLogAmount.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (playerCountry == 0f)
        {
            GoldLogAmount_text.text = franceGold.ToString();
            PopulationLogAmount_text.text = francePopulation.ToString();
            MaterialLogAmount_text.text = franceMaterial.ToString();
        }
        if (playerCountry == 1f)
        {
            GoldLogAmount_text.text = spainGold.ToString();
            PopulationLogAmount_text.text = spainPopulation.ToString();
            MaterialLogAmount_text.text = spainMaterial.ToString();
        }
        if (playerCountry == 2f)
        {
            GoldLogAmount_text.text = portugalGold.ToString();
            PopulationLogAmount_text.text = portugalPopulation.ToString();
            MaterialLogAmount_text.text = portugalMaterial.ToString();
        }
        if (playerCountry == 3f)
        {
            GoldLogAmount_text.text = UKGold.ToString();
            PopulationLogAmount_text.text = UKPopulation.ToString();
            MaterialLogAmount_text.text = UKMaterial.ToString();
        }
        if (playerCountry == 4f)
        {
            GoldLogAmount_text.text = CRGold.ToString();
            PopulationLogAmount_text.text = CRPopulation.ToString();
            MaterialLogAmount_text.text = CRMaterial.ToString();
        }
        if (playerCountry == 5f)
        {
            GoldLogAmount_text.text = moroccoGold.ToString();
            PopulationLogAmount_text.text = moroccoPopulation.ToString();
            MaterialLogAmount_text.text = moroccoMaterial.ToString();
        }
        if (playerCountry == 6f)
        {
            GoldLogAmount_text.text = algeriaGold.ToString();
            PopulationLogAmount_text.text = algeriaPopulation.ToString();
            MaterialLogAmount_text.text = algeriaMaterial.ToString();
        }
        if (playerCountry == 7f)
        {
            GoldLogAmount_text.text = tunisGold.ToString();
            PopulationLogAmount_text.text = tunisPopulation.ToString();
            MaterialLogAmount_text.text = tunisMaterial.ToString();
        }
        if (playerCountry == 8f)
        {
            GoldLogAmount_text.text = sardGold.ToString();
            PopulationLogAmount_text.text = sardPopulation.ToString();
            MaterialLogAmount_text.text = sardMaterial.ToString();
        }
        if (playerCountry == 9f)
        {
            GoldLogAmount_text.text = sicilyGold.ToString();
            PopulationLogAmount_text.text = sicilyPopulation.ToString();
            MaterialLogAmount_text.text = sicilyMaterial.ToString();
        }
        if (playerCountry == 10f)
        {
            GoldLogAmount_text.text = naplesGold.ToString();
            PopulationLogAmount_text.text = naplesPopulation.ToString();
            MaterialLogAmount_text.text = naplesMaterial.ToString();
        }
        if (playerCountry == 11f)
        {
            GoldLogAmount_text.text = luccaGold.ToString();
            PopulationLogAmount_text.text = luccaPopulation.ToString();
            MaterialLogAmount_text.text = luccaMaterial.ToString();
        }
        if (playerCountry == 12f)
        {
            GoldLogAmount_text.text = italyGold.ToString();
            PopulationLogAmount_text.text = italyPopulation.ToString();
            MaterialLogAmount_text.text = italyMaterial.ToString();
        }
        if (playerCountry == 13f)
        {
            GoldLogAmount_text.text = helvetiaGold.ToString();
            PopulationLogAmount_text.text = helvetiaPopulation.ToString();
            MaterialLogAmount_text.text = helvetiaMaterial.ToString();
        }
        if (playerCountry == 14f)
        {
            GoldLogAmount_text.text = austrianGold.ToString();
            PopulationLogAmount_text.text = austrianPopulation.ToString();
            MaterialLogAmount_text.text = austrianMaterial.ToString();
        }
        if (playerCountry == 15f)
        {
            GoldLogAmount_text.text = ottomanGold.ToString();
            PopulationLogAmount_text.text = ottomanPopulation.ToString();
            MaterialLogAmount_text.text = ottomanMaterial.ToString();
        }
        if (playerCountry == 16f)
        {
            GoldLogAmount_text.text = monteGold.ToString();
            PopulationLogAmount_text.text = montePopulation.ToString();
            MaterialLogAmount_text.text = monteMaterial.ToString();
        }
        if (playerCountry == 17f)
        {
            GoldLogAmount_text.text = prussiaGold.ToString();
            PopulationLogAmount_text.text = prussiaPopulation.ToString();
            MaterialLogAmount_text.text = prussiaMaterial.ToString();
        }
        if (playerCountry == 18f)
        {
            GoldLogAmount_text.text = warsawGold.ToString();
            PopulationLogAmount_text.text = warsawPopulation.ToString();
            MaterialLogAmount_text.text = warsawMaterial.ToString();
        }
        if (playerCountry == 19f)
        {
            GoldLogAmount_text.text = russianGold.ToString();
            PopulationLogAmount_text.text = russianPopulation.ToString();
            MaterialLogAmount_text.text = russianMaterial.ToString();
        }
        if (playerCountry == 20f)
        {
            GoldLogAmount_text.text = swedenGold.ToString();
            PopulationLogAmount_text.text = swedenPopulation.ToString();
            MaterialLogAmount_text.text = swedenMaterial.ToString();
        }
        if (playerCountry == 21f)
        {
            GoldLogAmount_text.text = norwayGold.ToString();
            PopulationLogAmount_text.text = norwayPopulation.ToString();
            MaterialLogAmount_text.text = norwayMaterial.ToString();
        }
        if (countryTurn >= 22f) //change countryTurn to highest number of country
        {
            foreach (GameObject countries in GameObject.FindGameObjectsWithTag("country"))
            {
                countries.GetComponent<Control>().espionage = Random.Range(0, 100);
            }
            turnNumber += 1f;
            countryTurn = 0f;
        }
    }

    public void NewTurn()
    {
        if (GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1 != GameObject.Find("information"))
        {
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<ColorC>().attackFlash = false;
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<ColorC>().wait = false;
        }

        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (countryTurn == playerCountry)
                {
                    targetAI.GetComponent<Country_AI>().PlayerDiplomacy();
                }
                targetAI.GetComponent<Country_AI>().FindGold();
            }
        }

        GoldMath();
        PopulationMath();
        MaterialMath();
        if (GameObject.Find("Main Camera").GetComponent<ArmyUI>().touched == false)
        {
            countryTurn += 1f;
        }
    }

    public void SpawnWar()
    {
        Instantiate(war, new Vector2(0, 0), Quaternion.identity, transform);
        warList.Clear();
        foreach (GameObject warObject in GameObject.FindGameObjectsWithTag("war"))
        {
            warList.Add(warObject);
        }
    }

    public void SaveAIData()
    {
        Debug.Log("Save clicked");
        StartCoroutine(OneLevel(SceneManager.GetActiveScene().buildIndex - 2));
        SaveConvertor.AISaver(this);
    }

    IEnumerator OneLevel(int levelIndex)
    {
        GameObject.Find("information").GetComponent<Menu_SS>().canvas.sortingOrder = 2;
        LoadingCanvas.SetActive(true);
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

    void GoldMath()
    {
        if (easy == true)
        {
            goldMultiplier = Random.Range(1f, 1.3f);
        }
        if (normal == true)
        {
            goldMultiplier = 1.3f;
        }
        if (hard == true)
        {
            goldMultiplier = Random.Range(1.3f, 1.6f);
        }

        if (playerCountry == 0f)
        {
            franceGold += franceGoldWorth * 1;
        }
        else
        {
            franceGold += franceGoldWorth * goldMultiplier;
            franceGold = Mathf.Round(franceGold);
        }
        if (playerCountry == 1f)
        {
            spainGold += spainGoldWorth * 1;
        }
        else
        {
            spainGold += spainGoldWorth * goldMultiplier;
            spainGold = Mathf.Round(spainGold);
        }
        if (playerCountry == 2f)
        {
            portugalGold += portugalGoldWorth * 1;
        }
        else
        {
            portugalGold += portugalGoldWorth * goldMultiplier;
            portugalGold = Mathf.Round(portugalGold);
        }
        if (playerCountry == 3f)
        {
            UKGold += UKGoldWorth * 1;
        }
        else
        {
            UKGold += UKGoldWorth * goldMultiplier;
            UKGold = Mathf.Round(UKGold);
        }
        if (playerCountry == 4f)
        {
            CRGold += CRGoldWorth * 1;
        }
        else
        {
            CRGold += CRGoldWorth * goldMultiplier;
            CRGold = Mathf.Round(CRGold);
        }
        if (playerCountry == 5f)
        {
            moroccoGold += moroccoGoldWorth * 1;
        }
        else
        {
            moroccoGold += moroccoGoldWorth * goldMultiplier;
            moroccoGold = Mathf.Round(moroccoGold);
        }
        if (playerCountry == 6f)
        {
            algeriaGold += algeriaGoldWorth * 1;
        }
        else
        {
            algeriaGold += algeriaGoldWorth * goldMultiplier;
            algeriaGold = Mathf.Round(algeriaGold);
        }
        if (playerCountry == 7f)
        {
            tunisGold += tunisGoldWorth * 1;
        }
        else
        {
            tunisGold += tunisGoldWorth * goldMultiplier;
            tunisGold = Mathf.Round(tunisGold);
        }
        if (playerCountry == 8f)
        {
            sardGold += sardGoldWorth * 1;
        }
        else
        {
            sardGold += sardGoldWorth * goldMultiplier;
            sardGold = Mathf.Round(sardGold);
        }
        if (playerCountry == 9f)
        {
            sicilyGold += sicilyGoldWorth * 1;
        }
        else
        {
            sicilyGold += sicilyGoldWorth * goldMultiplier;
            sicilyGold = Mathf.Round(sicilyGold);
        }
        if (playerCountry == 10f)
        {
            naplesGold += naplesGoldWorth * 1;
        }
        else
        {
            naplesGold += naplesGoldWorth * goldMultiplier;
            naplesGold = Mathf.Round(naplesGold);
        }
        if (playerCountry == 11f)
        {
            luccaGold += luccaGoldWorth * 1;
        }
        else
        {
            luccaGold += luccaGoldWorth * goldMultiplier;
            luccaGold = Mathf.Round(luccaGold);
        }
        if (playerCountry == 12f)
        {
            italyGold += italyGoldWorth * 1;
        }
        else
        {
            italyGold += italyGoldWorth * goldMultiplier;
            italyGold = Mathf.Round(italyGold);
        }
        if (playerCountry == 13f)
        {
            helvetiaGold += helvetiaGoldWorth * 1;
        }
        else
        {
            helvetiaGold += helvetiaGoldWorth * goldMultiplier;
            helvetiaGold = Mathf.Round(helvetiaGold);
        }
        if (playerCountry == 14f)
        {
            austrianGold += austrianGoldWorth * 1;
        }
        else
        {
            austrianGold += austrianGoldWorth * goldMultiplier;
            austrianGold = Mathf.Round(austrianGold);
        }
        if (playerCountry == 15f)
        {
            ottomanGold += ottomanGoldWorth * 1;
        }
        else
        {
            ottomanGold += ottomanGoldWorth * goldMultiplier;
            ottomanGold = Mathf.Round(ottomanGold);
        }
        if (playerCountry == 16f)
        {
            monteGold += monteGoldWorth * 1;
        }
        else
        {
            monteGold += monteGoldWorth * goldMultiplier;
            monteGold = Mathf.Round(monteGold);
        }
        if (playerCountry == 17f)
        {
            prussiaGold += prussiaGoldWorth * 1;
        }
        else
        {
            prussiaGold += prussiaGoldWorth * goldMultiplier;
            prussiaGold = Mathf.Round(prussiaGold);
        }
        if (playerCountry == 18f)
        {
            warsawGold += warsawGoldWorth * 1;
        }
        else
        {
            warsawGold += warsawGoldWorth * goldMultiplier;
            warsawGold = Mathf.Round(warsawGold);
        }
        if (playerCountry == 19f)
        {
            russianGold += russianGoldWorth * 1;
        }
        else
        {
            russianGold += russianGoldWorth * goldMultiplier;
            russianGold = Mathf.Round(russianGold);
        }
        if (playerCountry == 20f)
        {
            swedenGold += swedenGoldWorth * 1;
        }
        else
        {
            swedenGold += swedenGoldWorth * goldMultiplier;
            swedenGold = Mathf.Round(swedenGold);
        }
        if (playerCountry == 21f)
        {
            norwayGold += norwayGoldWorth * 1;
        }
        else
        {
            norwayGold += norwayGoldWorth * goldMultiplier;
            norwayGold = Mathf.Round(norwayGold);
        }
    }

    void PopulationMath()
    {
        if (easy == true)
        {
            populationMultiplier = Random.Range(1f, 1.3f);
        }
        if (normal == true)
        {
            populationMultiplier = 1.3f;
        }
        if (hard == true)
        {
            populationMultiplier = Random.Range(1.3f, 1.6f);
        }

        if (playerCountry == 0f)
        {
            francePopulation += francePopulationWorth * 1;
        }
        else
        {
            francePopulation += francePopulationWorth * populationMultiplier;
            francePopulation = Mathf.Round(francePopulation);
        }
        if (playerCountry == 1f)
        {
            spainPopulation += spainPopulationWorth * 1;
        }
        else
        {
            spainPopulation += spainPopulationWorth * populationMultiplier;
            spainPopulation = Mathf.Round(spainPopulation);
        }
        if (playerCountry == 2f)
        {
            portugalPopulation += portugalPopulationWorth * 1;
        }
        else
        {
            portugalPopulation += portugalPopulationWorth * populationMultiplier;
            portugalPopulation = Mathf.Round(portugalPopulation);
        }
        if (playerCountry == 3f)
        {
            UKPopulation += UKPopulationWorth * 1;
        }
        else
        {
            UKPopulation += UKPopulationWorth * populationMultiplier;
            UKPopulation = Mathf.Round(UKPopulation);
        }
        if (playerCountry == 4f)
        {
            CRPopulation += CRPopulationWorth * 1;
        }
        else
        {
            CRPopulation += CRPopulationWorth * populationMultiplier;
            CRPopulation = Mathf.Round(CRPopulation);
        }
        if (playerCountry == 5f)
        {
            moroccoPopulation += moroccoPopulationWorth * 1;
        }
        else
        {
            moroccoPopulation += moroccoPopulationWorth * populationMultiplier;
            moroccoPopulation = Mathf.Round(moroccoPopulation);
        }
        if (playerCountry == 6f)
        {
            algeriaPopulation += algeriaPopulationWorth * 1;
        }
        else
        {
            algeriaPopulation += algeriaPopulationWorth * populationMultiplier;
            algeriaPopulation = Mathf.Round(algeriaPopulation);
        }
        if (playerCountry == 7f)
        {
            tunisPopulation += tunisPopulationWorth * 1;
        }
        else
        {
            tunisPopulation += tunisPopulationWorth * populationMultiplier;
            tunisPopulation = Mathf.Round(tunisPopulation);
        }
        if (playerCountry == 8f)
        {
            sardPopulation += sardPopulationWorth * 1;
        }
        else
        {
            sardPopulation += sardPopulationWorth * populationMultiplier;
            sardPopulation = Mathf.Round(sardPopulation);
        }
        if (playerCountry == 9f)
        {
            sicilyPopulation += sicilyPopulationWorth * 1;
        }
        else
        {
            sicilyPopulation += sicilyPopulationWorth * populationMultiplier;
            sicilyPopulation = Mathf.Round(sicilyPopulation);
        }
        if (playerCountry == 10f)
        {
            naplesPopulation += naplesPopulationWorth * 1;
        }
        else
        {
            naplesPopulation += naplesPopulationWorth * populationMultiplier;
            naplesPopulation = Mathf.Round(naplesPopulation);
        }
        if (playerCountry == 11f)
        {
            luccaPopulation += luccaPopulationWorth * 1;
        }
        else
        {
            luccaPopulation += luccaPopulationWorth * populationMultiplier;
            luccaPopulation = Mathf.Round(luccaPopulation);
        }
        if (playerCountry == 12f)
        {
            italyPopulation += italyPopulationWorth * 1;
        }
        else
        {
            italyPopulation += italyPopulationWorth * populationMultiplier;
            italyPopulation = Mathf.Round(italyPopulation);
        }
        if (playerCountry == 13f)
        {
            helvetiaPopulation += helvetiaPopulationWorth * 1;
        }
        else
        {
            helvetiaPopulation += helvetiaPopulationWorth * populationMultiplier;
            helvetiaPopulation = Mathf.Round(helvetiaPopulation);
        }
        if (playerCountry == 14f)
        {
            austrianPopulation += austrianPopulationWorth * 1;
        }
        else
        {
            austrianPopulation += austrianPopulationWorth * populationMultiplier;
            austrianPopulation = Mathf.Round(austrianPopulation);
        }
        if (playerCountry == 15f)
        {
            ottomanPopulation += ottomanPopulationWorth * 1;
        }
        else
        {
            ottomanPopulation += ottomanPopulationWorth * populationMultiplier;
            ottomanPopulation = Mathf.Round(ottomanPopulation);
        }
        if (playerCountry == 16f)
        {
            montePopulation += montePopulationWorth * 1;
        }
        else
        {
            montePopulation += montePopulationWorth * populationMultiplier;
            montePopulation = Mathf.Round(montePopulation);
        }
        if (playerCountry == 17f)
        {
            prussiaPopulation += prussiaPopulationWorth * 1;
        }
        else
        {
            prussiaPopulation += prussiaPopulationWorth * populationMultiplier;
            prussiaPopulation = Mathf.Round(prussiaPopulation);
        }
        if (playerCountry == 18f)
        {
            warsawPopulation += warsawPopulationWorth * 1;
        }
        else
        {
            warsawPopulation += warsawPopulationWorth * populationMultiplier;
            warsawPopulation = Mathf.Round(warsawPopulation);
        }
        if (playerCountry == 19f)
        {
            russianPopulation += russianPopulationWorth * 1;
        }
        else
        {
            russianPopulation += russianPopulationWorth * populationMultiplier;
            russianPopulation = Mathf.Round(russianPopulation);
        }
        if (playerCountry == 20f)
        {
            swedenPopulation += swedenPopulationWorth * 1;
        }
        else
        {
            swedenPopulation += swedenPopulationWorth * populationMultiplier;
            swedenPopulation = Mathf.Round(swedenPopulation);
        }
        if (playerCountry == 21f)
        {
            norwayPopulation += norwayPopulationWorth * 1;
        }
        else
        {
            norwayPopulation += norwayPopulationWorth * populationMultiplier;
            norwayPopulation = Mathf.Round(norwayPopulation);
        }
    }

    void MaterialMath()
    {
        if (easy == true)
        {
            materialMultiplier = Random.Range(1f, 1.3f);
        }
        if (normal == true)
        {
            materialMultiplier = 1.3f;
        }
        if (hard == true)
        {
            materialMultiplier = Random.Range(1.3f, 1.6f);
        }

        if (playerCountry == 0f)
        {
            franceMaterial += franceMaterialWorth * 1;
        }
        else
        {
            franceMaterial += franceMaterialWorth * materialMultiplier;
            franceMaterial = Mathf.Round(franceMaterial);
        }
        if (playerCountry == 1f)
        {
            spainMaterial += spainMaterialWorth * 1;
        }
        else
        {
            spainMaterial += spainMaterialWorth * materialMultiplier;
            spainMaterial = Mathf.Round(spainMaterial);
        }
        if (playerCountry == 2f)
        {
            portugalMaterial += portugalMaterialWorth * 1;
        }
        else
        {
            portugalMaterial += portugalMaterialWorth * materialMultiplier;
            portugalMaterial = Mathf.Round(portugalMaterial);
        }
        if (playerCountry == 3f)
        {
            UKMaterial += UKMaterialWorth * 1;
        }
        else
        {
            UKMaterial += UKMaterialWorth * materialMultiplier;
            UKMaterial = Mathf.Round(UKMaterial);
        }
        if (playerCountry == 4f)
        {
            CRMaterial += CRMaterialWorth * 1;
        }
        else
        {
            CRMaterial += CRMaterialWorth * materialMultiplier;
            CRMaterial = Mathf.Round(CRMaterial);
        }
        if (playerCountry == 5f)
        {
            moroccoMaterial += moroccoMaterialWorth * 1;
        }
        else
        {
            moroccoMaterial += moroccoMaterialWorth * materialMultiplier;
            moroccoMaterial = Mathf.Round(moroccoMaterial);
        }
        if (playerCountry == 6f)
        {
            algeriaMaterial += algeriaMaterialWorth * 1;
        }
        else
        {
            algeriaMaterial += algeriaMaterialWorth * materialMultiplier;
            algeriaMaterial = Mathf.Round(algeriaMaterial);
        }
        if (playerCountry == 7f)
        {
            tunisMaterial += tunisMaterialWorth * 1;
        }
        else
        {
            tunisMaterial += tunisMaterialWorth * materialMultiplier;
            tunisMaterial = Mathf.Round(tunisMaterial);
        }
        if (playerCountry == 8f)
        {
            sardMaterial += sardMaterialWorth * 1;
        }
        else
        {
            sardMaterial += sardMaterialWorth * materialMultiplier;
            sardMaterial = Mathf.Round(sardMaterial);
        }
        if (playerCountry == 9f)
        {
            sicilyMaterial += sicilyMaterialWorth * 1;
        }
        else
        {
            sicilyMaterial += sicilyMaterialWorth * materialMultiplier;
            sicilyMaterial = Mathf.Round(sicilyMaterial);
        }
        if (playerCountry == 10f)
        {
            naplesMaterial += naplesMaterialWorth * 1;
        }
        else
        {
            naplesMaterial += naplesMaterialWorth * materialMultiplier;
            naplesMaterial = Mathf.Round(naplesMaterial);
        }
        if (playerCountry == 11f)
        {
            luccaMaterial += luccaMaterialWorth * 1;
        }
        else
        {
            luccaMaterial += luccaMaterialWorth * materialMultiplier;
            luccaMaterial = Mathf.Round(luccaMaterial);
        }
        if (playerCountry == 12f)
        {
            italyMaterial += italyMaterialWorth * 1;
        }
        else
        {
            italyMaterial += italyMaterialWorth * materialMultiplier;
            italyMaterial = Mathf.Round(italyMaterial);
        }
        if (playerCountry == 13f)
        {
            helvetiaMaterial += helvetiaMaterialWorth * 1;
        }
        else
        {
            helvetiaMaterial += helvetiaMaterialWorth * materialMultiplier;
            helvetiaMaterial = Mathf.Round(helvetiaMaterial);
        }
        if (playerCountry == 14f)
        {
            austrianMaterial += austrianMaterialWorth * 1;
        }
        else
        {
            austrianMaterial += austrianMaterialWorth * materialMultiplier;
            austrianMaterial = Mathf.Round(austrianMaterial);
        }
        if (playerCountry == 15f)
        {
            ottomanMaterial += ottomanMaterialWorth * 1;
        }
        else
        {
            ottomanMaterial += ottomanMaterialWorth * materialMultiplier;
            ottomanMaterial = Mathf.Round(ottomanMaterial);
        }
        if (playerCountry == 16f)
        {
            monteMaterial += monteMaterialWorth * 1;
        }
        else
        {
            monteMaterial += monteMaterialWorth * materialMultiplier;
            monteMaterial = Mathf.Round(monteMaterial);
        }
        if (playerCountry == 17f)
        {
            prussiaMaterial += prussiaMaterialWorth * 1;
        }
        else
        {
            prussiaMaterial += prussiaMaterialWorth * materialMultiplier;
            prussiaMaterial = Mathf.Round(prussiaMaterial);
        }
        if (playerCountry == 18f)
        {
            warsawMaterial += warsawMaterialWorth * 1;
        }
        else
        {
            warsawMaterial += warsawMaterialWorth * materialMultiplier;
            warsawMaterial = Mathf.Round(warsawMaterial);
        }
        if (playerCountry == 19f)
        {
            russianMaterial += russianMaterialWorth * 1;
        }
        else
        {
            russianMaterial += russianMaterialWorth * materialMultiplier;
            russianMaterial = Mathf.Round(russianMaterial);
        }
        if (playerCountry == 20f)
        {
            swedenMaterial += swedenMaterialWorth * 1;
        }
        else
        {
            swedenMaterial += swedenMaterialWorth * materialMultiplier;
            swedenMaterial = Mathf.Round(swedenMaterial);
        }
        if (playerCountry == 21f)
        {
            norwayMaterial += norwayMaterialWorth * 1;
        }
        else
        {
            norwayMaterial += norwayMaterialWorth * materialMultiplier;
            norwayMaterial = Mathf.Round(norwayMaterial);
        }
    }

    public void PressWar()
    {
        allianceChoice = false;
        warChoice = true;
        GameObject.Find("Main Camera").GetComponent<ArmyUI>().choiceui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<ArmyUI>().countryui.SetActive(true);
        WarCanvas.SetActive(true);
        AlliancCanvas.SetActive(false);

        foreach (Transform child in Warcontainer.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (targetAI.gameObject.GetComponent<Country_AI>().FranceWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 0)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 0;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().SpainWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 1)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 1;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().PortugalWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 2)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 2;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().UKWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 3)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 3;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().CRWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 4)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 4;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().MoroccoWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 5)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 5;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().AlgeriaWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 6)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 6;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().TunisWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 7)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 7;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().SardWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 8)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 8;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().SicilyWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 9)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 9;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().NaplesWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 10)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 10;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().LuccaWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 11)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 11;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().ItalyWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 12)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 12;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().HelvetiaWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 13)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 13;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().AustrianWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 14)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 14;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().OttomanWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 15)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 15;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().MonteWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 16)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 16;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().PrussiaWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 17)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 17;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().WarsawWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 18)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 18;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().RussianWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 19)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 19;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().SwedenWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 20)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 20;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().NorwayWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 21)
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 21;
                    originalGameObject.transform.SetParent(Warcontainer.transform, false);
                }
            }
        }
    }

    public void PressAlliance()
    {
        allianceChoice = true;
        warChoice = false;
        GameObject.Find("Main Camera").GetComponent<ArmyUI>().choiceui.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<ArmyUI>().countryui.SetActive(true);
        WarCanvas.SetActive(false);
        AlliancCanvas.SetActive(true);

        foreach (Transform child in Alliancecontainer.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (targetAI.gameObject.GetComponent<Country_AI>().FranceWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 0 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("France AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 0;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().SpainWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 1 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Spain AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 1;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().PortugalWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 2 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Portugal AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 2;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().UKWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 3 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("UK AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 3;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().CRWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 4 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("CR AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 4;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().MoroccoWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 5 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Morocco AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 5;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().AlgeriaWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 6 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Algeria AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 6;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().TunisWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 7 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Tunis AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 7;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().SardWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 8 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Sardinia AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 8;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().SicilyWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 9 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Sicily AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 9;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().NaplesWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 10 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Naples AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 10;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().LuccaWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 11 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Lucca AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 11;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().ItalyWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 12 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Italy AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 12;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().HelvetiaWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 13 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Helvetia AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 13;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().AustrianWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 14 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Austria AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 14;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().OttomanWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 15 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Ottoman AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 15;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().MonteWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 16 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Montenegro AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 16;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().PrussiaWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 17 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Prussia AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 17;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().WarsawWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 18 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Warsaw AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 18;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().RussianWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 19 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Russia AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 19;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().SwedenWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 20 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Sweden AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 20;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
                if (targetAI.gameObject.GetComponent<Country_AI>().NorwayWar == false && targetAI.gameObject.GetComponent<Country_AI>().CountryType != 21 && !targetAI.gameObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Norway AI")))
                {
                    GameObject originalGameObject = Instantiate(choicePrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                    originalGameObject.GetComponent<Country_List>().choice = 21;
                    originalGameObject.transform.SetParent(Alliancecontainer.transform, false);
                }
            }
        }
    }

    public void PlayerWar()
    {
        //all below start war
        if (PlayerObject.GetComponent<Country_AI>().FranceWar == false && PlayerChoice == 0 && playerCountry != 0) //0
        {
            if (GameObject.Find("France AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("France AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("France AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and France");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and France";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().FranceWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("France AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("France AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and France");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and France";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);;
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().SpainWar == false && PlayerChoice == 1 && playerCountry != 1) //1
        {
            if (GameObject.Find("Spain AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Spain AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Spain AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Spain");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Spain";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().SpainWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Spain AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Spain AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Spain");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Spain";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().PortugalWar == false && PlayerChoice == 2 && playerCountry != 2) //2
        {
            if (GameObject.Find("Portugal AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Portugal AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Portugal AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Portugal");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Portugal";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().PortugalWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Portugal AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Portugal AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Portugal");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Portugal";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().UKWar == false && PlayerChoice == 3 && playerCountry != 3) //3
        {
            if (GameObject.Find("UK AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("UK AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("UK AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and UK");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and UK";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().UKWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Uk AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("UK AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("UK AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and UK");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and UK";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().CRWar == false && PlayerChoice == 4 && playerCountry != 4) //4
        {
            if (GameObject.Find("CR AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("CR AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("CR AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and CR");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and CR";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().CRWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("CR AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("CR AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and CR");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and CR";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().MoroccoWar == false && PlayerChoice == 5 && playerCountry != 5) //5
        {
            if (GameObject.Find("Morocco AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Morocco AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Morocco AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Morocco");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Morocco";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().MoroccoWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Morocco AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Morocco AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Morocco");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Morocco";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().AlgeriaWar == false && PlayerChoice == 6 && playerCountry != 6) //6
        {
            if (GameObject.Find("Algeria AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Algeria AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Algeria AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Algeria");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Algeria";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().AlgeriaWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Algeria AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Algeria AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Algeria");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Algeria";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().TunisWar == false && PlayerChoice == 7 && playerCountry != 7) //7
        {
            if (GameObject.Find("Tunis AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Tunis AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Tunis AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Tunis");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Tunis";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().TunisWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Tunis AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Tunis AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Tunis");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Tunis";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().SardWar == false && PlayerChoice == 8 && playerCountry != 8) //8
        {
            if (GameObject.Find("Sardinia AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Sardinia AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Sardinia AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Sardinia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Sardinia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().SardWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Sardinia AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Sardinia AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Sardinia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Sardinia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().SicilyWar == false && PlayerChoice == 9 && playerCountry != 9) //9
        {
            if (GameObject.Find("Sicily AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Sicily AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Sicily AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Sicily");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Sicily";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().SicilyWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Sicily AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Sicily AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Sicily");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Sicily";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().NaplesWar == false && PlayerChoice == 10 && playerCountry != 10) //10
        {
            if (GameObject.Find("Naples AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Naples AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Naples AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Naples");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Naples";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().NaplesWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Naples AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Naples AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Naples");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Naples";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().LuccaWar == false && PlayerChoice == 11 && playerCountry != 11) //11
        {
            if (GameObject.Find("Lucca AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Lucca AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Lucca AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Lucca");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Lucca";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().LuccaWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Lucca AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Lucca AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Lucca");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Lucca";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().ItalyWar == false && PlayerChoice == 12 && playerCountry != 12) //12
        {
            if (GameObject.Find("Italy AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Italy AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Italy AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Italy");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Italy";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().ItalyWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Italy AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Italy AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Italy");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Italy";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().HelvetiaWar == false && PlayerChoice == 13 && playerCountry != 13) //13
        {
            if (GameObject.Find("Helvetia AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Helvetia AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Helvetia AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Helvetia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Helvetia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().HelvetiaWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Helvetia AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Helvetia AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Helvetia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Helvetia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().AustrianWar == false && PlayerChoice == 14 && playerCountry != 14) //14
        {
            if (GameObject.Find("Austria AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Austria AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Austria AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Austria");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Austria";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().AustrianWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Austria AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Austria AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Austria");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Austria";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().OttomanWar == false && PlayerChoice == 15 && playerCountry != 15) //15
        {
            if (GameObject.Find("Ottoman AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Ottoman AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Ottoman AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Ottoman");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Ottoman";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().OttomanWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Ottoman AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Ottoman AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Ottoman");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Ottoman";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().MonteWar == false && PlayerChoice == 16 && playerCountry != 16) //16
        {
            if (GameObject.Find("Montenegro AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Montenegro AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Montenegro AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Montenegro");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Montenegro";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().MonteWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Montenegro AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Montenegro AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Montenegro");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Montenegro";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().PrussiaWar == false && PlayerChoice == 17 && playerCountry != 17) //17
        {
            if (GameObject.Find("Prussia AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Prussia AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Prussia AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Prussia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Prussia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().PrussiaWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Prussia AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Prussia AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Prussia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Prussia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().WarsawWar == false && PlayerChoice == 18 && playerCountry != 18) //18
        {
            if (GameObject.Find("Warsaw AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Warsaw AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Warsaw AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Warsaw");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Warsaw";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().WarsawWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Warsaw AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Warsaw AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Warsaw");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Warsaw";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().RussianWar == false && PlayerChoice == 19 && playerCountry != 19) //19
        {
            if (GameObject.Find("Russia AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Russia AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Russia AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Russia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Russia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().RussianWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Russia AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Russia AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Russia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Russia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().SwedenWar == false && PlayerChoice == 20 && playerCountry != 20) //20
        {
            if (GameObject.Find("Sweden AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Sweden AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Sweden AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Sweden");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Sweden";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().SwedenWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 7)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().TunisWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Sweden AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Sweden AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Sweden");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Sweden";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().NorwayWar == false && PlayerChoice == 21 && playerCountry != 21) //21
        {
            if (GameObject.Find("Norway AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject))
            {
                GameObject.Find("Norway AI").GetComponent<Country_AI>().alliances.Remove(PlayerObject);
                PlayerObject.GetComponent<Country_AI>().alliances.Remove(GameObject.Find("Norway AI"));
                Debug.Log("Alliance broken between " + PlayerObject.name + " and Norway/Denmark");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance Broken between " + PlayerObject.name + " and Norway/Denmark";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
            else
            {
                PlayerObject.GetComponent<Country_AI>().NorwayWar = true;
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 1)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().SpainWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 2)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().PortugalWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 3)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().UKWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 0)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().FranceWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 5)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().MoroccoWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 6)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().AlgeriaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 4)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().CRWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 8)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().SardWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 9)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().SicilyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 10)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().NaplesWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 11)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().LuccaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 12)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().ItalyWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 13)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().HelvetiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 14)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().AustrianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 15)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().OttomanWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 16)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().MonteWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 17)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().PrussiaWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 18)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().WarsawWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 19)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().RussianWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 20)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().SwedenWar = true;
                }
                if (PlayerObject.GetComponent<Country_AI>().CountryType == 21)
                {
                    GameObject.Find("Norway AI").GetComponent<Country_AI>().NorwayWar = true;
                }
                warCountry1 = PlayerObject;
                warCountry2 = GameObject.Find("Norway AI");
                SpawnWar();
                Debug.Log("War started between " + PlayerObject.name + " and Norway/Denmark");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War started between " + PlayerObject.name + " and Norway/Denmark";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
    }

    public void PlayerAlliance()
    {
        #pragma warning disable 0642
        //all below start alliance
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("France AI")))
        {
            //ignore
        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().FranceWar == false && !GameObject.Find("France AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 0 && playerCountry != 0) //0
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("France AI"));
                GameObject.Find("France AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and France");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and France";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Spain AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().SpainWar == false && !GameObject.Find("Spain AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 1 && playerCountry != 1) //1
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Spain AI"));
                GameObject.Find("Spain AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Spain");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Spain";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Portugal AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().PortugalWar == false && !GameObject.Find("Portugal AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 2 && playerCountry != 2) //2
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Portugal AI"));
                GameObject.Find("Portugal AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Portugal");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Portugal";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("UK AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().UKWar == false && !GameObject.Find("UK AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 3 && playerCountry != 3) //3
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("UK AI"));
                GameObject.Find("UK AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and UK");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and UK";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("CR AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().CRWar == false && !GameObject.Find("CR AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 4 && playerCountry != 4) //4
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("CR AI"));
                GameObject.Find("CR AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and CR");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and CR";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Morocco AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().MoroccoWar == false && !GameObject.Find("Morocco AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 5 && playerCountry != 5) //5
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Morocco AI"));
                GameObject.Find("Morocco AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Morocco");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Morocco";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Algeria AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().AlgeriaWar == false && !GameObject.Find("Algeria AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 6 && playerCountry != 6) //6
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Algeria AI"));
                GameObject.Find("Algeria AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Algeria");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Algeria";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Tunis AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().TunisWar == false && !GameObject.Find("Tunis AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 7 && playerCountry != 7) //7
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Tunis AI"));
                GameObject.Find("Tunis AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Tunis");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Tunis";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Sardinia AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().SardWar == false && !GameObject.Find("Sardinia AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 8 && playerCountry != 8) //8
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Sardinia AI"));
                GameObject.Find("Sardinia AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Sardinia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Sardinia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Sicily AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().SicilyWar == false && !GameObject.Find("Sicily AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 9 && playerCountry != 9) //9
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Sicily AI"));
                GameObject.Find("Sicily AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Sicily");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Sicily";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Naples AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().NaplesWar == false && !GameObject.Find("Naples AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 10 && playerCountry != 10) //10
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Naples AI"));
                GameObject.Find("Naples AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Naples");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Naples";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Lucca AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().LuccaWar == false && !GameObject.Find("Lucca AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 11 && playerCountry != 11) //11
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Lucca AI"));
                GameObject.Find("Lucca AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Lucca");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Lucca";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Italy AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().ItalyWar == false && !GameObject.Find("Italy AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 12 && playerCountry != 12) //12
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Italy AI"));
                GameObject.Find("Italy AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Italy");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Italy";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Helvetia AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().HelvetiaWar == false && !GameObject.Find("Helvetia AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 13 && playerCountry != 13) //13
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Helvetia AI"));
                GameObject.Find("Helvetia AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Helvetia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Helvetia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Austria AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().AustrianWar == false && !GameObject.Find("Austria AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 14 && playerCountry != 14) //14
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Austria AI"));
                GameObject.Find("Austria AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Austria");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Austria";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Ottoman AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().OttomanWar == false && !GameObject.Find("Ottoman AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 15 && playerCountry != 15) //15
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Ottoman AI"));
                GameObject.Find("Ottoman AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Ottoman");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Ottoman";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Montenegro AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().MonteWar == false && !GameObject.Find("Montenegro AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 16 && playerCountry != 16) //16
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Montenegro AI"));
                GameObject.Find("Montenegro AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Montenegro");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Montenegro";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Prussia AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().PrussiaWar == false && !GameObject.Find("Prussia AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 17 && playerCountry != 17) //17
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Prussia AI"));
                GameObject.Find("Prussia AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Prussia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Prussia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Warsaw AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().WarsawWar == false && !GameObject.Find("Warsaw AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 18 && playerCountry != 18) //18
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Warsaw AI"));
                GameObject.Find("Warsaw AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Warsaw");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Warsaw";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Russia AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().RussianWar == false && !GameObject.Find("Russia AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 19 && playerCountry != 19) //19
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Russia AI"));
                GameObject.Find("Russia AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Russia");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Russia";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Sweden AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().SwedenWar == false && !GameObject.Find("Sweden AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 20 && playerCountry != 20) //20
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Sweden AI"));
                GameObject.Find("Sweden AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Sweden");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Sweden";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
        if (PlayerObject.GetComponent<Country_AI>().alliances.Contains(GameObject.Find("Norway AI")))
        {

        }
        else
        {
            if (PlayerObject.GetComponent<Country_AI>().NorwayWar == false && !GameObject.Find("Norway AI").GetComponent<Country_AI>().alliances.Contains(PlayerObject) && PlayerChoice == 21 && playerCountry != 21) //21
            {
                PlayerObject.GetComponent<Country_AI>().alliances.Add(GameObject.Find("Norway AI"));
                GameObject.Find("Norway AI").GetComponent<Country_AI>().alliances.Add(PlayerObject);
                Debug.Log("Alliance started between " + PlayerObject.name + " and Norway/Denmark");
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "Alliance started between " + PlayerObject.name + " and Norway/Denmark";
                GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
                GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
                originalGameObject.transform.SetParent(container.transform, false);
            }
        }
    #pragma warning restore 0642
    }

    public void BuyCavalry()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (targetAI.GetComponent<Country_AI>().AIGold > 21 && targetAI.GetComponent<Country_AI>().AIPopulation > 41 && targetAI.GetComponent<Country_AI>().AIMaterial > 31)
                {
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().cavalry += 1f;
                    if (playerCountry == 0)
                    {
                        franceGold -= 20f;
                        francePopulation -= 40f;
                        franceMaterial -= 30f;
                    }
                    if (playerCountry == 1)
                    {
                        spainGold -= 20f;
                        spainPopulation -= 40f;
                        spainMaterial -= 30f;
                    }
                    if (playerCountry == 2)
                    {
                        portugalGold -= 20f;
                        portugalPopulation -= 40f;
                        portugalMaterial -= 30f;
                    }
                    if (playerCountry == 3)
                    {
                        UKGold -= 20f;
                        UKPopulation -= 40f;
                        UKMaterial -= 30f;
                    }
                    if (playerCountry == 4)
                    {
                        CRGold -= 20f;
                        CRPopulation -= 40f;
                        CRMaterial -= 30f;
                    }
                    if (playerCountry == 5)
                    {
                        moroccoGold -= 20f;
                        moroccoPopulation -= 40f;
                        moroccoMaterial -= 30f;
                    }
                    if (playerCountry == 6)
                    {
                        algeriaGold -= 20f;
                        algeriaPopulation -= 40f;
                        algeriaMaterial -= 30f;
                    }
                    if (playerCountry == 7)
                    {
                        tunisGold -= 20f;
                        tunisPopulation -= 40f;
                        tunisMaterial -= 30f;
                    }
                    if (playerCountry == 8)
                    {
                        sardGold -= 20f;
                        sardPopulation -= 40f;
                        sardMaterial -= 30f;
                    }
                    if (playerCountry == 9)
                    {
                        sicilyGold -= 20f;
                        sicilyPopulation -= 40f;
                        sicilyMaterial -= 30f;
                    }
                    if (playerCountry == 10)
                    {
                        naplesGold -= 20f;
                        naplesPopulation -= 40f;
                        naplesMaterial -= 30f;
                    }
                    if (playerCountry == 11)
                    {
                        luccaGold -= 20f;
                        luccaPopulation -= 40f;
                        luccaMaterial -= 30f;
                    }
                    if (playerCountry == 12)
                    {
                        italyGold -= 20f;
                        italyPopulation -= 40f;
                        italyMaterial -= 30f;
                    }
                    if (playerCountry == 13)
                    {
                        helvetiaGold -= 20f;
                        helvetiaPopulation -= 40f;
                        helvetiaMaterial -= 30f;
                    }
                    if (playerCountry == 14)
                    {
                        austrianGold -= 20f;
                        austrianPopulation -= 40f;
                        austrianMaterial -= 30f;
                    }
                    if (playerCountry == 15)
                    {
                        ottomanGold -= 20f;
                        ottomanPopulation -= 40f;
                        ottomanMaterial -= 30f;
                    }
                    if (playerCountry == 16)
                    {
                        monteGold -= 20f;
                        montePopulation -= 40f;
                        monteMaterial -= 30f;
                    }
                    if (playerCountry == 17)
                    {
                        prussiaGold -= 20f;
                        prussiaPopulation -= 40f;
                        prussiaMaterial -= 30f;
                    }
                    if (playerCountry == 18)
                    {
                        warsawGold -= 20f;
                        warsawPopulation -= 40f;
                        warsawMaterial -= 30f;
                    }
                    if (playerCountry == 19)
                    {
                        russianGold -= 20f;
                        russianPopulation -= 40f;
                        russianMaterial -= 30f;
                    }
                    if (playerCountry == 20)
                    {
                        swedenGold -= 20f;
                        swedenPopulation -= 40f;
                        swedenMaterial -= 30f;
                    }
                    if (playerCountry == 21)
                    {
                        norwayGold -= 20f;
                        norwayPopulation -= 40f;
                        norwayMaterial -= 30f;
                    }
                    targetAI.GetComponent<Country_AI>().FindGold();
                }
                else
                {
                    Debug.Log("Can't afford it");
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableBuy();
                    StartCoroutine(WaitOff(3f));
                }
            }
        }
    }

    public void CheckMaxCavalry()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (targetAI.GetComponent<Country_AI>().AIGold > 21 && targetAI.GetComponent<Country_AI>().AIPopulation > 41 && targetAI.GetComponent<Country_AI>().AIMaterial > 31)
                {
                    targetAI.GetComponent<Country_AI>().AIGold -= 20f;
                    targetAI.GetComponent<Country_AI>().AIPopulation -= 40f;
                    targetAI.GetComponent<Country_AI>().AIMaterial -= 30f;
                    maxCalvalry += 1f;

                    MaxBuyCavalry();
                }
            }
        }
    }

    public void MaxBuyCavalry()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (targetAI.GetComponent<Country_AI>().AIGold > 21 && targetAI.GetComponent<Country_AI>().AIPopulation > 41 && targetAI.GetComponent<Country_AI>().AIMaterial > 31)
                {
                    CheckMaxCavalry();
                }
                if (targetAI.GetComponent<Country_AI>().AIGold < 21 || targetAI.GetComponent<Country_AI>().AIPopulation < 41 || targetAI.GetComponent<Country_AI>().AIMaterial < 31)
                {
                    if (maxCalvalry == 0f)
                    {
                        Debug.Log("Can't afford it");
                        GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableBuy();
                        StartCoroutine(WaitOff(3f));
                    }
                    else
                    {
                        GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().cavalry += maxCalvalry;
                        if (playerCountry == 0)
                        {
                            franceGold -= 20f * maxCalvalry;
                            francePopulation -= 40f * maxCalvalry;
                            franceMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 1)
                        {
                            spainGold -= 20f * maxCalvalry;
                            spainPopulation -= 40f * maxCalvalry;
                            spainMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 2)
                        {
                            portugalGold -= 20f * maxCalvalry;
                            portugalPopulation -= 40f * maxCalvalry;
                            portugalMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 3)
                        {
                            UKGold -= 20f * maxCalvalry;
                            UKPopulation -= 40f * maxCalvalry;
                            UKMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 4)
                        {
                            CRGold -= 20f * maxCalvalry;
                            CRPopulation -= 40f * maxCalvalry;
                            CRMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 5)
                        {
                            moroccoGold -= 20f * maxCalvalry;
                            moroccoPopulation -= 40f * maxCalvalry;
                            moroccoMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 6)
                        {
                            algeriaGold -= 20f * maxCalvalry;
                            algeriaPopulation -= 40f * maxCalvalry;
                            algeriaMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 7)
                        {
                            tunisGold -= 20f * maxCalvalry;
                            tunisPopulation -= 40f * maxCalvalry;
                            tunisMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 8)
                        {
                            sardGold -= 20f * maxCalvalry;
                            sardPopulation -= 40f * maxCalvalry;
                            sardMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 9)
                        {
                            sicilyGold -= 20f * maxCalvalry;
                            sicilyPopulation -= 40f * maxCalvalry;
                            sicilyMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 10)
                        {
                            naplesGold -= 20f * maxCalvalry;
                            naplesPopulation -= 40f * maxCalvalry;
                            naplesMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 11)
                        {
                            luccaGold -= 20f * maxCalvalry;
                            luccaPopulation -= 40f * maxCalvalry;
                            luccaMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 12)
                        {
                            italyGold -= 20f * maxCalvalry;
                            italyPopulation -= 40f * maxCalvalry;
                            italyMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 13)
                        {
                            helvetiaGold -= 20f * maxCalvalry;
                            helvetiaPopulation -= 40f * maxCalvalry;
                            helvetiaMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 14)
                        {
                            austrianGold -= 20f * maxCalvalry;
                            austrianPopulation -= 40f * maxCalvalry;
                            austrianMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 15)
                        {
                            ottomanGold -= 20f * maxCalvalry;
                            ottomanPopulation -= 40f * maxCalvalry;
                            ottomanMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 16)
                        {
                            monteGold -= 20f * maxCalvalry;
                            montePopulation -= 40f * maxCalvalry;
                            monteMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 17)
                        {
                            prussiaGold -= 20f * maxCalvalry;
                            prussiaPopulation -= 40f * maxCalvalry;
                            prussiaMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 18)
                        {
                            warsawGold -= 20f * maxCalvalry;
                            warsawPopulation -= 40f * maxCalvalry;
                            warsawMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 19)
                        {
                            russianGold -= 20f * maxCalvalry;
                            russianPopulation -= 40f * maxCalvalry;
                            russianMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 20)
                        {
                            swedenGold -= 20f * maxCalvalry;
                            swedenPopulation -= 40f * maxCalvalry;
                            swedenMaterial -= 30f * maxCalvalry;
                        }
                        if (playerCountry == 21)
                        {
                            norwayGold -= 20f * maxCalvalry;
                            norwayPopulation -= 40f * maxCalvalry;
                            norwayMaterial -= 30f * maxCalvalry;
                        }
                        maxCalvalry = 0f;
                        targetAI.GetComponent<Country_AI>().FindGold();
                        GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableBuy();
                    }
                }
            }
        }
    }

    public void BuyInfantry()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (targetAI.GetComponent<Country_AI>().AIGold > 11 && targetAI.GetComponent<Country_AI>().AIPopulation > 21 && targetAI.GetComponent<Country_AI>().AIMaterial > 11)
                {
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().infantry += 1f;
                    if (playerCountry == 0)
                    {
                        franceGold -= 10f;
                        francePopulation -= 20f;
                        franceMaterial -= 10f;
                    }
                    if (playerCountry == 1)
                    {
                        spainGold -= 10f;
                        spainPopulation -= 20f;
                        spainMaterial -= 10f;
                    }
                    if (playerCountry == 2)
                    {
                        portugalGold -= 10f;
                        portugalPopulation -= 20f;
                        portugalMaterial -= 10f;
                    }
                    if (playerCountry == 3)
                    {
                        UKGold -= 10f;
                        UKPopulation -= 20f;
                        UKMaterial -= 10f;
                    }
                    if (playerCountry == 4)
                    {
                        CRGold -= 10f;
                        CRPopulation -= 20f;
                        CRMaterial -= 10f;
                    }
                    if (playerCountry == 5)
                    {
                        moroccoGold -= 10f;
                        moroccoPopulation -= 20f;
                        moroccoMaterial -= 10f;
                    }
                    if (playerCountry == 6)
                    {
                        algeriaGold -= 10f;
                        algeriaPopulation -= 20f;
                        algeriaMaterial -= 10f;
                    }
                    if (playerCountry == 7)
                    {
                        tunisGold -= 10f;
                        tunisPopulation -= 20f;
                        tunisMaterial -= 10f;
                    }
                    if (playerCountry == 8)
                    {
                        sardGold -= 10f;
                        sardPopulation -= 20f;
                        sardMaterial -= 10f;
                    }
                    if (playerCountry == 9)
                    {
                        sicilyGold -= 10f;
                        sicilyPopulation -= 20f;
                        sicilyMaterial -= 10f;
                    }
                    if (playerCountry == 10)
                    {
                        naplesGold -= 10f;
                        naplesPopulation -= 20f;
                        naplesMaterial -= 10f;
                    }
                    if (playerCountry == 11)
                    {
                        luccaGold -= 10f;
                        luccaPopulation -= 20f;
                        luccaMaterial -= 10f;
                    }
                    if (playerCountry == 12)
                    {
                        italyGold -= 10f;
                        italyPopulation -= 20f;
                        italyMaterial -= 10f;
                    }
                    if (playerCountry == 13)
                    {
                        helvetiaGold -= 10f;
                        helvetiaPopulation -= 20f;
                        helvetiaMaterial -= 10f;
                    }
                    if (playerCountry == 14)
                    {
                        austrianGold -= 10f;
                        austrianPopulation -= 20f;
                        austrianMaterial -= 10f;
                    }
                    if (playerCountry == 15)
                    {
                        ottomanGold -= 10f;
                        ottomanPopulation -= 20f;
                        ottomanMaterial -= 10f;
                    }
                    if (playerCountry == 16)
                    {
                        monteGold -= 10f;
                        montePopulation -= 20f;
                        monteMaterial -= 10f;
                    }
                    if (playerCountry == 17)
                    {
                        prussiaGold -= 10f;
                        prussiaPopulation -= 20f;
                        prussiaMaterial -= 10f;
                    }
                    if (playerCountry == 18)
                    {
                        warsawGold -= 10f;
                        warsawPopulation -= 20f;
                        warsawMaterial -= 10f;
                    }
                    if (playerCountry == 19)
                    {
                        russianGold -= 10f;
                        russianPopulation -= 20f;
                        russianMaterial -= 10f;
                    }
                    if (playerCountry == 20)
                    {
                        swedenGold -= 10f;
                        swedenPopulation -= 20f;
                        swedenMaterial -= 10f;
                    }
                    if (playerCountry == 21)
                    {
                        norwayGold -= 10f;
                        norwayPopulation -= 20f;
                        norwayMaterial -= 10f;
                    }
                }
                else
                {
                    Debug.Log("Can't afford it");
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableBuy();
                    StartCoroutine(WaitOff(3f));
                }
                targetAI.GetComponent<Country_AI>().FindGold();
            }
        }
    }

    public void CheckMaxInfantry()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (targetAI.GetComponent<Country_AI>().AIGold > 11 && targetAI.GetComponent<Country_AI>().AIPopulation > 21 && targetAI.GetComponent<Country_AI>().AIMaterial > 11)
                {
                    targetAI.GetComponent<Country_AI>().AIGold -= 10f;
                    targetAI.GetComponent<Country_AI>().AIPopulation -= 20f;
                    targetAI.GetComponent<Country_AI>().AIMaterial -= 10f;
                    maxInfantry += 1f;

                    MaxBuyInfantry();
                }
            }
        }
    }

    public void MaxBuyInfantry()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (targetAI.GetComponent<Country_AI>().AIGold > 11 && targetAI.GetComponent<Country_AI>().AIPopulation > 21 && targetAI.GetComponent<Country_AI>().AIMaterial > 11)
                {
                    CheckMaxInfantry();
                }
                if (targetAI.GetComponent<Country_AI>().AIGold < 11 || targetAI.GetComponent<Country_AI>().AIPopulation < 21 || targetAI.GetComponent<Country_AI>().AIMaterial < 11)
                {
                    if (maxInfantry == 0f)
                    {
                        Debug.Log("Can't afford it");
                        GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableBuy();
                        StartCoroutine(WaitOff(3f));
                    }
                    else
                    {
                        GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().cavalry += maxInfantry;
                        if (playerCountry == 0)
                        {
                            franceGold -= 10f * maxInfantry;
                            francePopulation -= 20f * maxInfantry;
                            franceMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 1)
                        {
                            spainGold -= 10f * maxInfantry;
                            spainPopulation -= 20f * maxInfantry;
                            spainMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 2)
                        {
                            portugalGold -= 10f * maxInfantry;
                            portugalPopulation -= 20f * maxInfantry;
                            portugalMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 3)
                        {
                            UKGold -= 10f * maxInfantry;
                            UKPopulation -= 20f * maxInfantry;
                            UKMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 4)
                        {
                            CRGold -= 10f * maxInfantry;
                            CRPopulation -= 20f * maxInfantry;
                            CRMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 5)
                        {
                            moroccoGold -= 10f * maxInfantry;
                            moroccoPopulation -= 20f * maxInfantry;
                            moroccoMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 6)
                        {
                            algeriaGold -= 10f * maxInfantry;
                            algeriaPopulation -= 20f * maxInfantry;
                            algeriaMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 7)
                        {
                            tunisGold -= 10f * maxInfantry;
                            tunisPopulation -= 20f * maxInfantry;
                            tunisMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 8)
                        {
                            sardGold -= 10f * maxInfantry;
                            sardPopulation -= 20f * maxInfantry;
                            sardMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 9)
                        {
                            sicilyGold -= 10f * maxInfantry;
                            sicilyPopulation -= 20f * maxInfantry;
                            sicilyMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 10)
                        {
                            naplesGold -= 10f * maxInfantry;
                            naplesPopulation -= 20f * maxInfantry;
                            naplesMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 11)
                        {
                            luccaGold -= 10f * maxInfantry;
                            luccaPopulation -= 20f * maxInfantry;
                            luccaMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 12)
                        {
                            italyGold -= 10f * maxInfantry;
                            italyPopulation -= 20f * maxInfantry;
                            italyMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 13)
                        {
                            helvetiaGold -= 10f * maxInfantry;
                            helvetiaPopulation -= 20f * maxInfantry;
                            helvetiaMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 14)
                        {
                            austrianGold -= 10f * maxInfantry;
                            austrianPopulation -= 20f * maxInfantry;
                            austrianMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 15)
                        {
                            ottomanGold -= 10f * maxInfantry;
                            ottomanPopulation -= 20f * maxInfantry;
                            ottomanMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 16)
                        {
                            monteGold -= 10f * maxInfantry;
                            montePopulation -= 20f * maxInfantry;
                            monteMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 17)
                        {
                            prussiaGold -= 10f * maxInfantry;
                            prussiaPopulation -= 20f * maxInfantry;
                            prussiaMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 18)
                        {
                            warsawGold -= 10f * maxInfantry;
                            warsawPopulation -= 20f * maxInfantry;
                            warsawMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 19)
                        {
                            russianGold -= 10f * maxInfantry;
                            russianPopulation -= 20f * maxInfantry;
                            russianMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 20)
                        {
                            swedenGold -= 10f * maxInfantry;
                            swedenPopulation -= 20f * maxInfantry;
                            swedenMaterial -= 10f * maxInfantry;
                        }
                        if (playerCountry == 21)
                        {
                            norwayGold -= 10f * maxInfantry;
                            norwayPopulation -= 20f * maxInfantry;
                            norwayMaterial -= 10f * maxInfantry;
                        }
                        maxInfantry = 0f;
                        targetAI.GetComponent<Country_AI>().FindGold();
                        GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableBuy();
                    }
                }
            }
        }
    }

    public void BuyArtillery()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (targetAI.GetComponent<Country_AI>().AIGold > 16 && targetAI.GetComponent<Country_AI>().AIPopulation > 31 && targetAI.GetComponent<Country_AI>().AIMaterial > 21)
                {
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().artillery += 1f;
                    if (playerCountry == 0)
                    {
                        franceGold -= 15f;
                        francePopulation -= 30f;
                        franceMaterial -= 20f;
                    }
                    if (playerCountry == 1)
                    {
                        spainGold -= 15f;
                        spainPopulation -= 30f;
                        spainMaterial -= 20f;
                    }
                    if (playerCountry == 2)
                    {
                        portugalGold -= 15f;
                        portugalPopulation -= 30f;
                        portugalMaterial -= 20f;
                    }
                    if (playerCountry == 3)
                    {
                        UKGold -= 15f;
                        UKPopulation -= 30f;
                        UKMaterial -= 20f;
                    }
                    if (playerCountry == 4)
                    {
                        CRGold -= 15f;
                        CRPopulation -= 30f;
                        CRMaterial -= 20f;
                    }
                    if (playerCountry == 5)
                    {
                        moroccoGold -= 15f;
                        moroccoPopulation -= 30f;
                        moroccoMaterial -= 20f;
                    }
                    if (playerCountry == 6)
                    {
                        algeriaGold -= 15f;
                        algeriaPopulation -= 30f;
                        algeriaMaterial -= 20f;
                    }
                    if (playerCountry == 7)
                    {
                        tunisGold -= 15f;
                        tunisPopulation -= 30f;
                        tunisMaterial -= 20f;
                    }
                    if (playerCountry == 8)
                    {
                        sardGold -= 15f;
                        sardPopulation -= 30f;
                        sardMaterial -= 20f;
                    }
                    if (playerCountry == 9)
                    {
                        sicilyGold -= 15f;
                        sicilyPopulation -= 30f;
                        sicilyMaterial -= 20f;
                    }
                    if (playerCountry == 10)
                    {
                        naplesGold -= 15f;
                        naplesPopulation -= 30f;
                        naplesMaterial -= 20f;
                    }
                    if (playerCountry == 11)
                    {
                        luccaGold -= 15f;
                        luccaPopulation -= 30f;
                        luccaMaterial -= 20f;
                    }
                    if (playerCountry == 12)
                    {
                        italyGold -= 15f;
                        italyPopulation -= 30f;
                        italyMaterial -= 20f;
                    }
                    if (playerCountry == 13)
                    {
                        helvetiaGold -= 15f;
                        helvetiaPopulation -= 30f;
                        helvetiaMaterial -= 20f;
                    }
                    if (playerCountry == 14)
                    {
                        austrianGold -= 15f;
                        austrianPopulation -= 30f;
                        austrianMaterial -= 20f;
                    }
                    if (playerCountry == 15)
                    {
                        ottomanGold -= 15f;
                        ottomanPopulation -= 30f;
                        ottomanMaterial -= 20f;
                    }
                    if (playerCountry == 16)
                    {
                        monteGold -= 15f;
                        montePopulation -= 30f;
                        monteMaterial -= 20f;
                    }
                    if (playerCountry == 17)
                    {
                        prussiaGold -= 15f;
                        prussiaPopulation -= 30f;
                        prussiaMaterial -= 20f;
                    }
                    if (playerCountry == 18)
                    {
                        warsawGold -= 15f;
                        warsawPopulation -= 30f;
                        warsawMaterial -= 20f;
                    }
                    if (playerCountry == 19)
                    {
                        russianGold -= 15f;
                        russianPopulation -= 30f;
                        russianMaterial -= 20f;
                    }
                    if (playerCountry == 20)
                    {
                        swedenGold -= 15f;
                        swedenPopulation -= 30f;
                        swedenMaterial -= 20f;
                    }
                    if (playerCountry == 21)
                    {
                        norwayGold -= 15f;
                        norwayPopulation -= 30f;
                        norwayMaterial -= 20f;
                    }
                    targetAI.GetComponent<Country_AI>().FindGold();
                }
                else
                {
                    Debug.Log("Can't afford it");
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableBuy();
                    StartCoroutine(WaitOff(3f));
                }
            }
        }
    }

    public void CheckMaxArtillery()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (targetAI.GetComponent<Country_AI>().AIGold > 16 && targetAI.GetComponent<Country_AI>().AIPopulation > 31 && targetAI.GetComponent<Country_AI>().AIMaterial > 21)
                {
                    targetAI.GetComponent<Country_AI>().AIGold -= 15f;
                    targetAI.GetComponent<Country_AI>().AIPopulation -= 30f;
                    targetAI.GetComponent<Country_AI>().AIMaterial -= 20f;
                    maxArtillery += 1f;

                    MaxBuyArtillery();
                }
            }
        }
    }

    public void MaxBuyArtillery()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (targetAI.GetComponent<Country_AI>().AIGold > 16 && targetAI.GetComponent<Country_AI>().AIPopulation > 31 && targetAI.GetComponent<Country_AI>().AIMaterial > 21)
                {
                    CheckMaxArtillery();
                }
                if (targetAI.GetComponent<Country_AI>().AIGold < 16 || targetAI.GetComponent<Country_AI>().AIPopulation < 31 || targetAI.GetComponent<Country_AI>().AIMaterial < 21)
                {
                    if (maxArtillery == 0f)
                    {
                        Debug.Log("Can't afford it");
                        GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableBuy();
                        StartCoroutine(WaitOff(3f));
                    }
                    else
                    {
                        GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().cavalry += maxArtillery;
                        if (playerCountry == 0)
                        {
                            franceGold -= 15f * maxArtillery;
                            francePopulation -= 30f * maxArtillery;
                            franceMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 1)
                        {
                            spainGold -= 15f * maxArtillery;
                            spainPopulation -= 30f * maxArtillery;
                            spainMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 2)
                        {
                            portugalGold -= 15f * maxArtillery;
                            portugalPopulation -= 30f * maxArtillery;
                            portugalMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 3)
                        {
                            UKGold -= 15f * maxArtillery;
                            UKPopulation -= 30f * maxArtillery;
                            UKMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 4)
                        {
                            CRGold -= 15f * maxArtillery;
                            CRPopulation -= 30f * maxArtillery;
                            CRMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 5)
                        {
                            moroccoGold -= 15f * maxArtillery;
                            moroccoPopulation -= 30f * maxArtillery;
                            moroccoMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 6)
                        {
                            algeriaGold -= 15f * maxArtillery;
                            algeriaPopulation -= 30f * maxArtillery;
                            algeriaMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 7)
                        {
                            tunisGold -= 15f * maxArtillery;
                            tunisPopulation -= 30f * maxArtillery;
                            tunisMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 8)
                        {
                            sardGold -= 15f * maxArtillery;
                            sardPopulation -= 30f * maxArtillery;
                            sardMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 9)
                        {
                            sicilyGold -= 15f * maxArtillery;
                            sicilyPopulation -= 30f * maxArtillery;
                            sicilyMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 10)
                        {
                            naplesGold -= 15f * maxArtillery;
                            naplesPopulation -= 30f * maxArtillery;
                            naplesMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 11)
                        {
                            luccaGold -= 15f * maxArtillery;
                            luccaPopulation -= 30f * maxArtillery;
                            luccaMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 12)
                        {
                            italyGold -= 15f * maxArtillery;
                            italyPopulation -= 30f * maxArtillery;
                            italyMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 13)
                        {
                            helvetiaGold -= 15f * maxArtillery;
                            helvetiaPopulation -= 30f * maxArtillery;
                            helvetiaMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 14)
                        {
                            austrianGold -= 15f * maxArtillery;
                            austrianPopulation -= 30f * maxArtillery;
                            austrianMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 15)
                        {
                            ottomanGold -= 15f * maxArtillery;
                            ottomanPopulation -= 30f * maxArtillery;
                            ottomanMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 16)
                        {
                            monteGold -= 15f * maxArtillery;
                            montePopulation -= 30f * maxArtillery;
                            monteMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 17)
                        {
                            prussiaGold -= 15f * maxArtillery;
                            prussiaPopulation -= 30f * maxArtillery;
                            prussiaMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 18)
                        {
                            warsawGold -= 15f * maxArtillery;
                            warsawPopulation -= 30f * maxArtillery;
                            warsawMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 19)
                        {
                            russianGold -= 15f * maxArtillery;
                            russianPopulation -= 30f * maxArtillery;
                            russianMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 20)
                        {
                            swedenGold -= 15f * maxArtillery;
                            swedenPopulation -= 30f * maxArtillery;
                            swedenMaterial -= 20f * maxArtillery;
                        }
                        if (playerCountry == 21)
                        {
                            norwayGold -= 15f * maxArtillery;
                            norwayPopulation -= 30f * maxArtillery;
                            norwayMaterial -= 20f * maxArtillery;
                        }
                        maxArtillery = 0f;
                        targetAI.GetComponent<Country_AI>().FindGold();
                        GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableBuy();
                    }
                }
            }
        }
    }

    public void BuyForts()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().defenseLevel <= 4 && targetAI.GetComponent<Country_AI>().AIGold > 31 && targetAI.GetComponent<Country_AI>().AIPopulation > 11 && targetAI.GetComponent<Country_AI>().AIMaterial > 31)
                {
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().defenseMultiplier += 0.1f;
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().defenseLevel += 1f;
                    if (playerCountry == 0)
                    {
                        franceGold -= 30f;
                        francePopulation -= 10f;
                        franceMaterial -= 30f;
                    }
                    if (playerCountry == 1)
                    {
                        spainGold -= 30f;
                        spainPopulation -= 10f;
                        spainMaterial -= 30f;
                    }
                    if (playerCountry == 2)
                    {
                        portugalGold -= 30f;
                        portugalPopulation -= 10f;
                        portugalMaterial -= 30f;
                    }
                    if (playerCountry == 3)
                    {
                        UKGold -= 30f;
                        UKPopulation -= 10f;
                        UKMaterial -= 30f;
                    }
                    if (playerCountry == 4)
                    {
                        CRGold -= 30f;
                        CRPopulation -= 10f;
                        CRMaterial -= 30f;
                    }
                    if (playerCountry == 5)
                    {
                        moroccoGold -= 30f;
                        moroccoPopulation -= 10f;
                        moroccoMaterial -= 30f;
                    }
                    if (playerCountry == 6)
                    {
                        algeriaGold -= 30f;
                        algeriaPopulation -= 10f;
                        algeriaMaterial -= 30f;
                    }
                    if (playerCountry == 7)
                    {
                        tunisGold -= 30f;
                        tunisPopulation -= 10f;
                        tunisMaterial -= 30f;
                    }
                    if (playerCountry == 8)
                    {
                        sardGold -= 30f;
                        sardPopulation -= 10f;
                        sardMaterial -= 30f;
                    }
                    if (playerCountry == 9)
                    {
                        sicilyGold -= 30f;
                        sicilyPopulation -= 10f;
                        sicilyMaterial -= 30f;
                    }
                    if (playerCountry == 10)
                    {
                        naplesGold -= 30f;
                        naplesPopulation -= 10f;
                        naplesMaterial -= 30f;
                    }
                    if (playerCountry == 11)
                    {
                        luccaGold -= 30f;
                        luccaPopulation -= 10f;
                        luccaMaterial -= 30f;
                    }
                    if (playerCountry == 12)
                    {
                        italyGold -= 30f;
                        italyPopulation -= 10f;
                        italyMaterial -= 30f;
                    }
                    if (playerCountry == 13)
                    {
                        helvetiaGold -= 30f;
                        helvetiaPopulation -= 10f;
                        helvetiaMaterial -= 30f;
                    }
                    if (playerCountry == 14)
                    {
                        austrianGold -= 30f;
                        austrianPopulation -= 10f;
                        austrianMaterial -= 30f;
                    }
                    if (playerCountry == 15)
                    {
                        ottomanGold -= 30f;
                        ottomanPopulation -= 10f;
                        ottomanMaterial -= 30f;
                    }
                    if (playerCountry == 16)
                    {
                        monteGold -= 30f;
                        montePopulation -= 10f;
                        monteMaterial -= 30f;
                    }
                    if (playerCountry == 17)
                    {
                        prussiaGold -= 30f;
                        prussiaPopulation -= 10f;
                        prussiaMaterial -= 30f;
                    }
                    if (playerCountry == 18)
                    {
                        warsawGold -= 30f;
                        warsawPopulation -= 10f;
                        warsawMaterial -= 30f;
                    }
                    if (playerCountry == 19)
                    {
                        russianGold -= 30f;
                        russianPopulation -= 10f;
                        russianMaterial -= 30f;
                    }
                    if (playerCountry == 20)
                    {
                        swedenGold -= 30f;
                        swedenPopulation -= 10f;
                        swedenMaterial -= 30f;
                    }
                    if (playerCountry == 21)
                    {
                        norwayGold -= 30f;
                        norwayPopulation -= 10f;
                        norwayMaterial -= 30f;
                    }
                }
                if (GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().defenseLevel >= 5)
                {
                    Debug.Log("Max Level");
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableBuy();
                    StartCoroutine(WaitBuilding(3f));
                }
                if (GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().defenseLevel <= 4 && targetAI.GetComponent<Country_AI>().AIGold <= 30 || targetAI.GetComponent<Country_AI>().AIPopulation <= 10 || targetAI.GetComponent<Country_AI>().AIMaterial <= 30)
                {
                    Debug.Log("Can't afford it");
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableBuy();
                    StartCoroutine(WaitOff(3f));
                }

                targetAI.GetComponent<Country_AI>().FindGold();
            }
        }
    }

    public void BuyBarracks()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == playerCountry)
            {
                if (GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().barracksLevel <= 4 && targetAI.GetComponent<Country_AI>().AIGold > 31 && targetAI.GetComponent<Country_AI>().AIPopulation > 11 && targetAI.GetComponent<Country_AI>().AIMaterial > 31)
                {
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().barracksMultiplier += 0.1f;
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().barracksLevel += 1f;
                    if (playerCountry == 0)
                    {
                        franceGold -= 30f;
                        francePopulation -= 10f;
                        franceMaterial -= 30f;
                    }
                    if (playerCountry == 1)
                    {
                        spainGold -= 30f;
                        spainPopulation -= 10f;
                        spainMaterial -= 30f;
                    }
                    if (playerCountry == 2)
                    {
                        portugalGold -= 30f;
                        portugalPopulation -= 10f;
                        portugalMaterial -= 30f;
                    }
                    if (playerCountry == 3)
                    {
                        UKGold -= 30f;
                        UKPopulation -= 10f;
                        UKMaterial -= 30f;
                    }
                    if (playerCountry == 4)
                    {
                        CRGold -= 30f;
                        CRPopulation -= 10f;
                        CRMaterial -= 30f;
                    }
                    if (playerCountry == 5)
                    {
                        moroccoGold -= 30f;
                        moroccoPopulation -= 10f;
                        moroccoMaterial -= 30f;
                    }
                    if (playerCountry == 6)
                    {
                        algeriaGold -= 30f;
                        algeriaPopulation -= 10f;
                        algeriaMaterial -= 30f;
                    }
                    if (playerCountry == 7)
                    {
                        tunisGold -= 30f;
                        tunisPopulation -= 10f;
                        tunisMaterial -= 30f;
                    }
                    if (playerCountry == 8)
                    {
                        sardGold -= 30f;
                        sardPopulation -= 10f;
                        sardMaterial -= 30f;
                    }
                    if (playerCountry == 9)
                    {
                        sicilyGold -= 30f;
                        sicilyPopulation -= 10f;
                        sicilyMaterial -= 30f;
                    }
                    if (playerCountry == 10)
                    {
                        naplesGold -= 30f;
                        naplesPopulation -= 10f;
                        naplesMaterial -= 30f;
                    }
                    if (playerCountry == 11)
                    {
                        luccaGold -= 30f;
                        luccaPopulation -= 10f;
                        luccaMaterial -= 30f;
                    }
                    if (playerCountry == 12)
                    {
                        italyGold -= 30f;
                        italyPopulation -= 10f;
                        italyMaterial -= 30f;
                    }
                    if (playerCountry == 13)
                    {
                        helvetiaGold -= 30f;
                        helvetiaPopulation -= 10f;
                        helvetiaMaterial -= 30f;
                    }
                    if (playerCountry == 14)
                    {
                        austrianGold -= 30f;
                        austrianPopulation -= 10f;
                        austrianMaterial -= 30f;
                    }
                    if (playerCountry == 15)
                    {
                        ottomanGold -= 30f;
                        ottomanPopulation -= 10f;
                        ottomanMaterial -= 30f;
                    }
                    if (playerCountry == 16)
                    {
                        monteGold -= 30f;
                        montePopulation -= 10f;
                        monteMaterial -= 30f;
                    }
                    if (playerCountry == 17)
                    {
                        prussiaGold -= 30f;
                        prussiaPopulation -= 10f;
                        prussiaMaterial -= 30f;
                    }
                    if (playerCountry == 18)
                    {
                        warsawGold -= 30f;
                        warsawPopulation -= 10f;
                        warsawMaterial -= 30f;
                    }
                    if (playerCountry == 19)
                    {
                        russianGold -= 30f;
                        russianPopulation -= 10f;
                        russianMaterial -= 30f;
                    }
                    if (playerCountry == 20)
                    {
                        swedenGold -= 30f;
                        swedenPopulation -= 10f;
                        swedenMaterial -= 30f;
                    }
                    if (playerCountry == 21)
                    {
                        norwayGold -= 30f;
                        norwayPopulation -= 10f;
                        norwayMaterial -= 30f;
                    }
                }
                if (GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().barracksLevel >= 5)
                {
                    Debug.Log("Max Level");
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableBuy();
                    StartCoroutine(WaitBuilding(3f));
                }
                if (GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1.GetComponent<Control>().barracksLevel <= 4 && targetAI.GetComponent<Country_AI>().AIGold <= 30 || targetAI.GetComponent<Country_AI>().AIPopulation <= 10 || targetAI.GetComponent<Country_AI>().AIMaterial <= 30)
                {
                    Debug.Log("Can't afford it");
                    GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableBuy();
                    StartCoroutine(WaitOff(3f));
                }

                targetAI.GetComponent<Country_AI>().FindGold();
            }
        }
    }

    public void Simple()
    {
        if (simpleColor == false)
        {
            simpleColor = true;
            simpleColorText.GetComponent<TextMeshProUGUI>().text = "Turn off Simple Color";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisablePause();
        }
        else
        {
            simpleColor = false;
            simpleColorText.GetComponent<TextMeshProUGUI>().text = "Turn on Simple Color";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisablePause();
        }
    }

    public void CountryAfford()
    {
        StartCoroutine(WaitOff(3f));
    }

    IEnumerator WaitOff(float waitTurnTime)
    {
        yield return new WaitForSeconds(0.1f);
        messageBoardImage.SetActive(true);
        messageBoard.GetComponent<TextMeshProUGUI>().text = "Can't afford it!";
        messageBoardImage.GetComponent<ColorC>().attackFlash = true;
        yield return new WaitForSeconds(waitTurnTime);
        messageBoardImage.SetActive(false);
    }

    IEnumerator WaitBuilding(float waitTurnTime)
    {
        yield return new WaitForSeconds(0.1f);
        messageBoardImage.SetActive(true);
        messageBoard.GetComponent<TextMeshProUGUI>().text = "Max Level";
        messageBoardImage.GetComponent<ColorC>().attackFlash = true;
        yield return new WaitForSeconds(waitTurnTime);
        messageBoardImage.SetActive(false);
    }
}