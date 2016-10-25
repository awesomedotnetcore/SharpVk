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
    /// Structure specifying a draw indexed indirect command.
    /// </para>
    /// <para>
    /// The members of sname:VkDrawIndexedIndirectCommand have the same meaning
    /// as the similarly named parameters of flink:vkCmdDrawIndexed.
    /// </para>
    /// <para>
    /// .Valid Usage **** * For a given vertex buffer binding, any attribute
    /// data fetched must: be entirely contained within the corresponding
    /// vertex buffer binding, as described in &lt;&lt;fxvertex-input&gt;&gt; *
    /// (pname:indexSize * (pname:firstIndex + pname:indexCount) +
    /// pname:offset) must: be less than or equal to the size of the currently
    /// bound index buffer, with pname:indexSize being based on the type
    /// specified by pname:indexType, where the index buffer, pname:indexType,
    /// and pname:offset are specified via fname:vkCmdBindIndexBuffer * If the
    /// &lt;&lt;features-features-drawIndirectFirstInstance,drawIndirectFirstInstance&gt;&gt; feature
    /// is not enabled, pname:firstInstance must: be code:0 ****
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DrawIndexedIndirectCommand
    {
        /// <summary>
        /// pname:indexCount is the number of vertices to draw.
        /// </summary>
        public uint IndexCount; 
        
        /// <summary>
        /// pname:instanceCount is the number of instances to draw.
        /// </summary>
        public uint InstanceCount; 
        
        /// <summary>
        /// pname:firstIndex is the base index within the index buffer.
        /// </summary>
        public uint FirstIndex; 
        
        /// <summary>
        /// pname:vertexOffset is the value added to the vertex index before
        /// indexing into the vertex buffer.
        /// </summary>
        public int VertexOffset; 
        
        /// <summary>
        /// pname:firstInstance is the instance ID of the first instance to
        /// draw.
        /// </summary>
        public uint FirstInstance; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("DrawIndexedIndirectCommand");
            builder.AppendLine("{");
            builder.AppendLine($"IndexCount: {this.IndexCount}");
            builder.AppendLine($"InstanceCount: {this.InstanceCount}");
            builder.AppendLine($"FirstIndex: {this.FirstIndex}");
            builder.AppendLine($"VertexOffset: {this.VertexOffset}");
            builder.AppendLine($"FirstInstance: {this.FirstInstance}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
