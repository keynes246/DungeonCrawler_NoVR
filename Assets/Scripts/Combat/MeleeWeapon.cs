using UnityEngine;
using System.Collections;

public class MeleeWeapon : MonoBehaviour
{
    public int damage = 25;
    public float attackCooldown = 0.5f;
    bool canAttack = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canAttack)
            StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        canAttack = false;
        yield return new WaitForSeconds(attackCooldown);
        canAttack = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
            other.GetComponent<EnemyHealth>()?.TakeDamage(damage);
    }
}
