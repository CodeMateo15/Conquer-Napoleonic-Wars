using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorC : MonoBehaviour
{
    public float occupy;
    private SpriteRenderer sprite;
    private RawImage rawImage;

    public bool message;

    private bool highlight;
    public bool attackFlash;
    public bool wait;

    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        if (message == true)
        {
            rawImage = GetComponent<RawImage>();
        }
        highlight = false;
        attackFlash = false;
    }

    void Update()
    {
        if (message == false)
        {
            occupy = GetComponent<Control>().controller;
        }

        if (GameObject.Find("information").GetComponent<countries>().simpleColor == true && message == false)
        {
            if (attackFlash == true)
            {
                if (wait == true)
                {
                    StartCoroutine(AttackFlashing()); //fix this code to match
                    attackFlash = false;
                }
                if (wait == false)
                {
                    attackFlash = false;
                }
            }
            if (attackFlash == false)
            {
                if (wait == false)
                {
                    if (highlight == false)
                    {
                        AllianceColorOff();
                    }
                    if (highlight == true)
                    {
                        AllianceColorOn();
                    }
                }
            }
        }
        if (GameObject.Find("information").GetComponent<countries>().simpleColor == false && message == false)
        {
            if (attackFlash == true)
            {
                if (wait == true)
                {
                    StartCoroutine(AttackFlashing());
                    attackFlash = false;
                }
                if (wait == false)
                {
                    attackFlash = false;
                }
            }
            if (attackFlash == false)
            {
                if (wait == false)
                {
                    if (highlight == false)
                    {
                        HighlightOff();
                    }
                    if (highlight == true)
                    {
                        HighlightOn();
                    }
                }
            }
        }
        if (message == true)
        {
            if (attackFlash == true)
            {
                StartCoroutine(AttackFlashing());
                attackFlash = false;
            }
        }
    }

    //enter mouse, highlights...exit mouse, stops highlights
    void OnMouseEnter()
    {
        highlight = true;
    }
    void OnMouseExit()
    {
        highlight = false;
    }

    void HighlightOn()
    {
        if (occupy == 0f)
        {
            sprite.color = new Color(0.990566f, 0.855064f, 0.855064f, 1);
        }
        if (occupy == 1f)
        {
            sprite.color = new Color(0.4669811f, 1, 0.6927302f, 1);
        }
        if (occupy == 2f)
        {
            sprite.color = new Color(0.9607736f, 1, 0.5330188f, 1);
        }
        if (occupy == 3f)
        {
            sprite.color = new Color(1, .5f, .5f, 1);
        }
        if (occupy == 4f)
        {
            sprite.color = new Color(0.3329477f, 0.5471698f, 0.3431487f, 1);
        }
        if (occupy == 5f)
        {
            sprite.color = new Color(0.6434737f, 0.2843539f, 0.8490566f, 1);
        }
        if (occupy == 6f)
        {
            sprite.color = new Color(0.6886792f, 0.6886792f, 0.6886792f, 1);
        }
        if (occupy == 7f)
        {
            sprite.color = new Color(0.1864098f, 0.295175f, 0.6698113f, 1);
        }
        if (occupy == 8f)
        {
            sprite.color = new Color(0.8207547f, 0.8054577f, 0.7162246f, 1);
        }
        if (occupy == 9f)
        {
            sprite.color = new Color(0.8245181f, 0.7164471f, 0.9433962f, 1);
        }
        if (occupy == 10f)
        {
            sprite.color = new Color(0.9056604f, 0.5767177f, 0.5852249f, 1);
        }
        if (occupy == 11f)
        {
            sprite.color = new Color(0.8490566f, 0.6608223f, 0.8191503f, 1);
        }
        if (occupy == 12f)
        {
            sprite.color = new Color(0.8584906f, 0.5952742f, 0.8584906f, 1);
        }
        if (occupy == 13f)
        {
            sprite.color = new Color(0.5087572f, 0.6603774f, 0.1588643f, 1);
        }
        if (occupy == 14f)
        {
            sprite.color = new Color(0.7981829f, 0.5990566f, 1, 1);
        }
        if (occupy == 15f)
        {
            sprite.color = new Color(0.5639611f, 0.5660378f, 0.509968f, 1);
        }
        if (occupy == 16f)
        {
            sprite.color = new Color(0.6509434f, 0.4176466f, 0.2671325f, 1);
        }
        if (occupy == 17f)
        {
            sprite.color = new Color(0.9716981f, 0.6846793f, 0.5271004f, 1);
        }
        if (occupy == 18f)
        {
            sprite.color = new Color(1, 0.9559748f, 0.5990566f, 1);
        }
        if (occupy == 19f)
        {
            sprite.color = new Color(0.4716981f, 0.2825739f, 0.4588761f, 1);
        }
        if (occupy == 20f)
        {
            sprite.color = new Color(0.6807737f, 0.6093805f, 0.7735849f, 1);
        }
        if (occupy == 21f)
        {
            sprite.color = new Color(0.3821645f, 0.5160912f, 0.7169812f, 1);
        }
        if (message == true)
        {
            rawImage.color = new Color(0.5566038f, 0.3871485f, 0.3871485f, 1f);
        }
    }

    void HighlightOff()
    {
        if (occupy == 0f)
        {
            sprite.color = new Color(1f, 1f, 1, 1);
        }
        if (occupy == 1f)
        {
            sprite.color = new Color(0, 1, 0.4156f, 1);
        }
        if (occupy == 2f)
        {
            sprite.color = new Color(0.8980f, 0.9803f, 0, 1);
        }
        if (occupy == 3f)
        {
            sprite.color = new Color(1f, 0, 0, 1);
        }
        if (occupy == 4f)
        {
            sprite.color = new Color(0, 0.4941177f, 0.02352941f, 1);
        }
        if (occupy == 5f)
        {
            sprite.color = new Color(0.5411765f, 0f, 0.8509805f, 1);
        }
        if (occupy == 6f)
        {
            sprite.color = new Color(0.5803922f, 0.6666667f, 0.6509804f, 1);
        }
        if (occupy == 7f)
        {
            sprite.color = new Color(0.03921569f, 0.1803922f, 0.6666667f, 1);
        }
        if (occupy == 8f)
        {
            sprite.color = new Color(0.7529413f, 0.7058824f, 0.4313726f, 1);
        }
        if (occupy == 9f)
        {
            sprite.color = new Color(0.7568628f, 0.6f, 0.9294118f, 1);
        }
        if (occupy == 10f)
        {
            sprite.color = new Color(0.8980392f, 0.4431373f, 0.454902f, 1);
        }
        if (occupy == 11f)
        {
            sprite.color = new Color(0.8392158f, 0.4196079f, 0.7725491f, 1);
        }
        if (occupy == 12f)
        {
            sprite.color = new Color(0.8980393f, 0f, 0.8980393f, 1);
        }
        if (occupy == 13f)
        {
            sprite.color = new Color(0.6431373f, 0.8470589f, 0.172549f, 1);
        }
        if (occupy == 14f)
        {
            sprite.color = new Color(0.7058824f, 0.4156863f, 1, 1);
        }
        if (occupy == 15f)
        {
            sprite.color = new Color(0.4823529f, 0.4941176f, 0.1764706f, 1);
        }
        if (occupy == 16f)
        {
            sprite.color = new Color(0.6431373f, 0.2784314f, 0.04313726f, 1);
        }
        if (occupy == 17f)
        {
            sprite.color = new Color(1, 0.4f, 0.07058824f, 1);
        }
        if (occupy == 18f)
        {
            sprite.color = new Color(1, 0.8901961f, 0, 1);
        }
        if (occupy == 19f)
        {
            sprite.color = new Color(0.4f, 0, 0.3254902f, 1);
        }
        if (occupy == 20f)
        {
            sprite.color = new Color(0.5764706f, 0.4196078f, 0.7803922f, 1);
        }
        if (occupy == 21f)
        {
            sprite.color = new Color(0, 0.3137255f, 0.7843138f, 1);
        }
        if (message == true)
        {
            rawImage.color = new Color(0.5566038f, 0.5566038f, 0.5566038f, 1f);
        }
    }

    void AllianceColorOn()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == GameObject.Find("information").GetComponent<countries>().playerCountry)
            {
                if (occupy == 0f && targetAI.gameObject.GetComponent<Country_AI>().FranceWar == true) //enemy
                {
                    sprite.color = new Color(0.9811321f, 0.07592835f, 0, 1);
                }
                if (occupy == 0f && targetAI.gameObject.GetComponent<Country_AI>().FranceWar == false && targetAI.gameObject.GetComponent<Country_AI>().FranceOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.4188704f, 0.9339623f, 0.374466f, 1);
                }
                if (occupy == 0f && targetAI.gameObject.GetComponent<Country_AI>().FranceWar == false && targetAI.gameObject.GetComponent<Country_AI>().FranceOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4839356f, 0.6025867f, 0.7075472f, 1);
                }
                if (occupy == 0f && GameObject.Find("information").GetComponent<countries>().playerCountry == 0f) //player
                {
                    sprite.color = new Color(0.990566f, 0.855064f, 0.855064f, 1);
                }

                if (occupy == 1f && targetAI.gameObject.GetComponent<Country_AI>().SpainWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 1f && targetAI.gameObject.GetComponent<Country_AI>().SpainWar == false && targetAI.gameObject.GetComponent<Country_AI>().SpainOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 1f && targetAI.gameObject.GetComponent<Country_AI>().SpainWar == false && targetAI.gameObject.GetComponent<Country_AI>().SpainOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 1f && GameObject.Find("information").GetComponent<countries>().playerCountry == 1f) //player
                {
                    sprite.color = new Color(0.4669811f, 1, 0.6927302f, 1);
                }

                if (occupy == 2f && targetAI.gameObject.GetComponent<Country_AI>().PortugalWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 2f && targetAI.gameObject.GetComponent<Country_AI>().PortugalWar == false && targetAI.gameObject.GetComponent<Country_AI>().PortugalOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 2f && targetAI.gameObject.GetComponent<Country_AI>().PortugalWar == false && targetAI.gameObject.GetComponent<Country_AI>().PortugalOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 2f && GameObject.Find("information").GetComponent<countries>().playerCountry == 2f) //player
                {
                    sprite.color = new Color(0.9607736f, 1, 0.5330188f, 1);
                }

                if (occupy == 3f && targetAI.gameObject.GetComponent<Country_AI>().UKWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 3f && targetAI.gameObject.GetComponent<Country_AI>().UKWar == false && targetAI.gameObject.GetComponent<Country_AI>().UKOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 3f && targetAI.gameObject.GetComponent<Country_AI>().UKWar == false && targetAI.gameObject.GetComponent<Country_AI>().UKOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 3f && GameObject.Find("information").GetComponent<countries>().playerCountry == 3f) //player
                {
                    sprite.color = new Color(1, .5f, .5f, 1);
                }

                if (occupy == 4f && targetAI.gameObject.GetComponent<Country_AI>().CRWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 4f && targetAI.gameObject.GetComponent<Country_AI>().CRWar == false && targetAI.gameObject.GetComponent<Country_AI>().CROpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 4f && targetAI.gameObject.GetComponent<Country_AI>().CRWar == false && targetAI.gameObject.GetComponent<Country_AI>().CROpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 4f && GameObject.Find("information").GetComponent<countries>().playerCountry == 4f) //player
                {
                    sprite.color = new Color(0.3329477f, 0.5471698f, 0.3431487f, 1);
                }

                if (occupy == 5f && targetAI.gameObject.GetComponent<Country_AI>().MoroccoWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 5f && targetAI.gameObject.GetComponent<Country_AI>().MoroccoWar == false && targetAI.gameObject.GetComponent<Country_AI>().MoroccoOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 5f && targetAI.gameObject.GetComponent<Country_AI>().MoroccoWar == false && targetAI.gameObject.GetComponent<Country_AI>().MoroccoOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 5f && GameObject.Find("information").GetComponent<countries>().playerCountry == 5f) //player
                {
                    sprite.color = new Color(0.6434737f, 0.2843539f, 0.8490566f, 1);
                }

                if (occupy == 6f && targetAI.gameObject.GetComponent<Country_AI>().AlgeriaWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 6f && targetAI.gameObject.GetComponent<Country_AI>().AlgeriaWar == false && targetAI.gameObject.GetComponent<Country_AI>().AlgeriaOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 6f && targetAI.gameObject.GetComponent<Country_AI>().AlgeriaWar == false && targetAI.gameObject.GetComponent<Country_AI>().AlgeriaOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 6f && GameObject.Find("information").GetComponent<countries>().playerCountry == 6f) //player
                {
                    sprite.color = new Color(0.6886792f, 0.6886792f, 0.6886792f, 1);
                }

                if (occupy == 7f && targetAI.gameObject.GetComponent<Country_AI>().TunisWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 7f && targetAI.gameObject.GetComponent<Country_AI>().TunisWar == false && targetAI.gameObject.GetComponent<Country_AI>().TunisOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 7f && targetAI.gameObject.GetComponent<Country_AI>().TunisWar == false && targetAI.gameObject.GetComponent<Country_AI>().TunisOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 7f && GameObject.Find("information").GetComponent<countries>().playerCountry == 7f) //player
                {
                    sprite.color = new Color(0.1864098f, 0.295175f, 0.6698113f, 1);
                }

                if (occupy == 8f && targetAI.gameObject.GetComponent<Country_AI>().SardWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 8f && targetAI.gameObject.GetComponent<Country_AI>().SardWar == false && targetAI.gameObject.GetComponent<Country_AI>().SardOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 8f && targetAI.gameObject.GetComponent<Country_AI>().SardWar == false && targetAI.gameObject.GetComponent<Country_AI>().SardOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 8f && GameObject.Find("information").GetComponent<countries>().playerCountry == 8f) //player
                {
                    sprite.color = new Color(0.8207547f, 0.8054577f, 0.7162246f, 1);
                }

                if (occupy == 9f && targetAI.gameObject.GetComponent<Country_AI>().SicilyWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 9f && targetAI.gameObject.GetComponent<Country_AI>().SicilyWar == false && targetAI.gameObject.GetComponent<Country_AI>().SicilyOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 9f && targetAI.gameObject.GetComponent<Country_AI>().SicilyWar == false && targetAI.gameObject.GetComponent<Country_AI>().SicilyOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 9f && GameObject.Find("information").GetComponent<countries>().playerCountry == 9f) //player
                {
                    sprite.color = new Color(0.8245181f, 0.7164471f, 0.9433962f, 1);
                }

                if (occupy == 10f && targetAI.gameObject.GetComponent<Country_AI>().NaplesWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 10f && targetAI.gameObject.GetComponent<Country_AI>().NaplesWar == false && targetAI.gameObject.GetComponent<Country_AI>().NaplesOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 10f && targetAI.gameObject.GetComponent<Country_AI>().NaplesWar == false && targetAI.gameObject.GetComponent<Country_AI>().NaplesOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 10f && GameObject.Find("information").GetComponent<countries>().playerCountry == 10f) //player
                {
                    sprite.color = new Color(0.9056604f, 0.5767177f, 0.5852249f, 1);
                }

                if (occupy == 11f && targetAI.gameObject.GetComponent<Country_AI>().LuccaWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 11f && targetAI.gameObject.GetComponent<Country_AI>().LuccaWar == false && targetAI.gameObject.GetComponent<Country_AI>().LuccaOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 11f && targetAI.gameObject.GetComponent<Country_AI>().LuccaWar == false && targetAI.gameObject.GetComponent<Country_AI>().LuccaOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 11f && GameObject.Find("information").GetComponent<countries>().playerCountry == 11f) //player
                {
                    sprite.color = new Color(0.8490566f, 0.6608223f, 0.8191503f, 1);
                }

                if (occupy == 12f && targetAI.gameObject.GetComponent<Country_AI>().ItalyWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 12f && targetAI.gameObject.GetComponent<Country_AI>().ItalyWar == false && targetAI.gameObject.GetComponent<Country_AI>().ItalyOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 12f && targetAI.gameObject.GetComponent<Country_AI>().ItalyWar == false && targetAI.gameObject.GetComponent<Country_AI>().ItalyOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 12f && GameObject.Find("information").GetComponent<countries>().playerCountry == 12f) //player
                {
                    sprite.color = new Color(0.8584906f, 0.5952742f, 0.8584906f, 1);
                }

                if (occupy == 13f && targetAI.gameObject.GetComponent<Country_AI>().HelvetiaWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 13f && targetAI.gameObject.GetComponent<Country_AI>().HelvetiaWar == false && targetAI.gameObject.GetComponent<Country_AI>().HelvetiaOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 13f && targetAI.gameObject.GetComponent<Country_AI>().HelvetiaWar == false && targetAI.gameObject.GetComponent<Country_AI>().HelvetiaOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 13f && GameObject.Find("information").GetComponent<countries>().playerCountry == 13f) //player
                {
                    sprite.color = new Color(0.5087572f, 0.6603774f, 0.1588643f, 1);
                }

                if (occupy == 14f && targetAI.gameObject.GetComponent<Country_AI>().AustrianWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 14f && targetAI.gameObject.GetComponent<Country_AI>().AustrianWar == false && targetAI.gameObject.GetComponent<Country_AI>().AustrianOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 14f && targetAI.gameObject.GetComponent<Country_AI>().AustrianWar == false && targetAI.gameObject.GetComponent<Country_AI>().AustrianOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 14f && GameObject.Find("information").GetComponent<countries>().playerCountry == 14f) //player
                {
                    sprite.color = new Color(0.7981829f, 0.5990566f, 1, 1);
                }

                if (occupy == 15f && targetAI.gameObject.GetComponent<Country_AI>().OttomanWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 15f && targetAI.gameObject.GetComponent<Country_AI>().OttomanWar == false && targetAI.gameObject.GetComponent<Country_AI>().OttomanOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 15f && targetAI.gameObject.GetComponent<Country_AI>().OttomanWar == false && targetAI.gameObject.GetComponent<Country_AI>().OttomanOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 15f && GameObject.Find("information").GetComponent<countries>().playerCountry == 15f) //player
                {
                    sprite.color = new Color(0.5639611f, 0.5660378f, 0.509968f, 1);
                }

                if (occupy == 16f && targetAI.gameObject.GetComponent<Country_AI>().MonteWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 16f && targetAI.gameObject.GetComponent<Country_AI>().MonteWar == false && targetAI.gameObject.GetComponent<Country_AI>().MonteOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 16f && targetAI.gameObject.GetComponent<Country_AI>().MonteWar == false && targetAI.gameObject.GetComponent<Country_AI>().MonteOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 16f && GameObject.Find("information").GetComponent<countries>().playerCountry == 16f) //player
                {
                    sprite.color = new Color(0.6509434f, 0.4176466f, 0.2671325f, 1);
                }

                if (occupy == 17f && targetAI.gameObject.GetComponent<Country_AI>().PrussiaWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 17f && targetAI.gameObject.GetComponent<Country_AI>().PrussiaWar == false && targetAI.gameObject.GetComponent<Country_AI>().PrussiaOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 17f && targetAI.gameObject.GetComponent<Country_AI>().PrussiaWar == false && targetAI.gameObject.GetComponent<Country_AI>().PrussiaOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 17f && GameObject.Find("information").GetComponent<countries>().playerCountry == 17f) //player
                {
                    sprite.color = new Color(0.9716981f, 0.6846793f, 0.5271004f, 1);
                }

                if (occupy == 18f && targetAI.gameObject.GetComponent<Country_AI>().WarsawWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 18f && targetAI.gameObject.GetComponent<Country_AI>().WarsawWar == false && targetAI.gameObject.GetComponent<Country_AI>().WarsawOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 18f && targetAI.gameObject.GetComponent<Country_AI>().WarsawWar == false && targetAI.gameObject.GetComponent<Country_AI>().WarsawOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 18f && GameObject.Find("information").GetComponent<countries>().playerCountry == 18f) //player
                {
                    sprite.color = new Color(1, 0.9559748f, 0.5990566f, 1);
                }

                if (occupy == 19f && targetAI.gameObject.GetComponent<Country_AI>().RussianWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 19f && targetAI.gameObject.GetComponent<Country_AI>().RussianWar == false && targetAI.gameObject.GetComponent<Country_AI>().RussianOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 19f && targetAI.gameObject.GetComponent<Country_AI>().RussianWar == false && targetAI.gameObject.GetComponent<Country_AI>().RussianOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 19f && GameObject.Find("information").GetComponent<countries>().playerCountry == 19f) //player
                {
                    sprite.color = new Color(0.4716981f, 0.2825739f, 0.4588761f, 1);
                }

                if (occupy == 20f && targetAI.gameObject.GetComponent<Country_AI>().SwedenWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 20f && targetAI.gameObject.GetComponent<Country_AI>().SwedenWar == false && targetAI.gameObject.GetComponent<Country_AI>().SwedenOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 20f && targetAI.gameObject.GetComponent<Country_AI>().SwedenWar == false && targetAI.gameObject.GetComponent<Country_AI>().SwedenOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 20f && GameObject.Find("information").GetComponent<countries>().playerCountry == 20f) //player
                {
                    sprite.color = new Color(0.6807737f, 0.6093805f, 0.7735849f, 1);
                }

                if (occupy == 21f && targetAI.gameObject.GetComponent<Country_AI>().NorwayWar == true)
                {
                    sprite.color = new Color(0.9433962f, 0, 0, 1);
                }
                if (occupy == 21f && targetAI.gameObject.GetComponent<Country_AI>().NorwayWar == false && targetAI.gameObject.GetComponent<Country_AI>().NorwayOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.01974951f, 0.9339623f, 0, 1);
                }
                if (occupy == 21f && targetAI.gameObject.GetComponent<Country_AI>().NorwayWar == false && targetAI.gameObject.GetComponent<Country_AI>().NorwayOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.5575828f, 0.6603774f, 0.5668914f, 1);
                }
                if (occupy == 21f && GameObject.Find("information").GetComponent<countries>().playerCountry == 21f) //player
                {
                    sprite.color = new Color(0.3821645f, 0.5160912f, 0.7169812f, 1);
                }

            }
        }
    }

    void AllianceColorOff()
    {
        foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
        {
            if (targetAI.gameObject.GetComponent<Country_AI>().CountryType == GameObject.Find("information").GetComponent<countries>().playerCountry)
            {
                if (occupy == 0f && targetAI.gameObject.GetComponent<Country_AI>().FranceWar == true) //enemy
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 0f && targetAI.gameObject.GetComponent<Country_AI>().FranceWar == false && targetAI.gameObject.GetComponent<Country_AI>().FranceOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 0f && targetAI.gameObject.GetComponent<Country_AI>().FranceWar == false && targetAI.gameObject.GetComponent<Country_AI>().FranceOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 0f && GameObject.Find("information").GetComponent<countries>().playerCountry == 0f) //player
                {
                    sprite.color = new Color(1f, 1f, 1, 1);
                }

                if (occupy == 1f && targetAI.gameObject.GetComponent<Country_AI>().SpainWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 1f && targetAI.gameObject.GetComponent<Country_AI>().SpainWar == false && targetAI.gameObject.GetComponent<Country_AI>().SpainOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 1f && targetAI.gameObject.GetComponent<Country_AI>().SpainWar == false && targetAI.gameObject.GetComponent<Country_AI>().SpainOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 1f && GameObject.Find("information").GetComponent<countries>().playerCountry == 1f) //player
                {
                    sprite.color = new Color(0, 1, 0.4156f, 1);
                }

                if (occupy == 2f && targetAI.gameObject.GetComponent<Country_AI>().PortugalWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 2f && targetAI.gameObject.GetComponent<Country_AI>().PortugalWar == false && targetAI.gameObject.GetComponent<Country_AI>().PortugalOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 2f && targetAI.gameObject.GetComponent<Country_AI>().PortugalWar == false && targetAI.gameObject.GetComponent<Country_AI>().PortugalOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 2f && GameObject.Find("information").GetComponent<countries>().playerCountry == 2f) //player
                {
                    sprite.color = new Color(0.8980f, 0.9803f, 0, 1);
                }

                if (occupy == 3f && targetAI.gameObject.GetComponent<Country_AI>().UKWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 3f && targetAI.gameObject.GetComponent<Country_AI>().UKWar == false && targetAI.gameObject.GetComponent<Country_AI>().UKOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 3f && targetAI.gameObject.GetComponent<Country_AI>().UKWar == false && targetAI.gameObject.GetComponent<Country_AI>().UKOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 3f && GameObject.Find("information").GetComponent<countries>().playerCountry == 3f) //player
                {
                    sprite.color = new Color(1f, 0, 0, 1);
                }

                if (occupy == 4f && targetAI.gameObject.GetComponent<Country_AI>().CRWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 4f && targetAI.gameObject.GetComponent<Country_AI>().CRWar == false && targetAI.gameObject.GetComponent<Country_AI>().CROpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 4f && targetAI.gameObject.GetComponent<Country_AI>().CRWar == false && targetAI.gameObject.GetComponent<Country_AI>().CROpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 4f && GameObject.Find("information").GetComponent<countries>().playerCountry == 4f) //player
                {
                    sprite.color = new Color(0, 0.4941177f, 0.02352941f, 1);
                }

                if (occupy == 5f && targetAI.gameObject.GetComponent<Country_AI>().MoroccoWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 5f && targetAI.gameObject.GetComponent<Country_AI>().MoroccoWar == false && targetAI.gameObject.GetComponent<Country_AI>().MoroccoOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 5f && targetAI.gameObject.GetComponent<Country_AI>().MoroccoWar == false && targetAI.gameObject.GetComponent<Country_AI>().MoroccoOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 5f && GameObject.Find("information").GetComponent<countries>().playerCountry == 5f) //player
                {
                    sprite.color = new Color(0.5411765f, 0f, 0.8509805f, 1);
                }

                if (occupy == 6f && targetAI.gameObject.GetComponent<Country_AI>().AlgeriaWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 6f && targetAI.gameObject.GetComponent<Country_AI>().AlgeriaWar == false && targetAI.gameObject.GetComponent<Country_AI>().AlgeriaOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 6f && targetAI.gameObject.GetComponent<Country_AI>().AlgeriaWar == false && targetAI.gameObject.GetComponent<Country_AI>().AlgeriaOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 6f && GameObject.Find("information").GetComponent<countries>().playerCountry == 6f) //player
                {
                    sprite.color = new Color(0.5803922f, 0.6666667f, 0.6509804f, 1);
                }

                if (occupy == 7f && targetAI.gameObject.GetComponent<Country_AI>().TunisWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 7f && targetAI.gameObject.GetComponent<Country_AI>().TunisWar == false && targetAI.gameObject.GetComponent<Country_AI>().TunisOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 7f && targetAI.gameObject.GetComponent<Country_AI>().TunisWar == false && targetAI.gameObject.GetComponent<Country_AI>().TunisOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 7f && GameObject.Find("information").GetComponent<countries>().playerCountry == 7f) //player
                {
                    sprite.color = new Color(0.03921569f, 0.1803922f, 0.6666667f, 1);
                }

                if (occupy == 8f && targetAI.gameObject.GetComponent<Country_AI>().SardWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 8f && targetAI.gameObject.GetComponent<Country_AI>().SardWar == false && targetAI.gameObject.GetComponent<Country_AI>().SardOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 8f && targetAI.gameObject.GetComponent<Country_AI>().SardWar == false && targetAI.gameObject.GetComponent<Country_AI>().SardOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 8f && GameObject.Find("information").GetComponent<countries>().playerCountry == 8f) //player
                {
                    sprite.color = new Color(0.7529413f, 0.7058824f, 0.4313726f, 1);
                }

                if (occupy == 9f && targetAI.gameObject.GetComponent<Country_AI>().SicilyWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 9f && targetAI.gameObject.GetComponent<Country_AI>().SicilyWar == false && targetAI.gameObject.GetComponent<Country_AI>().SicilyOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 9f && targetAI.gameObject.GetComponent<Country_AI>().SicilyWar == false && targetAI.gameObject.GetComponent<Country_AI>().SicilyOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 9f && GameObject.Find("information").GetComponent<countries>().playerCountry == 9f) //player
                {
                    sprite.color = new Color(0.7568628f, 0.6f, 0.9294118f, 1);
                }

                if (occupy == 10f && targetAI.gameObject.GetComponent<Country_AI>().NaplesWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 10f && targetAI.gameObject.GetComponent<Country_AI>().NaplesWar == false && targetAI.gameObject.GetComponent<Country_AI>().NaplesOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 10f && targetAI.gameObject.GetComponent<Country_AI>().NaplesWar == false && targetAI.gameObject.GetComponent<Country_AI>().NaplesOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 10f && GameObject.Find("information").GetComponent<countries>().playerCountry == 10f) //player
                {
                    sprite.color = new Color(0.8980392f, 0.4431373f, 0.454902f, 1);
                }

                if (occupy == 11f && targetAI.gameObject.GetComponent<Country_AI>().LuccaWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 11f && targetAI.gameObject.GetComponent<Country_AI>().LuccaWar == false && targetAI.gameObject.GetComponent<Country_AI>().LuccaOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 11f && targetAI.gameObject.GetComponent<Country_AI>().LuccaWar == false && targetAI.gameObject.GetComponent<Country_AI>().LuccaOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 11f && GameObject.Find("information").GetComponent<countries>().playerCountry == 11f) //player
                {
                    sprite.color = new Color(0.8392158f, 0.4196079f, 0.7725491f, 1);
                }

                if (occupy == 12f && targetAI.gameObject.GetComponent<Country_AI>().ItalyWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 12f && targetAI.gameObject.GetComponent<Country_AI>().ItalyWar == false && targetAI.gameObject.GetComponent<Country_AI>().ItalyOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 12f && targetAI.gameObject.GetComponent<Country_AI>().ItalyWar == false && targetAI.gameObject.GetComponent<Country_AI>().ItalyOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 12f && GameObject.Find("information").GetComponent<countries>().playerCountry == 12f) //player
                {
                    sprite.color = new Color(0.8980393f, 0f, 0.8980393f, 1);
                }

                if (occupy == 13f && targetAI.gameObject.GetComponent<Country_AI>().HelvetiaWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 13f && targetAI.gameObject.GetComponent<Country_AI>().HelvetiaWar == false && targetAI.gameObject.GetComponent<Country_AI>().HelvetiaOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 13f && targetAI.gameObject.GetComponent<Country_AI>().HelvetiaWar == false && targetAI.gameObject.GetComponent<Country_AI>().HelvetiaOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 13f && GameObject.Find("information").GetComponent<countries>().playerCountry == 13f) //player
                {
                    sprite.color = new Color(0.6431373f, 0.8470589f, 0.172549f, 1);
                }

                if (occupy == 14f && targetAI.gameObject.GetComponent<Country_AI>().AustrianWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 14f && targetAI.gameObject.GetComponent<Country_AI>().AustrianWar == false && targetAI.gameObject.GetComponent<Country_AI>().AustrianOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 14f && targetAI.gameObject.GetComponent<Country_AI>().AustrianWar == false && targetAI.gameObject.GetComponent<Country_AI>().AustrianOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 14f && GameObject.Find("information").GetComponent<countries>().playerCountry == 14f) //player
                {
                    sprite.color = new Color(0.7058824f, 0.4156863f, 1, 1);
                }

                if (occupy == 15f && targetAI.gameObject.GetComponent<Country_AI>().OttomanWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 15f && targetAI.gameObject.GetComponent<Country_AI>().OttomanWar == false && targetAI.gameObject.GetComponent<Country_AI>().OttomanOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 15f && targetAI.gameObject.GetComponent<Country_AI>().OttomanWar == false && targetAI.gameObject.GetComponent<Country_AI>().OttomanOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 15f && GameObject.Find("information").GetComponent<countries>().playerCountry == 15f) //player
                {
                    sprite.color = new Color(0.4823529f, 0.4941176f, 0.1764706f, 1);
                }

                if (occupy == 16f && targetAI.gameObject.GetComponent<Country_AI>().MonteWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 16f && targetAI.gameObject.GetComponent<Country_AI>().MonteWar == false && targetAI.gameObject.GetComponent<Country_AI>().MonteOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 16f && targetAI.gameObject.GetComponent<Country_AI>().MonteWar == false && targetAI.gameObject.GetComponent<Country_AI>().MonteOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 16f && GameObject.Find("information").GetComponent<countries>().playerCountry == 16f) //player
                {
                    sprite.color = new Color(0.6431373f, 0.2784314f, 0.04313726f, 1);
                }

                if (occupy == 17f && targetAI.gameObject.GetComponent<Country_AI>().PrussiaWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 17f && targetAI.gameObject.GetComponent<Country_AI>().PrussiaWar == false && targetAI.gameObject.GetComponent<Country_AI>().PrussiaOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 17f && targetAI.gameObject.GetComponent<Country_AI>().PrussiaWar == false && targetAI.gameObject.GetComponent<Country_AI>().PrussiaOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 17f && GameObject.Find("information").GetComponent<countries>().playerCountry == 17f) //player
                {
                    sprite.color = new Color(1, 0.4f, 0.07058824f, 1);
                }

                if (occupy == 18f && targetAI.gameObject.GetComponent<Country_AI>().WarsawWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 18f && targetAI.gameObject.GetComponent<Country_AI>().WarsawWar == false && targetAI.gameObject.GetComponent<Country_AI>().WarsawOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 18f && targetAI.gameObject.GetComponent<Country_AI>().WarsawWar == false && targetAI.gameObject.GetComponent<Country_AI>().WarsawOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 18f && GameObject.Find("information").GetComponent<countries>().playerCountry == 18f) //player
                {
                    sprite.color = new Color(1, 0.8901961f, 0, 1);
                }

                if (occupy == 19f && targetAI.gameObject.GetComponent<Country_AI>().RussianWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 19f && targetAI.gameObject.GetComponent<Country_AI>().RussianWar == false && targetAI.gameObject.GetComponent<Country_AI>().RussianOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 19f && targetAI.gameObject.GetComponent<Country_AI>().RussianWar == false && targetAI.gameObject.GetComponent<Country_AI>().RussianOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 19f && GameObject.Find("information").GetComponent<countries>().playerCountry == 19f) //player
                {
                    sprite.color = new Color(0.4f, 0, 0.3254902f, 1);
                }

                if (occupy == 20f && targetAI.gameObject.GetComponent<Country_AI>().SwedenWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 20f && targetAI.gameObject.GetComponent<Country_AI>().SwedenWar == false && targetAI.gameObject.GetComponent<Country_AI>().SwedenOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 20f && targetAI.gameObject.GetComponent<Country_AI>().SwedenWar == false && targetAI.gameObject.GetComponent<Country_AI>().SwedenOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 20f && GameObject.Find("information").GetComponent<countries>().playerCountry == 20f) //player
                {
                    sprite.color = new Color(0.5764706f, 0.4196078f, 0.7803922f, 1);
                }

                if (occupy == 21f && targetAI.gameObject.GetComponent<Country_AI>().NorwayWar == true)
                {
                    sprite.color = new Color(0.8396226f, 0.1113847f, 0.05148631f, 1);
                }
                if (occupy == 21f && targetAI.gameObject.GetComponent<Country_AI>().NorwayWar == false && targetAI.gameObject.GetComponent<Country_AI>().NorwayOpinion >= 60) //ally
                {
                    sprite.color = new Color(0.06888819f, 0.754717f, 0.01067994f, 1);
                }
                if (occupy == 21f && targetAI.gameObject.GetComponent<Country_AI>().NorwayWar == false && targetAI.gameObject.GetComponent<Country_AI>().NorwayOpinion <= 60) //neutral
                {
                    sprite.color = new Color(0.4317373f, 0.5331551f, 0.6226415f, 1);
                }
                if (occupy == 21f && GameObject.Find("information").GetComponent<countries>().playerCountry == 21f) //player
                {
                    sprite.color = new Color(0, 0.3137255f, 0.7843138f, 1);
                }
            }
        }
    }

    IEnumerator AttackFlashing()
    {
        if (message == true)
        {
            HighlightOn();
            yield return new WaitForSeconds(0.5f);
            HighlightOff();
            yield return new WaitForSeconds(0.5f);
            attackFlash = true;
        }
        if (GameObject.Find("information").GetComponent<countries>().simpleColor == true && message == false)
        {
            AllianceColorOn();
            yield return new WaitForSeconds(0.5f);
            AllianceColorOff();
            yield return new WaitForSeconds(0.5f);
            attackFlash = true;
        }
        if (GameObject.Find("information").GetComponent<countries>().simpleColor == false && message == false)
        {
            HighlightOn();
            yield return new WaitForSeconds(0.5f);
            HighlightOff();
            yield return new WaitForSeconds(0.5f);
            attackFlash = true;
        }
    }
}