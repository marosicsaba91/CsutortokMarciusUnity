using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

class Damageable : MonoBehaviour
{
    [SerializeField] int maxHP = 10;
    [SerializeField] TMP_Text healthText;

    //[SerializeField] Color minHPColor = Color.red;
    //[SerializeField] Color maxHPColor = Color.green;
    [SerializeField] Gradient healthColor;
    [SerializeField] GameObject isDeadObject;

    int health;

    public int HealthLost 
    {
        get => maxHP - health;
        set => health = maxHP - value;
    }

    void Start()
    {
        health = maxHP;
        UpdateUI();

        int lost = HealthLost;
        HealthLost = 12;

        Vector3 pos = transform.position;
    }

    public int GetHealth() => health;

    public bool IsAlive => health > 0;

    public void Damage(int n)
    {
        health -= n;
        health = Mathf.Max(health, 0);

        UpdateUI();
    }

    void UpdateUI()
    {
        float t = (float)health / maxHP;
        // Color c = Color.Lerp(minHPColor, maxHPColor, t);
        Color c = healthColor.Evaluate(t);

        healthText.color = c;
        healthText.text = health.ToString();

        isDeadObject.SetActive(!IsAlive);
    }
}