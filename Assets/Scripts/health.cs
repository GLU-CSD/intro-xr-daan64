using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public Image healthbarFill;

void UpdateHealthBar()
{
    healthbarFill.fillAmount = currentHealth / maxHealth;
}
void Start()
{
    currentHealth = maxHealth;
    UpdateHealthBar();
}
public void TakeDamage(float amount)
{
    currentHealth -= amount;
    currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    UpdateHealthBar();
}

public void RestoreHealth(float amount)
{
    currentHealth += amount;
    currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    UpdateHealthBar();
}
   // Update is called once per frame
void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject, 1f);
        }
    }
}
