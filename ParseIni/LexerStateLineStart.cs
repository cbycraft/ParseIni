﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseIni
{
    internal class LexerStateLineStart : ILexerState
    {
        public void StateChange(LexerStateHandle stateContext)
        {
            switch (stateContext.CurrentCharacter)
            {
                case ';':
                    stateContext.CurrentState = new LexerStateComment();
                    break;
                case '[':
                    stateContext.TokenLine.Add(new LexerTokenNode(LexerTokenNode.Token.OpenSquareBrace, "[", stateContext.LineNumber, stateContext.CharacterNumber));
                    stateContext.CurrentState = new LexerStateScanString();
                    break;
                default:
                    break;
            }
        }
    }
}