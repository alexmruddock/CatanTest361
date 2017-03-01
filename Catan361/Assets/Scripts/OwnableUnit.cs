using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OwnableUnit
{
    Player player;
    
    public OwnableUnit() {  }

    public OwnableUnit(Player player) {

        this.player = player;

    }

    public void setOwner(Player p)
    {
        this.player = player;
    }

    public Player getOwner()
    {
        return this.player;
    }

}
