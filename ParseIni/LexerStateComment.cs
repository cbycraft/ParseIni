﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseIni
{
    internal class LexerStateComment : ILexerState
    {
        public void StateChange(LexerStateHandle stateContext)
        {
            switch (stateContext.CurrentCharacter)
            {
                case '\r':
                    stateContext.CurrentState = new LexerStateReturn();
                    break;
                default:
                    stateContext.CurrentState = new LexerStateComment();
                    break;
            }
        }
    }
}
