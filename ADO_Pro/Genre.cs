﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Pro
{
    public  class Genre
    {
        private int num;
        private string libelle = "";

        public int Num { get => num; set => num = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
