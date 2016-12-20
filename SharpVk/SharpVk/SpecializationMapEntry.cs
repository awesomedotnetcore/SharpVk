// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
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
using System.Text;

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure specifying a specialization map entry.
    /// </para>
    /// <para>
    /// If a pname:constantID value is not a specialization constant ID used in
    /// the shader, that map entry does not affect the behavior of the
    /// pipeline.
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpecializationMapEntry
    {
        /// <summary>
        /// 
        /// </summary>
        public SpecializationMapEntry(uint constantID, uint offset, Size size)
        {
            this.ConstantID = constantID;
            this.Offset = offset;
            this.Size = size;
        }
        
        /// <summary>
        /// pname:constantID is the ID of the specialization constant in
        /// SPIR-V.
        /// </summary>
        public uint ConstantID; 
        
        /// <summary>
        /// pname:offset is the byte offset of the specialization constant
        /// value within the supplied data buffer.
        /// </summary>
        public uint Offset; 
        
        /// <summary>
        /// pname:size is the byte size of the specialization constant value
        /// within the supplied data buffer.
        /// </summary>
        public Size Size; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("SpecializationMapEntry");
            builder.AppendLine("{");
            builder.AppendLine($"ConstantID: {this.ConstantID}");
            builder.AppendLine($"Offset: {this.Offset}");
            builder.AppendLine($"Size: {this.Size}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}