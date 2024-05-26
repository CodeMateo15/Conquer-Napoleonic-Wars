using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Occupation : MonoBehaviour
{
    public GameObject attackCountry1;
    public GameObject attackCountry2;

    [HideInInspector] public GameObject buyCountry;
    [HideInInspector] public float playerGold;

    [HideInInspector] public GameObject changeCountry0;
    [HideInInspector] public GameObject changeCountry1;
    [HideInInspector] public GameObject changeCountry2;
    [HideInInspector] public GameObject changeCountry3;
    [HideInInspector] public GameObject changeCountry4;

    public GameObject warCountry1;
    public GameObject warCountry2;

    [HideInInspector] public float ten1Loss;
    [HideInInspector] public float ten2Loss;

    [HideInInspector] public GameObject AICountry;
    [HideInInspector] public GameObject AIPlayer;

    public float setTurn;

    private bool attackDone = false;

    void Start()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == GameObject.Find("information").GetComponent<countries>().playerCountry)
            {
                AIPlayer = targetAI;
            }
        }
    }

    void Update()
    {
        if (setTurn == 0f)
        {
            attackDone = true;
            GameObject.Find("MusicManager").GetComponent<MusicManager>().FightSound();
            setTurn = 1000f;
        }

        if (attackDone == true)
        {
            Attack();
            attackDone = false;
        }
    }
    public void removeTurn()
    {
        if (setTurn <= 999f)
        {
            setTurn -= 1f;
        }
        else
        {
            //ignore setTurn subtraction
        }
    }

    void FindPlayerGold()
    {
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 0)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().franceGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 1)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().spainGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 2)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().portugalGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 3)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().UKGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 4)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().CRGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 5)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().moroccoGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 6)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().algeriaGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 7)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().tunisGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 8)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().sardGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 9)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().sicilyGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 10)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().naplesGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 11)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().luccaGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 12)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().italyGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 13)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().helvetiaGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 14)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().austrianGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 15)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().ottomanGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 16)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().monteGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 17)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().prussiaGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 18)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().warsawGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 19)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().russianGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 20)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().swedenGold;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 21)
        {
            playerGold = GameObject.Find("information").GetComponent<countries>().norwayGold;
        }
    }

    void BuyPlayerGold()
    {
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 0)
        {
            GameObject.Find("information").GetComponent<countries>().franceGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 1)
        {
            GameObject.Find("information").GetComponent<countries>().spainGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 2)
        {
            GameObject.Find("information").GetComponent<countries>().portugalGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 3)
        {
            GameObject.Find("information").GetComponent<countries>().UKGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 4)
        {
            GameObject.Find("information").GetComponent<countries>().CRGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 5)
        {
            GameObject.Find("information").GetComponent<countries>().moroccoGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 6)
        {
            GameObject.Find("information").GetComponent<countries>().algeriaGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 7)
        {
            GameObject.Find("information").GetComponent<countries>().tunisGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 8)
        {
            GameObject.Find("information").GetComponent<countries>().sardGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 9)
        {
            GameObject.Find("information").GetComponent<countries>().sicilyGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 10)
        {
            GameObject.Find("information").GetComponent<countries>().naplesGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 11)
        {
            GameObject.Find("information").GetComponent<countries>().luccaGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 12)
        {
            GameObject.Find("information").GetComponent<countries>().italyGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 13)
        {
            GameObject.Find("information").GetComponent<countries>().helvetiaGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 14)
        {
            GameObject.Find("information").GetComponent<countries>().austrianGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 15)
        {
            GameObject.Find("information").GetComponent<countries>().ottomanGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 16)
        {
            GameObject.Find("information").GetComponent<countries>().monteGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 17)
        {
            GameObject.Find("information").GetComponent<countries>().prussiaGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 18)
        {
            GameObject.Find("information").GetComponent<countries>().warsawGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 19)
        {
            GameObject.Find("information").GetComponent<countries>().russianGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 20)
        {
            GameObject.Find("information").GetComponent<countries>().swedenGold -= 3f;
        }
        if (GameObject.Find("information").GetComponent<countries>().playerCountry == 21)
        {
            GameObject.Find("information").GetComponent<countries>().norwayGold -= 3f;
        }
    }

    public void BuyArmy() //if you click buy button
    {
        buyCountry = GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1;
        FindPlayerGold();
        if (playerGold > 5)
        {
            buyCountry.GetComponent<Control>().cavalry += 1f;
            BuyPlayerGold();
        }
    }

    public void MoveArmy() //if you click attack button
    {
        setTurn = 1f;
        GameObject.Find("Main Camera").GetComponent<ArmyUI>().touched = true;
        AttackFlashTrue();
    }

    public void Attack()
    {
        if (GameObject.Find("information").GetComponent<countries>().countryTurn == GameObject.Find("information").GetComponent<countries>().playerCountry)
        {
            GameObject.Find("Main Camera").GetComponent<ArmyUI>().ready = false;
            PlayerAttack();
        }
        if (GameObject.Find("information").GetComponent<countries>().countryTurn != GameObject.Find("information").GetComponent<countries>().playerCountry)
        {
            AIAttack();
        }
    }

    void AttackFlashTrue()
    {
        if (GameObject.Find("information").GetComponent<countries>().countryTurn == GameObject.Find("information").GetComponent<countries>().playerCountry)
        {
            attackCountry1 = GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1;
        }

        if (attackCountry1.gameObject.GetComponent<Control>().borderSpawn.Count >= 1)
        {
            changeCountry0 = attackCountry1.GetComponent<Control>().accountGame0;
            if (changeCountry0.GetComponent<Control>().controller == 0f && AIPlayer.GetComponent<Country_AI>().FranceWar == true || changeCountry0.GetComponent<Control>().controller == 1f && AIPlayer.GetComponent<Country_AI>().SpainWar == true || changeCountry0.GetComponent<Control>().controller == 2f && AIPlayer.GetComponent<Country_AI>().PortugalWar == true || changeCountry0.GetComponent<Control>().controller == 3f && AIPlayer.GetComponent<Country_AI>().UKWar == true || changeCountry0.GetComponent<Control>().controller == 4f && AIPlayer.GetComponent<Country_AI>().CRWar == true || changeCountry0.GetComponent<Control>().controller == 5f && AIPlayer.GetComponent<Country_AI>().MoroccoWar == true || changeCountry0.GetComponent<Control>().controller == 6f && AIPlayer.GetComponent<Country_AI>().AlgeriaWar == true || changeCountry0.GetComponent<Control>().controller == 7f && AIPlayer.GetComponent<Country_AI>().TunisWar == true || changeCountry0.GetComponent<Control>().controller == 8f && AIPlayer.GetComponent<Country_AI>().SardWar == true || changeCountry0.GetComponent<Control>().controller == 9f && AIPlayer.GetComponent<Country_AI>().SicilyWar == true || changeCountry0.GetComponent<Control>().controller == 10f && AIPlayer.GetComponent<Country_AI>().NaplesWar == true || changeCountry0.GetComponent<Control>().controller == 11f && AIPlayer.GetComponent<Country_AI>().LuccaWar == true || changeCountry0.GetComponent<Control>().controller == 12f && AIPlayer.GetComponent<Country_AI>().ItalyWar == true || changeCountry0.GetComponent<Control>().controller == 13f && AIPlayer.GetComponent<Country_AI>().HelvetiaWar == true || changeCountry0.GetComponent<Control>().controller == 14f && AIPlayer.GetComponent<Country_AI>().AustrianWar == true || changeCountry0.GetComponent<Control>().controller == 15f && AIPlayer.GetComponent<Country_AI>().OttomanWar == true || changeCountry0.GetComponent<Control>().controller == 16f && AIPlayer.GetComponent<Country_AI>().MonteWar == true || changeCountry0.GetComponent<Control>().controller == 17f && AIPlayer.GetComponent<Country_AI>().PrussiaWar == true || changeCountry0.GetComponent<Control>().controller == 18f && AIPlayer.GetComponent<Country_AI>().WarsawWar == true || changeCountry0.GetComponent<Control>().controller == 19f && AIPlayer.GetComponent<Country_AI>().RussianWar == true || changeCountry0.GetComponent<Control>().controller == 20f && AIPlayer.GetComponent<Country_AI>().SwedenWar == true || changeCountry0.GetComponent<Control>().controller == 21f && AIPlayer.GetComponent<Country_AI>().NorwayWar == true)
            {
                changeCountry0.GetComponent<ColorC>().attackFlash = true;
                changeCountry0.GetComponent<ColorC>().wait = true;
            }
        }
        if (attackCountry1.gameObject.GetComponent<Control>().borderSpawn.Count >= 2)
        {
            changeCountry1 = attackCountry1.GetComponent<Control>().accountGame1;
            if (changeCountry1.GetComponent<Control>().controller == 0f && AIPlayer.GetComponent<Country_AI>().FranceWar == true || changeCountry1.GetComponent<Control>().controller == 1f && AIPlayer.GetComponent<Country_AI>().SpainWar == true || changeCountry1.GetComponent<Control>().controller == 2f && AIPlayer.GetComponent<Country_AI>().PortugalWar == true || changeCountry1.GetComponent<Control>().controller == 3f && AIPlayer.GetComponent<Country_AI>().UKWar == true || changeCountry1.GetComponent<Control>().controller == 4f && AIPlayer.GetComponent<Country_AI>().CRWar == true || changeCountry1.GetComponent<Control>().controller == 5f && AIPlayer.GetComponent<Country_AI>().MoroccoWar == true || changeCountry1.GetComponent<Control>().controller == 6f && AIPlayer.GetComponent<Country_AI>().AlgeriaWar == true || changeCountry1.GetComponent<Control>().controller == 7f && AIPlayer.GetComponent<Country_AI>().TunisWar == true || changeCountry1.GetComponent<Control>().controller == 8f && AIPlayer.GetComponent<Country_AI>().SardWar == true || changeCountry1.GetComponent<Control>().controller == 9f && AIPlayer.GetComponent<Country_AI>().SicilyWar == true || changeCountry1.GetComponent<Control>().controller == 10f && AIPlayer.GetComponent<Country_AI>().NaplesWar == true || changeCountry1.GetComponent<Control>().controller == 11f && AIPlayer.GetComponent<Country_AI>().LuccaWar == true || changeCountry1.GetComponent<Control>().controller == 12f && AIPlayer.GetComponent<Country_AI>().ItalyWar == true || changeCountry1.GetComponent<Control>().controller == 13f && AIPlayer.GetComponent<Country_AI>().HelvetiaWar == true || changeCountry1.GetComponent<Control>().controller == 14f && AIPlayer.GetComponent<Country_AI>().AustrianWar == true || changeCountry1.GetComponent<Control>().controller == 15f && AIPlayer.GetComponent<Country_AI>().OttomanWar == true || changeCountry1.GetComponent<Control>().controller == 16f && AIPlayer.GetComponent<Country_AI>().MonteWar == true || changeCountry1.GetComponent<Control>().controller == 17f && AIPlayer.GetComponent<Country_AI>().PrussiaWar == true || changeCountry1.GetComponent<Control>().controller == 18f && AIPlayer.GetComponent<Country_AI>().WarsawWar == true || changeCountry1.GetComponent<Control>().controller == 19f && AIPlayer.GetComponent<Country_AI>().RussianWar == true || changeCountry1.GetComponent<Control>().controller == 20f && AIPlayer.GetComponent<Country_AI>().SwedenWar == true || changeCountry1.GetComponent<Control>().controller == 21f && AIPlayer.GetComponent<Country_AI>().NorwayWar == true)
            {
                changeCountry1.GetComponent<ColorC>().attackFlash = true;
                changeCountry1.GetComponent<ColorC>().wait = true;
            }
        }
        if (attackCountry1.gameObject.GetComponent<Control>().borderSpawn.Count >= 3)
        {
            changeCountry2 = attackCountry1.GetComponent<Control>().accountGame2;
            if (changeCountry2.GetComponent<Control>().controller == 0f && AIPlayer.GetComponent<Country_AI>().FranceWar == true || changeCountry2.GetComponent<Control>().controller == 1f && AIPlayer.GetComponent<Country_AI>().SpainWar == true || changeCountry2.GetComponent<Control>().controller == 2f && AIPlayer.GetComponent<Country_AI>().PortugalWar == true || changeCountry2.GetComponent<Control>().controller == 3f && AIPlayer.GetComponent<Country_AI>().UKWar == true || changeCountry2.GetComponent<Control>().controller == 4f && AIPlayer.GetComponent<Country_AI>().CRWar == true || changeCountry2.GetComponent<Control>().controller == 5f && AIPlayer.GetComponent<Country_AI>().MoroccoWar == true || changeCountry2.GetComponent<Control>().controller == 6f && AIPlayer.GetComponent<Country_AI>().AlgeriaWar == true || changeCountry2.GetComponent<Control>().controller == 7f && AIPlayer.GetComponent<Country_AI>().TunisWar == true || changeCountry2.GetComponent<Control>().controller == 8f && AIPlayer.GetComponent<Country_AI>().SardWar == true || changeCountry2.GetComponent<Control>().controller == 9f && AIPlayer.GetComponent<Country_AI>().SicilyWar == true || changeCountry2.GetComponent<Control>().controller == 10f && AIPlayer.GetComponent<Country_AI>().NaplesWar == true || changeCountry2.GetComponent<Control>().controller == 11f && AIPlayer.GetComponent<Country_AI>().LuccaWar == true || changeCountry2.GetComponent<Control>().controller == 12f && AIPlayer.GetComponent<Country_AI>().ItalyWar == true || changeCountry2.GetComponent<Control>().controller == 13f && AIPlayer.GetComponent<Country_AI>().HelvetiaWar == true || changeCountry2.GetComponent<Control>().controller == 14f && AIPlayer.GetComponent<Country_AI>().AustrianWar == true || changeCountry2.GetComponent<Control>().controller == 15f && AIPlayer.GetComponent<Country_AI>().OttomanWar == true || changeCountry2.GetComponent<Control>().controller == 16f && AIPlayer.GetComponent<Country_AI>().MonteWar == true || changeCountry2.GetComponent<Control>().controller == 17f && AIPlayer.GetComponent<Country_AI>().PrussiaWar == true || changeCountry2.GetComponent<Control>().controller == 18f && AIPlayer.GetComponent<Country_AI>().WarsawWar == true || changeCountry2.GetComponent<Control>().controller == 19f && AIPlayer.GetComponent<Country_AI>().RussianWar == true || changeCountry2.GetComponent<Control>().controller == 20f && AIPlayer.GetComponent<Country_AI>().SwedenWar == true || changeCountry2.GetComponent<Control>().controller == 21f && AIPlayer.GetComponent<Country_AI>().NorwayWar == true)
            {
                changeCountry2.GetComponent<ColorC>().attackFlash = true;
                changeCountry2.GetComponent<ColorC>().wait = true;
            }
        }
        if (attackCountry1.gameObject.GetComponent<Control>().borderSpawn.Count >= 4)
        {
            changeCountry3 = attackCountry1.GetComponent<Control>().accountGame3;
            if (changeCountry3.GetComponent<Control>().controller == 0f && AIPlayer.GetComponent<Country_AI>().FranceWar == true || changeCountry3.GetComponent<Control>().controller == 1f && AIPlayer.GetComponent<Country_AI>().SpainWar == true || changeCountry3.GetComponent<Control>().controller == 2f && AIPlayer.GetComponent<Country_AI>().PortugalWar == true || changeCountry3.GetComponent<Control>().controller == 3f && AIPlayer.GetComponent<Country_AI>().UKWar == true || changeCountry3.GetComponent<Control>().controller == 4f && AIPlayer.GetComponent<Country_AI>().CRWar == true || changeCountry3.GetComponent<Control>().controller == 5f && AIPlayer.GetComponent<Country_AI>().MoroccoWar == true || changeCountry3.GetComponent<Control>().controller == 6f && AIPlayer.GetComponent<Country_AI>().AlgeriaWar == true || changeCountry3.GetComponent<Control>().controller == 7f && AIPlayer.GetComponent<Country_AI>().TunisWar == true || changeCountry3.GetComponent<Control>().controller == 8f && AIPlayer.GetComponent<Country_AI>().SardWar == true || changeCountry3.GetComponent<Control>().controller == 9f && AIPlayer.GetComponent<Country_AI>().SicilyWar == true || changeCountry3.GetComponent<Control>().controller == 10f && AIPlayer.GetComponent<Country_AI>().NaplesWar == true || changeCountry3.GetComponent<Control>().controller == 11f && AIPlayer.GetComponent<Country_AI>().LuccaWar == true || changeCountry3.GetComponent<Control>().controller == 12f && AIPlayer.GetComponent<Country_AI>().ItalyWar == true || changeCountry3.GetComponent<Control>().controller == 13f && AIPlayer.GetComponent<Country_AI>().HelvetiaWar == true || changeCountry3.GetComponent<Control>().controller == 14f && AIPlayer.GetComponent<Country_AI>().AustrianWar == true || changeCountry3.GetComponent<Control>().controller == 15f && AIPlayer.GetComponent<Country_AI>().OttomanWar == true || changeCountry3.GetComponent<Control>().controller == 16f && AIPlayer.GetComponent<Country_AI>().MonteWar == true || changeCountry3.GetComponent<Control>().controller == 17f && AIPlayer.GetComponent<Country_AI>().PrussiaWar == true || changeCountry3.GetComponent<Control>().controller == 18f && AIPlayer.GetComponent<Country_AI>().WarsawWar == true || changeCountry3.GetComponent<Control>().controller == 19f && AIPlayer.GetComponent<Country_AI>().RussianWar == true || changeCountry3.GetComponent<Control>().controller == 20f && AIPlayer.GetComponent<Country_AI>().SwedenWar == true || changeCountry3.GetComponent<Control>().controller == 21f && AIPlayer.GetComponent<Country_AI>().NorwayWar == true)
            {
                changeCountry3.GetComponent<ColorC>().attackFlash = true;
                changeCountry3.GetComponent<ColorC>().wait = true;
            }
        }
        if (attackCountry1.gameObject.GetComponent<Control>().borderSpawn.Count >= 5)
        {
            changeCountry4 = attackCountry1.GetComponent<Control>().accountGame4;
            if (changeCountry4.GetComponent<Control>().controller == 0f && AIPlayer.GetComponent<Country_AI>().FranceWar == true || changeCountry4.GetComponent<Control>().controller == 1f && AIPlayer.GetComponent<Country_AI>().SpainWar == true || changeCountry4.GetComponent<Control>().controller == 2f && AIPlayer.GetComponent<Country_AI>().PortugalWar == true || changeCountry4.GetComponent<Control>().controller == 3f && AIPlayer.GetComponent<Country_AI>().UKWar == true || changeCountry4.GetComponent<Control>().controller == 4f && AIPlayer.GetComponent<Country_AI>().CRWar == true || changeCountry4.GetComponent<Control>().controller == 5f && AIPlayer.GetComponent<Country_AI>().MoroccoWar == true || changeCountry4.GetComponent<Control>().controller == 6f && AIPlayer.GetComponent<Country_AI>().AlgeriaWar == true || changeCountry4.GetComponent<Control>().controller == 7f && AIPlayer.GetComponent<Country_AI>().TunisWar == true || changeCountry4.GetComponent<Control>().controller == 8f && AIPlayer.GetComponent<Country_AI>().SardWar == true || changeCountry4.GetComponent<Control>().controller == 9f && AIPlayer.GetComponent<Country_AI>().SicilyWar == true || changeCountry4.GetComponent<Control>().controller == 10f && AIPlayer.GetComponent<Country_AI>().NaplesWar == true || changeCountry4.GetComponent<Control>().controller == 11f && AIPlayer.GetComponent<Country_AI>().LuccaWar == true || changeCountry4.GetComponent<Control>().controller == 12f && AIPlayer.GetComponent<Country_AI>().ItalyWar == true || changeCountry4.GetComponent<Control>().controller == 13f && AIPlayer.GetComponent<Country_AI>().HelvetiaWar == true || changeCountry4.GetComponent<Control>().controller == 14f && AIPlayer.GetComponent<Country_AI>().AustrianWar == true || changeCountry4.GetComponent<Control>().controller == 15f && AIPlayer.GetComponent<Country_AI>().OttomanWar == true || changeCountry4.GetComponent<Control>().controller == 16f && AIPlayer.GetComponent<Country_AI>().MonteWar == true || changeCountry4.GetComponent<Control>().controller == 17f && AIPlayer.GetComponent<Country_AI>().PrussiaWar == true || changeCountry4.GetComponent<Control>().controller == 18f && AIPlayer.GetComponent<Country_AI>().WarsawWar == true || changeCountry4.GetComponent<Control>().controller == 19f && AIPlayer.GetComponent<Country_AI>().RussianWar == true || changeCountry4.GetComponent<Control>().controller == 20f && AIPlayer.GetComponent<Country_AI>().SwedenWar == true || changeCountry4.GetComponent<Control>().controller == 21f && AIPlayer.GetComponent<Country_AI>().NorwayWar == true)
            {
                changeCountry4.GetComponent<ColorC>().attackFlash = true;
                changeCountry4.GetComponent<ColorC>().wait = true;
            }
        }
    }
    void AttackFlashFalse()
    {
        if (attackCountry1.gameObject.GetComponent<Control>().borderSpawn.Count >= 1)
        {
            changeCountry0 = attackCountry1.GetComponent<Control>().accountGame0;
            changeCountry0.GetComponent<ColorC>().attackFlash = false;
            changeCountry0.GetComponent<ColorC>().wait = false;
        }
        if (attackCountry1.gameObject.GetComponent<Control>().borderSpawn.Count >= 2)
        {
            changeCountry1 = attackCountry1.GetComponent<Control>().accountGame1;
            changeCountry1.GetComponent<ColorC>().attackFlash = false;
            changeCountry1.GetComponent<ColorC>().wait = false;
        }
        if (attackCountry1.gameObject.GetComponent<Control>().borderSpawn.Count >= 3)
        {
            changeCountry2 = attackCountry1.GetComponent<Control>().accountGame2;
            changeCountry2.GetComponent<ColorC>().attackFlash = false;
            changeCountry2.GetComponent<ColorC>().wait = false;
        }
        if (attackCountry1.gameObject.GetComponent<Control>().borderSpawn.Count >= 4)
        {
            changeCountry3 = attackCountry1.GetComponent<Control>().accountGame3;
            changeCountry3.GetComponent<ColorC>().attackFlash = false;
            changeCountry3.GetComponent<ColorC>().wait = false;
        }
        if (attackCountry1.gameObject.GetComponent<Control>().borderSpawn.Count >= 5)
        {
            changeCountry4 = attackCountry1.GetComponent<Control>().accountGame4;
            changeCountry4.GetComponent<ColorC>().attackFlash = false;
            changeCountry4.GetComponent<ColorC>().wait = false;
        }
    }

    void PlayerAttack()
    {
        attackCountry1 = GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry1;
        attackCountry2 = GameObject.Find("Main Camera").GetComponent<ArmyUI>().touchCountry2;
        Debug.Log(attackCountry2);
        Debug.Log("got country");

        if (attackCountry2 != GameObject.Find("information"))
        {
            if (attackCountry1.GetComponent<Control>().attackPower > attackCountry2.GetComponent<Control>().defensePower)
            {
                Debug.Log("attacking" + attackCountry1 + attackCountry2);
                attackCountry2.GetComponent<Control>().controller = attackCountry1.GetComponent<Control>().controller;
                attackCountry2.GetComponent<Control>().ControlChange();

                attackCountry2.GetComponent<Control>().cavalry = 0f;
                attackCountry2.GetComponent<Control>().cavalry += attackCountry1.GetComponent<Control>().cavalry * .9f;
                attackCountry1.GetComponent<Control>().cavalry = attackCountry1.GetComponent<Control>().cavalry * .1f;
                attackCountry2.GetComponent<Control>().cavalry = Mathf.Round(attackCountry2.GetComponent<Control>().cavalry);
                attackCountry1.GetComponent<Control>().cavalry = Mathf.Round(attackCountry1.GetComponent<Control>().cavalry);
                attackCountry2.GetComponent<Control>().infantry = 0f;
                attackCountry2.GetComponent<Control>().infantry += attackCountry1.GetComponent<Control>().infantry * .9f;
                attackCountry1.GetComponent<Control>().infantry = attackCountry1.GetComponent<Control>().infantry * .1f;
                attackCountry2.GetComponent<Control>().infantry = Mathf.Round(attackCountry2.GetComponent<Control>().infantry);
                attackCountry1.GetComponent<Control>().infantry = Mathf.Round(attackCountry1.GetComponent<Control>().infantry);
                attackCountry2.GetComponent<Control>().artillery = 0f;
                attackCountry2.GetComponent<Control>().artillery += attackCountry1.GetComponent<Control>().artillery * .9f;
                attackCountry1.GetComponent<Control>().artillery = attackCountry1.GetComponent<Control>().artillery * .1f;
                attackCountry2.GetComponent<Control>().artillery = Mathf.Round(attackCountry2.GetComponent<Control>().artillery);
                attackCountry1.GetComponent<Control>().artillery = Mathf.Round(attackCountry1.GetComponent<Control>().artillery);
            }
            if (attackCountry1.GetComponent<Control>().attackPower <= attackCountry2.GetComponent<Control>().defensePower)
            {
                ten1Loss = attackCountry1.GetComponent<Control>().cavalry * 0.3f;
                ten2Loss = attackCountry2.GetComponent<Control>().cavalry * 0.1f;
                float LossC1 = Random.Range(0, ten1Loss);
                float LossC2 = Random.Range(0, ten2Loss);
                LossC1 = Mathf.Round(LossC1);
                LossC2 = Mathf.Round(LossC2);
                attackCountry1.GetComponent<Control>().cavalry -= LossC1;
                attackCountry2.GetComponent<Control>().cavalry -= LossC2;

                ten1Loss = attackCountry1.GetComponent<Control>().infantry * 0.3f;
                ten2Loss = attackCountry2.GetComponent<Control>().infantry * 0.1f;
                float LossI1 = Random.Range(0, ten1Loss);
                float LossI2 = Random.Range(0, ten2Loss);
                LossI1 = Mathf.Round(LossI1);
                LossI2 = Mathf.Round(LossI2);
                attackCountry1.GetComponent<Control>().infantry -= LossI1;
                attackCountry2.GetComponent<Control>().infantry -= LossI2;

                ten1Loss = attackCountry1.GetComponent<Control>().artillery * 0.3f;
                ten2Loss = attackCountry2.GetComponent<Control>().artillery * 0.1f;
                float LossA1 = Random.Range(0, ten1Loss);
                float LossA2 = Random.Range(0, ten2Loss);
                LossA1 = Mathf.Round(LossA1);
                LossA2 = Mathf.Round(LossA2);
                attackCountry1.GetComponent<Control>().artillery -= LossA1;
                attackCountry2.GetComponent<Control>().artillery -= LossA2;
            }
        }
        else
        {
            //show that they need to pick neighboring nations
        }

        AttackFlashFalse();
        GameObject.Find("information").GetComponent<countries>().countryTurn += 1f;
        GameObject.Find("Main Camera").GetComponent<ArmyUI>().touched = false;
        GameObject.Find("Main Camera").GetComponent<ArmyUI>().DisableButton();
    }

    void AIAttack()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == GameObject.Find("information").GetComponent<countries>().countryTurn)
            {
                AICountry = targetAI;
            }
        }
        attackCountry1 = AICountry.GetComponent<Country_AI>().attackCountryAI1;
        attackCountry2 = AICountry.GetComponent<Country_AI>().attackCountryAI2;

        if (attackCountry2 != GameObject.Find("information"))
        {
            if (attackCountry1.GetComponent<Control>().attackPower >= attackCountry2.GetComponent<Control>().defensePower)
            {
                Debug.Log("attacking");
                attackCountry2.GetComponent<Control>().controller = attackCountry1.GetComponent<Control>().controller;
                attackCountry2.GetComponent<Control>().ControlChange();

                attackCountry2.GetComponent<Control>().cavalry = 0f;
                attackCountry2.GetComponent<Control>().cavalry += attackCountry1.GetComponent<Control>().cavalry * .9f;
                attackCountry1.GetComponent<Control>().cavalry = attackCountry1.GetComponent<Control>().cavalry * .1f;
                attackCountry2.GetComponent<Control>().cavalry = Mathf.Round(attackCountry2.GetComponent<Control>().cavalry);
                attackCountry1.GetComponent<Control>().cavalry = Mathf.Round(attackCountry1.GetComponent<Control>().cavalry);
                attackCountry2.GetComponent<Control>().infantry = 0f;
                attackCountry2.GetComponent<Control>().infantry += attackCountry1.GetComponent<Control>().infantry * .9f;
                attackCountry1.GetComponent<Control>().infantry = attackCountry1.GetComponent<Control>().infantry * .1f;
                attackCountry2.GetComponent<Control>().infantry = Mathf.Round(attackCountry2.GetComponent<Control>().infantry);
                attackCountry1.GetComponent<Control>().infantry = Mathf.Round(attackCountry1.GetComponent<Control>().infantry);
                attackCountry2.GetComponent<Control>().artillery = 0f;
                attackCountry2.GetComponent<Control>().artillery += attackCountry1.GetComponent<Control>().artillery * .9f;
                attackCountry1.GetComponent<Control>().artillery = attackCountry1.GetComponent<Control>().artillery * .1f;
                attackCountry2.GetComponent<Control>().artillery = Mathf.Round(attackCountry2.GetComponent<Control>().artillery);
                attackCountry1.GetComponent<Control>().artillery = Mathf.Round(attackCountry1.GetComponent<Control>().artillery);

                foreach (GameObject warObject in GameObject.FindGameObjectsWithTag("war"))
                {
                    warCountry1 = warObject.GetComponent<WarSystem>().WarCountry1;
                    warCountry2 = warObject.GetComponent<WarSystem>().WarCountry2;
                    if (warCountry1.GetComponent<Country_AI>().CountryType == attackCountry1.GetComponent<Control>().controller && warCountry2.GetComponent<Country_AI>().CountryType == attackCountry2.GetComponent<Control>().controller || warCountry2.GetComponent<Country_AI>().CountryType == attackCountry1.GetComponent<Control>().controller && warCountry1.GetComponent<Country_AI>().CountryType == attackCountry2.GetComponent<Control>().controller)
                    {
                        warObject.GetComponent<WarSystem>().points += 34f;
                    }
                }
            }
            if (attackCountry1.GetComponent<Control>().attackPower <= attackCountry2.GetComponent<Control>().defensePower)
            {
                ten1Loss = attackCountry1.GetComponent<Control>().cavalry * 0.3f;
                ten2Loss = attackCountry2.GetComponent<Control>().cavalry * 0.1f;
                float LossC1 = Random.Range(0, ten1Loss);
                float LossC2 = Random.Range(0, ten2Loss);
                LossC1 = Mathf.Round(LossC1);
                LossC2 = Mathf.Round(LossC2);
                attackCountry1.GetComponent<Control>().cavalry -= LossC1;
                attackCountry2.GetComponent<Control>().cavalry -= LossC2;

                ten1Loss = attackCountry1.GetComponent<Control>().infantry * 0.3f;
                ten2Loss = attackCountry2.GetComponent<Control>().infantry * 0.1f;
                float LossI1 = Random.Range(0, ten1Loss);
                float LossI2 = Random.Range(0, ten2Loss);
                LossI1 = Mathf.Round(LossI1);
                LossI2 = Mathf.Round(LossI2);
                attackCountry1.GetComponent<Control>().infantry -= LossI1;
                attackCountry2.GetComponent<Control>().infantry -= LossI2;

                ten1Loss = attackCountry1.GetComponent<Control>().artillery * 0.3f;
                ten2Loss = attackCountry2.GetComponent<Control>().artillery * 0.1f;
                float LossA1 = Random.Range(0, ten1Loss);
                float LossA2 = Random.Range(0, ten2Loss);
                LossA1 = Mathf.Round(LossA1);
                LossA2 = Mathf.Round(LossA2);
                attackCountry1.GetComponent<Control>().artillery -= LossA1;
                attackCountry2.GetComponent<Control>().artillery -= LossA2;

                foreach (GameObject warObject in GameObject.FindGameObjectsWithTag("war"))
                {
                    warCountry1 = warObject.GetComponent<WarSystem>().WarCountry1;
                    warCountry2 = warObject.GetComponent<WarSystem>().WarCountry2;
                    if (warCountry1.GetComponent<Country_AI>().CountryType == attackCountry1.GetComponent<Control>().controller && warCountry2.GetComponent<Country_AI>().CountryType == attackCountry2.GetComponent<Control>().controller || warCountry2.GetComponent<Country_AI>().CountryType == attackCountry1.GetComponent<Control>().controller && warCountry1.GetComponent<Country_AI>().CountryType == attackCountry2.GetComponent<Control>().controller)
                    {
                        warObject.GetComponent<WarSystem>().points += 10f;
                    }
                }
            }
        }
    }
}