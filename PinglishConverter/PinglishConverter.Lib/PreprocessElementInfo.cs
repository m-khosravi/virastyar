﻿// Virastyar
// http://www.virastyar.ir
// Copyright (C) 2011 Supreme Council for Information and Communication Technology (SCICT) of Iran
// 
// This file is part of Virastyar.
// 
// Virastyar is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Virastyar is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Virastyar.  If not, see <http://www.gnu.org/licenses/>.
// 
// Additional permission under GNU GPL version 3 section 7
// The sole exception to the license's terms and requierments might be the
// integration of Virastyar with Microsoft Word (any version) as an add-in.

using System.Collections.Generic;

namespace SCICT.NLP.Utility.PinglishConverter
{
    ///<summary>
    ///</summary>
    public class PreprocessElementInfo
    {
        public readonly bool IsWholeWord;

        public readonly TokenPosition Position;

        public string PinglishString { get; private set; }

        public readonly bool IsExactWord;

        public readonly List<string> Equivalents = new List<string>();

        public PreprocessElementInfo(string pinglishString)
            : this(pinglishString, false, false, TokenPosition.Any)
        {
        }

        public PreprocessElementInfo(string pinglishString, bool isWholeWord)
            : this(pinglishString, isWholeWord, false, TokenPosition.Any)
        {
        }

        public PreprocessElementInfo(string pinglishString, bool isWholeWord, bool isExactWord, TokenPosition position)
        {
            this.PinglishString = pinglishString;
            this.IsWholeWord = isWholeWord;
            this.IsExactWord = isExactWord;
            this.Position = position;
        }
    }
}