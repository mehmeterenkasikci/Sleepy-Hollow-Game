using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public int maxExp;
    public float updatedExp;

    public Image Bar;


    public float expIncreasedPerSecond;

    public int playerLevel;

    public Text Text2;

    // Start is called before the first frame update
    void Start()
    {
        playerLevel = 1;
        expIncreasedPerSecond = 5f;
        maxExp = 25;
        updatedExp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        updatedExp += expIncreasedPerSecond * Time.deltaTime;
        Bar.fillAmount = updatedExp / maxExp;

        Text2.text = playerLevel + "";

        if (updatedExp >= maxExp)
        {
            playerLevel++;
            updatedExp = 0;
            maxExp += maxExp;
        }
    }
}
