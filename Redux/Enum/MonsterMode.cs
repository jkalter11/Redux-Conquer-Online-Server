﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Redux.Enum
{
    public enum MonsterMode
    {
        Dormancy = 0,
        Idle,
        Walk,
        Goto,
        Talk,
        Follow,
        Escape,
        Forward,
        Encircle, //Turn around when monster can't walk.
        Search, //When Target is a range attacker.
        Attack
    }

}
