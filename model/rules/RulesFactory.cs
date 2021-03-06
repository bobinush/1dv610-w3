﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class RulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            return new BasicHitStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }

        public IHitStrategy SoftSeventeenRule()
        {
            return new SoftSeventeenStrategy();
        }

        public IWhoWinsStrategy DealerWinsRule() 
        {
            return new DealerWinsOnEqual();
        }
          
        public IWhoWinsStrategy PlayerWinsRule() 
        {
            return new PlayerWinsOnEqual();
        }
    }
}
