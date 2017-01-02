// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;

namespace SharpVk
{
    /// <summary>
    /// Bitmask specifying sample counts supported for an image used for
    /// storage operations.
    /// </summary>
    [Flags]
    public enum SampleCountFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Sample count 1 supported
        /// </summary>
        SampleCount1 = 1 << 0, 
        
        /// <summary>
        /// Sample count 2 supported
        /// </summary>
        SampleCount2 = 1 << 1, 
        
        /// <summary>
        /// Sample count 4 supported
        /// </summary>
        SampleCount4 = 1 << 2, 
        
        /// <summary>
        /// Sample count 8 supported
        /// </summary>
        SampleCount8 = 1 << 3, 
        
        /// <summary>
        /// Sample count 16 supported
        /// </summary>
        SampleCount16 = 1 << 4, 
        
        /// <summary>
        /// Sample count 32 supported
        /// </summary>
        SampleCount32 = 1 << 5, 
        
        /// <summary>
        /// Sample count 64 supported
        /// </summary>
        SampleCount64 = 1 << 6, 
    }
}
