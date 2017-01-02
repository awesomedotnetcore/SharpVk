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
    /// Structure specifying the allocation parameters for descriptor sets.
    /// </summary>
    public struct DescriptorSetAllocateInfo
    {
        /// <summary>
        /// pname:descriptorPool is the pool which the sets will be allocated
        /// from.
        /// </summary>
        public DescriptorPool DescriptorPool
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSetLayouts is an array of descriptor set layouts, with each
        /// member specifying how the corresponding descriptor set is
        /// allocated.
        /// </summary>
        public DescriptorSetLayout[] SetLayouts
        {
            get;
            set;
        }
        
        internal unsafe Interop.DescriptorSetAllocateInfo* MarshalTo()
        {
            var result = (Interop.DescriptorSetAllocateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.DescriptorSetAllocateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.DescriptorSetAllocateInfo* pointer)
        {
            pointer->SType = StructureType.DescriptorSetAllocateInfo;
            this.DescriptorPool?.MarshalTo(&pointer->DescriptorPool);
            
            //SetLayouts
            if (this.SetLayouts != null)
            {
                var fieldPointer = (Interop.DescriptorSetLayout*)Interop.HeapUtil.AllocateAndClear<Interop.DescriptorSetLayout>(this.SetLayouts.Length);
                for (int index = 0; index < this.SetLayouts.Length; index++)
                {
                    this.SetLayouts[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->SetLayouts = fieldPointer;
            }
            else
            {
                pointer->SetLayouts = null;
            }
            pointer->DescriptorSetCount = (uint)(this.SetLayouts?.Length ?? 0);
        }
    }
}
