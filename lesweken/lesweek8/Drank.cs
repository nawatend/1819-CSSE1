using System;
using System.Collections;
using System.Collections.Generic;

namespace startproject
{

    class Drank : Product
    {
        private int hoeveelheid;
        private bool alchoholAanwezig;



        public override int BerekenKCal()
        {

            return 2;
        }
    }
}