﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvQuerySystem : MonoBehaviour
{
    EnvQueryGenerator Generator;

    List<EnvQueryItem> QueryItems;
    public Transform Querier;


    private void Awake()
    {
       
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
        
        
        
        
    }
        // Update is called once per frame
    void Update()
    {
        if (QueryItems != null)
        {
            foreach (EnvQueryItem item in QueryItems)
            {
                item.RunConditionCheck();
            }
        }
    }


    private void OnDrawGizmos()
    {
        Generator = new GridGenerator(10, Querier);

        if (Generator != null)
        {
            QueryItems = Generator.Items(transform);
        }

        if (QueryItems != null)
        {
            foreach (EnvQueryItem item in QueryItems)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(item.GetWorldLocation(), 0.25f);
            }
        }
       
       


    }
}
