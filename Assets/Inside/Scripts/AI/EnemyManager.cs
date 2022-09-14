using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform player;
    public static Transform _player;
    public int avaibleEnemies;
    public static int _avaibleEnemies;

    private void Start()
    {
        _player = player;
        _avaibleEnemies = avaibleEnemies;
    }
}
