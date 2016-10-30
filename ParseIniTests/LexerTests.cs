﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseIni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ParseIni.Tests
{
    [TestClass()]
    public class LexerTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyPathToLexer()
        {
            Lexer lexer = new Lexer("");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullPathToLexer()
        {
            string nullString = null;
            Lexer lexer = new Lexer(nullString);
        }

        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void InvalidPathToLexer()
        {
            Lexer lexer = new Lexer(@"C:\ThisDoesNotExistEver.ini");
        }
    }
}