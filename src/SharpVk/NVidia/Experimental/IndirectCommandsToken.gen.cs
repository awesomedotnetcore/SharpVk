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
using System.Runtime.InteropServices;

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    /// Structure specifying parameters for the reservation of command buffer
    /// space.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct IndirectCommandsToken
    {
        /// <summary>
        /// Specifies the token command type.
        /// </summary>
        public SharpVk.NVidia.Experimental.IndirectCommandsTokenType TokenType
        {
            get;
            set;
        }
        
        /// <summary>
        /// Specifies the Buffer storing the functional arguments for each
        /// squence. These argumetns can be written by the device.
        /// </summary>
        public SharpVk.Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// offset specified an offset into buffer where the arguments start.
        /// </summary>
        public DeviceSize Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.Experimental.IndirectCommandsToken* pointer)
        {
            pointer->TokenType = this.TokenType;
            pointer->Buffer = this.Buffer?.handle ?? default(SharpVk.Interop.Buffer);
            pointer->Offset = this.Offset;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe IndirectCommandsToken MarshalFrom(SharpVk.Interop.NVidia.Experimental.IndirectCommandsToken* pointer)
        {
            IndirectCommandsToken result = default(IndirectCommandsToken);
            result.TokenType = pointer->TokenType;
            result.Buffer = new SharpVk.Buffer(default(SharpVk.Device), pointer->Buffer);
            result.Offset = pointer->Offset;
            return result;
        }
    }
}
