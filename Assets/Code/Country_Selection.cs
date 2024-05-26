using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country_Selection : MonoBehaviour
{
    public bool easy;
    public bool normal;
    public bool hard;

    public GameObject countryUI;
    public GameObject difficultyUI;
    public GameObject mapUI;

    public void SetFranceCountry()
    {
        PlayerPrefs.SetFloat("Player", 0f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetSpainCountry()
    {
        PlayerPrefs.SetFloat("Player", 1f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetPortugalCountry()
    {
        PlayerPrefs.SetFloat("Player", 2f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetUKCountry()
    {
        PlayerPrefs.SetFloat("Player", 3f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetCRCountry()
    {
        PlayerPrefs.SetFloat("Player", 4f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetMoroccoCountry()
    {
        PlayerPrefs.SetFloat("Player", 5f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetAlgeriaCountry()
    {
        PlayerPrefs.SetFloat("Player", 6f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetTunisCountry()
    {
        PlayerPrefs.SetFloat("Player", 7f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetSardCountry()
    {
        PlayerPrefs.SetFloat("Player", 8f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetSicilyCountry()
    {
        PlayerPrefs.SetFloat("Player", 9f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetNaplesCountry()
    {
        PlayerPrefs.SetFloat("Player", 10f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetLuccaCountry()
    {
        PlayerPrefs.SetFloat("Player", 11f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetItalyCountry()
    {
        PlayerPrefs.SetFloat("Player", 12f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetHelvetiaCountry()
    {
        PlayerPrefs.SetFloat("Player", 13f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetAustrianCountry()
    {
        PlayerPrefs.SetFloat("Player", 14f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetOttomanCountry()
    {
        PlayerPrefs.SetFloat("Player", 15f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetMonteCountry()
    {
        PlayerPrefs.SetFloat("Player", 16f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetPrussiaCountry()
    {
        PlayerPrefs.SetFloat("Player", 17f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetWarsawCountry()
    {
        PlayerPrefs.SetFloat("Player", 18f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetRussianCountry()
    {
        PlayerPrefs.SetFloat("Player", 19f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetSwedenCountry()
    {
        PlayerPrefs.SetFloat("Player", 20f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }
    public void SetNorwayCountry()
    {
        PlayerPrefs.SetFloat("Player", 21f);
        countryUI.SetActive(false);
        difficultyUI.SetActive(true);
    }

    public void SetEasy()
    {
        easy = true;
        normal = false;
        hard = false;
        PlayerPrefs.SetInt("easy", easy ? 1 : 0);
        PlayerPrefs.SetInt("normal", normal ? 1 : 0);
        PlayerPrefs.SetInt("hard", hard ? 1 : 0);
    }
    public void SetNormal()
    {
        easy = false;
        normal = true;
        hard = false;
        PlayerPrefs.SetInt("easy", easy ? 1 : 0);
        PlayerPrefs.SetInt("normal", normal ? 1 : 0);
        PlayerPrefs.SetInt("hard", hard ? 1 : 0);
    }
    public void SetHard()
    {
        easy = false;
        normal = false;
        hard = true;
        PlayerPrefs.SetInt("easy", easy ? 1 : 0);
        PlayerPrefs.SetInt("normal", normal ? 1 : 0);
        PlayerPrefs.SetInt("hard", hard ? 1 : 0);
    }

    public void OnMap()
    {
        countryUI.SetActive(false);
        mapUI.SetActive(true);
    }
    public void OffMap()
    {
        countryUI.SetActive(true);
        mapUI.SetActive(false);
    }
}