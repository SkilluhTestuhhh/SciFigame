﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    abstract class Location
    {
        protected string name;
        protected bool hasEnemy;
        protected Dictionary<string, Objects> items;

        public Location(string name)
        {
            this.name = name;
            hasEnemy = false;
            items = new Dictionary<string, Objects>();
        }

        abstract public void Description();

        public virtual string GetName()
        {
            return name;
        }

        public virtual bool HasEnemy()
        {
            return hasEnemy;
        }

        public virtual bool CheckForItems()
        {
            if (items.Count() == 0)
                return false;
            else
                return true;
        }

        public Dictionary<string, Objects> GetItems()
        {
            return items;
        }
    }
}
