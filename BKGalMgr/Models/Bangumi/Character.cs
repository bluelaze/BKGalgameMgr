﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKGalMgr.Models.Bangumi;

public class Character
{
    public Images images { get; set; }
    public string name { get; set; }
    public string relation { get; set; }

    public List<Actor> actors { get; set; }
    public int id { get; set; }
    public int type { get; set; }
}
