﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : SingleClass<GameData>
{
    public WorkloadDictionary rawmaterialWorkloadDic = new WorkloadDictionary();

    public void Init()
    {
        rawmaterialWorkloadDic.Add(MenuType.Felling,new MaterialInfo {
            Name="原木",
            Type= MaterialType.Timber,
            Workload=20
        });
        rawmaterialWorkloadDic.Add(MenuType.Mining, new MaterialInfo
        {
            Name = "石头",
            Type = MaterialType.Ore,
            Workload = 20
        });
    }
}
