﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerBob.Entities
{
    class Entity
    {
        int _id;
        static int _netxtValidID;
        

        void setID()
        {
            _id = _netxtValidID;
        }

        public Entity()
        {
            setID();
        }
        virtual public void Update()
        {

        }
    }
}
