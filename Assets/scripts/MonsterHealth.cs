using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHealth : MonoBehaviour
{
    public int maxHp = 10;
    public int mhp;
    // Start is called before the first frame update
    void Start()
    {
        mhp = maxHp;
    }
    public void TakeDmg(int dmg)
    {
        mhp -= dmg;
    }
}
