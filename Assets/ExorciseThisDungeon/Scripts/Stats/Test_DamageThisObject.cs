using UnityEngine;

public class Test_DamageThisObject : MonoBehaviour
{
    public int DamageValue = 1;

    [ContextMenu("Damage This Object")]
    public void DamageThis()
    {
        if (gameObject.TryGetComponent<IDamageable>(out var damageableTarget))
        {
            damageableTarget.TakeDamage(DamageValue);
        }
    }
}
