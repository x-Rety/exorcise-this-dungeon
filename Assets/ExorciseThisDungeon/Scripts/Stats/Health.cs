using UnityEngine;

public class Health : MonoBehaviour, IDamageable
{
    [SerializeField] private int _hp = 1;
    public bool IsDead { get; private set; } = false;

    public int HP
    {
        get => _hp;

        private set
        {
            if (IsDead) return;

            _hp = Mathf.Clamp(value, 0, 100);

            if (_hp <= 0) 
                Die();
        }
    }

    public void TakeDamage(int damage)
    {
        if (IsDead) return;

        HP -= damage;
    }

    private void Die()
    {
        if (IsDead) return;
        IsDead = true;

        Debug.Log("death");
    }
}
