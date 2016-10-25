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

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure containing parameters of a memory allocation.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:allocationSize must: be less than or equal to
    /// the amount of memory available to the sname:VkMemoryHeap specified by
    /// pname:memoryTypeIndex and the calling command's sname:VkDevice *
    /// pname:allocationSize must: be greater than `0` ****
    /// </para>
    /// </summary>
    public struct MemoryAllocateInfo
    {
        /// <summary>
        /// pname:allocationSize is the size of the allocation in bytes
        /// </summary>
        public ulong AllocationSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memoryTypeIndex is the memory type index, which selects the
        /// properties of the memory to be allocated, as well as the heap the
        /// memory will come from.
        /// </summary>
        public uint MemoryTypeIndex
        {
            get;
            set;
        }
        
        internal unsafe Interop.MemoryAllocateInfo Pack()
        {
            Interop.MemoryAllocateInfo result = default(Interop.MemoryAllocateInfo);
            result.SType = StructureType.MemoryAllocateInfo;
            result.AllocationSize = this.AllocationSize;
            result.MemoryTypeIndex = this.MemoryTypeIndex;
            return result;
        }
        
        internal unsafe Interop.MemoryAllocateInfo* MarshalTo()
        {
            return (Interop.MemoryAllocateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
