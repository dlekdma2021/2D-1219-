using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    //프리펩 보관할 변수 
    public GameObject[] prefabs;

    //풀 담당을 하는 리스트들 
    List<GameObject>[] pools;

    void Awake()
    {
        //초기화
        pools = new List<GameObject>[prefabs.Length];

        for (int index = 0; index < pools.Length; index++)
        {
            pools[index] = new List<GameObject>();
        }
    }

    public GameObject Get(int index)
    {
        GameObject select = null;
        //선택한 풀의 놀고 있는(비활성화된) 게임오브젝트 접근 
        //발견하면 셀렉트 변수에 할당 
        foreach (GameObject item in pools[index])
        {
            if (!item.activeSelf)
            {
                select = item;
                select.SetActive(true);
                break;
            }
        }

        //못 찾았다면 새롭게 생성하고 세렉트 변수에 할당 
        if (!select)
        {
            select = Instantiate(prefabs[index], transform);
            pools[index].Add(select);
        }

        return select;
    }
}
