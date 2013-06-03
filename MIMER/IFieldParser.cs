/*
Copyright (c) 2007, Robert Wallstr�m, smithimage.com
All rights reserved.
 
Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
	
	* Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer. 
	* Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution. 
	* Neither the name of the SMITHIMAGE nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission. 

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH  DAMAGE.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace MIMER
{
    public interface IFieldParser
    {
        /// <summary>
        /// Shall parse all fields within the parameter 'fieldString'.
        /// </summary>
        /// <param name="fields">The list to add parsed fields into.</param>
        /// <param name="fieldString">The string which entails the unparsed fields.</param>
        void Parse(ref IList<RFC822.Field> fields, ref string fieldString);

        /// <summary>
        /// This should be called if we want to add functionality in a child method
        /// but let base build/compile it .i.e. 'base.CompilePattern();'
        /// </summary>
        void CompilePattern();
    }
}