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
    /// Structure specifying a copy descriptor set operation.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:srcBinding must: be a valid binding within
    /// pname:srcSet * The sum of pname:srcArrayElement and
    /// pname:descriptorCount must: be less than or equal to the number of
    /// array elements in the descriptor set binding specified by
    /// pname:srcBinding, and all applicable consecutive bindings, as described
    /// by &lt;&lt;descriptorsets-updates-consecutive&gt;&gt; *
    /// pname:dstBinding must: be a valid binding within pname:dstSet * The sum
    /// of pname:dstArrayElement and pname:descriptorCount must: be less than
    /// or equal to the number of array elements in the descriptor set binding
    /// specified by pname:dstBinding, and all applicable consecutive bindings,
    /// as described by &lt;&lt;descriptorsets-updates-consecutive&gt;&gt; * If
    /// pname:srcSet is equal to pname:dstSet, then the source and destination
    /// ranges of descriptors must: not overlap, where the ranges may: include
    /// array elements from consecutive bindings as described by
    /// &lt;&lt;descriptorsets-updates-consecutive&gt;&gt; ****
    /// </para>
    /// </summary>
    public struct CopyDescriptorSet
    {
        /// <summary>
        /// pname:srcSet, pname:srcBinding, and pname:srcArrayElement are the
        /// source set, binding, and array element, respectively.
        /// </summary>
        public DescriptorSet SourceSet
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public uint SourceBinding
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public uint SourceArrayElement
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstSet, pname:dstBinding, and pname:dstArrayElement are the
        /// destination set, binding, and array element, respectively.
        /// </summary>
        public DescriptorSet DestinationSet
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public uint DestinationBinding
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public uint DestinationArrayElement
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:descriptorCount is the number of descriptors to copy from the
        /// source to destination. If pname:descriptorCount is greater than the
        /// number of remaining array elements in the source or destination
        /// binding, those affect consecutive bindings in a manner similar to
        /// slink:VkWriteDescriptorSet above.
        /// </summary>
        public uint DescriptorCount
        {
            get;
            set;
        }
        
        internal unsafe Interop.CopyDescriptorSet Pack()
        {
            Interop.CopyDescriptorSet result = default(Interop.CopyDescriptorSet);
            result.SType = StructureType.CopyDescriptorSet;
            result.SourceSet = this.SourceSet?.Pack() ?? Interop.DescriptorSet.Null;
            result.DestinationSet = this.DestinationSet?.Pack() ?? Interop.DescriptorSet.Null;
            result.SourceBinding = this.SourceBinding;
            result.SourceArrayElement = this.SourceArrayElement;
            result.DestinationBinding = this.DestinationBinding;
            result.DestinationArrayElement = this.DestinationArrayElement;
            result.DescriptorCount = this.DescriptorCount;
            return result;
        }
        
        internal unsafe Interop.CopyDescriptorSet* MarshalTo()
        {
            return (Interop.CopyDescriptorSet*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
