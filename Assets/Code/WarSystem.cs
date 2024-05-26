using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarSystem : MonoBehaviour
{
    public float points;

    public GameObject WarCountry1;
    public GameObject WarCountry2;
    public GameObject newsPrefab;
    public GameObject container;

    void Awake()
    {
        WarCountry1 = GameObject.Find("information").GetComponent<countries>().warCountry1;
        WarCountry2 = GameObject.Find("information").GetComponent<countries>().warCountry2;
        container = GameObject.Find("information").GetComponent<countries>().container;
    }

    void Update()
    {
        if (points >= 100)
        {
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 0)
            {
                EndWarFrance();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 1)
            {
                EndWarSpain();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 2)
            {
                EndWarPortugal();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 3)
            {
                EndWarUK();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 4)
            {
                EndWarCR();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 5)
            {
                EndWarMorocco();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 6)
            {
                EndWarAlgeria();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 7)
            {
                EndWarTunis();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 8)
            {
                EndWarSard();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 9)
            {
                EndWarSicily();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 10)
            {
                EndWarNaples();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 11)
            {
                EndWarLucca();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 12)
            {
                EndWarItaly();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 13)
            {
                EndWarHelvetia();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 14)
            {
                EndWarAustrian();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 15)
            {
                EndWarOttoman();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 16)
            {
                EndWarMonte();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 17)
            {
                EndWarPrussia();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 18)
            {
                EndWarWarsaw();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 19)
            {
                EndWarRussian();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 20)
            {
                EndWarSweden();
            }
            if (WarCountry1.GetComponent<Country_AI>().CountryType == 21)
            {
                EndWarNorway();
            }
            Destroy(gameObject);
        }

        if (WarCountry1.GetComponent<Country_AI>().allLand.Count == 0 || WarCountry2.GetComponent<Country_AI>().allLand.Count == 0)
        {
            Destroy(gameObject);
        }
    }

    void EndWarFrance()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: "+ GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().FranceWar = false;
            Debug.Log("War has ended between France and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between France and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarSpain()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: "+ GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SpainWar = false;
            Debug.Log("War has ended between Spain and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Spain and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarPortugal()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PortugalWar = false;
            Debug.Log("War has ended between Portugal and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Portugal and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarUK()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().UKWar = false;
            Debug.Log("War has ended between UK and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between UK and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarCR()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Italy";
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().CRWar = false;
            Debug.Log("War has ended between CR and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between CR and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarMorocco()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MoroccoWar = false;
            Debug.Log("War has ended between Morocco and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Morocco and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarAlgeria()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AlgeriaWar = false;
            Debug.Log("War has ended between Algeria and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Algeria and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarTunis()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().TunisWar = false;
            Debug.Log("War has ended between Tunis and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Tunis and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarSard()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SardWar = false;
            Debug.Log("War has ended between Sardinia and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sardinia and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarSicily()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SicilyWar = false;
            Debug.Log("War has ended between Sicily and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sicily and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarNaples()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NaplesWar = false;
            Debug.Log("War has ended between Naples and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Naples and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarLucca()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().LuccaWar = false;
            Debug.Log("War has ended between Lucca and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Lucca and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarItaly()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().ItalyWar = false;
            Debug.Log("War has ended between Italy and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Italy and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarHelvetia()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().HelvetiaWar = false;
            Debug.Log("War has ended between Helvetia and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Helvetia and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarAustrian()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().AustrianWar = false;
            Debug.Log("War has ended between Austria and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Austria and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarOttoman()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().OttomanWar = false;
            Debug.Log("War has ended between Ottoman and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Ottoman and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarMonte()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().MonteWar = false;
            Debug.Log("War has ended between Montenegro and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Montenegro and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarPrussia()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().PrussiaWar = false;
            Debug.Log("War has ended between Prussia and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Prussia and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarWarsaw()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().WarsawWar = false;
            Debug.Log("War has ended between Warsaw and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Warsaw and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarRussian()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().RussianWar = false;
            Debug.Log("War has ended between Russia and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Russia and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarSweden()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 21)
        {
            WarCountry1.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NorwayWar = false;
            WarCountry2.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().SwedenWar = false;
            Debug.Log("War has ended between Sweden and Norway/Denmark");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Sweden and Norway/Denmark";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
    void EndWarNorway()
    {
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 0)
        {
            WarCountry1.GetComponent<Country_AI>().FranceOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().FranceWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and France");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and France";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 1)
        {
            WarCountry1.GetComponent<Country_AI>().SpainOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SpainWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Spain");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Spain";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 2)
        {
            WarCountry1.GetComponent<Country_AI>().PortugalOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PortugalWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Portugal");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Portugal";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 3)
        {
            WarCountry1.GetComponent<Country_AI>().UKOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().UKWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and UK");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and UK";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 4)
        {
            WarCountry1.GetComponent<Country_AI>().CROpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().CRWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and CR");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and CR";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 5)
        {
            WarCountry1.GetComponent<Country_AI>().MoroccoOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MoroccoWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Morocco");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Morocco";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 6)
        {
            WarCountry1.GetComponent<Country_AI>().AlgeriaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AlgeriaWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Algeria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Algeria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 8)
        {
            WarCountry1.GetComponent<Country_AI>().SardOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SardWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Sardinia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Sardinia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 9)
        {
            WarCountry1.GetComponent<Country_AI>().SicilyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SicilyWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Sicily");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Sicily";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 10)
        {
            WarCountry1.GetComponent<Country_AI>().NaplesOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().NaplesWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Naples");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Naples";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 11)
        {
            WarCountry1.GetComponent<Country_AI>().LuccaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().LuccaWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Lucca");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Lucca";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 12)
        {
            WarCountry1.GetComponent<Country_AI>().ItalyOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().ItalyWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Italy");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Italy";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 13)
        {
            WarCountry1.GetComponent<Country_AI>().HelvetiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().HelvetiaWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Helvetia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Helvetia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 14)
        {
            WarCountry1.GetComponent<Country_AI>().AustrianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().AustrianWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Austria");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Austria";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 15)
        {
            WarCountry1.GetComponent<Country_AI>().OttomanOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().OttomanWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Ottoman");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Ottoman";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 16)
        {
            WarCountry1.GetComponent<Country_AI>().MonteOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().MonteWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Montenegro");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Montenegro";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 17)
        {
            WarCountry1.GetComponent<Country_AI>().PrussiaOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().PrussiaWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Prussia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Prussia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 18)
        {
            WarCountry1.GetComponent<Country_AI>().WarsawOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().WarsawWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Warsaw");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Warsaw";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 19)
        {
            WarCountry1.GetComponent<Country_AI>().RussianOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().RussianWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Russia");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Russia";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 20)
        {
            WarCountry1.GetComponent<Country_AI>().SwedenOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().SwedenWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Sweden");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Sweden";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
        if (WarCountry2.GetComponent<Country_AI>().CountryType == 7)
        {
            WarCountry1.GetComponent<Country_AI>().TunisOpinion = 50f;
            WarCountry1.GetComponent<Country_AI>().TunisWar = false;
            WarCountry2.GetComponent<Country_AI>().NorwayOpinion = 50f;
            WarCountry2.GetComponent<Country_AI>().NorwayWar = false;
            Debug.Log("War has ended between Norway/Denmark and Tunis");
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().news = "War has ended between Norway/Denmark and Tunis";
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().round = "Round: " + GameObject.Find("information").GetComponent<countries>().turnNumber;
            GameObject originalGameObject = Instantiate(newsPrefab, new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
            originalGameObject.transform.SetParent(container.transform, false);
        }
    }
}