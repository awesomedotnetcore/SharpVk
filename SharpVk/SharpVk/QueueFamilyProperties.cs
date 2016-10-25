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
    /// Structure providing information about a queue family.
    /// </para>
    /// <para>
    /// The bits specified in pname:queueFlags are:
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct QueueFamilyProperties
    {
        /// <summary>
        /// pname:queueFlags contains flags indicating the capabilities of the
        /// queues in this queue family.
        /// </summary>
        public QueueFlags QueueFlags; 
        
        /// <summary>
        /// pname:queueCount is the unsigned integer count of queues in this
        /// queue family.
        /// </summary>
        public uint QueueCount; 
        
        /// <summary>
        /// pname:timestampValidBits is the unsigned integer count of
        /// meaningful bits in the timestamps written via
        /// fname:vkCmdWriteTimestamp. The valid range for the count is 36..64
        /// bits, or a value of 0, indicating no support for timestamps. Bits
        /// outside the valid range are guaranteed to be zeros.
        /// </summary>
        public uint TimestampValidBits; 
        
        /// <summary>
        /// pname:minImageTransferGranularity is the minimum granularity
        /// supported for image transfer operations on the queues in this queue
        /// family.
        /// </summary>
        public Extent3D MinImageTransferGranularity; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("QueueFamilyProperties");
            builder.AppendLine("{");
            builder.AppendLine($"QueueFlags: {this.QueueFlags}");
            builder.AppendLine($"QueueCount: {this.QueueCount}");
            builder.AppendLine($"TimestampValidBits: {this.TimestampValidBits}");
            builder.AppendLine($"MinImageTransferGranularity: {this.MinImageTransferGranularity}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
