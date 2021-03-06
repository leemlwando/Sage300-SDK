﻿// The MIT License (MIT) 
// Copyright (c) 1994-2020 The Sage Group plc or its licensors.  All rights reserved.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of 
// this software and associated documentation files (the "Software"), to deal in 
// the Software without restriction, including without limitation the rights to use, 
// copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
// Software, and to permit persons to whom the Software is furnished to do so, 
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all 
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
// PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
// OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

// MUST match guids.h
#region Imports
using System;
#endregion

namespace Sage300LanguageResourceWizardMenuExtension
{
    static class GuidList
    {
        /*
         * Developer Note:
         * 
         *  If you are reusing this project for another project, please ensure you generate new guids below
         */
        public const string guidSage300LanguageResourceMenuExtensionPkgString = "38086752-eef6-4ca4-953b-067c31cb97d3";
        public const string guidSage300LanguageResourceMenuExtensionCmdSetString = "44c3f082-499c-4eff-8020-aff49d893f8c";

        public static readonly Guid guidSage300LanguageResourceMenuExtensionCmdSet = new Guid(guidSage300LanguageResourceMenuExtensionCmdSetString);
    };
}