using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village :  IntersectionUnit {

    private VillageKind myKind;
    private bool cityWall;

    public Village(VillageKind myKind, bool cityWall)
    {
        this.myKind = myKind;
        this.cityWall = cityWall;
    }

    public Village()
    {

    }

    public VillageKind getKind()
    {
        return this.VillageKind;
    }

    public VillageKind setKind(VillageKind myKind)
    {
         this.VillageKind = myKind;
    }

    public bool hasWall()
    {
        return this.cityWall;
    }

    public void setWall(bool cityWall)
    {
        this.cityWall = cityWall;
    }

    public void upgradeToCity()
    {
        
    }

}
