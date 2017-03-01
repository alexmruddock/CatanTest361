using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IntersectionUnit : OwnableUnit, HexUnit {


    // changes made by Alex B:
    // 1. abstract class does not need a constructor
    // Intersection was not set to private
    // changed intersection to attribute
    
    Intersection intersection { get; set; };

}
