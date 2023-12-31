using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHealth : MonoBehaviour
{
    public float Health, MaxHealth;


    [SerializeField]
    private HealthBarUI healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth(MaxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            SetHealth(-20f);
        }
        if (Input.GetKeyDown("h"))
        {
            SetHealth(20f);
        }


    }

    public void SetHealth(float healthChange)
    {
        Health += healthChange;
        Health = Mathf.Clamp(Health, 0, MaxHealth);

        healthBar.SetHealth(Health);
    }
}
