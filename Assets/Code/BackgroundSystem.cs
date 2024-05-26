using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundSystem : MonoBehaviour
{
    public List<Sprite> backgrounds;

    void Awake()
    {
        int randomBack = Random.Range(0, 8);

        if (randomBack == 0)
        {
            this.gameObject.GetComponent<Image>().sprite = backgrounds[0];
        }
        if (randomBack == 1)
        {
            this.gameObject.GetComponent<Image>().sprite = backgrounds[1];
        }
        if (randomBack == 2)
        {
            this.gameObject.GetComponent<Image>().sprite = backgrounds[2];
        }
        if (randomBack == 3)
        {
            this.gameObject.GetComponent<Image>().sprite = backgrounds[3];
        }
        if (randomBack == 4)
        {
            this.gameObject.GetComponent<Image>().sprite = backgrounds[4];
        }
        if (randomBack == 5)
        {
            this.gameObject.GetComponent<Image>().sprite = backgrounds[5];
        }
        if (randomBack == 6)
        {
            this.gameObject.GetComponent<Image>().sprite = backgrounds[6];
        }
        if (randomBack == 7)
        {
            this.gameObject.GetComponent<Image>().sprite = backgrounds[7];
        }
        if (randomBack == 8)
        {
            this.gameObject.GetComponent<Image>().sprite = backgrounds[8];
        }
    }
}
