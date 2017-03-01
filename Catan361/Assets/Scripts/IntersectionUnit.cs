using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IntersectionUnit : OwnableUnit, HexUnit {

    Intersection intersection;

    public IntersectionUnit()
    {

    }

    public IntersectionUnit(Intersection intersection)
    {
        this.intersection = intersection;
    }

    public Intersection getLocation()
    {
        return this.intersection;
    }

    public void setLocation(Intersection intersection)
    {
        this.intersection = intersection;
    }

}
