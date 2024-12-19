using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float gameTime;
    public float maxGameTime = 2 * 10f;

    public PoolManager pool;
    public Player player;

    void Awake()
    {
        //인스턴스 초기화
        instance = this;
    }

    void Update()
    {
        gameTime += Time.deltaTime;

        if (gameTime > maxGameTime)
        {

            gameTime = maxGameTime;
        }
    }
}
