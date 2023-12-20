using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthMana : MonoBehaviour
{
    public Slider healthSlider;
    public Slider manaSlider;
    public int health;
    public float mana;
    public HealthMana instance;
    public PlayerChanger changer;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        mana = 100;
        healthSlider.value = health;
        manaSlider.value = mana;

    }

}