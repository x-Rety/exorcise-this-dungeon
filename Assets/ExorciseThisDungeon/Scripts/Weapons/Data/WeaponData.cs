using UnityEngine;

[CreateAssetMenu(fileName = "Weapon_New", menuName = "Configs/Weapons/Weapon data", order = 0)]
public class WeaponData : ScriptableObject
{
    [Header("Identity")]

    [SerializeField] private string _weaponName;

    [Header("General")]
    [SerializeField] private int _damage;
    [SerializeField] private float _fireRate;

    public string DisplayName => _weaponName;
    public int Damage => _damage;
    public float FireRate => _fireRate;

    private void OnValidate()
    {
        if (_damage < 0) _damage = 0;
        if (_fireRate < 0) _fireRate = 0.01f;
    }
}
