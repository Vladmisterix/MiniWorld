using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public float heal = 20f;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
            if (enemyHealth.canHeal && enemyHealth.death && Input.GetKeyDown(KeyCode.I))
            {
                Debug.Log("Can heal");
                enemyHealth.canHeal = false;
                enemyHealth.SetNewColor(Color.green);

                PlayerHealth playerHealth = transform.parent.GetComponent<PlayerHealth>();

                playerHealth.health += heal;
                if (playerHealth.health > 100f)
                    playerHealth.health = 100f;

                playerHealth.SetHealthBar();
            }
        }
    }
}
